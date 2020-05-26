using Comercial.Dominio.Interfaces;
using Comercial.Dominio.Interfaces.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Servicos
{
    public class ServicoBase<T> : IDisposable, IServicoBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repositoryBase;

        public ServicoBase(IRepositoryBase<T> repositorioBase)
        {
            _repositoryBase = repositorioBase;
        }

        public bool Delete(T entity)
        {
            return _repositoryBase.Delete(entity);
        }

        public void Dispose()
        {
            _repositoryBase.Disposed();
        }

        public T First(Expression<Func<T, bool>> predicate)
        {
            return _repositoryBase.First(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return _repositoryBase.Todos();
        }

        public T GetById(int id)
        {
            return _repositoryBase.GetById(id);
        }

        public IEnumerable<T> GetList(Expression<Func<T, bool>> predicate)
        {
            return _repositoryBase.GetList(predicate);
        }

        public void Insert(ref T entity)
        {
            _repositoryBase.Insert(ref entity);
        }

        public bool Update(T entity)
        {
            return _repositoryBase.Update(entity);
        }
    }
}
