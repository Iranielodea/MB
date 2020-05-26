using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class EnderecoEntrega
    {
        public int Cod_Cliente { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public int? Cod_Cidade { get; set; }
        public string CEP { get; set; }

        public virtual Cidade Cidade { get; set; }
    }
}
