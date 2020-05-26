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
    public class RepositorioContato : RepositoryBase<Contato>, IRepositorioContato, IRepositorioContatoConsulta
    {
        private IDbConnection _conexao;
        private IDbTransaction _transaction;
        public RepositorioContato(IDbConnection conexao, IDbTransaction transaction) : base(conexao, transaction)
        {
            _conexao = conexao;
            _transaction = transaction;
        }
        public override void Insert(ref Contato entity)
        {
            string instrucaoSQL;
            instrucaoSQL = "INSERT INTO CONTATO(SEQ, COD_EMPRESA, FONE, FAX, CONTATO, EMAIL, USU_INC, USU_ALT, CODIGO, TIPO, DATANASC)";
            instrucaoSQL += " VALUES(";
            instrucaoSQL += " @SEQ, @COD_EMPRESA, @FONE, @FAX, @CONTATOTEXTO, @EMAIL, @USU_INC, @USU_ALT, @CODIGO, @TIPO, @DATANASC)";

            Enumerador.EnContato tpContato;
            if (entity.Tipo == "C")
                tpContato = Enumerador.EnContato.Cliente;
            else
                tpContato = Enumerador.EnContato.Fornecedor;

            entity.Seq = ProxigoSeq(entity.Cod_Empresa, entity.Codigo, tpContato);
            _conexao.Execute(instrucaoSQL, entity, _transaction);
        }

        public override bool Update(Contato entity)
        {
            string instrucaoSQL = "";
            instrucaoSQL += "UPDATE CONTATO SET ";
            instrucaoSQL += " FONE = @FONE, FAX = @FAX, CONTATO = @CONTATOTEXTO, EMAIL = @EMAIL, ";
            instrucaoSQL += " USU_INC = @USU_INC, USU_ALT = @USU_ALT, CODIGO = @CODIGO, TIPO = @TIPO, DATANASC = @DATANASC";
            instrucaoSQL += " WHERE COD_EMPRESA = @COD_EMPRESA AND CODIGO = @CODIGO AND TIPO = @TIPO AND SEQ = @SEQ";

            int id = _conexao.Execute(instrucaoSQL, entity, _transaction);
            return id > 0;
        }

        public IEnumerable<ContatoConsulta> Filtrar(string campo, string valor, int codEmpresa)
        {
            string sql = "SEQ, COD_EMPRESA, FONE, FAX, CONTATO AS CONTATOTEXTO, EMAIL, CODIGO, TIPO, EMAIL FROM CONTATO";
            sql += " WHERE COD_EMPRESA = " + codEmpresa;
            sql += " AND " + campo + " CONTAINING(" + Funcao.QuotedStr(valor) + ")";
            sql += " ORDER BY " + campo;

            return _conexao.Query<ContatoConsulta>(sql);
        }

        public IEnumerable<ContatoConsulta> BuscarDados(int codigo, int codEmpresa, Enumerador.EnContato tipoContato)
        {
            string sql = "SELECT SEQ, COD_EMPRESA, FONE, FAX, CONTATO AS CONTATOTEXTO, EMAIL, CODIGO, TIPO FROM CONTATO";
            sql += " WHERE COD_EMPRESA = " + codEmpresa;
            sql += " AND CODIGO = " + codigo;
            if (tipoContato == Enumerador.EnContato.Cliente)
                sql += " AND TIPO = " + Funcao.QuotedStr("C");
            else
                sql += " AND TIPO = " + Funcao.QuotedStr("F");

            return _conexao.Query<ContatoConsulta>(sql);
        }

        private int ProxigoSeq(int codEmpresa, int codigo, Enumerador.EnContato tipoContato)
        {
            string instrucaoSQL = "";
            instrucaoSQL += "SELECT COALESCE(MAX(SEQ),0) + 1 FROM CONTATO";
            instrucaoSQL += " WHERE COD_EMPRESA = " + codEmpresa;
            instrucaoSQL += " AND CODIGO = " + codigo;

            if (tipoContato == Enumerador.EnContato.Cliente)
                instrucaoSQL += " AND TIPO = " + Funcao.QuotedStr("C");
            else
                instrucaoSQL += " AND TIPO = " + Funcao.QuotedStr("F");

            int id = _conexao.Query<int>(instrucaoSQL, null, _transaction).First();

            if (id == 0)
                id = 1;

            return id;
        }

        public void Excluir(int codEmpresa, int codigo, int seq, string tipo)
        {
            string instrucaoSQL = "";
            instrucaoSQL += "DELETE FROM CONTATO ";
            instrucaoSQL += " WHERE COD_EMPRESA = " + codEmpresa;
            instrucaoSQL += " AND CODIGO = " + codigo;
            instrucaoSQL += " AND SEQ = " + seq;
            instrucaoSQL += " AND TIPO = '" + tipo + "'";

            int id = _conexao.Execute(instrucaoSQL, null, _transaction);
        }
    }
}
