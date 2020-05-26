using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioPedido : IRepositoryBase<Pedido>
    {
        Pedido ObterPedido(int codEmpresa, int idPedido);
    }

    public interface IRepositorioPedidoConsulta
    {
        IEnumerable<PedidoConsulta> Filtrar(string campo, string valor, int codEmpresa, PedidoFiltro pedidoFiltro, int id = 0);
    }
}
