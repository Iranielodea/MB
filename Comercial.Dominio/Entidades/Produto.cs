using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comercial.Dominio.Entidades
{
    public class Produto : EntidadeBase
    {
        public int Cod_Produto { get; set; }
        public int Cod_Empresa { get; set; }
        public int Id_Unidade { get; set; }
        public int? Cod_Grupo { get; set; }
        public string Desc_Produto { get; set; }
        public decimal Valor_Venda { get; set; }
        public string Referencia { get; set; }

        public virtual Unidade Unidade { get; set; }
        public virtual Grupo Grupo { get; set; }
    }

    public class ProdutoConsulta
    {
        public int Cod_Produto { get; set; }
        public string Sigla { get; set; }
        public string Desc_Produto { get; set; }
        public decimal Valor_Venda { get; set; }
    }
}
