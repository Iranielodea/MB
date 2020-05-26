using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class Motorista : PessoaBase
    {
        public int Cod_Motorista { get; set; }
        public string Fone1 { get; set; }
        public string Fone2 { get; set; }
        public int? Cod_Trans { get; set; }
        public string Placa { get; set; }
        public string CPF { get; set; }
        public string Estado_CPF { get; set; }
        public string Placa_Reboque1 { get; set; }
        public string Placa_Reboque2 { get; set; }
        public string Placa_Reboque3 { get; set; }
        public DateTime? DataNasc { get; set; }
        public string Obs { get; set; }
        public decimal Tonelagem { get; set; }
        public string CNH { get; set; }
        public string RENAVAN { get; set; }

        public virtual Transportadora Transportadora { get; set; }
        public virtual Cidade Cidade { get; set; }
    }

    public class MotoristaConsulta
    {
        public int Cod_Motorista { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
    }
}
