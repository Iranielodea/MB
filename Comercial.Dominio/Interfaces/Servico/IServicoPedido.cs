using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Servico
{
    public interface IServicoPedido
    {
        Pedido ObterPorId(int codEmpresa, int numPedido);
        IEnumerable<PedidoConsulta> Filtrar(string campo, string valor, int codEmpresa, PedidoFiltro pedidoFiltro, int id = 0);
        void Excluir(Pedido pedido, string nomeUsuario);
        int Salvar(Pedido pedido, string nomeUsuario);
        void CalcularComissao(Pedido pedido);
    }
}
