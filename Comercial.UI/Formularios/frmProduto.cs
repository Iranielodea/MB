using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces;
using Comercial.UI.Comum;
using Comercial.UI.Consultas;
using StructureMap;
using System;
using System.Windows.Forms;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.UI.Formularios
{
    public partial class frmProduto : Comercial.BaseUI.Base.frmPadrao
    {
        private Produto _produto;
        private bool _pesquisa;
        private IUnitOfWork _unitOfWork;

        public frmProduto()
        {
            _pesquisa = false;
            Iniciar("ABCDE");
        }

        public frmProduto(string descricao)
        {
            _pesquisa = true;
            Iniciar(descricao);
        }

        private void Iniciar(string descricao)
        {
            InitializeComponent();

            tabControl1.TabPages.Remove(tpEditar);
            tabControl1.TabPages.Remove(tpFiltro);

            UsrGrupo.Programa(EnumProgramas.Grupo);
            UsrUnidade.Programa(EnumProgramas.Unidade);

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
            dgvDados.DataSource = _unitOfWork.ServicoProduto.Filtrar(campo, valor, DadosStaticos.IdEmpresa);
            cbCampos.Text = campos;
        }

        private void LimparTela()
        {
            Funcoes.LimparTela(tbPrincipal);
            txtValorVenda.txtValor.Clear();
            UsrGrupo.txtId.Clear();
            UsrGrupo.txtNome.Clear();
            UsrUnidade.txtId.Clear();
            UsrUnidade.txtNome.Clear();
        }

        public override void Novo()
        {
            base.Novo();
            _produto = new Produto();
            LimparTela();

            VincularDados();
            txtDescricao.Focus();
        }

        public override void Editar()
        {
            if (dgvDados.RowCount > 0)
            {
                base.Editar();
                LimparTela();
                int id = Grade.RetornarId(ref dgvDados, "Codigo");
                _produto = new Produto();
                _produto = _unitOfWork.ServicoProduto.ObterPorId(id);
                UsrUnidade.txtId.Text = _produto.Id_Unidade.ToString();
                UsrUnidade.txtNome.Text = _produto.Unidade.Sigla;

                if (_produto.Cod_Grupo != null)
                {
                    UsrGrupo.txtId.Text = _produto.Cod_Grupo.ToString();
                    UsrGrupo.txtNome.Text = _produto.Grupo.Desc_Grupo;
                }

                txtValorVenda.txtValor.Text = _produto.Valor_Venda.ToString("n2");

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
                        var produto = _unitOfWork.ServicoProduto.ObterPorId(Grade.RetornarId(ref dgvDados, "Codigo"));
                        if (produto != null)
                        {
                            _unitOfWork.ServicoProduto.Excluir(produto, DadosStaticos.NomeUsuario);
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
                if (UsrUnidade.txtId.Text == "")
                    throw new Exception("É obrigatório a unidade.");

                int id = 0;
                _produto.Id_Unidade = int.Parse(UsrUnidade.txtId.Text);
                _produto.Cod_Grupo = Funcoes.StrToIntNull(UsrGrupo.txtId.Text);
                _produto.Valor_Venda = decimal.Parse(txtValorVenda.txtValor.Text);
                id = _unitOfWork.ServicoProduto.Salvar(_produto, DadosStaticos.NomeUsuario);
                dgvDados.DataSource = _unitOfWork.ServicoProduto.Filtrar("", "", DadosStaticos.IdEmpresa, id);
                base.Salvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VincularDados()
        {
            Funcoes.Binding(ref txtCodigo, _produto, "Cod_Produto");
            Funcoes.Binding(ref txtDescricao, _produto, "Desc_Produto");
            Funcoes.Binding(ref txtReferencia, _produto, "Referencia");

            Funcoes.Binding(ref txtUsuarioAlterou, _produto, "Usu_Alt");
            Funcoes.Binding(ref txtUsuarioCadastrou, _produto, "Usu_Inc");
        }

        protected override void OnShown(EventArgs e)
        {
            if (_pesquisa && dgvDados.RowCount > 0)
                dgvDados.Focus();
            else
                base.OnShown(e);

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

        private void frmProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            _unitOfWork.Dispose();
        }
    }
}
