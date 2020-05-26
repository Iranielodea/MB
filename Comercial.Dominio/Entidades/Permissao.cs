using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class Permissao : EntidadeBase
    {
        public int Id_Per { get; set; }
        public string Tabela { get; set; }
        public string Nome { get; set; }
        public string Inc { get; set; }
        public string Alt { get; set; }
        public string Exc { get; set; }
        public string Con { get; set; }
        public int Cod_Empresa { get; set; }
    }

    public class PermissaoConsulta
    {
        public int Id_Per { get; set; }
        public string Tabela { get; set; }
        public string Inc { get; set; }
        public string Alt { get; set; }
        public string Exc { get; set; }
        public string Con { get; set; }
    }
}
