using Comercial.Dominio.Entidades;
using Comercial.Dominio.Geral;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Infra.DataBase;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Comercial.Infra.Repositorio
{
    public class RepositorioPedido : RepositoryBase<Pedido>, IRepositorioPedido, IRepositorioPedidoConsulta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        private IRepositorioCliente _repositorioCliente;
        private IRepositorioFornecedor _repositorioFornecedor;
        private IRepositorioVendedor _repositorioVendedor;

        public RepositorioPedido(IDbConnection conexao, IDbTransaction transaction,
            IRepositorioCliente repositorioCliente,
            IRepositorioVendedor repositorioVendedor,
            IRepositorioFornecedor repositorioFornecedor
            ) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
            _repositorioCliente = repositorioCliente;
            _repositorioFornecedor = repositorioFornecedor;
            _repositorioVendedor = repositorioVendedor;
        }

        public override void Insert(ref Pedido entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new Pedido(), "PEDIDO", "NUM_PEDIDO");

            entity.Num_Pedido = _conexao.Query<int>(base.SequencialFB("gen_pedido"), null, _transaction).First();
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        public IEnumerable<PedidoConsulta> Filtrar(string campo, string valor, int codEmpresa, PedidoFiltro pedidoFiltro, int id = 0)
        {
            var model = new PedidoConsulta();
            model.Data = Convert.ToDateTime("01/01/2019");
            string sql = "SELECT PED.NUM_PEDIDO, PED.DATA, PED.COD_CLIENTE, CLI.NOME AS NOMECLIENTE, PED.SITUACAO, PED.TOTAL_LIQUIDO FROM PEDIDO PED";
            sql += " INNER JOIN CLIENTE CLI ON PED.COD_CLIENTE = CLI.COD_CLIENTE";
            if (id == 0)
            {
                sql += " WHERE PED.COD_EMPRESA = " + codEmpresa;
                sql += " AND " + campo + " CONTAINING(" + Funcao.QuotedStr(valor) + ")";

                if (pedidoFiltro.CodCliente > 0)
                    sql += " AND PED.COD_CLIENTE = " + pedidoFiltro.CodCliente.ToString();

                if (pedidoFiltro.CodFornecedor > 0)
                    sql += " AND PED.COD_FOR = " + pedidoFiltro.CodFornecedor.ToString();

                if (pedidoFiltro.DataInicial.Trim() != "/  /")
                    sql += " AND PED.DATA >= @data"; // + string.Format(pedidoFiltro.DataInicial);
                //if (pedidoFiltro.DataFinal.Trim() != "/  /")
                //    sql += " AND PED.DATA <= '" + string.Format(pedidoFiltro.DataFinal, "MM/dd/yyyy") + "'";

                if (pedidoFiltro.NumPedido > 0)
                    sql += " AND PED.NUM_PEDIDO = " + pedidoFiltro.NumPedido.ToString();

                if (pedidoFiltro.Situacao == "A")
                    sql += " AND PED.SITUACAO = 'A'";

                if (pedidoFiltro.Situacao == "E")
                    sql += " AND PED.SITUACAO = 'E'";

                sql += " ORDER BY PED.DATA ";
            }
            else
            {
                sql += " WHERE PED.NUM_PEDIDO = " + id;
            }
            return _conexao.Query<PedidoConsulta>(sql);
        }

        public Pedido ObterPedido(int codEmpresa, int idPedido)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Select(new PedidoItem(), "ITENS_PEDIDO");
            instrucaoSQL += "WHERE COD_EMPRESA = " + codEmpresa;
            instrucaoSQL += "AND NUM_PEDIDO = " + idPedido;

            var pedido = base.GetById(idPedido);

            if (pedido != null)
            {
                if (pedido.Cod_Cliente > 0)
                    pedido.Cliente = _repositorioCliente.GetById(pedido.Cod_Cliente);

                if (pedido.Cod_For > 0)
                    pedido.Fornecedor = _repositorioFornecedor.GetById(pedido.Cod_For);

                if (pedido.Cod_Contato != null)
                    pedido.Contato = _repositorioCliente.GetById(pedido.Cod_Contato.Value);

                if (pedido.Cod_Usina != null)
                    pedido.Usina = _repositorioFornecedor.GetById(pedido.Cod_Usina.Value);

                if (pedido.Cod_Vendedor != null)
                    pedido.Vendedor = _repositorioVendedor.GetById(pedido.Cod_Vendedor.Value);
            }

            pedido.PedidoItems = _conexao.Query<PedidoItem>(instrucaoSQL).ToList();
            return pedido;

        }
    }
}
