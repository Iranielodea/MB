using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoPedidoItem
    {
        PedidoItem ObterPorId(int codEmpresa, int numPedido, int codProduto, int seq);
        void Excluir(PedidoItem pedidoItem);
        void Salvar(PedidoItem pedidoItem, string nomeUsuario);
        IEnumerable<PedidoItem> ItensPorPedido(int codEmpresa, int numPedido);
    }
}
