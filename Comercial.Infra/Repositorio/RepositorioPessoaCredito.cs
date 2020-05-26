using Comercial.Dominio.Entidades;
using Comercial.Dominio.Geral;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Infra.DataBase;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Comercial.Infra.Repositorio
{
    public class RepositorioPessoaCredito : RepositoryBase<PessoaCredito>, IRepositorioPessoaCredito
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        public RepositorioPessoaCredito(IDbConnection conexao, IDbTransaction transaction) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
        }

        public void Atualizar(PessoaCredito entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
           // string instrucaoSQL = Dados.Update(new PessoaCredito(), "PESSOA_CREDITO", "COD_CLIENTE", entity.Cod_Cliente);
            string instrucaoSQL = @"UPDATE PESSOA_CREDITO SET DATA_CREDITO=@DATA_CREDITO,
                QTDE_CREDITO = @QTDE_CREDITO, QTDE_USADO = @QTDE_USADO
                WHERE COD_CLIENTE = @COD_CLIENTE";
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        public override void Insert(ref PessoaCredito entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            //string instrucaoSQL = Dados.Inserir(new PessoaCredito(), "PESSOA_CREDITO", "COD_CLIENTE");
            string instrucaoSQL = @"INSERT INTO PESSOA_CREDITO(COD_CLIENTE, DATA_CREDITO,
                QTDE_CREDITO, QTDE_USADO) VALUES (@COD_CLIENTE, @DATA_CREDITO, @QTDE_CREDITO, @QTDE_USADO)";
               
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        public PessoaCredito ObterPorCodigo(int codigo)
        {
            string sql = Geral.InstrucaoSQL.MontarSelect(new PessoaCredito(), "PESSOA_CREDITO",
                "WHERE COD_CLIENTE = " + codigo);

            return _conexao.Query<PessoaCredito>(sql, null, _transaction).FirstOrDefault();
        }
    }
}
