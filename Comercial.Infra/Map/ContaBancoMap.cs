using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class ContaBancoMap : DommelEntityMap<ContaBanco>
    {
        public ContaBancoMap()
        {
            ToTable("CONTABANCO");
            Map(x => x.Id_ContaBanco).ToColumn("ID_CONTABANCO").IsKey();
        }
    }
}
