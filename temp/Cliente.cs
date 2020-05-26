using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflaction.ConsoleApp
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public DateTime? DataNasc { get; set; }
        public decimal Preco { get; set; }
        public int? CidadeId { get; set; }
    }
}
