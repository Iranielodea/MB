using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAPPER.Dominio;
using DAPPER.Dominio.Repository;
using FirebirdSql.Data.FirebirdClient;

namespace DAPPER.Cross
{
    public class UnitOfWork : IDisposable
    {
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
        private bool _inTransacao;

        public UnitOfWork()
        {
            ConnectionString = connection;
            _conexao = new FbConnection(connection);
            _inTransacao = false;
        }

        public void BeginTransaction()
        {
            _conexao.Open();
            _transacao = _conexao.BeginTransaction();
            _inTransacao = true;
        }

        public void Commit()
        {
            _transacao.Commit();
            _inTransacao = true;
        }

        public void RollBack()
        {
            _transacao.Rollback();
            _inTransacao = true;
        }

        public void Dispose()
        {
            _conexao.Dispose();
            if (_inTransacao)
                _transacao.Dispose();
        }

        public BancoRepositorio BancoRepositorio { get { return new BancoRepositorio(_conexao, _transacao); } }
    }
}
