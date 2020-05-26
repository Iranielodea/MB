using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Comercial.UI.Objetos
{
    public partial class ucValor : UserControl
    {
        public enum Casas
        {
            Inteira,
            Duas,
            Tres,
            Quatro
        }

        [DefaultValue(typeof(Casas), "CasasDecimais"),
            Description("Tipo Casas Decimais"),
            Category("Casas Decimais")]
        public Casas CasasDecimais { get; set; }

        public ucValor()
        {
            InitializeComponent();

            ValorComCasas();
            //txtValor.Text = "0";
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            ValorComCasas();
        }

        private void ValorComCasas()
        {
            try
            {
                decimal valor = Convert.ToDecimal(txtValor.Text);
                if (CasasDecimais == Casas.Inteira)
                    txtValor.Text = valor.ToString("N0");
                else if (CasasDecimais == Casas.Duas)
                    txtValor.Text = valor.ToString("N2");
                else if (CasasDecimais == Casas.Tres)
                    txtValor.Text = valor.ToString("N3");
                else if (CasasDecimais == Casas.Quatro)
                    txtValor.Text = valor.ToString("N4");
            }
            catch
            {
                if (CasasDecimais == Casas.Inteira)
                    txtValor.Text = "0";
                else if (CasasDecimais == Casas.Duas)
                    txtValor.Text = "0,00";
                else if (CasasDecimais == Casas.Tres)
                    txtValor.Text = "0,000";
                else if (CasasDecimais == Casas.Quatro)
                    txtValor.Text = "0,0000";
            }
        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            //txtValor.TextAlign = HorizontalAlignment.Left;
            txtValor.SelectAll();            
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CasasDecimais == Casas.Inteira)
                RetornoSoNumero(e);
            else
                RetornoSoNumero(e, true);
        }

        private void RetornoSoNumero(KeyPressEventArgs e, bool EhDecimal = false)
        {
            if (EhDecimal)
            {
                    if (!char.IsDigit(e.KeyChar) && e.KeyChar != 44 && e.KeyChar != 8)
                    {
                    e.Handled = true;
                }

                string letra = txtValor.Text;

                if (letra.IndexOf(",") > 0 && e.KeyChar == 44)
                    e.Handled = true;
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
