using DAPPER.Dominio.Entidades;
using FirebirdSql.Data.FirebirdClient;

namespace DAPPER.Dominio.Repository
{
    public class BancoRepositorio : RepositoryBase<Banco>
    {
        //private readonly FbConnection _conexao;
        //private readonly FbTransaction _transaction;

        public BancoRepositorio(FbConnection conexao, FbTransaction transaction) : base(conexao, transaction)
        {
            //_conexao = conexao;
            //_transaction = transaction;
        }
    }
}
