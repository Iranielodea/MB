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
    public class RepositorioEmpresa : RepositoryBase<Empresa>, IRepositorioEmpresa, IRepositorioEmpresaConsulta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        public RepositorioEmpresa(IDbConnection conexao, IDbTransaction transaction) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
        }
        public override void Insert(ref Empresa entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new Empresa(), "EMPRESA", "COD_EMPRESA");

            entity.Cod_Empresa = _conexao.Query<int>(base.SequencialFB("gen_empresa"), null, _transaction).First();
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        public IEnumerable<EmpresaConsulta> Filtrar(string campo, string valor, int id = 0)
        {
            string sql = "SELECT COD_EMPRESA, NOME FROM EMPRESA";
            if (id == 0)
            {
                sql += " WHERE " + campo + " CONTAINING(" + Funcao.QuotedStr(valor) + ")";
                sql += " ORDER BY " + campo;
            }
            else
            {
                sql += " WHERE COD_EMPRESA = " + id;
            }

            return _conexao.Query<EmpresaConsulta>(sql);
        }
    }
}
