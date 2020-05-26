using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class EstadoMap : DommelEntityMap<Estado>
    {
        public EstadoMap()
        {
            ToTable("ESTADO");
            Map(x => x.Id_Estado).IsKey();
        }
    }
}
