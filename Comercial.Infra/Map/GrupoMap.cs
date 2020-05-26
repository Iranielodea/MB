using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class GrupoMap : DommelEntityMap<Grupo>
    {
        public GrupoMap()
        {
            ToTable("GRUPO");
            Map(x => x.Cod_Grupo).ToColumn("COD_GRUPO").IsKey();
        }
    }
}
