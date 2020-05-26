using Comercial.Dominio.Entidades;
using Comercial.Dominio.Enumeradores;
using Comercial.Dominio.Geral;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Infra.DataBase;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Comercial.Infra.Repositorio
{
    public class RepositorioPermissao : RepositoryBase<Permissao>, IRepositorioPermissao, IRepositorioPermissaoConsulta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        public RepositorioPermissao(IDbConnection conexao, IDbTransaction transaction) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
        }
        public override void Insert(ref Permissao entity)
        {
            var Dados = new PersistenciaFactory().Instanciar();
            string instrucaoSQL = Dados.Inserir(new Permissao(), "PERMISSAO", "ID_PER");

            entity.Id_Per = _conexao.Query<int>(base.SequencialFB("gen_permissao"), null, _transaction).First();
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        public IEnumerable<PermissaoConsulta> Filtrar(string campo, string valor, int codEmpresa, int id = 0)
        {
            string sql = "SELECT ID_PER, TABELA, INC, ALT, EXC, CON FROM PERMISSAO";
            if (id == 0)
            {
                sql += " WHERE COD_EMPRESA = " + codEmpresa;
                sql += " AND " + campo + " CONTAINING(" + Funcao.QuotedStr(valor) + ")";
                sql += " ORDER BY " + campo;
            }
            else
            {
                sql += " WHERE ID_PER = " + id;
            }

            return _conexao.Query<PermissaoConsulta>(sql);
        }

        public Permissao Permitir(string tabela, string nomeUsuario, Enumerador.AcaoUsuario acao = Enumerador.AcaoUsuario.Consultar)
        {
            string sql = Geral.InstrucaoSQL.MontarSelect(new Permissao(), "PERMISSAO", 
                "WHERE TABELA = " + Funcao.QuotedStr(tabela) + " AND NOME = " + Funcao.QuotedStr( nomeUsuario ));

            return _conexao.Query<Permissao>(sql,null, _transaction).FirstOrDefault();
        }
    }
}
