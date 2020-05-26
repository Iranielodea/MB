using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces;
using Comercial.UI.Comum;
using Comercial.UI.Consultas;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static Comercial.Dominio.Enumeradores.Enumerador;

namespace Comercial.UI.Formularios
{
    public partial class frmContas : BaseUI.Base.frmPadrao
    {
        private Conta _conta;
        private IUnitOfWork _unitOfWork;
        private TipoFinanceiro _tipoFinanceiro;
        private int _id;

        public frmContas(TipoFinanceiro tipoFinanceiro)
        {
            _tipoFinanceiro = tipoFinanceiro;

            Iniciar();
        }

        private void Iniciar()
        {
            InitializeComponent();

            tabControl1.TabPages.Remove(tpEditar);
            tabControl1.TabPages.Remove(tpFiltro);

            UsrContaBanco.Programa(EnumProgramas.ContaBancaria);
            UsrFormaPagto.Programa(EnumProgramas.FormaPagto);

            _unitOfWork = ObjectFactory.GetInstance<IUnitOfWork>();

            Grade.Configurar(ref dgvDados);
            cbCampos.Items.Add("Id_Conta");
            cbCampos.Items.Add("DOCUMENTO");
            //cbCampos.DataSource = Grade.ListarCampos(ref dgvDados);
            //cbCampos.SelectedIndex = 1;

            if (_tipoFinanceiro == TipoFinanceiro.tfPagar)
            {
                lblCliente.Text = "Fornecedor";
                lblReceber.Text = "Pagar";
                lblRecebido.Text = "Pago";
                this.Text = "Contas a Pagar";
            }

            Carregar();

            btnSair.Left = btnFiltro.Left;
            btnFiltro.Visible = false;
        }

        private void BuscarPessoa()
        {
            var conta = new Conta();
            if (_tipoFinanceiro == TipoFinanceiro.tfReceber)
                conta = _unitOfWork.ServicoConta.ObterContasReceberPorDocumento(DadosStaticos.IdEmpresa, txtDocumento.Text);
            else
                conta = _unitOfWork.ServicoConta.ObterContasPagarPorDocumento(DadosStaticos.IdEmpresa, txtDocumento.Text); ;

            if (conta != null)
            {
                if (_tipoFinanceiro == TipoFinanceiro.tfReceber)
                {
                    txtCodCliente.Text = conta.Cod_Cliente.ToString();
                    txtNomeCliente.Text = conta.Cliente.Nome;
                }
                else
                {
                    txtCodCliente.Text = conta.Cod_For.ToString();
                    txtNomeCliente.Text = conta.Fornecedor.Nome;
                }
                Carregar();
            }
        }

        private void Carregar(int id = 0)
        {
            var filtro = new ContaFiltro();
            filtro.CodEmpresa = DadosStaticos.IdEmpresa;
            filtro.CodPessoa = Funcoes.StrToInt(txtCodCliente.Text);
            filtro.Documento = txtDocumento.Text;

            List<ContaConsulta> Lista = new List<ContaConsulta>();
            Lista = _unitOfWork.ServicoConta.ListarContas(filtro, _tipoFinanceiro, id).ToList();

            decimal totalReceber = Lista.Sum(x => x.Valor_Pagar);
            decimal totalRecebido = Lista.Sum(x => x.Valor_Pago);
            decimal saldo = totalReceber - totalRecebido;

            dgvDados.DataSource = Lista;

            txtTotalReceber.Text = totalReceber.ToString("N2");
            txtTotalRecebido.Text = totalRecebido.ToString("N2");
            txtSaldo.Text = saldo.ToString("N2");

            txtCodCliente.Modified = false;
            txtDocumento.Modified = false;
        }

        public override void Novo()
        {
            if (!ValidarCliente())
                return;

            base.Novo();
            _conta = new Conta();
            _id = 0;
            txtQtdeTitulos.txtValor.Text = "1";
            grpDuplicar.Visible = true;
            VincularDados();
            txtDescricao.Focus();
        }

        private bool ValidarCliente()
        {
            bool retorno = true;
            if (txtCodCliente.Text.Trim() == "")
            {
                retorno = false;
                if (_tipoFinanceiro == TipoFinanceiro.tfReceber)
                    MessageBox.Show("Informe o Cliente!");
                else
                    MessageBox.Show("Informe o Fornecedor!");
                txtCodCliente.Focus();
            }
            return retorno;
        }

        public override void Editar()
        {
            if (!ValidarCliente())
                return;

            if (dgvDados.RowCount > 0)
            {
                base.Editar();
                grpDuplicar.Visible = false;
                int id = Grade.RetornarId(ref dgvDados, "Id_Conta");
                _id = id;
                txtQtdeTitulos.txtValor.Text = "1";
                _conta = new Conta();
                _conta = _unitOfWork.ServicoConta.ObterPorId(id);
                var obs = _unitOfWork.ServicoObsConta.ObterPorConta(_conta.Id_Conta, _conta.Cod_Empresa);
                txtObservacao.Text = "";
                foreach (var item in obs)
                    txtObservacao.Text = txtObservacao.Text + item.Texto + Environment.NewLine;

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
                        var conta = _unitOfWork.ServicoConta.ObterPorId(Grade.RetornarId(ref dgvDados, "Id_Conta"));
                        if (conta != null)
                        {
                            _unitOfWork.BeginTransaction();
                            _unitOfWork.ServicoConta.Excluir(conta, DadosStaticos.NomeUsuario);
                            _unitOfWork.Commit();
                            Carregar();
                        }
                    }
                    catch (Exception ex)
                    {
                        _unitOfWork.RollBack();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public override void Salvar()
        {
            if (_tipoFinanceiro == TipoFinanceiro.tfReceber)
                _conta.Cod_Cliente = Funcoes.StrToIntNull(txtCodCliente.Text);
            else
                _conta.Cod_For = Funcoes.StrToIntNull(txtCodCliente.Text);

            _conta.Cod_Empresa = DadosStaticos.IdEmpresa;
            _conta.Cod_Pagto = Funcoes.StrToIntNull(UsrFormaPagto.txtId.Text);
            _conta.Id_ContaBanco = Funcoes.StrToIntNull(UsrContaBanco.txtId.Text);
            _conta.Data_Emissao = Funcoes.StrToDateNull(txtDataEmissao.txtData.Text);
            _conta.Data_Pago = Funcoes.StrToDateNull(txtDataPagto.txtData.Text);
            _conta.Data_Vencto = Funcoes.StrToDateNull(txtDataVencto.txtData.Text);
            _conta.Id_Conta = _id;

            _conta.Situacao = rbAberto.Checked ? "A" : "P";

            _conta.Tipo_Conta = (int)_tipoFinanceiro;
            _conta.Valor_Original = Funcoes.StrToDecimal(txtValorPagar.txtValor.Text);
            _conta.Valor_Pagar = _conta.Valor_Original;
            _conta.Valor_Pago = Funcoes.StrToDecimal(txtValorPago.txtValor.Text);

            try
            {
                _unitOfWork.BeginTransaction();

                var listaObs = new List<ObsConta>();

                int count = txtObservacao.Lines.Count();

                for (int i = 0; i < count; i++)
                {
                    var item = new ObsConta()
                    {
                        Cod_Empresa = DadosStaticos.IdEmpresa,
                        Id_Conta = _id,
                        Id_Obs = 0,
                        Texto = txtObservacao.Lines[i]
                    };
                    listaObs.Add(item);
                }

                int id = 0;
                int idConta = _conta.Id_Conta;
                for (int i = 1; i <= Convert.ToInt32(txtQtdeTitulos.txtValor.Text); i++)
                {
                    if (idConta == 0)
                        _conta.Id_Conta = 0;

                    id = _unitOfWork.ServicoConta.Salvar(_conta, listaObs, DadosStaticos.NomeUsuario);
                    _conta.Dias = _conta.Dias + 30;
                    _conta.Data_Vencto = _conta.Data_Emissao.Value.AddDays(_conta.Dias.Value);
                }
                _unitOfWork.Commit();

                Carregar(id);
                base.Salvar();
            }
            catch (Exception ex)
            {
                _unitOfWork.RollBack();
                MessageBox.Show(ex.Message);
            }
        }

        private void BuscarDadosPessoa(int id, string nome, TipoPesquisaGeral tipoPesquisaGeral)
        {
            if (_tipoFinanceiro == TipoFinanceiro.tfPagar)
                ConsultarFornecedor(id, nome, tipoPesquisaGeral);
            else
                ConsultarCliente(id, nome, tipoPesquisaGeral);
        }

        private void ConsultarFornecedor(int id, string nome, TipoPesquisaGeral tipoPesquisaGeral)
        {
            var consulta = new ConsultaFornecedor();
            try
            {
                if (tipoPesquisaGeral != TipoPesquisaGeral.pgTela)
                {
                    txtCodCliente.Text = "";
                    txtNomeCliente.Text = "";
                }
                var model = consulta.Pesquisar(id, nome, DadosStaticos.IdEmpresa, tipoPesquisaGeral);
                if (model != null)
                {
                    txtCodCliente.Text = model.Cod_For.ToString();
                    txtNomeCliente.Text = model.Nome;
                    Carregar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtCodCliente.Modified = false;
            txtNomeCliente.Modified = false;
        }

        private void ConsultarCliente(int id, string nome, TipoPesquisaGeral tipoPesquisaGeral)
        {
            var consulta = new ConsultaCliente();
            try
            {
                if (tipoPesquisaGeral != TipoPesquisaGeral.pgTela)
                {
                    txtCodCliente.Text = "";
                    txtNomeCliente.Text = "";
                }
                var model = consulta.Pesquisar(id, nome, DadosStaticos.IdEmpresa, tipoPesquisaGeral);
                if (model != null)
                {
                    txtCodCliente.Text = model.Cod_Cliente.ToString();
                    txtNomeCliente.Text = model.Nome;
                    Carregar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txtCodCliente.Modified = false;
            txtNomeCliente.Modified = false;
        }

        private void txtTexto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                Carregar();
        }

        private void VincularDados()
        {
            Funcoes.Binding(ref txtDescricao, _conta, "Documento");
            Funcoes.Binding(ref txtUsuarioAlterou, _conta, "Usu_Alt");
            Funcoes.Binding(ref txtUsuarioCadastrou, _conta, "Usu_Inc");
            Funcoes.Binding(ref txtDias, _conta, "Dias");

            txtDataEmissao.txtData.Text = _conta.Data_Emissao.ToString();
            txtDataVencto.txtData.Text = _conta.Data_Vencto.ToString();
            txtValorPagar.txtValor.Text = _conta.Valor_Pagar.ToString("N2");

            UsrFormaPagto.txtId.Text = "";
            UsrFormaPagto.txtNome.Text = "";
            if (_conta.Cod_Pagto != null)
            {
                UsrFormaPagto.txtId.Text = _conta.Cod_Pagto.ToString();
                UsrFormaPagto.txtNome.Text = _conta.FormaPagto.Desc_Pagto;
            }

            rbAberto.Checked = (_conta.Situacao == "A");
            rbPago.Checked = (_conta.Situacao == "P");
            txtValorPago.txtValor.Text = _conta.Valor_Pago.ToString("N2");
            txtDataPagto.txtData.Text = _conta.Data_Pago.ToString();

            UsrContaBanco.txtId.Text = "";
            UsrContaBanco.txtNome.Text = "";
            if (_conta.Id_ContaBanco != null)
            {
                UsrContaBanco.txtId.Text = _conta.Id_ContaBanco.ToString();
                UsrContaBanco.txtNome.Text = _conta.ContaBanco.Num_Conta;
            }

            if (_id == 0)
            {
                rbAberto.Checked = true;
                txtDataEmissao.txtData.Text = DateTime.Now.ToShortDateString();
            }
        }

        protected override void OnShown(EventArgs e)
        {
            txtCodCliente.Focus();
            //if (_pesquisa && dgvDados.RowCount > 0)
            //    dgvDados.Focus();
            //else
            //    base.OnShown(e);

        }

        private void CalcularVencimento()
        {
            DateTime dataEmissao = Convert.ToDateTime(txtDataEmissao.txtData.Text);
            int dias = Funcoes.StrToInt(txtDias.Text);
            DateTime dataVencimento = dataEmissao.AddDays(dias);
            txtDataVencto.txtData.Text = dataVencimento.ToString();
        }

        private void CalculaDataEmissao()
        {
            DateTime dataVencimento = Convert.ToDateTime(txtDataVencto.txtData.Text);
            int dias = Funcoes.StrToInt(txtDias.Text);
            DateTime dataEmissao = dataVencimento.AddDays(0 - dias);
            txtDataEmissao.txtData.Text = dataEmissao.ToString();
        }

        private void dgvDados_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void frmGrupo_FormClosed(object sender, FormClosedEventArgs e)
        {
            _unitOfWork.Dispose();
        }

        private void txtCodCliente_Leave(object sender, EventArgs e)
        {
            if (txtCodCliente.Modified)
            {
                BuscarDadosPessoa(Funcoes.StrToInt(txtCodCliente.Text), txtNomeCliente.Text, TipoPesquisaGeral.pgId);                
            }
        }

        private void txtDocumento_Leave(object sender, EventArgs e)
        {
            if (txtDocumento.Modified)
                BuscarPessoa();
        }

        private void txtDias_Leave(object sender, EventArgs e)
        {
            CalcularVencimento();
        }

        private void txtDataVencto_Leave(object sender, EventArgs e)
        {
            CalculaDataEmissao();
        }

        private void grSituacao_Leave(object sender, EventArgs e)
        {
            if (rbPago.Checked)
            {
                if (Funcoes.DataEmBranco(txtDataPagto.txtData.Text))
                    txtDataPagto.txtData.Text = DateTime.Now.ToShortDateString();

                if (Funcoes.StrToDecimal(txtValorPago.txtValor.Text) == 0)
                    txtValorPago.txtValor.Text = txtValorPagar.txtValor.Text;
            }
            else
            {
                txtDataPagto.txtData.Text = "";
                txtValorPago.txtValor.Text = "0,00";
            }
        }

        private void txtNomeCliente_Leave(object sender, EventArgs e)
        {
            if (txtNomeCliente.Modified)
            {
                BuscarDadosPessoa(Funcoes.StrToInt(txtCodCliente.Text), txtNomeCliente.Text, TipoPesquisaGeral.pgDescricao);
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            BuscarDadosPessoa(Funcoes.StrToInt(txtCodCliente.Text), txtNomeCliente.Text, TipoPesquisaGeral.pgTela);
            txtNomeCliente.Focus();
        }
    }
}
