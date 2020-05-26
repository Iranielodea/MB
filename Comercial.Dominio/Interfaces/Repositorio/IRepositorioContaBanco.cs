using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioContaBanco : IRepositoryBase<ContaBanco>
    {
    }

    public interface IRepositorioContaBancoConsulta
    {
        IEnumerable<ContaBancoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
    }
}
