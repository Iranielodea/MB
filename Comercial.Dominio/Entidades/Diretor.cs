using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class Diretor
    {
        public int Id_Diretor { get; set; }
        public int Cod_Empresa { get; set; }
        public int Cod_Cliente { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Fone { get; set; }
        public string Endereco { get; set; }
        public DateTime? DataNasc { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}
