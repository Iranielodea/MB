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
    public class RepositorioUnidade : RepositoryBase<Unidade>, IRepositorioUnidade, IRepositorioUnidadeConsulta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        private IRepositorioUnidadeTexto _repositorioUnidadeTexto;
        public RepositorioUnidade(IDbConnection conexao, IDbTransaction transaction,
            IRepositorioUnidadeTexto repositorioUnidadeTexto) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
            _repositorioUnidadeTexto = repositorioUnidadeTexto;
        }

        private string RetornarCampos()
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new Unidade(), "UNIDADE", "ID_UNIDADE");
            return instrucaoSQL;
        }
        public override void Insert(ref Unidade entity)
        {
            entity.Id_Unidade = _conexao.Query<int>(base.SequencialFB("gen_unidade"), null, _transaction).First();
            _conexao.Execute(RetornarCampos(), entity, _transaction);
        }

        public IEnumerable<UnidadeConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            string sql = "SELECT ID_UNIDADE, SIGLA, DESC_UNIDADE FROM UNIDADE";
            if (id == 0)
            {
                sql += " WHERE COD_EMPRESA = " + codEmpresa;
                sql += " AND " + campo + " CONTAINING(" + Funcao.QuotedStr(valor) + ")";
                sql += " ORDER BY " + campo;
            }
            else
            {
                sql += " WHERE ID_UNIDADE = " + id;
            }

            return _conexao.Query<UnidadeConsulta>(sql);
        }

        public override Unidade GetById(int id)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Select(new Unidade(), "UNIDADE");
            instrucaoSQL += " WHERE ID_UNIDADE = " + id;

            var model = _conexao.Query<Unidade>(instrucaoSQL, null, _transaction).FirstOrDefault();
            if (model != null)
            {
                model.UnidadeTexto = _repositorioUnidadeTexto.GetById(model.Id_Texto.Value);
            }
            return model;
        }
    }
}
