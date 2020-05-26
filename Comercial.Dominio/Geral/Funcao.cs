using System.Text.RegularExpressions;

namespace Comercial.Dominio.Geral
{
    public static class Funcao
    {
        public static string QuotedStr(string valor)
        {
            return "'" + valor + "'";
        }

        public static string SomenteNumeros(string valor)
        {
            Regex r = new Regex(@"\d+");
            string result = "";
            foreach (Match m in r.Matches(valor))
                result += m.Value;
            return result;
        }

        public static bool DataEmBranco(string data)
        {
            if (data.Trim() == "/  /")
                return true;
            else
                return false;
        }
    }
}
