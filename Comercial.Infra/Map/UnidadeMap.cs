using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class UnidadeMap : DommelEntityMap<Unidade>
    {
        public UnidadeMap()
        {
            ToTable("UNIDADE");
            Map(x => x.Id_Unidade).ToColumn("ID_UNIDADE").IsKey();
            Map(x => x.UnidadeTexto).Ignore();
        }
    }
}
