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
    public class RepositorioCidade : RepositoryBase<Cidade>, IRepositorioCidade, IRepositorioCidadeConsulta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        private IRepositorioEstado _repositorioEstado;
        public RepositorioCidade(IDbConnection conexao, IDbTransaction transaction,
            IRepositorioEstado repositorioEstado) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
            _repositorioEstado = repositorioEstado;
        }

        public override void Insert(ref Cidade entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new Cidade(), "CIDADE", "COD_CIDADE");

            entity.Cod_Cidade = _conexao.Query<int>(base.SequencialFB("gen_cidade"), null, _transaction).First();
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        public IEnumerable<CidadeConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            string sql = "SELECT COD_CIDADE, DESC_CIDADE, SIGLA FROM CIDADE LEFT JOIN ESTADO ON CIDADE.ID_ESTADO = ESTADO.ID_ESTADO";
            if (id == 0)
            {
                sql += " WHERE CIDADE.COD_EMPRESA = " + codEmpresa;
                sql += " AND " + campo + " CONTAINING(" + Funcao.QuotedStr(valor) + ")";
                sql += " ORDER BY " + campo;
            }
            else
            {
                sql += " WHERE COD_CIDADE = " + id;
            }

            return _conexao.Query<CidadeConsulta>(sql);
        }

        public override Cidade GetById(int id)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Select(new Cidade(), "CIDADE");
            instrucaoSQL += " WHERE COD_CIDADE = " + id;

            var model = _conexao.Query<Cidade>(instrucaoSQL, null, _transaction).FirstOrDefault();
            if (model != null)
                model.Estado = _repositorioEstado.GetById(model.Id_Estado);
            return model;
        }
    }
}
