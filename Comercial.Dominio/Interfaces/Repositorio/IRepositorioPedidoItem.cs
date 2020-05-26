using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioPedidoItem : IRepositoryBase<PedidoItem>
    {
        PedidoItem ObterPedidoItem(int codEmpresa, int numPedido, int codProduto, int seq);
        IEnumerable<PedidoItem> ObterPorPedido(int codEmpresa, int numPedido);
    }
}
