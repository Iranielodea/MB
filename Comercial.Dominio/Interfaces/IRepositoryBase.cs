using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Comercial.Dominio.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        IQueryable<TEntity> Todos();
        TEntity GetById(int id);
        void Insert(ref TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
        IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate);
        TEntity First(Expression<Func<TEntity, bool>> predicate);
        void Disposed();
    }
}
