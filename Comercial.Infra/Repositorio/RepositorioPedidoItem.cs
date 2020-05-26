using Comercial.Dominio.Entidades;
using Comercial.Dominio.Geral;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Infra.DataBase;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Comercial.Infra.Repositorio
{
    public class RepositorioPedidoItem : RepositoryBase<PedidoItem>, IRepositorioPedidoItem
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        public RepositorioPedidoItem(IDbConnection conexao, IDbTransaction transaction) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
        }
        public override void Insert(ref PedidoItem entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new PedidoItem(), "ITENS_PEDIDO", "NUM_PEDIDO");

            //entity.Num_Pedido = _conexao.Query<int>(base.SequencialFB("gen_pedido"), null, _transaction).First();
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        private string RetornarCampos()
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Select(new PedidoItem(), "ITENS_PEDIDO", "ITE", false);
            instrucaoSQL += ", PRO.DESC_PRODUTO AS NOMEPRODUTO";
            instrucaoSQL += ", UNI.SIGLA AS SIGLAUN";
            instrucaoSQL += " FROM ITENS_PEDIDO";
            instrucaoSQL += " INNER JOIN PRODUTO PRO ON ITE.COD_EMPRESA = PRO.CODEMPRESA AND PRO.COD_PRODUTO = ITE.COD_PRODUTO";
            instrucaoSQL += " LEFT JOIN UNIDADE UNI ON ITE.ID_UNIDADE = UNI.ID_UNIDADE";
            return instrucaoSQL;
        }

        public PedidoItem ObterPedidoItem(int codEmpresa, int numPedido, int codProduto, int seq)
        {
            string instrucaoSQL = RetornarCampos();
            instrucaoSQL += " WHERE COD_EMPRESA = " + codEmpresa;
            instrucaoSQL += " WHERE NUM_PEDIDO = " + numPedido;
            instrucaoSQL += " WHERE SEQ = " + seq;

            return  _conexao.Query<PedidoItem>(instrucaoSQL, null, _transaction).FirstOrDefault();
        }

        public IEnumerable<PedidoItem> ObterPorPedido(int codEmpresa, int numPedido)
        {
            string instrucaoSQL = RetornarCampos();
            instrucaoSQL += " WHERE COD_EMPRESA = " + codEmpresa;
            instrucaoSQL += " WHERE NUM_PEDIDO = " + numPedido;

            return _conexao.Query<PedidoItem>(instrucaoSQL, null, _transaction);
        }
    }
}
