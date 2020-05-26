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
    public class RepositorioCarga : RepositoryBase<Carga>, IRepositorioCarga, IRepositorioCargaConsulta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        private string _instrucaoSQL;
        private Persistencia _persistencia;

        public RepositorioCarga(IDbConnection conexao, IDbTransaction transaction) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
            _persistencia = new PersistenciaFactory().Instanciar();
        }
        public override void Insert(ref Carga entity)
        {
            //var Dados = new PersistenciaFactory().Instanciar();
            //_instrucaoSQL = Dados.Inserir(new Carga(), "CARGA", "ID_CARGA");
            _instrucaoSQL = _persistencia.Inserir(new Carga(), "CARGA", "ID_CARGA");

            entity.Num_Carga = _conexao.Query<int>(base.SequencialFB("gen_carga"), null, _transaction).First();
            _conexao.Execute(_instrucaoSQL, entity, _transaction);
        }

        public IEnumerable<CargaConsulta> Filtrar(string campo, string valor, int codEmpresa, CargaFiltro cargaFiltro, int id = 0)
        {
            string sql = "SELECT CAR.ID_CARGA, CAR.NUM_CARGA, CAR.NUM_PEDIDO, CAR.LETRA, CAR.DATA, CAR.COD_CLIENTE, CLI.NOME AS NOME, CAR.QTDE_PEDIDO, CAR.QTDE, CAR.VALOR_PEDIDO, CAR.VALOR_FRETE FROM CARGA CAR";
            sql += " INNER JOIN CLIENTE CLI ON CAR.COD_CLIENTE = CLI.COD_CLIENTE";
            if (id == 0)
            {
                sql += " WHERE CAR.COD_EMPRESA = " + codEmpresa;
                sql += " AND " + campo + " CONTAINING(" + Funcao.QuotedStr(valor) + ")";
                sql += " ORDER BY " + campo;
            }
            else
            {
                sql += " WHERE CAR_ID_CARGA = " + id;
            }

            return _conexao.Query<CargaConsulta>(sql);
        }

        public Carga ObterCargasDoMotorista(int codEmpresa, DateTime data, int codMotorista)
        {
            string sql = "SELECT count(ID_CARGA) AS QTDE, max(NUM_CARGA) AS NUM_CARGA FROM CARGA";
            sql += " WHERE COD_EMPRESA = " + codEmpresa;
            sql += " AND DATA = " + data;
            sql += " AND COD_MOTORISTA = " + codMotorista;
            return _conexao.Query<Carga>(sql).FirstOrDefault();
        }

        public Carga ObterUltimaCargaDaData(int codEmpresa, DateTime data)
        {
            string sql = "SELECT max(NUM_CARGA) AS NUM_CARGA FROM CARGA";
            sql += " WHERE COD_EMPRESA = " + codEmpresa;
            sql += " AND DATA = " + data;
            return _conexao.Query<Carga>(sql).FirstOrDefault();
        }

        public decimal ObterSaldoCarga(int codEmpresa, int idCarga, int numPedido)
        {
            string sql = "SELECT sum(QTDE) AS QTDE FROM CARGA";
            sql += " WHERE COD_EMPRESA = " + codEmpresa;
            sql += " AND ID_CARGA <> " + idCarga;
            sql += " AND NUM_PEDIDO = " + numPedido;

            return _conexao.Query<decimal>(sql).First();
        }

        public Carga ObterPorPedido(int numPedido)
        {
            _instrucaoSQL = _persistencia.Select(new Carga(), "CARGA", "");
            _instrucaoSQL += " WHERE ID_CARGA = " + numPedido;
            return _conexao.Query<Carga>(_instrucaoSQL, null, _transaction).FirstOrDefault();
        }

        public IEnumerable<Carga> ObterCargasDoPedido(int numPedido)
        {
            _instrucaoSQL = _persistencia.Select(new Carga(), "CARGA", "");
            _instrucaoSQL += " WHERE NUM_PEDIDO = " + numPedido;

            return _conexao.Query<Carga>(_instrucaoSQL, null, _transaction);
        }

        public decimal CalcularLucro(Carga carga, bool calcularTudo)
        {
            if (calcularTudo)
            {
                carga.Valor_Carrega = (carga.Pedido.Valor_Lucro * carga.Qtde) - carga.Valor_Frete;
            }
            // ValorDif = return mostrar na tela
            return carga.Pedido.Valor_Lucro;
        }
    }

    public class RepositorioCargaVencimento : RepositoryBase<CargaVencimento>, IRepositorioCargaVencimento
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        public RepositorioCargaVencimento(IDbConnection conexao, IDbTransaction transaction) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
        }

        public override void Insert(ref CargaVencimento entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new CargaVencimento(), "CARGA_VENCTO", "ID");

            entity.Id = _conexao.Query<int>(base.SequencialFB("gen_carga_vencto"), null, _transaction).First();
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }
    }
}
