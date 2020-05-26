using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioUnidadeTexto : IRepositoryBase<UnidadeTexto>
    {
    }

    public interface IRepositorioUnidadeTextoConsulta
    {
        IEnumerable<UnidadeTextoConsulta> Filtrar(string campo, string valor, int id = 0);
    }
}
