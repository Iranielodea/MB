using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class ContaBanco
    {
        public int Id_ContaBanco { get; set; }
        public int Cod_Empresa { get; set; }
        public string Num_Conta { get; set; }
        public string Agencia { get; set; }
        public string Banco { get; set; }
        public string Ativo { get; set; }
        public string CNPJ_CPF { get; set; }
    }

    public class ContaBancoConsulta
    {
        public int Id_ContaBanco { get; set; }
        public string Num_Conta { get; set; }
        public string Agencia { get; set; }
        public string Banco { get; set; }
    }
}
