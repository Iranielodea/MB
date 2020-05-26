using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class CondicaoItem : EntidadeBase
    {
        public int Seq { get; set; }
        public int Cod_Condicao { get; set; }
        public int Cod_Empresa { get; set; }
        public int Dias { get; set; }
        public string Sequencia { get; set; }

        public virtual Condicao Condicao { get; set; }
    }
}
