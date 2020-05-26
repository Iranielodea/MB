using Comercial.Dominio.Entidades;
using System.Collections.Generic;

namespace Comercial.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioCidade : IRepositoryBase<Cidade>
    {
    }

    public interface IRepositorioCidadeConsulta
    {
        IEnumerable<CidadeConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0);
    }
}
