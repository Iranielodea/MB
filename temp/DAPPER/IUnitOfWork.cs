using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkInfra.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IProdutoRepositorio produtoRepositorio { get; }
        IModuloRepositorio moduloRepositorio { get; }

        int Commit();
    }
}
