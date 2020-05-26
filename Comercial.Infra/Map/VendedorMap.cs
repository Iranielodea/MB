using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class VendedorMap : DommelEntityMap<Vendedor>
    {
        public VendedorMap()
        {
            ToTable("VENDEDOR");
            Map(x => x.Cod_Vendedor).ToColumn("COD_VENDEDOR").IsKey();
        }
    }
}
