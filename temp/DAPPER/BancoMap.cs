using Dapper.FluentMap.Dommel.Mapping;
using DAPPER.Dominio.Entidades;

namespace DAPPER.Dominio.Mapper
{
    public class BancoMap : DommelEntityMap<Banco>
    {
        public BancoMap()
        {
            ToTable("TBANCO");
            Map(x => x.Codigo).ToColumn("BANCODIGO").IsKey();
            Map(x => x.Nome).ToColumn("BANNOME");

        }
    }
}
