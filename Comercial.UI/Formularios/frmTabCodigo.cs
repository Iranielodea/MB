using Comercial.Dominio.Interfaces;
using StructureMap;
using System;
using System.Windows.Forms;

namespace Comercial.UI.Formularios
{
    public partial class frmTabCodigo : Form
    {
        public string _cidade { get; set; }
        public string _cliente { get; set; }
        public string _condPagto { get; set; }
        public string _Empresa { get; set; }
        public string _Estado { get; set; }
        public string _FormaPagto { get; set; }
        public string _Permissao { get; set; }
        public string _Fornecedor { get; set; }
        public string _grupo { get; set; }
        public string _pedido { get; set; }
        public string _produto { get; set; }
        public string _unidade { get; set; }
        public string _usuario { get; set; }
        public string _vendedor { get; set; }
        public string _tipoFornecedor { get; set; }

        public frmTabCodigo()
        {
            InitializeComponent();
            BuscarDados();
        }

        private void BuscarDados()
        {
            using (var unitOfWork = ObjectFactory.GetInstance<IUnitOfWork>())
            {
                _cidade = unitOfWork.ServicoTabCodigo.RetornarUltimaCidade().ToString();
                _cliente = unitOfWork.ServicoTabCodigo.RetornarUltimoCliente().ToString();
                _condPagto = unitOfWork.ServicoTabCodigo.RetornarUltimaCondicaoPagto().ToString();
                _Empresa = unitOfWork.ServicoTabCodigo.RetornarUltimaEmpresa().ToString();
                _Estado = unitOfWork.ServicoTabCodigo.RetornarUltimoEstado().ToString();
                _FormaPagto = unitOfWork.ServicoTabCodigo.RetornarUltimaFormaPagto().ToString();
                _Permissao = unitOfWork.ServicoTabCodigo.RetornarUltimoPermissao().ToString();
                _Fornecedor = unitOfWork.ServicoTabCodigo.RetornarUltimoFornecedor().ToString();
                _grupo = unitOfWork.ServicoTabCodigo.RetornarUltimoGrupo().ToString();
                _pedido = unitOfWork.ServicoTabCodigo.RetornarUltimoPedido().ToString();
                _produto = unitOfWork.ServicoTabCodigo.RetornarUltimoProduto().ToString();
                _unidade = unitOfWork.ServicoTabCodigo.RetornarUltimaUnidade().ToString();
                _usuario = unitOfWork.ServicoTabCodigo.RetornarUltimoUsuario().ToString();
                _vendedor = unitOfWork.ServicoTabCodigo.RetornarUltimoVendedor().ToString();
                _tipoFornecedor = unitOfWork.ServicoTabCodigo.RetornarUltimoTipoFornecedor().ToString();
            }
            txtCidade.Text = _cidade;
            txtCliente.Text = _cliente;
            txtCondPagto.Text = _condPagto;
            txtEmpresa.Text = _Empresa;
            txtEstado.Text = _Estado;
            txtFormaPagto.Text = _FormaPagto;
            txtPermissao.Text = _Permissao;
            txtFornecedor.Text = _Fornecedor;
            txtGrupo.Text = _grupo;
            txtPedido.Text = _pedido;
            txtProduto.Text = _produto;
            txtUnidade.Text = _unidade;
            txtUsuario.Text = _usuario;
            txtVendedor.Text = _vendedor;
            txtTipoFornecedor.Text = _tipoFornecedor;
        }

        private void frmTabCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }

        private void frmTabCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void btnVoltar2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Salvar()
        {
            using (var unitOfWork = ObjectFactory.GetInstance<IUnitOfWork>())
            {
                try
                {
                    unitOfWork.BeginTransaction();
                    if (txtCidade.Text != _cidade)
                        unitOfWork.ServicoTabCodigo.AtualizaCidade(int.Parse(txtCidade.Text));
                    if (txtCliente.Text != _cliente)
                        unitOfWork.ServicoTabCodigo.AtualizaCliente(int.Parse(txtCliente.Text));
                    if (txtCondPagto.Text != _condPagto)
                        unitOfWork.ServicoTabCodigo.AtualizaCondicaoPagto(int.Parse(txtCondPagto.Text));
                    if (txtEmpresa.Text != _Empresa)
                        unitOfWork.ServicoTabCodigo.AtualizaEmpresa(int.Parse(txtEmpresa.Text));
                    if (txtEstado.Text != _Estado)
                        unitOfWork.ServicoTabCodigo.AtualizaEstado(int.Parse(txtEstado.Text));
                    if (txtFormaPagto.Text != _FormaPagto)
                        unitOfWork.ServicoTabCodigo.AtualizaFormaPagto(int.Parse(txtFormaPagto.Text));
                    if (txtPermissao.Text != _Permissao)
                        unitOfWork.ServicoTabCodigo.AtualizaPermissao(int.Parse(txtPermissao.Text));
                    if (txtFornecedor.Text != _Fornecedor)
                        unitOfWork.ServicoTabCodigo.AtualizaFornecedor(int.Parse(txtFornecedor.Text));
                    if (txtGrupo.Text != _grupo)
                        unitOfWork.ServicoTabCodigo.AtualizaGrupo(int.Parse(txtGrupo.Text));
                    if (txtPedido.Text != _pedido)
                        unitOfWork.ServicoTabCodigo.AtualizaPedido(int.Parse(txtPedido.Text));
                    if (txtProduto.Text != _produto)
                        unitOfWork.ServicoTabCodigo.AtualizaProduto(int.Parse(txtProduto.Text));
                    if (txtUnidade.Text != _unidade)
                        unitOfWork.ServicoTabCodigo.AtualizaUnidade(int.Parse(txtUnidade.Text));
                    if (txtUsuario.Text != _usuario)
                        unitOfWork.ServicoTabCodigo.AtualizaUsuario(int.Parse(txtUsuario.Text));
                    if (txtVendedor.Text != _vendedor)
                        unitOfWork.ServicoTabCodigo.AtualizaVendedor(int.Parse(txtVendedor.Text));
                    if (txtTipoFornecedor.Text != _tipoFornecedor)
                        unitOfWork.ServicoTabCodigo.AtualizaTipoFornecedor(int.Parse(txtTipoFornecedor.Text));
                    unitOfWork.Commit();
                }
                catch(Exception ex)
                {
                    unitOfWork.RollBack();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }
    }
}
