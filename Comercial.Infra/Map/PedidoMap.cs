using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class PedidoMap : DommelEntityMap<Pedido>
    {
        public PedidoMap()
        {
            ToTable("PEDIDO");
            Map(x => x.Num_Pedido).ToColumn("NUM_PEDIDO").IsKey();
        }
    }

    public class PedidoItemMap : DommelEntityMap<PedidoItem>
    {
        public PedidoItemMap()
        {
            ToTable("ITENS_PEDIDO");
            Map(x => x.Num_Pedido).ToColumn("NUM_PEDIDO").IsKey();
            Map(x => x.NomeProduto).Ignore();
            Map(x => x.SiglaUn).Ignore();
        }
    }
}
