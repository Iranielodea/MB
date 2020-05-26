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
    public class RepositorioParametro : RepositoryBase<Parametro>, IRepositorioParametro, IRepositorioParametroConsulta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        public RepositorioParametro(IDbConnection conexao, IDbTransaction transaction) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
        }
        public override void Insert(ref Parametro entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new Parametro(), "PARAMETRO", "PAR_ID");

            entity.Par_Id = _conexao.Query<int>(base.SequencialFB("gen_parametros"), null, _transaction).First();
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        public IEnumerable<ParametroConsulta> Filtrar(string campo, string valor, int id = 0)
        {
            string sql = "SELECT PAR_ID, CODIGO, VALOR, NOME FROM PARAMETROS";
            if (id == 0)
            {
                sql += " WHERE " + campo + " CONTAINING(" + Funcao.QuotedStr(valor) + ")";
                sql += " ORDER BY " + campo;
            }
            else
            {
                sql += " WHERE PAR_ID = " + id;
            }

            return _conexao.Query<ParametroConsulta>(sql);
        }
    }
}
