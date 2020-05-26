using DAPPER.Dominio.Contratcts;
using Dommel;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DAPPER.Dominio.Repository
{
    public class RepositoryBase<TEntity> : IRepositorioBase<TEntity> where TEntity : class
    {
        //protected readonly string ConnectionString;
        string connection =
        "User=SYSDBA;" +
        "Password=masterkey;" +
        "Database=D:\\TESTES\\Clientes\\TJR\\EMPDADOS;" +
        "DataSource=localhost;" +
        "Port=3050;" +
        "Dialect=3;" +
        "Charset=NONE;" +
        "Role=;" +
        "Connection lifetime=15;" +
        "Pooling=true;" +
        "Packet Size=8192;" +
        "ServerType=0";

        protected readonly string ConnectionString;
        FbTransaction _transacao;
        FbConnection _conexao;

        //public RepositoryBase()
        //{
        //    ConnectionString = connection;
        //}

        public RepositoryBase(FbConnection conexao, FbTransaction transaction)
        {
            ConnectionString = connection;
            _conexao = conexao;
            _transacao = transaction;
        }

        public virtual bool Delete(int id)
        {
            using (var db = new FbConnection(ConnectionString))
            {
                var entity = GetById(id);

                if (entity == null) throw new Exception("Registro não encontrado");

                return db.Delete(entity);
            }
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            using (var db = new FbConnection(ConnectionString))
            {
                return db.GetAll<TEntity>();
            }
        }

        public TEntity GetById(int id)
        {
            using (var db = new FbConnection(ConnectionString))
            {
                return db.Get<TEntity>(id);
            }
        }

        public IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> predicate)
        {
            using (var db = new FbConnection(ConnectionString))
            {
                return db.Select(predicate);
            }
        }

        public void Insert(ref TEntity entity)
        {
            using (var db = new FbConnection(ConnectionString))
            {
                var id = db.Insert(entity);

                entity = GetById((int)id);
            }
        }

        //public bool Update(TEntity entity)
        //{
            
        //    var db = new FbConnection(ConnectionString);
        //    FbTransaction trans;

        //    db.Open();

        //    trans = db.BeginTransaction();

        //    bool ok = db.Update(entity, trans);

        //    //Convert.ToInt32("abcd");

        //    trans.Commit();
        //    db.Close();
        //    return ok;
        //}

        public bool Update(TEntity entity)
        {
            //_conexao.Open();
            //_transacao = _conexao.BeginTransaction();
            bool ok = _conexao.Update(entity, _transacao);
            //_transacao.Commit();
            //_conexao.Close();
            return ok;

            //var db = new FbConnection(ConnectionString);
            //FbTransaction trans;

            //db.Open();

            //trans = db.BeginTransaction();

            //bool ok = db.Update(entity, trans);

            //Convert.ToInt32("abcd");

            //trans.Commit();
            //return ok;
        }
    }
}
