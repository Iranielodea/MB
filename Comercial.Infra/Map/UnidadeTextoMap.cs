using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class UnidadeTextoMap : DommelEntityMap<UnidadeTexto>
    {
        public UnidadeTextoMap()
        {
            ToTable("UNIDADE_TEXTO");
            Map(x => x.Id).ToColumn("ID").IsKey();
        }
    }
}
