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
    public class RepositorioUnidadeTexto : RepositoryBase<UnidadeTexto>, IRepositorioUnidadeTexto, IRepositorioUnidadeTextoConsulta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        public RepositorioUnidadeTexto(IDbConnection conexao, IDbTransaction transaction) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
        }
        public override void Insert(ref UnidadeTexto entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new UnidadeTexto(), "UNIDADE_TEXTO", "ID");

            entity.Id = _conexao.Query<int>(base.SequencialFB("gen_unidade_Texto"), null, _transaction).First();
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        public IEnumerable<UnidadeTextoConsulta> Filtrar(string campo, string valor, int id = 0)
        {
            string sql = "SELECT ID, OBSERVACAO FROM UNIDADE_TEXTO";
            if (id == 0)
            {
                sql += " WHERE " + campo + " CONTAINING(" + Funcao.QuotedStr(valor) + ")";
                sql += " ORDER BY " + campo;
            }
            else
            {
                sql += " WHERE ID = " + id;
            }

            return _conexao.Query<UnidadeTextoConsulta>(sql);
        }
    }
}
