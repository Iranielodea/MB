using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Enumeradores
{
    public class Enumerador 
    {
        public enum AcaoUsuario
        {
            Incluir = 1,
            Alterar = 2,
            Excluir = 3,
            Consultar = 4
        }

        public enum EnContato
        {
            Cliente,
            Fornecedor
        }

        public enum TipoContaFinanceiro
        {
            tpPedido=1,
            tpCarga=2
        }

        public enum TipoPesquisaGeral
        {
            pgId=1,
            pgDescricao=2,
            pgTela=3,
            pgNenhum = 4
        }

        public enum TipoVinculo
        {
            Novo,
            Editar,
            Salvar
        }

        public enum TipoFinanceiro
        {
            tfPedido = 1,
            tfReceber = 2,
            tfPagar = 3
        }
    }
}
