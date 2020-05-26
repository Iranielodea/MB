using Comercial.Infra.DataBase;
using System.Text;

namespace Comercial.Infra.Geral
{
    public class InstrucaoSQL
    {
        public static string MontarSelect(object obj, string tabela, string condicao)
        {
            var persiste = new PersistenciaFB();
            var sb = new StringBuilder();
            sb.AppendLine(persiste.Select(obj, tabela));
            sb.AppendLine(" " + condicao);
            return sb.ToString();
        }
    }
}
