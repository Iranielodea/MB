using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class PessoaBase : EntidadeBase
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public int? Cod_Cidade { get; set; }
        public string CEP { get; set; }
        public int Cod_Empresa { get; set; }
    }
}
