using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class ContatoMap : DommelEntityMap<Contato>
    {
        public ContatoMap()
        {
            ToTable("CONTATO");
            Map(x => x.ContatoTexto).ToColumn("CONTATO");
        }
    }
}
