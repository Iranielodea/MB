using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class Parametro
    {
        public int Par_Id { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
        public string Observacao { get; set; }
    }

    public class ParametroConsulta
    {
        public int Par_Id { get; set; }
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Valor { get; set; }
    }
}
