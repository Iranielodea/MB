using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces;
using Comercial.UI.Comum;
using StructureMap;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Comercial.UI.Formularios
{
    public partial class frmFormaPagto : BaseUI.Base.frmPadrao
    {
        private FormaPagto _formaPagto;
        private bool _pesquisa;
        private IUnitOfWork _unitOfWork;

        public frmFormaPagto()
        {
            _pesquisa = false;
            Iniciar("ABCDE");
        }

        public frmFormaPagto(string descricao)
        {
            _pesquisa = true;
            Iniciar(descricao);
        }

        private void Iniciar(string descricao)
        {
            InitializeComponent();

            tabControl1.TabPages.Remove(tpEditar);
            tabControl1.TabPages.Remove(tpFiltro);

            _unitOfWork = ObjectFactory.GetInstance<IUnitOfWork>();

            Grade.Configurar(ref dgvDados);
            cbCampos.DataSource = Grade.ListarCampos(ref dgvDados);
            cbCampos.SelectedIndex = 1;
            Carregar(descricao);

            btnSair.Left = btnFiltro.Left;
            btnFiltro.Visible = false;
        }

        private void Carregar(string valor)
        {
            string campos = cbCampos.Text;
            string campo = Grade.BuscarCampo(ref dgvDados, cbCampos.Text);
            dgvDados.DataSource = _unitOfWork.ServicoFormaPagto.Filtrar(campo, valor, DadosStaticos.IdEmpresa).ToList();
            cbCampos.Text = campos;
        }

        public override void Novo()
        {
            base.Novo();
            _formaPagto = new FormaPagto();
            VincularDados();
            txtDescricao.Focus();
        }

        public override void Editar()
        {
            if (dgvDados.RowCount > 0)
            {
                base.Editar();
                int id = Grade.RetornarId(ref dgvDados, "Codigo");
                _formaPagto = new FormaPagto();
                _formaPagto = _unitOfWork.ServicoFormaPagto.ObterPorId(id);
                VincularDados();
                txtDescricao.Focus();
            }
        }

        public override void Excluir()
        {
            if (dgvDados.RowCount > 0)
            {
                if (Funcoes.Confirmar("Confirmar Exclusão?"))
                {
                    try
                    {
                        base.Excluir();
                        var formaPagto = _unitOfWork.ServicoFormaPagto.ObterPorId(Grade.RetornarId(ref dgvDados, "Codigo"));
                        if (formaPagto != null)
                        {
                            _unitOfWork.ServicoFormaPagto.Excluir(formaPagto, DadosStaticos.NomeUsuario);
                            Carregar(txtTexto.Text);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public override void Salvar()
        {
            try
            {
                int id = 0;
                id = _unitOfWork.ServicoFormaPagto.Salvar(_formaPagto, DadosStaticos.NomeUsuario);
                dgvDados.DataSource = _unitOfWork.ServicoFormaPagto.Filtrar("", "", DadosStaticos.IdEmpresa, id);
                base.Salvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VincularDados()
        {
            Funcoes.Binding(ref txtCodigo, _formaPagto, "Cod_Pagto");
            Funcoes.Binding(ref txtDescricao, _formaPagto, "Desc_Pagto");
            Funcoes.Binding(ref txtSigla, _formaPagto, "Sigla");
            Funcoes.Binding(ref txtUsuarioAlterou, _formaPagto, "Usu_Alt");
            Funcoes.Binding(ref txtUsuarioCadastrou, _formaPagto, "Usu_Inc");
        }

        private void txtTexto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                Carregar(txtTexto.Text);
        }

        protected override void OnShown(EventArgs e)
        {
            if (_pesquisa && dgvDados.RowCount > 0)
                dgvDados.Focus();
            else
                base.OnShown(e);

        }

        private void dgvDados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                if (_pesquisa && dgvDados.RowCount > 0)
                {
                    DadosStaticos.IdSelecionado = Grade.RetornarId(ref dgvDados, "Codigo");
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
        }

        private void frmFormaPagto_FormClosed(object sender, FormClosedEventArgs e)
        {
            _unitOfWork.Dispose();
        }
    }
}
