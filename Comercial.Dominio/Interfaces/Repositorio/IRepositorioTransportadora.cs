using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioTransportadora : IRepositoryBase<Transportadora>
    {
    }

    public interface IRepositorioTransportadoraConsulta
    {
        IEnumerable<TransportadoraConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
    }
}
