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
    public class RepositorioTransportadora : RepositoryBase<Transportadora>, IRepositorioTransportadora, IRepositorioTransportadoraConsulta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        private IRepositorioCidade _repositorioCidade;
        public RepositorioTransportadora(IDbConnection conexao, IDbTransaction transaction,
            IRepositorioCidade repositorioCidade) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
            _repositorioCidade = repositorioCidade;
        }
        public override void Insert(ref Transportadora entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new Transportadora(), "TRANSPORTADOR", "COD_TRANS");

            entity.Cod_Trans = _conexao.Query<int>(base.SequencialFB("gen_transportador"), null, _transaction).First();
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        public IEnumerable<TransportadoraConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            string sql = "SELECT COD_TRANS, NOME, CNPJ, CPF_TRANSP, INSC_ESTADUAL FROM TRANSPORTADOR";
            if (id == 0)
            {
                sql += " WHERE COD_EMPRESA = " + codEmpresa;
                sql += " AND " + campo + " CONTAINING(" + Funcao.QuotedStr(valor) + ")";
                sql += " ORDER BY " + campo;
            }
            else
            {
                sql += " WHERE COD_TRANS = " + id;
            }

            return _conexao.Query<TransportadoraConsulta>(sql);
        }

        public override Transportadora GetById(int id)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Select(new Transportadora(), "TRANSPORTADOR");
            instrucaoSQL += " WHERE COD_TRANS = " + id;

            var model = _conexao.Query<Transportadora>(instrucaoSQL, null, _transaction).FirstOrDefault();
            if (model != null)
            {
                if (model.Cod_Cidade != null)
                    model.Cidade = _repositorioCidade.GetById(model.Cod_Cidade.Value);
            }
            return model;
        }
    }
}
