using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class UnidadeTexto : EntidadeBase
    {
        public int Id { get; set; }
        public string Observacao { get; set; }
        public string Texto { get; set; }
    }

    public class UnidadeTextoConsulta
    {
        public int Id { get; set; }
        public string Observacao { get; set; }
    }
}
