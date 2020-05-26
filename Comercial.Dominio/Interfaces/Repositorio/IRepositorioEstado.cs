using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioEstado : IRepositoryBase<Estado>
    {
    }
    public interface IRepositorioEstadoConsulta
    {
        IEnumerable<EstadoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
    }
}
