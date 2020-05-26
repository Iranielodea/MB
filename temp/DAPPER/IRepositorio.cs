using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkInfra.Interfaces
{
    public interface IRepositorio<T> where T : class
    {
        T GetId(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Remove(T entity);
    }
}
