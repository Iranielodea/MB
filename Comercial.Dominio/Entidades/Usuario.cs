using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comercial.Dominio.Entidades
{
    public class Usuario : EntidadeBase
    {
        public int Id_Usuario { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public int Cod_Empresa { get; set; }
        public string Gerente { get; set; }
    }

    public class UsuarioConsulta
    {
        public int Id_Usuario { get; set; }
        public string Nome { get; set; }
    }
}
