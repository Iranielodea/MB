using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class ReferenciaComercial
    {
        public int Id_Comercio { get; set; }
        public int Cod_Empresa { get; set; }
        public int Cod_Cliente { get; set; }
        public string Nome_Fornecedor { get; set; }
        public string Fone { get; set; }
        public string CNPJ { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
