using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class Agenciador : PessoaBase
    {
        public int Cod_Agencia { get; set; }
        public string Fone1 { get; set; }
        public string Fone2 { get; set; }
        public string Email { get; set; }
        public string CNPJ { get; set; }
        public string Insc_Estadual { get; set; }
        public string Conta_Banco { get; set; }
        public string Agencia { get; set; }
        public string Nome_Banco { get; set; }
        public decimal Perc_Comissao { get; set; }
        public string Obs { get; set; }

        public virtual Cidade Cidade { get; set; }
    }
}
