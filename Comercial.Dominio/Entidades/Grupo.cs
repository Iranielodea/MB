using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class Grupo : EntidadeBase
    {
        public int Cod_Grupo { get; set; }
        public int Cod_Empresa { get; set; }
        public string Desc_Grupo { get; set; }
    }

    public class GrupoConsulta
    {
        public int Cod_Grupo { get; set; }
        public string Desc_Grupo { get; set; }
    }
}
