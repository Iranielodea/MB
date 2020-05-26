using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces;
using Comercial.UI.Comum;
using StructureMap;
using System;
using System.Windows.Forms;

namespace Comercial.UI.Formularios
{
    public partial class frmPedido : BaseUI.Base.frmPadrao
    {
        private Pedido _pedido;
        private bool _pesquisa;
        private IUnitOfWork _unitOfWork;

        public frmPedido()
        {
            _pesquisa = false;
            Iniciar("ABCDE");
        }

        public frmPedido(string descricao)
        {
            _pesquisa = true;
            Iniciar(descricao);
        }

        private void Iniciar(string descricao)
        {
            InitializeComponent();

            tabControl1.TabPages.Remove(tpEditar);
            tabControl1.TabPages.Remove(tpFiltro);

            UsrCliente.Programa(EnumProgramas.Cliente);
            UsrFornecedor.Programa(EnumProgramas.Fornecedor);
            UsrContato.Programa(EnumProgramas.Cliente);
            UsrVendedor.Programa(EnumProgramas.Vendedor);
            UsrUsina.Programa(EnumProgramas.Fornecedor);
            UsrClienteFiltro.Programa(EnumProgramas.Cliente);
            UsrFornecedorFiltro.Programa(EnumProgramas.Fornecedor);
            UsrContato.lblCodigo.Text = "Contato";
            UsrUsina.lblCodigo.Text = "Usina";

            _unitOfWork = ObjectFactory.GetInstance<IUnitOfWork>();

            Grade.Configurar(ref dgvDados);
            cbCampos.DataSource = Grade.ListarCampos(ref dgvDados);
            cbCampos.SelectedIndex = 1;
            Carregar(descricao);

            btnSair.Left = btnFiltro.Left;
            txtDataInicial.txtData.Text = DateTime.Now.Date.ToShortDateString();
            txtDataFinal.txtData.Text = DateTime.Now.Date.ToShortDateString();

        }

        private void Carregar(string valor)
        {
            string campos = cbCampos.Text;
            string campo = Grade.BuscarCampo(ref dgvDados, cbCampos.Text);
            var filtro = new PedidoFiltro();
            filtro.DataInicial = txtDataInicial.txtData.Text;
            filtro.DataFinal = txtDataInicial.txtData.Text;
            filtro.CodCliente = Funcoes.StrToInt(UsrCliente.txtId.Text);
            filtro.CodFornecedor = Funcoes.StrToInt(UsrFornecedor.txtId.Text);
            filtro.NumPedido = Funcoes.StrToInt(txtNumPedidoFiltro.Text);

            string situacao = "T";
            if (rbAbertoFiltro.Checked)
                situacao = "A";
            if (rbEntregueFiltro.Checked)
                situacao = "E";
            if (rbCanceladoFiltro.Checked)
                situacao = "C";

            filtro.Situacao = situacao;

            var lista = _unitOfWork.ServicoPedido.Filtrar(campo, txtTexto.Text, DadosStaticos.IdEmpresa, filtro);
            dgvDados.DataSource = lista;
            cbCampos.Text = campos;
        }

        public override void Novo()
        {
            base.Novo();
            _pedido = new Pedido();
            VincularDados();
            LimparTela();
            txtData.txtData.Text = _pedido.Data.ToString();
            rbAberto.Checked = true;
            txtData.Focus();
        }

        private void LimparTela()
        {
            txtData.txtData.Clear();
            UsrCliente.LimparTela();
            UsrContato.LimparTela();
            UsrFornecedor.LimparTela();
            UsrUsina.LimparTela();
            UsrVendedor.LimparTela();
        }

        public override void Editar()
        {
            if (dgvDados.RowCount > 0)
            {
                base.Editar();
                int id = Grade.RetornarId(ref dgvDados, "Num_Pedido");
                _pedido = new Pedido();
                _pedido = _unitOfWork.ServicoPedido.ObterPorId(DadosStaticos.IdEmpresa, id);

                VincularDados();
                txtData.Focus();
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
                        var pedido = _unitOfWork.ServicoPedido.ObterPorId(DadosStaticos.IdEmpresa, Grade.RetornarId(ref dgvDados, "Codigo"));
                        if (pedido != null)
                        {
                            _unitOfWork.ServicoPedido.Excluir(pedido, DadosStaticos.NomeUsuario);
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
                id = _unitOfWork.ServicoPedido.Salvar(_pedido, DadosStaticos.NomeUsuario);
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
            if (_pedido != null)
            {
                txtData.txtData.Text = _pedido.Data.ToString();
                UsrCliente.txtId.Text = _pedido.Cod_Cliente.ToString();
                if (_pedido.Cliente != null)
                    UsrCliente.txtNome.Text = _pedido.Cliente.Nome;

                UsrFornecedor.txtId.Text = _pedido.Cod_For.ToString();
                if (_pedido.Fornecedor != null)
                    UsrFornecedor.txtNome.Text = _pedido.Fornecedor.Nome;

                txtPercComissao.txtValor.Text = _pedido.Perc_Comissao.ToString("N4");

                UsrContato.txtId.Text = _pedido.Cod_Contato.ToString();
                if (_pedido.Contato != null)
                    UsrContato.txtNome.Text = _pedido.Contato.Nome;

                UsrVendedor.txtId.Text = _pedido.Cod_Vendedor.ToString();
                if (_pedido.Vendedor != null)
                    UsrVendedor.txtNome.Text = _pedido.Vendedor.Nome;

                txtValorComissao.txtValor.Text = _pedido.Valor_Comissao.ToString("N4");

                UsrUsina.txtId.Text = _pedido.Cod_Usina.ToString();
                if (_pedido.Usina != null)
                    UsrUsina.txtNome.Text = _pedido.Usina.Nome;

                rbAberto.Checked = (_pedido.Situacao == "A");
                rbEntregue.Checked = (_pedido.Situacao == "E");
                rbCancelado.Checked = (_pedido.Situacao == "C");

            }
            Funcoes.Binding(ref txtCodigo, _pedido, "Num_Pedido");
            Funcoes.Binding(ref txtUsuarioAlterou, _pedido, "Usu_Alt");
            Funcoes.Binding(ref txtUsuarioCadastrou, _pedido, "Usu_Inc");
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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Carregar("");
        }
    }
}
