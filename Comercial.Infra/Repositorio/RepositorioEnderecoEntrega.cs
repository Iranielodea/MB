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
    public class RepositorioEnderecoEntrega : RepositoryBase<EnderecoEntrega>, IRepositorioEnderecoEntrega
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        public RepositorioEnderecoEntrega(IDbConnection conexao, IDbTransaction transaction) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
        }
        public override void Insert(ref EnderecoEntrega entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new EnderecoEntrega(), "END_ENTREGA", "COD_CLIENTE");

            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }
    }
}
