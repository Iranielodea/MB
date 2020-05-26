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
    public class RepositorioFornecedorTipoEmpresa : RepositoryBase<FornecedorTipoEmpresa>, IRepositorioFornecedorTipoEmpresa, IRepositorioFornecedorTipoEmpresaConsulta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        public RepositorioFornecedorTipoEmpresa(IDbConnection conexao, IDbTransaction transaction) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
        }
        public override void Insert(ref FornecedorTipoEmpresa entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new FornecedorTipoEmpresa(), "FORN_TIPO_EMPRESA", "ID_TIPO");

            entity.Id_Tipo = _conexao.Query<int>(base.SequencialFB("GEN_FORN_TIPO_EMPRESA"), null, _transaction).First();
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        public IEnumerable<FornecedorTipoEmpresaConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            string sql = "SELECT ID_TIPO, DESC_TIPO, SIGLA FROM FORN_TIPO_EMPRESA";
            if (id == 0)
            {
                sql += " WHERE COD_EMPRESA = " + codEmpresa;
                sql += " AND " + campo + " CONTAINING(" + Funcao.QuotedStr(valor) + ")";
                sql += " ORDER BY " + campo;
            }
            else
            {
                sql += " WHERE ID_TIPO = " + id;
            }

            return _conexao.Query<FornecedorTipoEmpresaConsulta>(sql);
        }
    }
}
