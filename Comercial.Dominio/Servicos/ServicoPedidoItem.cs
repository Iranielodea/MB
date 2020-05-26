using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;

namespace Comercial.Dominio.Servicos
{
    public class ServicoPedidoItem : ServicoBase<PedidoItem>, IServicoPedidoItem
    {
        private readonly IRepositorioPedidoItem _repositorioPedidoItem;

        public ServicoPedidoItem(IRepositorioPedidoItem repositorioPedidoItem)
            :base(repositorioPedidoItem)
        {
            _repositorioPedidoItem = repositorioPedidoItem;
        }

        public void Excluir(PedidoItem pedidoItem)
        {
            try
            {
                var model = _repositorioPedidoItem.ObterPedidoItem(pedidoItem.Cod_Empresa.Value,
                    pedidoItem.Num_Pedido,
                    pedidoItem.Cod_Produto,
                    pedidoItem.Seq);

                if (model != null)
                    _repositorioPedidoItem.Delete(model);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<PedidoItem> ItensPorPedido(int codEmpresa, int numPedido)
        {
            return _repositorioPedidoItem.ObterPorPedido(codEmpresa, numPedido);
        }

        public PedidoItem ObterPorId(int codEmpresa, int numPedido, int codProduto, int seq)
        {
            return _repositorioPedidoItem.ObterPedidoItem(codEmpresa, numPedido, codProduto, seq);
        }

        public void Salvar(PedidoItem pedidoItem, string nomeUsuario)
        {
            if (pedidoItem.Cod_Produto == 0)
                throw new Exception("Informe o Produto!");

            if (pedidoItem.Qtde == 0)
                throw new Exception("Informe a Quantidade!");

            if (pedidoItem.Valor == 0)
                throw new Exception("Informe o Valor!");

            if (pedidoItem.Preco_Venda == 0)
                throw new Exception("Informe o Preço de Venda!");

            if (pedidoItem.Valor > pedidoItem.Preco_Venda)
                throw new Exception("Preço de compra maior que preço de venda!");

            try
            {
                CalcularTotalItem(pedidoItem);

                if (pedidoItem.Seq == 0)
                {
                    pedidoItem.Usu_Inc = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioPedidoItem.Insert(ref pedidoItem);
                }
                else
                {
                    pedidoItem.Usu_Alt = Geral.PermissaoUsuario.GravarUsuarioDataHora(nomeUsuario);
                    _repositorioPedidoItem.Update(pedidoItem);
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        private void CalcularTotalItem(PedidoItem pedidoItem)
        {
            pedidoItem.Valor_Total = pedidoItem.Qtde * pedidoItem.Valor;
            pedidoItem.Valor_Lucro = pedidoItem.Preco_Venda - pedidoItem.Valor;
            pedidoItem.Total_Lucro = pedidoItem.Valor_Lucro * pedidoItem.Qtde;
            pedidoItem.Total_Venda = pedidoItem.Preco_Venda * pedidoItem.Qtde;
        }
    }
}
