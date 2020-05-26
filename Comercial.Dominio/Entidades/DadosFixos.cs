using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class DadosFixos
    {
        public int IdUsuario { get; set; }
        public List<Permissao> Permissoes { get; set; }
        public int IdEmpresa { get; set; }
        public string NomeEmpresa { get; set; }
        public string NomeUsuario { get; set; }
    }
}
