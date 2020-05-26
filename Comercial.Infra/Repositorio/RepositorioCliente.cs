using Comercial.Dominio.Entidades;
using Comercial.Dominio.Geral;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Infra.DataBase;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Comercial.Infra.Repositorio
{
    public class RepositorioCliente : RepositoryBase<Cliente>, IRepositorioCliente, IRepositorioClienteConsulta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        private IRepositorioFormaPagto _repositorioFormaPagto;
        private IRepositorioVendedor _repositorioVendedor;
        private IRepositorioCidade _repositorioCidade;
        public RepositorioCliente(IDbConnection conexao, IDbTransaction transaction,
            IRepositorioCidade repositorioCidade,
            IRepositorioVendedor repositorioVendedor,
            IRepositorioFormaPagto repositorioFormaPagto) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
            _repositorioCidade = repositorioCidade;
            _repositorioFormaPagto = repositorioFormaPagto;
            _repositorioVendedor = repositorioVendedor;
        }
        public override void Insert(ref Cliente entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new Cliente(), "CLIENTE", "COD_CLIENTE");

            entity.Cod_Cliente = _conexao.Query<int>(base.SequencialFB("gen_cliente"), null, _transaction).First();
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        public IEnumerable<ClienteConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            string sql = "SELECT COD_CLIENTE, NOME, CNPJ, CPF, EMAIL, FONE FROM CLIENTE";
            if (id == 0)
            {
                sql += " WHERE COD_EMPRESA = " + codEmpresa;
                sql += " AND " + campo + " CONTAINING(" + Funcao.QuotedStr(valor) + ")";
                sql += " ORDER BY " + campo;
            }
            else
            {
                sql += " WHERE COD_CLIENTE = " + id;
            }

            return _conexao.Query<ClienteConsulta>(sql);
        }

        public IEnumerable<ClienteUltimosPedidos> UltimosPedidos(int idCliente)
        {
            var sb = new StringBuilder();
            sb.AppendLine("SELECT");
            sb.AppendLine(" PED.NUM_PEDIDO as NUMPEDIDO,");
            sb.AppendLine("PED.DATA,");
            sb.AppendLine("PRO.DESC_PRODUTO AS NOMEPRODUTO,");
            sb.AppendLine("UNI.SIGLA AS UNIDADE,");
            sb.AppendLine("ITE.QTDE AS QUANTIDADE,");
            sb.AppendLine("ITE.VALOR AS VALORPEDIDO,");
            sb.AppendLine("ITE.PRECO_VENDA AS VALORVENDA");
            sb.AppendLine("from PEDIDO PED");
            sb.AppendLine("left join CLIENTE CLI on PED.COD_CLIENTE = CLI.COD_CLIENTE");
            sb.AppendLine("left join ITENS_PEDIDO ITE on PED.NUM_PEDIDO = ITE.NUM_PEDIDO");
            sb.AppendLine("left join PRODUTO PRO on ITE.COD_PRODUTO = PRO.COD_PRODUTO");
            sb.AppendLine("left join UNIDADE UNI on ITE.ID_UNIDADE = UNI.ID_UNIDADE");
            sb.AppendLine("where PED.COD_CLIENTE = " + idCliente);
            sb.AppendLine("order by PED.NUM_PEDIDO desc");

            return _conexao.Query<ClienteUltimosPedidos>(sb.ToString());
        }

        public override Cliente GetById(int id)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Select(new Cliente(), "CLIENTE");
            instrucaoSQL += " WHERE COD_CLIENTE = " + id;

            var model = _conexao.Query<Cliente>(instrucaoSQL, null, _transaction).FirstOrDefault();

            if (model != null)
            {
                if (model.Cod_Pagto != null)
                    model.FormaPagto = _repositorioFormaPagto.GetById(model.Cod_Pagto.Value);

                if (model.Cod_Cidade != null)
                    model.Cidade = _repositorioCidade.GetById(model.Cod_Cidade.Value);

                if (model.Cod_Vendedor != null)
                    model.Vendedor = _repositorioVendedor.GetById(model.Cod_Vendedor.Value);
            }
            return model;
        }
    }
}
