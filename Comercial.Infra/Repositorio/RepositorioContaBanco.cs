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
    public class RepositorioContaBanco : RepositoryBase<ContaBanco>, IRepositorioContaBanco, IRepositorioContaBancoConsulta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        public RepositorioContaBanco(IDbConnection conexao, IDbTransaction transaction) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
        }
        public override void Insert(ref ContaBanco entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new ContaBanco(), "CONTABANCO", "ID_CONTABANCO");

            entity.Id_ContaBanco = _conexao.Query<int>("SELECT MAX(ID_CONTABANCO) + 1 FROM CONTABANCO", null, _transaction).First();
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        public IEnumerable<ContaBancoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            string sql = "SELECT ID_CONTABANCO, NUM_CONTA, AGENCIA, BANCO FROM CONTABANCO";
            if (id == 0)
            {
                sql += " WHERE COD_EMPRESA = " + codEmpresa;
                sql += " AND " + campo + " CONTAINING(" + Funcao.QuotedStr(valor) + ")";
                sql += " ORDER BY " + campo;
            }
            else
                sql += " WHERE ID_CONTABANCO = " + id;

            return _conexao.Query<ContaBancoConsulta>(sql);
        }
    }
}
