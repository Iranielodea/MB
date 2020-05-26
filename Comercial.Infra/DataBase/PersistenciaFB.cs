using System;

namespace Comercial.Infra.DataBase
{
    public class PersistenciaFB : Persistencia
    {
        public override string Inserir(object obj, string tabela, string campoId)
        {
            string InstrucaoSQL = "INSERT INTO " + tabela + "(";
            string campos = "";
            string valores = "";

            foreach (var prop in obj.GetType().GetProperties())
            {
                if (prop.GetMethod.IsVirtual)
                    continue;

                if (prop.Name.ToUpper() == campoId.ToUpper())
                    continue;

                var valor = prop.GetValue(obj);
                string preco = "";

                campos += prop.Name + ",";

                if (prop.PropertyType == typeof(DateTime?) || prop.PropertyType == typeof(DateTime))
                {
                    if (valor == null)
                        valor = "NULL";
                    else
                        valor = "'" + FormatarData((DateTime)valor) + "'";
                }

                if (prop.PropertyType == typeof(int?) || prop.PropertyType == typeof(int))
                {
                    if (valor == null)
                        valor = "NULL";
                }

                if (prop.PropertyType == typeof(string))
                    valor = "'" + valor + "'";


                if (prop.PropertyType == typeof(decimal))
                {
                    preco = Convert.ToString(valor);
                    valor = preco.Replace(",", ".");
                }

                valores += valor + ",";
            }
            campos = campos.Remove(campos.Length - 1, 1);
            valores = valores.Remove(valores.Length - 1, 1);
            InstrucaoSQL += campos + ") VALUES (";
            InstrucaoSQL += valores + ") RETURNING " + campoId;

            return InstrucaoSQL;
        }

        public override string Update(object obj, string tabela, string campoId, int valorId)
        {
            string InstrucaoSQL = "";
            string campos = "";

            foreach (var prop in obj.GetType().GetProperties())
            {
                if (prop.GetMethod.IsVirtual)
                    continue;

                var valor = prop.GetValue(obj);
                string preco = "";

                campos += prop.Name + ",";

                if (prop.Name.ToUpper() == campoId.ToUpper())
                    continue;

                if (prop.PropertyType == typeof(DateTime?) || prop.PropertyType == typeof(DateTime))
                {
                    if (valor == null)
                        valor = "NULL";
                    else
                        valor = "'" + FormatarData((DateTime)valor) + "'";
                }

                if (prop.PropertyType == typeof(int?) || prop.PropertyType == typeof(int))
                {
                    if (valor == null)
                        valor = "NULL";
                }

                if (prop.PropertyType == typeof(string))
                    valor = "'" + valor + "'";


                if (prop.PropertyType == typeof(decimal))
                {
                    preco = Convert.ToString(valor);
                    valor = preco.Replace(",", ".");
                }

                InstrucaoSQL += prop.Name + "=" + valor + ", ";
            }
            InstrucaoSQL = "UPDATE " + tabela + " SET " + InstrucaoSQL;
            InstrucaoSQL = InstrucaoSQL.Remove(InstrucaoSQL.Length - 2, 2);
            InstrucaoSQL += " WHERE " + campoId + " = '" + valorId + "'";

            return InstrucaoSQL;
        }
    }
}
