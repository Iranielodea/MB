using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class ObservacaoConta
    {
        public int Id_Obs { get; set; }
        public int Cod_Empresa { get; set; }
        public int Id_Conta { get; set; }
        public string Texto { get; set; }

        public virtual Conta Conta { get; set; }
    }
}
