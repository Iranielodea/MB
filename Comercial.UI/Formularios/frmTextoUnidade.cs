using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces;
using Comercial.UI.Comum;
using StructureMap;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Comercial.UI.Formularios
{
    public partial class frmTextoUnidade : Comercial.BaseUI.Base.frmPadrao
    {
        private UnidadeTexto _unidadeTexto;
        private bool _pesquisa;
        private IUnitOfWork _unitOfWork;

        public frmTextoUnidade()
        {
            Iniciar("abcde");
        }

        public frmTextoUnidade(string descricao)
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

        private void Carregar(string valor, int id = 0)
        {
            string campos = cbCampos.Text;
            string campo = Grade.BuscarCampo(ref dgvDados, cbCampos.Text);
            dgvDados.DataSource = _unitOfWork.ServicoUnidadeTexto.Filtrar(campo, valor).ToList();
            cbCampos.Text = campos;
        }

        public override void Novo()
        {
            base.Novo();
            _unidadeTexto = new UnidadeTexto();
            VincularDados();
            txtDescricao.Focus();
        }

        public override void Editar()
        {
            if (dgvDados.RowCount > 0)
            {
                base.Editar();
                int id = Grade.RetornarId(ref dgvDados, "Codigo");
                _unidadeTexto = new UnidadeTexto();
                _unidadeTexto = _unitOfWork.ServicoUnidadeTexto.ObterPorId(id);
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
                        var unidadeTexto = _unitOfWork.ServicoUnidadeTexto.ObterPorId(Grade.RetornarId(ref dgvDados, "Codigo"));
                        if (unidadeTexto != null)
                        {
                            _unitOfWork.ServicoUnidadeTexto.Excluir(unidadeTexto, DadosStaticos.NomeUsuario);
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
                int id = _unitOfWork.ServicoUnidadeTexto.Salvar(_unidadeTexto, DadosStaticos.NomeUsuario);
                dgvDados.DataSource = _unitOfWork.ServicoUnidadeTexto.Filtrar("", "", id);
                base.Salvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VincularDados()
        {
            Funcoes.Binding(ref txtCodigo, _unidadeTexto, "Id");
            Funcoes.Binding(ref txtDescricao, _unidadeTexto, "Observacao");
            Funcoes.Binding(ref txtObs2, _unidadeTexto, "Texto");
            Funcoes.Binding(ref txtUsuarioAlterou, _unidadeTexto, "Usu_Alt");
            Funcoes.Binding(ref txtUsuarioCadastrou, _unidadeTexto, "Usu_Inc");
        }

        private void txtTexto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                Carregar(txtTexto.Text);
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

        protected override void OnShown(EventArgs e)
        {
            if (_pesquisa && dgvDados.RowCount > 0)
                dgvDados.Focus();
            else
                base.OnShown(e);
        }

        private void frmTextoUnidade_FormClosed(object sender, FormClosedEventArgs e)
        {
            _unitOfWork.Dispose();
        }
    }
}
