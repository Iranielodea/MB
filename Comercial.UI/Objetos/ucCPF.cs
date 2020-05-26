using Comercial.Dominio.Geral;
using System;
using System.Windows.Forms;

namespace Comercial.UI.Objetos
{
    public partial class ucCPF : UserControl
    {
        public ucCPF()
        {
            InitializeComponent();
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (txtValor.TextLength > 0)
            {
                try
                {
                    if (!Validacao.ValidarCPF(txtValor.Text))
                        throw new Exception("CPF inválido!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    txtValor.Focus();
                }
            }
        }
    }
}
