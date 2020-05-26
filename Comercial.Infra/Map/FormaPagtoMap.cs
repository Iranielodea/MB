using Comercial.Dominio.Entidades;
using Dapper.FluentMap.Dommel.Mapping;

namespace Comercial.Infra.Map
{
    public class FormaPagtoMap : DommelEntityMap<FormaPagto>
    {
        public FormaPagtoMap()
        {
            ToTable("FORMA_PAGTO");
            Map(x => x.Cod_Pagto).ToColumn("COD_PAGTO").IsKey();
        }
    }
}
