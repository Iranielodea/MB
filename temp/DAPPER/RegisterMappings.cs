using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using DAPPER.Dominio.Mapper;

namespace DAPPER.Dominio
{
    public static class RegisterMappings
    {
        public static void Register()
        {
            FluentMapper.Initialize(config =>
            {
                config.AddMap(new BancoMap());
                config.ForDommel();
            });
        }
    }
}
