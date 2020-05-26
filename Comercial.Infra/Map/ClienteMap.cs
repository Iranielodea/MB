using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class ClienteMap : DommelEntityMap<Cliente>
    {
        public ClienteMap()
        {
            ToTable("CLIENTE");
            Map(x => x.Cod_Cliente).ToColumn("COD_CLIENTE").IsKey();
            Map(x => x.Cidade).Ignore();
            Map(x => x.FormaPagto).Ignore();
            Map(x => x.Vendedor).Ignore();
        }
    }
}
