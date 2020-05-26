using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Comercial.Dominio.Geral;

namespace Comercial.UI.Objetos
{
    public partial class ucCNPJ : UserControl
    {
        public ucCNPJ()
        {
            InitializeComponent();
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            if (txtValor.Text.Length > 0)
            {
                try
                {
                    if (!Validacao.ValidarCnpj(txtValor.Text))
                        throw new Exception("CNPJ inválido!");
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
