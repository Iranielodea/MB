using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class CadObsMap : DommelEntityMap<CadObs>
    {
        public CadObsMap()
        {
            ToTable("CAD_OBS");
            Map(x => x.Codigo).IsKey();
        }
    }
}
