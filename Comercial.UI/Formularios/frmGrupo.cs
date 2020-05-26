using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces;
using Comercial.UI.Comum;
using StructureMap;
using System;
using System.Windows.Forms;

namespace Comercial.UI.Formularios
{
    public partial class frmGrupo : BaseUI.Base.frmPadrao
    {
        private Grupo _grupo;
        private bool _pesquisa;
        private IUnitOfWork _unitOfWork;

        public frmGrupo()
        {
            _pesquisa = false;
            Iniciar("ABCDE");
        }

        public frmGrupo(string descricao)
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
            var lista = _unitOfWork.ServicoGrupo.GetAll("A");
            dgvDados.DataSource = lista;
            cbCampos.Text = campos;
        }

        public override void Novo()
        {
            base.Novo();
            _grupo = new Grupo();
            VincularDados();
            txtDescricao.Focus();
        }

        public override void Editar()
        {
            if (dgvDados.RowCount > 0)
            {
                base.Editar();
                int id = Grade.RetornarId(ref dgvDados, "Codigo");
                _grupo = new Grupo();
                _grupo = _unitOfWork.ServicoGrupo.ObterPorId(id);
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
                        var grupo = _unitOfWork.ServicoGrupo.ObterPorId(Grade.RetornarId(ref dgvDados, "Codigo"));
                        if (grupo != null)
                        {
                            _unitOfWork.ServicoGrupo.Excluir(grupo, DadosStaticos.NomeUsuario);
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
                id = _unitOfWork.ServicoGrupo.Salvar(_grupo, DadosStaticos.NomeUsuario);
                dgvDados.DataSource = _unitOfWork.ServicoGrupo.Filtrar("", "", DadosStaticos.IdEmpresa, id);
                base.Salvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtTexto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                Carregar(txtTexto.Text);
        }

        private void VincularDados()
        {
            Funcoes.Binding(ref txtCodigo, _grupo, "Cod_Grupo");
            Funcoes.Binding(ref txtDescricao, _grupo, "Desc_Grupo");
            Funcoes.Binding(ref txtUsuarioAlterou, _grupo, "Usu_Alt");
            Funcoes.Binding(ref txtUsuarioCadastrou, _grupo, "Usu_Inc");
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

        private void frmGrupo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _unitOfWork.Dispose();
        }
    }
}
