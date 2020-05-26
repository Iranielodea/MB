using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Comercial.Dominio.Entidades
{
    public class Empresa : EntidadeBase
    {
        public int Cod_Empresa { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Numero { get; set; }
        public string Desc_Cidade { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Fone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string CNPJ { get; set; }
        public string Insc_Estadual { get; set; }
        public string Versao { get; set; }
    }

    public class EmpresaConsulta
    {
        public int Cod_Empresa { get; set; }
        public string Nome { get; set; }
    }
}
