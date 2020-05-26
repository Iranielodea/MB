using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Infra.DataBase;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Comercial.Infra.Repositorio
{
    public class RepositorioFormaPagto : RepositoryBase<FormaPagto>, IRepositorioFormaPagto, IRepositorioFormaPagtoConsulta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        public RepositorioFormaPagto(IDbConnection conexao, IDbTransaction transaction) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
        }
        public override void Insert(ref FormaPagto entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new FormaPagto(), "FORMA_PAGTO", "COD_PAGTO");

            entity.Cod_Pagto = _conexao.Query<int>(base.SequencialFB("gen_FormaPagto"), null, _transaction).First();
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        public IEnumerable<FormaPagtoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            string sql = "SELECT COD_PAGTO, SIGLA, DESC_PAGTO FROM FORMA_PAGTO";

            if (id == 0)
            {
                sql += " WHERE COD_EMPRESA = " + codEmpresa;
                sql += " AND " + campo + " CONTAINING('" + valor + "')";
                sql += " ORDER BY " + campo;
            }
            else
            {
                sql += " WHERE COD_PAGTO = " + id;
            }
            return _conexao.Query<FormaPagtoConsulta>(sql);
        }
    }
}
