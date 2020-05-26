using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class Transportadora : PessoaBase
    {
        public int Cod_Trans { get; set; }
        public string CNPJ { get; set; }
        public string Insc_Estadual { get; set; }
        public string Fone1 { get; set; }
        public string Fone2 { get; set; }
        public string Contato { get; set; }
        public int? Cod_Agencia { get; set; }
        public string DDD { get; set; }
        public string Destaque { get; set; }
        public string Fax { get; set; }
        public DateTime? DataNasc { get; set; }
        public string Obs { get; set; }
        public string Num_Banco { get; set; }
        public string Nome_Banco { get; set; }
        public string Num_Agencia { get; set; }
        public string Num_Conta { get; set; }
        public string Nome_Titular { get; set; }
        public string CPF { get; set; }
        public string Nome_Despositante { get; set; }
        public string Email { get; set; }
        public string CPF_Transp { get; set; }
        public string ANTT { get; set; }
        public string RENAVAN { get; set; }

        public virtual Cidade Cidade { get; set; }
        public virtual Agenciador Agenciador { get; set; }
    }

    public class TransportadoraConsulta
    {
        public int Cod_Trans { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string CPF_TRANSP { get; set; }
        public string Insc_Estadual { get; set; }
        public string Fone1 { get; set; }
    }
}
