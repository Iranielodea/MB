using Comercial.Dominio.Interfaces;
using Dommel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;

namespace Comercial.Infra.Repositorio
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        IDbTransaction _transacao;
        IDbConnection _conexao;

        public RepositoryBase(IDbConnection conexao, IDbTransaction transaction)
        {
            _conexao = conexao;
            _transacao = transaction;
        }

        public bool Delete(TEntity entity)
        {
            if (entity == null)
                throw new Exception("Registro não encontrado");

            return _conexao.Delete(entity, _transacao);
        }

        public IQueryable<TEntity> Todos()
        {
            return _conexao.GetAll<TEntity>().AsQueryable();
        }

        public virtual TEntity GetById(int id)
        {
            return _conexao.Get<TEntity>(id);
        }

        public TEntity First(Expression<Func<TEntity, bool>> predicate)
        {
            return _conexao.FirstOrDefault(predicate);
        }

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate)
        {
            return _conexao.Select(predicate);
        }
        
        public virtual void Insert(ref TEntity entity)
        {
            var id = _conexao.Insert(entity, _transacao);
            entity = GetById((int)id);
        }
        
        public virtual bool Update(TEntity entity)
        {
            return _conexao.Update(entity, _transacao);
        }

        protected string SequencialFB(string generator)
        {
            return "SELECT GEN_ID(" + generator + ", 1) FROM RDB$DATABASE";
        }

        public void Disposed()
        {
            if (_conexao != null)
                _conexao.Dispose();
        }
    }
}
