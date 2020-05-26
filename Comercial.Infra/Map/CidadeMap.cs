using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class CidadeMap : DommelEntityMap<Cidade>
    {
        public CidadeMap()
        {
            ToTable("CIDADE");
            Map(x => x.Cod_Cidade).ToColumn("COD_CIDADE").IsKey();
            Map(x => x.Estado).Ignore();
        }
    }
}
