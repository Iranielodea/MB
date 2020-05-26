using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces;
using Comercial.UI.Comum;
using StructureMap;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Comercial.UI.Formularios
{
    public partial class frmContaBanco : Comercial.BaseUI.Base.frmPadrao
    {
        private ContaBanco _contaBanco;
        private IUnitOfWork _unitOfWork;
        private bool _pesquisa;

        public frmContaBanco()
        {
            _pesquisa = false;
            Iniciar("ABCDE");
        }

        public frmContaBanco(string descricao)
        {
            _pesquisa = true;
            Iniciar(descricao);

            //InitializeComponent();

            //tabControl1.TabPages.Remove(tpEditar);
            //tabControl1.TabPages.Remove(tpFiltro);

            //_unitOfWork = ObjectFactory.GetInstance<IUnitOfWork>();

            //Grade.Configurar(ref dgvDados);
            //Carregar("ABCDE");
            //cbCampos.DataSource = Grade.ListarCampos(ref dgvDados);
            //cbCampos.SelectedIndex = 1;
            //btnSair.Left = btnFiltro.Left;
            //btnFiltro.Visible = false;
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
            dgvDados.DataSource = _unitOfWork.ServicoContaBanco.Filtrar(campo, valor, DadosStaticos.IdEmpresa).ToList();
            cbCampos.Text = campos;
        }

        public override void Novo()
        {
            base.Novo();
            _contaBanco = new ContaBanco();
            chkAtivo.Checked = true;
            VincularDados();
            txtNumConta.Focus();
        }

        public override void Editar()
        {
            if (dgvDados.RowCount > 0)
            {
                base.Editar();
                int id = Grade.RetornarId(ref dgvDados, "Codigo");
                _contaBanco = new ContaBanco();
                _contaBanco = _unitOfWork.ServicoContaBanco.ObterPorId(id);

                chkAtivo.Checked = (_contaBanco.Ativo == "S");
                VincularDados();
                txtNumConta.Focus();
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
                        var contaBanco = _unitOfWork.ServicoContaBanco.ObterPorId(Grade.RetornarId(ref dgvDados, "Codigo"));
                        if (contaBanco != null)
                        {
                            _unitOfWork.ServicoContaBanco.Excluir(contaBanco, DadosStaticos.NomeUsuario);
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
                if (chkAtivo.Checked)
                    _contaBanco.Ativo = "S";
                else
                    _contaBanco.Ativo = "N";
                id = _unitOfWork.ServicoContaBanco.Salvar(_contaBanco, DadosStaticos.NomeUsuario);
                dgvDados.DataSource = _unitOfWork.ServicoContaBanco.Filtrar("", "", 0, id);
                base.Salvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VincularDados()
        {
            Funcoes.Binding(ref txtCodigo, _contaBanco, "Id_ContaBanco");
            Funcoes.Binding(ref txtNumConta, _contaBanco, "Num_Conta");
            Funcoes.Binding(ref txtAgencia, _contaBanco, "Agencia");
            Funcoes.Binding(ref txtBanco, _contaBanco, "Banco");
            Funcoes.Binding(ref txtCNPJ, _contaBanco, "CNPJ_CPF");
            //Funcoes.Binding(ref txtUsuarioAlterou, _contaBanco, "Usu_Alt");
            //Funcoes.Binding(ref txtUsuarioCadastrou, _contaBanco, "Usu_Inc");
        }

        private void txtTexto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                Carregar(txtTexto.Text);
        }

        private void frmContaBanco_FormClosed(object sender, FormClosedEventArgs e)
        {
            _unitOfWork.Dispose();
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
    }
}
