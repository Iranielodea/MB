using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class FornecedorTipoEmpresa : EntidadeBase
    {
        public int Id_Tipo { get; set; }
        public int Cod_Empresa { get; set; }
        public string Sigla { get; set; }
        public string Desc_Tipo { get; set; }
    }

    public class FornecedorTipoEmpresaConsulta
    {
        public int Id_Tipo { get; set; }
        public string Sigla { get; set; }
        public string Desc_Tipo { get; set; }
    }
}
