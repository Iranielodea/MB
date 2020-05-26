using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces;
using Comercial.UI.Comum;
using StructureMap;
using System;
using System.Drawing;
using System.Windows.Forms;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.UI.Formularios
{
    public partial class frmCliente : BaseUI.Base.frmPadrao
    {
        private Cliente _cliente;
        private bool _pesquisa;
        private IUnitOfWork _unitOfWork;

        public frmCliente()
        {
            _pesquisa = false;
            Iniciar("ABCDE");
        }

        public frmCliente(string descricao)
        {
            _pesquisa = true;
            Iniciar(descricao);
        }

        private void Iniciar(string descricao)
        {
            InitializeComponent();

            tabControl1.TabPages.Remove(tpEditar);
            tabControl1.TabPages.Remove(tpFiltro);

            UsrCidade.Programa(EnumProgramas.Cidade);
            UsrVendedor.Programa(EnumProgramas.Vendedor);
            UsrFormaPagto.Programa(EnumProgramas.FormaPagto);

            _unitOfWork = ObjectFactory.GetInstance<IUnitOfWork>();

            //dgvDados.Columns["CPF"].DefaultCellStyle.Format = @"00\.000\.000/000-00";
            //dgvDados.Columns["CPF"].DefaultCellStyle.Format = @"###\.###\.###-##";
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
            dgvDados.DataSource = _unitOfWork.ServicoCliente.Filtrar(campo, valor, DadosStaticos.IdEmpresa);
            cbCampos.Text = campos;
        }

        public override void Novo()
        {
            base.Novo();
            _cliente = new Cliente();
            btnContato.Enabled = false;
            LimparTela();
            VincularDados(TipoVinculo.Novo, null);
            VincularDados();

            txtNome.Focus();
        }

        private void LimparTela()
        {
            tabControl4.SelectedTab = tpEndereco;
            Funcoes.LimparTela(tbPrincipal);
            Funcoes.LimparTela(tpEndereco);
            Funcoes.LimparTela(tpCompl);
            Funcoes.LimparTela(tpVendedor);
        }

        public override void Editar()
        {
            if (dgvDados.RowCount > 0)
            {
                LimparTela();
                btnContato.Enabled = true;
                base.Editar();
                int id = Grade.RetornarId(ref dgvDados, "Codigo");
                _cliente = new Cliente();
                _cliente = _unitOfWork.ServicoCliente.ObterPorId(id);
                VincularDados();
                VincularDados(TipoVinculo.Editar, _unitOfWork);
                txtNome.Focus();
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
                        var cliente = _unitOfWork.ServicoCliente.ObterPorId(Grade.RetornarId(ref dgvDados, "Codigo"));
                        if (cliente != null)
                        {
                            _unitOfWork.ServicoCliente.Excluir(cliente, DadosStaticos.NomeUsuario);
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
                VincularDados(TipoVinculo.Salvar, null);
                try
                {
                    _unitOfWork.BeginTransaction();
                    id = _unitOfWork.ServicoCliente.Salvar(_cliente, DadosStaticos.NomeUsuario);
                    _unitOfWork.Commit();
                }
                catch (Exception ex)
                {
                    _unitOfWork.RollBack();
                    MessageBox.Show(ex.Message);
                }
                dgvDados.DataSource = _unitOfWork.ServicoCliente.Filtrar("", "", DadosStaticos.IdEmpresa, id);
                base.Salvar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VincularDados(TipoVinculo tipoVinculo, IUnitOfWork unitOfWork)
        {
            if (tipoVinculo == TipoVinculo.Novo)
            {
                cbTipoPessoa.SelectedIndex = 1;
                txtDataCadastro.txtData.Text = DateTime.Now.Date.ToShortDateString();
                txtCNPJ.txtValor.Clear();
                txtCreditoData.txtData.Clear();
                txtCreditoQtde.txtValor.Text = "0";
                txtCreditoQtdeUsada.Text = "0";
                txtCreditoSaldo.Text = "0";
                UsrCidade.txtId.Clear();
                UsrCidade.txtNome.Clear();
                txtEstado.Clear();
                UsrFormaPagto.txtId.Clear();
                UsrFormaPagto.txtNome.Clear();
                UsrVendedor.txtId.Clear();
                UsrVendedor.txtNome.Clear();
            }

            if (tipoVinculo == TipoVinculo.Editar)
            {
                cbTipoPessoa.SelectedIndex = _cliente.Tipo_Pessoa == "F" ? 0 : 1;
                txtDataCadastro.txtData.Text = _cliente.Data_Cadastro.ToString();
                txtCNPJ.txtValor.Text = _cliente.CNPJ;
                txtCPF.txtValor.Text = _cliente.CPF;

                if (_cliente.Cod_Cidade.HasValue)
                {
                    UsrCidade.txtId.Text = _cliente.Cod_Cidade.ToString();
                    UsrCidade.txtNome.Text = _cliente.Cidade.Desc_Cidade;
                    txtEstado.Text = _cliente.Cidade.Estado.Sigla;
                }

                if (_cliente.Cod_Pagto.HasValue)
                {
                    UsrFormaPagto.txtId.Text = _cliente.FormaPagto.Cod_Pagto.ToString();
                    UsrFormaPagto.txtNome.Text = _cliente.FormaPagto.Desc_Pagto;
                }

                _cliente.PessoaCredito = unitOfWork.ServicoPessoaCredito.ObterPorId(_cliente.Cod_Cliente);
                if (_cliente.PessoaCredito != null)
                {
                    txtCreditoData.txtData.Text = _cliente.PessoaCredito.Data_Credito.Value.ToShortDateString();
                    txtCreditoQtde.txtValor.Text = _cliente.PessoaCredito.Qtde_Credito.ToString("N0");
                    txtCreditoQtdeUsada.Text = _cliente.PessoaCredito.Qtde_Usado.ToString("N0");
                    txtCreditoSaldo.Text = _cliente.PessoaCredito.Qtde_Saldo.ToString("N0");
                }

                if (_cliente.Cod_Vendedor.HasValue)
                {
                    if (_cliente.Vendedor != null)
                    {
                        UsrVendedor.txtId.Text = _cliente.Vendedor.Cod_Vendedor.ToString();
                        UsrVendedor.txtNome.Text = _cliente.Vendedor.Nome;
                    }
                }
            }

            if (tipoVinculo == TipoVinculo.Salvar)
            {
                _cliente.Cod_Cidade = Funcoes.StrToIntNull(UsrCidade.txtId.Text);
                _cliente.Tipo_Pessoa = cbTipoPessoa.SelectedIndex == 0 ? "F" : "J";
                _cliente.Data_Cadastro = Funcoes.StrToDateNull(txtDataCadastro.txtData.Text);
                _cliente.CNPJ = txtCNPJ.txtValor.Text;
                _cliente.CPF = txtCPF.txtValor.Text;
                _cliente.Cod_Pagto = Funcoes.StrToIntNull(UsrFormaPagto.txtId.Text);

                _cliente.PessoaCredito = new PessoaCredito();
                _cliente.PessoaCredito.Cod_Cliente = _cliente.Cod_Cliente;

                _cliente.PessoaCredito.Data_Credito = Dominio.Geral.Funcao.DataEmBranco(txtCreditoData.txtData.Text) ? null : Funcoes.StrToDateNull(txtCreditoData.txtData.Text);
                _cliente.PessoaCredito.Qtde_Credito = Funcoes.StrToDecimal(txtCreditoQtde.txtValor.Text);
                //_cliente.PessoaCredito.Qtde_Usado = Funcoes.StrToDecimal(txtCreditoQtdeUsada.Text);

                _cliente.Cod_Vendedor = string.IsNullOrEmpty(UsrVendedor.txtId.Text) ? null : Funcoes.StrToIntNull(UsrVendedor.txtId.Text);
            }
        }

        private void VincularDados()
        {
            Funcoes.Binding(ref txtCodigo, _cliente, "Cod_Cliente");
            Funcoes.Binding(ref txtNome, _cliente, "Nome");
            Funcoes.Binding(ref txtFantasia, _cliente, "Fantasia");
            Funcoes.Binding(ref txtEndereco, _cliente, "Endereco");
            Funcoes.Binding(ref txtNumero, _cliente, "Numero");
            Funcoes.Binding(ref txtComplemento, _cliente, "Complemento");
            Funcoes.Binding(ref txtBairro, _cliente, "Bairro");
            Funcoes.BindingMask(ref txtCep, _cliente, "Cep");
            Funcoes.Binding(ref txtInscEstadual, _cliente, "Insc_Estadual");
            Funcoes.Binding(ref txtRG, _cliente, "RG");
            Funcoes.Binding(ref txtTelefone, _cliente, "Fone");
            Funcoes.Binding(ref txtFax, _cliente, "Fax");
            Funcoes.Binding(ref txtEmail, _cliente, "Email");
            Funcoes.Binding(ref txtObservacao, _cliente, "Obs");


            Funcoes.Binding(ref txtUsuarioAlterou, _cliente, "Usu_Alt");
            Funcoes.Binding(ref txtUsuarioCadastrou, _cliente, "Usu_Inc");
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

        private void txtTexto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                Carregar(txtTexto.Text);
        }

        private void BuscarContatos(int codigo)
        {
            frmContato frmContato = new frmContato(codigo, EnContato.Fornecedor);
            frmContato.ShowDialog();
        }

        private void btnContato_Click(object sender, EventArgs e)
        {
            BuscarContatos(int.Parse(txtCodigo.Text));
        }

        private void CNPJ_CPF()
        {
            if (cbTipoPessoa.SelectedIndex == 0)
            {
                lblCnpjCpf.Text = "CPF";
                txtCNPJ.Visible = false;
                txtCPF.Visible = true;
                txtCNPJ.txtValor.Text = "";
                txtCPF.Location = new Point(266, 80);
            }
            else
            {
                lblCnpjCpf.Text = "CNPJ";
                txtCNPJ.Visible = true;
                txtCPF.Visible = false;
                txtCPF.txtValor.Text = "";
            }
        }

        private void cbTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            CNPJ_CPF();
        }

        private void btnUltPedidos_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtCodigo.Text) > 0)
            {
                frmUltimosPedidos frmUltimosPedidos = new frmUltimosPedidos(int.Parse(txtCodigo.Text));
                frmUltimosPedidos.ShowDialog();
            }
        }

        private void frmCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            _unitOfWork.Dispose();
        }

        private void usrPesquisa1_Leave(object sender, EventArgs e)
        {

            if (UsrCidade.Modificou)
            {
                var cidade = new Cidade();
                cidade = (Cidade)UsrCidade.RetornarObjeto();
                txtCep.Text = cidade.CEP;
                txtEstado.Text = cidade.Estado.Sigla;
            }
        }
    }
}

