using Comercial.Dominio.Entidades;
using Comercial.Dominio.Geral;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Infra.DataBase;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Comercial.Infra.Repositorio
{
    public class RepositorioConta : RepositoryBase<Conta>, IRepositorioConta, IRepositorioContaConsulta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        private IRepositorioContaBanco _repositorioContaBanco;
        private IRepositorioFormaPagto _repositorioFormaPagto;
        private IRepositorioCliente _repositorioCliente;
        private IRepositorioFornecedor _repositorioFornecedor;
        private string _SQLConsulta = "SELECT CON.ID_CONTA, CON.DOCUMENTO, CON.DATA_EMISSAO, CON.DIAS, CON.DATA_VENCTO,CON.VALOR_PAGAR, CON.DATA_PAGO, CON.VALOR_PAGO, CON.SITUACAO FROM CONTAS CON";

        public RepositorioConta(IDbConnection conexao, IDbTransaction transaction,
            IRepositorioContaBanco repositorioContaBanco,
            IRepositorioFormaPagto repositorioFormaPagto,
            IRepositorioCliente repositorioCliente,
            IRepositorioFornecedor repositorioFornecedor) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
            _repositorioContaBanco = repositorioContaBanco;
            _repositorioFormaPagto = repositorioFormaPagto;
            _repositorioCliente = repositorioCliente;
            _repositorioFornecedor = repositorioFornecedor;
        }
        public override void Insert(ref Conta entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new Conta(), "CONTAS", "ID_CONTA");

            entity.Id_Conta = _conexao.Query<int>(base.SequencialFB("gen_contas"), null, _transaction).First();
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        public IEnumerable<ContaConsulta> Filtrar(string campo, string valor, int codEmpresa, ContaFiltro contaFiltro, int id = 0)
        {
            string sql = _SQLConsulta;
            if (id == 0)
            {
                sql += " WHERE CON.COD_EMPRESA = " + codEmpresa;
                sql += " AND " + campo + " CONTAINING(" + Funcao.QuotedStr(valor) + ")";
                sql += " ORDER BY " + campo;
            }
            else
            {
                sql += " WHERE CON.ID_CONTA = " + id;
            }

            return _conexao.Query<ContaConsulta>(sql);
        }

        public IEnumerable<Conta> ObterPorPedido(int numPedido, int codEmpresa=1, int tipoConta=2)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Select(new Conta(), "CONTAS");
            instrucaoSQL += " WHERE COD_EMPRESA = " + codEmpresa;
            instrucaoSQL += " AND NUM_PEDIDO = " + numPedido;
            instrucaoSQL += " AND TIPO_CONTA = " + tipoConta;
            return _conexao.Query<Conta>(instrucaoSQL);
        }

        public IEnumerable<ContaConsulta> ObterContasAReceber(ContaFiltro contaFiltro, int id = 0)
        {
            string sql = _SQLConsulta;
            if (id == 0)
            {
                sql += " WHERE CON.COD_EMPRESA = " + contaFiltro.CodEmpresa;
                if (contaFiltro.CodPessoa > 0)
                    sql += " AND CON.COD_CLIENTE = " + contaFiltro.CodPessoa;

                if (!string.IsNullOrEmpty(contaFiltro.Documento))
                    sql += " AND CON.DOCUMENTO = " + Funcao.QuotedStr(contaFiltro.Documento);
                sql += " AND CON.TIPO_CONTA = 2";

                sql += " ORDER BY CON.SITUACAO, CON.DATA_PAGO desc, CON.DATA_VENCTO";
            }
            else
            {
                sql += " WHERE CON.ID_CONTA = " + id;
            }

            return _conexao.Query<ContaConsulta>(sql);
        }

        public IEnumerable<ContaConsulta> ObterContasAPagar(ContaFiltro contaFiltro, int id = 0)
        {
            string sql = _SQLConsulta;
            if (id == 0)
            {
                sql += " WHERE CON.COD_EMPRESA = " + contaFiltro.CodEmpresa;
                if (contaFiltro.CodPessoa > 0)
                    sql += " AND CON.COD_FOR = " + contaFiltro.CodPessoa;

                if (!string.IsNullOrEmpty(contaFiltro.Documento))
                    sql += " AND CON.DOCUMENTO = " + Funcao.QuotedStr(contaFiltro.Documento);
                sql += " AND CON.TIPO_CONTA = 3";

                sql += " ORDER BY CON.SITUACAO, CON.DATA_PAGO desc, CON.DATA_VENCTO";
            }
            else
            {
                sql += " WHERE CON.ID_CONTA = " + id;
            }

            return _conexao.Query<ContaConsulta>(sql);
        }

        public override Conta GetById(int id)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Select(new Conta(), "CONTAS");
            instrucaoSQL += " WHERE ID_CONTA = " + id;

            var model = _conexao.Query<Conta>(instrucaoSQL, null, _transaction).FirstOrDefault();
            if (model != null)
            {
                if (model.Id_ContaBanco != null)
                    model.ContaBanco = _repositorioContaBanco.GetById(model.Id_ContaBanco.Value);

                if (model.Cod_Pagto != null)
                    model.FormaPagto = _repositorioFormaPagto.GetById(model.Cod_Pagto.Value);
            }
            return model;
        }

        public Conta ObterContasReceberPorDocumento(int codEmpresa, string documento)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Select(new Conta(), "CONTAS");
            instrucaoSQL += " WHERE COD_EMPRESA = " + codEmpresa;
            instrucaoSQL += " AND DOCUMENTO = '" + documento + "'";
            instrucaoSQL += " AND TIPO_CONTA = 2";
            var conta = _conexao.Query<Conta>(instrucaoSQL).FirstOrDefault();

            if (conta != null)
                conta.Cliente = _repositorioCliente.GetById(conta.Cod_Cliente.Value);

            return conta;
        }

        public Conta ObterContasPagarPorDocumento(int codEmpresa, string documento)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Select(new Conta(), "CONTAS");
            instrucaoSQL += " WHERE COD_EMPRESA = " + codEmpresa;
            instrucaoSQL += " AND DOCUMENTO = '" + documento + "'";
            instrucaoSQL += " AND TIPO_CONTA = 3";
            var conta = _conexao.Query<Conta>(instrucaoSQL).FirstOrDefault();

            if (conta != null)
                conta.Fornecedor = _repositorioFornecedor.GetById(conta.Cod_For.Value);

            return conta;
        }

        public int Salvar(Conta conta, List<ObsConta> obsContas, string nomeUsuario)
        {
            if (conta.Id_Conta == 0)
            {
                Insert(ref conta);
            }
            else
            {
                Update(conta);
            }
            return conta.Id_Conta;
        }
    }

    public class RepositorioObsConta : RepositoryBase<ObsConta>, IRepositorioObsConta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;

        public RepositorioObsConta(IDbConnection conexao, IDbTransaction transaction) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
        }
        public IEnumerable<ObsConta> ObterPorConta(int IdConta, int codEmpresa)
        {
            string sql = "SELECT ID_OBS, COD_EMPRESA, ID_CONTA, TEXTO FROM OBS_CONTAS";
            sql += " WHERE COD_EMPRESA = " + codEmpresa;
            sql += " AND ID_CONTA = " + IdConta;
            return _conexao.Query<ObsConta>(sql, null, _transaction);
        }

        public override void Insert(ref ObsConta entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new ObsConta(), "OBS_CONTAS", "ID_OBS");

            entity.Id_Obs = _conexao.Query<int>(base.SequencialFB("GEN_OBSCONTA"), null, _transaction).First();
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }
    }
}
