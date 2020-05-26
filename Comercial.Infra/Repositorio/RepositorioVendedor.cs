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
    public class RepositorioVendedor : RepositoryBase<Vendedor>, IRepositorioVendedor, IRepositorioVendedorConsulta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        public RepositorioVendedor(IDbConnection conexao, IDbTransaction transaction) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
        }
        public override void Insert(ref Vendedor entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new Vendedor(), "VENDEDOR", "COD_VENDEDOR");

            entity.Cod_Vendedor = _conexao.Query<int>(base.SequencialFB("gen_vendedor"), null, _transaction).First();
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        public IEnumerable<VendedorConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            string sql = "SELECT COD_VENDEDOR, NOME FROM VENDEDOR";
            if (id == 0)
            {
                sql += " WHERE COD_EMPRESA = " + codEmpresa;
                sql += " AND " + campo + " CONTAINING(" + Funcao.QuotedStr(valor) + ")";
                sql += " ORDER BY " + campo;
            }
            else
            {
                sql += " WHERE COD_VENDEDOR = " + id;
            }

            return _conexao.Query<VendedorConsulta>(sql);
        }
    }
}
