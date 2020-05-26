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
    public class RepositorioGrupo : RepositoryBase<Grupo>, IRepositorioGrupo, IRepositorioGrupoConsulta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        public RepositorioGrupo(IDbConnection conexao, IDbTransaction transaction) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
        }
        public override void Insert(ref Grupo entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new Grupo(), "GRUPO", "COD_GRUPO");

            entity.Cod_Grupo = _conexao.Query<int>(base.SequencialFB("gen_grupo"), null, _transaction).First();
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        public IEnumerable<GrupoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            string sql = "SELECT COD_GRUPO, DESC_GRUPO FROM GRUPO";
            if (id == 0)
            {
                sql += " WHERE COD_EMPRESA = " + codEmpresa;
                sql += " AND " + campo + " CONTAINING(" + Funcao.QuotedStr(valor) + ")";
                sql += " ORDER BY " + campo;
            }
            else
            {
                sql += " WHERE COD_GRUPO = " + id;
            }

            return _conexao.Query<GrupoConsulta>(sql);
        }

        public IQueryable<GrupoConsulta> GetAll()
        {
            string sql = "SELECT COD_GRUPO, DESC_GRUPO FROM GRUPO";
            return _conexao.Query<GrupoConsulta>(sql).AsQueryable();
        }
    }
}
