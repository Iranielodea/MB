using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioMotorista : IRepositoryBase<Motorista>
    {
    }

    public interface IRepositorioMotoristaConsulta
    {
        IEnumerable<MotoristaConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
    }
}
