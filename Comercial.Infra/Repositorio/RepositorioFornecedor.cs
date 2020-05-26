using Comercial.Dominio.Entidades;
using Comercial.Dominio.Geral;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Infra.DataBase;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Comercial.Infra.Repositorio
{
    public class RepositorioFornecedor : RepositoryBase<Fornecedor>, IRepositorioFornecedor, IRepositorioFornecedorConsulta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        private IRepositorioCidade _repositorioCidade;
        private IRepositorioFornecedorTipoEmpresa _repositorioFornecedorTipoEmpresa;
        public RepositorioFornecedor(IDbConnection conexao, IDbTransaction transaction,
            IRepositorioCidade repositorioCidade,
            IRepositorioFornecedorTipoEmpresa repositorioFornecedorTipoEmpresa) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
            _repositorioCidade = repositorioCidade;
            _repositorioFornecedorTipoEmpresa = repositorioFornecedorTipoEmpresa;
        }
        public override void Insert(ref Fornecedor entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new Fornecedor(), "FORNECEDOR", "COD_FOR");

            entity.Cod_For = _conexao.Query<int>(base.SequencialFB("gen_fornecedor"), null, _transaction).First();
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        public IEnumerable<FornecedorConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            string sql = "SELECT COD_FOR, NOME, CNPJ, INSC_ESTADUAL, FONE, EMAIL, CPF FROM FORNECEDOR";
            if (id == 0)
            {
                sql += " WHERE COD_EMPRESA = " + codEmpresa;
                sql += " AND " + campo + " CONTAINING(" + Funcao.QuotedStr(valor) + ")";
                sql += " ORDER BY " + campo;
            }
            else
            {
                sql += " WHERE COD_FOR = " + id;
            }

            return _conexao.Query<FornecedorConsulta>(sql);
        }

        public override Fornecedor GetById(int id)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Select(new Fornecedor(), "FORNECEDOR");
            instrucaoSQL += " WHERE COD_FOR = " + id;

            var model = _conexao.Query<Fornecedor>(instrucaoSQL, null, _transaction).FirstOrDefault();
            if (model != null)
            {
                if (model.Cod_Cidade != null)
                    model.Cidade = _repositorioCidade.GetById(model.Cod_Cidade.Value);

                if (model.Id_Tipo_Empresa != null)
                    model.FornecedorTipoEmpresa = _repositorioFornecedorTipoEmpresa.GetById(model.Id_Tipo_Empresa.Value);
            }
            return model;
        }
    }
}
