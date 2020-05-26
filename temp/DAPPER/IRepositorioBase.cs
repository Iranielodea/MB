using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DAPPER.Dominio.Contratcts
{
    public interface IRepositorioBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        void Insert(ref TEntity entity);
        bool Update(TEntity entity);
        bool Delete(Int32 id);
        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate);
    }
}
