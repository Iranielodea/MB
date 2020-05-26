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
    public class RepositorioProduto : RepositoryBase<Produto>, IRepositorioProduto, IRepositorioProdutoConsulta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        private IRepositorioUnidade _repositorioUnidade;
        private IRepositorioGrupo _repositorioGrupo;
        public RepositorioProduto(IDbConnection conexao, IDbTransaction transaction,
            IRepositorioUnidade repositorioUnidade,
            IRepositorioGrupo repositorioGrupo) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
            _repositorioUnidade = repositorioUnidade;
            _repositorioGrupo = repositorioGrupo;
        }
        public override void Insert(ref Produto entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new Produto(), "PRODUTO", "COD_PRODUTO");

            entity.Cod_Produto = _conexao.Query<int>(base.SequencialFB("gen_produto"), null, _transaction).First();
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        public IEnumerable<ProdutoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            string sql = "SELECT PRO.COD_PRODUTO, PRO.DESC_PRODUTO, UNI.SIGLA, PRO.VALOR_VENDA FROM PRODUTO PRO";
            sql += " INNER JOIN UNIDADE UNI ON PRO.ID_UNIDADE = UNI.ID_UNIDADE";
            if (id == 0)
            {
                sql += " WHERE PRO.COD_EMPRESA = " + codEmpresa;
                sql += " AND " + campo + " CONTAINING(" + Funcao.QuotedStr(valor) + ")";
                sql += " ORDER BY " + campo;
            }
            else
            {
                sql += " WHERE PRO.COD_PRODUTO = " + id;
            }

            return _conexao.Query<ProdutoConsulta>(sql);
        }

        public override Produto GetById(int id)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Select(new Produto(), "PRODUTO");
            instrucaoSQL += " WHERE COD_PRODUTO = " + id;

            var model = _conexao.Query<Produto>(instrucaoSQL, null, _transaction).FirstOrDefault();
            if (model != null)
            {
                model.Unidade = _repositorioUnidade.GetById(model.Id_Unidade);
                if (model.Cod_Grupo != null)
                    model.Grupo = _repositorioGrupo.GetById(model.Cod_Grupo.Value);
            }
            return model;
        }
    }
}
