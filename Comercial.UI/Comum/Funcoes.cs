using System;
using System.Windows.Forms;

namespace Comercial.UI.Comum
{
    public static class Funcoes
    {
        public static bool Confirmar(string mensagem)
        {
            return
                (MessageBox.Show(mensagem, "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes);
        }

        public static void Binding(ref TextBox objTexto, object datasource, string campo)
        {
            objTexto.DataBindings.Clear();
            objTexto.DataBindings.Add("Text", datasource, campo, true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public static void BindingMask(ref MaskedTextBox objTexto, object datasource, string campo)
        {
            objTexto.DataBindings.Clear();
            objTexto.DataBindings.Add("Text", datasource, campo, true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public static string FormatStrDecimal(string mascara, string valor)
        {
            try
            {
                return decimal.Parse(valor).ToString(mascara);
            }
            catch
            {
                return decimal.Parse("0").ToString(mascara);
            }
        }

        public static void AbrirTela(Form formulario)
        {
            formulario.Show();
        }

        public static string StrtoStr(string value)
        {
            try
            {
                int valor = Convert.ToInt32(value);
                if (valor > 0)
                    return value;
                else
                    return "";
            }
            catch
            {
                return "";
            }
        }

        public static int StrToInt(string value)
        {
            try
            {
                return Convert.ToInt32(value);
            }
            catch
            {
                return 0;
            }
        }

        public static string StrToStrNull(string value)
        {
            try
            {
                return Convert.ToInt32(value).ToString();
            }
            catch
            {
                return "";
            }
        }

        public static int? StrToIntNull(string value)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(value))
                    return null;
                else
                    return Convert.ToInt32(value);
            }
            catch
            {
                return null;
            }
        }

        public static string DateNullToStr(DateTime? data)
        {
            return data.ToString();
        }

        public static DateTime? StrToDateNull(string data)
        {
            try
            {
                if (data.Trim() == "/  /")
                    return null;
                else
                    return Convert.ToDateTime(data);
            }
            catch
            {
                return null;
            }
        }

        public static string StrToNullStr(int? value)
        {
            try
            {
                Convert.ToInt32(value.Value);
                return value.Value.ToString();
            }
            catch
            {
                return "";
            }
        }

        public static void LimparTela(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
                if (c is MaskedTextBox)
                    c.Text = "";
            }
        }

        public static decimal StrToDecimal(string valor)
        {
            try
            {
                return Convert.ToDecimal(valor);
            }
            catch
            {
                return 0;
            }
        }

        public static bool DataEmBranco(string data)
        {
            return Dominio.Geral.Funcao.DataEmBranco(data);
        }
    }
}
