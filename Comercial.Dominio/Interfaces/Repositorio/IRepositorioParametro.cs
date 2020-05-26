using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioParametro : IRepositoryBase<Parametro>
    {
    }

    public interface IRepositorioParametroConsulta
    {
        IEnumerable<ParametroConsulta> Filtrar(string campo, string valor, int id = 0);
    }
}
