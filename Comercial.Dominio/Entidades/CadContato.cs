using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class CadContato : EntidadeBase
    {
        public int Seq { get; set; }
        public int Cod_Empresa { get; set; }
        public string Fone { get; set; }
        public string Fax { get; set; }
        public string Contato { get; set; }
        public string Email { get; set; }
        public int Codigo { get; set; }
        public string Tipo { get; set; }
        public DateTime? DataNasc { get; set; }
    }
}
