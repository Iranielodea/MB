using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Infra.DataBase;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Comercial.Infra.Repositorio
{
    public class RepositorioUsuario : RepositoryBase<Usuario>, IRepositorioUsuario, IRepositorioUsuarioConsulta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        public RepositorioUsuario(IDbConnection conexao, IDbTransaction transaction) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
        }
        public override void Insert(ref Usuario entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new Usuario(), "CAD_USUARIO", "ID_USUARIO");

            _conexao.Execute(instrucaoSQL, entity, _transaction);
            entity.Id_Usuario = _conexao.Query<int>(base.SequencialFB("gen_usuario"), null, _transaction).First();
        }

        public IEnumerable<UsuarioConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            string sql = "SELECT ID_USUARIO, NOME FROM CAD_USUARIO";
            if (id == 0)
            {
                sql += " WHERE COD_EMPRESA = " + codEmpresa;
                sql += " AND " + campo + " CONTAINING('" + valor + "')";
                sql += " ORDER BY " + campo;
            }
            else
            {
                sql += " WHERE ID_USUARIO = " + id;
            }

            return _conexao.Query<UsuarioConsulta>(sql);
        }
    }
}
