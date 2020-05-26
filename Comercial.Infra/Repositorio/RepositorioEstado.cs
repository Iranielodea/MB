using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Infra.DataBase;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Comercial.Infra.Repositorio
{
    public class RepositorioEstado : RepositoryBase<Estado>, IRepositorioEstado, IRepositorioEstadoConsulta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        public RepositorioEstado(IDbConnection conexao, IDbTransaction transaction) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
        }
        public override void Insert(ref Estado entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new Estado(), "ESTADO", "ID_ESTADO");

            //string instrucaoSQL = @"INSERT INTO ESTADO(DESC_ESTADO, SIGLA, USU_INC, COD_EMPRESA, ICMS)
            //    VALUES(@DESC_ESTADO, @SIGLA, @USU_INC, @COD_EMPRESA, @ICMS)";

            entity.Id_Estado = _conexao.Query<int>(base.SequencialFB("gen_estado"), null, _transaction).First();
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        public IEnumerable<EstadoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            string sql = "SELECT ID_ESTADO, SIGLA, DESC_ESTADO FROM ESTADO";
            if (id == 0)
            {
                sql += " WHERE COD_EMPRESA = " + codEmpresa;
                sql += " AND " + campo + " CONTAINING('" + valor + "')";
                sql += " ORDER BY " + campo;
            }
            else
            {
                sql += " WHERE ID_ESTADO = " + id;
            }

            return _conexao.Query<EstadoConsulta>(sql);
        }
    }
}
