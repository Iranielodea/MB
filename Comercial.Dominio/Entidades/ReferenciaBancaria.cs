using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class ReferenciaBancaria
    {
        public int Id_Banco { get; set; }
        public int Cod_Empresa { get; set; }
        public int Cod_Cliente { get; set; }
        public string Nome_Banco { get; set; }
        public string Fone { get; set; }
        public string Nome_Agencia { get; set; }
        public string Numero { get; set; }
        public string Num_Conta { get; set; }
        public string Tipo_Pessoa { get; set; }

        public virtual ContaBanco ContaBanco { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
