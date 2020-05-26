using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class ParametroMap : DommelEntityMap<Parametro>
    {
        public ParametroMap()
        {
            ToTable("PARAMETROS");
            Map(x => x.Par_Id).ToColumn("PAR_ID").IsKey();
        }
    }
}
