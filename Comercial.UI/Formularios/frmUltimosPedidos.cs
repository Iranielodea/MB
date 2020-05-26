using Comercial.Dominio.Interfaces;
using Comercial.UI.Comum;
using StructureMap;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Comercial.UI.Formularios
{
    public partial class frmUltimosPedidos : Form
    {
        public frmUltimosPedidos()
        {
            InitializeComponent();
        }

        public frmUltimosPedidos(int idCliente)
        {
            InitializeComponent();

            using (var unitOfWork = ObjectFactory.GetInstance<IUnitOfWork>())
            {
                Grade.Configurar(ref dgvDados);

                var Lista = unitOfWork.ServicoCliente.UltimosPedidos(idCliente);
                dgvDados.DataSource = Lista;
                txtQtde.Text = Lista.Sum(x => x.Quantidade).ToString("N0");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmUltimosPedidos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }
    }
}
