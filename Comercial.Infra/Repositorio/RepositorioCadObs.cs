using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Infra.DataBase;
using Dapper;
using System.Data;

namespace Comercial.Infra.Repositorio
{
    public class RepositorioCadObs : RepositoryBase<CadObs>, IRepositorioCadObs
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;

        public RepositorioCadObs(IDbConnection conexao, IDbTransaction transaction) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
        }

        public override void Insert(ref CadObs entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new CadObs(), "CAD_OBS", "CODIGO");

            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        public override bool Update(CadObs entity)
        {
            string instrucaoSQL = @"UPDATE CAD_OBS SET TEXTO = @TEXTO WHERE CODEMPRESA = @CODEMPRESA " +
                "AND CODIGO = @CODIGO AND TIPO = @TIPO AND NUM_LINHA = @NUM_LINHA";

            return _conexao.Execute(instrucaoSQL, entity, _transaction) > 0;
        }
    }
}
