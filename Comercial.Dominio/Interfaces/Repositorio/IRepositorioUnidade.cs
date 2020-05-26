using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioUnidade : IRepositoryBase<Unidade>
    {
    }

    public interface IRepositorioUnidadeConsulta
    {
        IEnumerable<UnidadeConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
    }
}
