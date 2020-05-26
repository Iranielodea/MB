using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comercial.UI.Objetos
{
    public partial class ucData : UserControl
    {
        public ucData()
        {
            InitializeComponent();
        }

        private void txtData_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtData.Text.Trim() != "/  /")
                {
                    DateTime data = Convert.ToDateTime(txtData.Text);
                    txtData.Text = data.ToString("dd/MM/yyyy");
                }
            }
            catch
            {
               MessageBox.Show("Data inválida!");
                txtData.Focus();
            }
        }

        private void txtData_Enter(object sender, EventArgs e)
        {
            //txtData.Focus();
            //txtData.SelectAll();
        }
    }
}
