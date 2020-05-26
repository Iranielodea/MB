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
    public class RepositorioMotorista : RepositoryBase<Motorista>, IRepositorioMotorista, IRepositorioMotoristaConsulta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        private IRepositorioTransportadora _repositorioTransportadora;
        private IRepositorioCidade _repositorioCidade;

        public RepositorioMotorista(IDbConnection conexao, IDbTransaction transaction,
            IRepositorioCidade repositorioCidade,
            IRepositorioTransportadora repositorioTransportadora) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
            _repositorioCidade = repositorioCidade;
            _repositorioTransportadora = repositorioTransportadora;
        }
        public override void Insert(ref Motorista entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new Motorista(), "MOTORISTA", "COD_MOTORISTA");

            entity.Cod_Motorista = _conexao.Query<int>(base.SequencialFB("gen_motorista"), null, _transaction).First();
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        public IEnumerable<MotoristaConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            string sql = "SELECT COD_MOTORISTA, NOME, CPF FROM MOTORISTA";
            if (id == 0)
            {
                sql += " WHERE COD_EMPRESA = " + codEmpresa;
                sql += " AND " + campo + " CONTAINING(" + Funcao.QuotedStr(valor) + ")";
                sql += " ORDER BY " + campo;
            }
            else
            {
                sql += " WHERE COD_MOTORISTA = " + id;
            }

            return _conexao.Query<MotoristaConsulta>(sql);
        }

        public override Motorista GetById(int id)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Select(new Motorista(), "MOTORISTA");
            instrucaoSQL += " WHERE COD_MOTORISTA = " + id;

            var model = _conexao.Query<Motorista>(instrucaoSQL, null, _transaction).FirstOrDefault();
            if (model != null)
            {
                if (model.Cod_Cidade != null)
                    model.Cidade = _repositorioCidade.GetById(model.Cod_Cidade.Value);

                if (model.Cod_Trans != null)
                    model.Transportadora = _repositorioTransportadora.GetById(model.Cod_Trans.Value);
            }
            return model;
        }
    }
}
