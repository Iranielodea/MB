using Comercial.Dominio.Entidades;
using Comercial.Dominio.Interfaces;
using Comercial.Dominio.Interfaces.Repositorio;
using Comercial.Dominio.Interfaces.Servico;
using Comercial.Dominio.Servicos;
using Comercial.Infra.Repositorio;
using FirebirdSql.Data.FirebirdClient;
using System;
using System.Data;

namespace CrossPlataforma
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        //private string connection =
        //"User=SYSDBA;" +
        //"Password=masterkey;" +
        //"Database=C:\\Projetos\\MB\\Banco\\Loja.fdb;" +
        //"DataSource=localhost;" +
        //"Port=3050;" +
        //"Dialect=3;" +
        //"Charset=NONE;" +
        //"Role=;" +
        //"Connection lifetime=15;" +
        //"Pooling=true;" +
        //"Packet Size=8192;" +
        //"ServerType=0";

        string connection;// = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ToString();

        protected readonly string ConnectionString;
        IDbConnection _conexao;
        IDbTransaction _transacao;
        private bool _inTransacao;

        public UnitOfWork()
        {
            if (string.IsNullOrWhiteSpace(DadosStaticos.StringConexao))
                DadosStaticos.StringConexao = System.IO.File.ReadAllText("Config.txt");

            connection = DadosStaticos.StringConexao;
            ConnectionString = connection;
            _conexao = new FbConnection(connection);
            _inTransacao = false;
        }

        public void BeginTransaction()
        {
            _conexao.Open();
            _transacao = _conexao.BeginTransaction();
            _inTransacao = true;
        }

        public void Commit()
        {
            _transacao.Commit();
            _conexao.Close();
            _inTransacao = true;
        }

        public void RollBack()
        {
            _transacao.Rollback();
            _conexao.Close();
            _inTransacao = true;
        }

        public void Dispose()
        {
            _conexao.Dispose();
            if (_inTransacao)
                _transacao.Dispose();
        }

        private IRepositorioPermissao RetornarRepositorioPermissao()
        {
            return new RepositorioPermissao(_conexao, _transacao);
        }

        private IRepositorioPermissaoConsulta RetornarRepositorioPermissaoConsulta()
        {
            return new RepositorioPermissao(_conexao, _transacao);
        }

        //public IServicoUsuario ServicoUsuario { get { return ObjectFactory.GetInstance<IServicoUsuario>(); } }
        //private IRepositorioPermissao repPermissao { get { return new RepositorioPermissao(_conexao, _transacao); } }
        //private IRepositorioPermissaoConsulta repPermissaoConsulta { get { return new RepositorioPermissao(_conexao, _transacao); } }
        //=====================================================================
        // Permissao
        //private IServicoPermissao servPermissao { get { return new ServicoPermissao(_conexao, _transacao, RetornarRepositorioPermissao(), RetornarRepositorioPermissaoConsulta()); } }
        //private IServicoPermissao servPermissao { get { return new Comercial.Dominio.Servicos.ServicoPermissao(RetornarRepositorioPermissao(), RetornarRepositorioPermissaoConsulta()); } }
        private IServicoPermissao _servicoPermissao;
        public IServicoPermissao ServicoPermissao
        { get
            {
                if (_servicoPermissao == null)
                    _servicoPermissao = new ServicoPermissao(RetornarRepositorioPermissao(), RetornarRepositorioPermissaoConsulta());
                return _servicoPermissao;
            }
        }
        //=====================================================================
        // Usuario
        private IRepositorioUsuario _repositorioUsuario;
        private IRepositorioUsuario repUsuario
        {
            get
            {
                if (_repositorioUsuario == null)
                    _repositorioUsuario = new RepositorioUsuario(_conexao, _transacao);
                return _repositorioUsuario;
            }
        }

        private IRepositorioUsuarioConsulta _repositorioUsuarioConsulta;
        private IRepositorioUsuarioConsulta repUsuarioConsulta
        {
            get
            {
                if (_repositorioUsuarioConsulta == null)
                    _repositorioUsuarioConsulta = new RepositorioUsuario(_conexao, _transacao);
                return _repositorioUsuarioConsulta;
            }
        }

        private IServicoUsuario _servicoUsuario;
        public IServicoUsuario ServicoUsuario
        {
            get
            {
                if (_servicoUsuario ==  null)
                    _servicoUsuario = new ServicoUsuario(repUsuario, repUsuarioConsulta, ServicoPermissao);
                return _servicoUsuario;
            }
        }
        //=====================================================================
        // Grupo
        private IRepositorioGrupoConsulta _repositorioGrupoConsulta;
        private IRepositorioGrupoConsulta repGrupoConsulta
        {
            get
            {
                if (_repositorioGrupoConsulta == null)
                    _repositorioGrupoConsulta = new RepositorioGrupo(_conexao, _transacao);
                return _repositorioGrupoConsulta;
            }
        }

        private IRepositorioGrupo _repositorioGrupo;
        private IRepositorioGrupo repGrupo
        {
            get
            {
                if (_repositorioGrupo == null)
                    _repositorioGrupo = new RepositorioGrupo(_conexao, _transacao);
                return _repositorioGrupo;
            }
        }

        private IServicoGrupo _servicoGrupo;
        public IServicoGrupo ServicoGrupo
        {
            get
            {
                if (_servicoGrupo == null)
                    _servicoGrupo = new ServicoGrupo(repGrupo, ServicoPermissao, repGrupoConsulta);
                return _servicoGrupo;
            }
        }
        //=====================================================================
        // Estado
        private IRepositorioEstado _repEstado;
        private IRepositorioEstado repEstado
        {
            get
            {
                    if (_repEstado == null)
                        _repEstado = new RepositorioEstado(_conexao, _transacao);
                return _repEstado;
            }
        }

        private IRepositorioEstadoConsulta _repositorioEstadoConsulta;
        private IRepositorioEstadoConsulta repEstadoConsulta
        {
            get
            {
                if (_repositorioEstadoConsulta == null)
                    _repositorioEstadoConsulta = new RepositorioEstado(_conexao, _transacao);
                return _repositorioEstadoConsulta;
            }
        }

        private IServicoEstado _servicoEstado;
        public IServicoEstado ServicoEstado
        {
            get
            {
                if (_servicoEstado == null)
                    _servicoEstado = new ServicoEstado(repEstado, repEstadoConsulta, ServicoPermissao);
                return _servicoEstado;
            }
        }
        //=====================================================================
        // Cadastro de Observacao
        private IRepositorioCadObs _repositorioCadObs;
        private IRepositorioCadObs repCadObs
        {
            get
            {
                if (_repositorioCadObs == null)
                    _repositorioCadObs = new RepositorioCadObs(_conexao, _transacao);
                return _repositorioCadObs;
            }
        }

        private IServicoCadObs _servicoCadObs;
        public IServicoCadObs ServicoCadObs
        {
            get
            {
                if (_servicoCadObs == null)
                    _servicoCadObs = new ServicoCadObs(repCadObs);
                return _servicoCadObs;
            }
        }
        //=====================================================================
        // Cidades
        private IRepositorioCidade _repositorioCidade;
        private IRepositorioCidade repCidade
        {
            get
            {
                if (_repositorioCidade == null)
                    _repositorioCidade = new RepositorioCidade(_conexao, _transacao, repEstado);
                return _repositorioCidade;
            }
        }

        private IRepositorioCidadeConsulta _repositorioCidadeConsulta;
        private IRepositorioCidadeConsulta repCidadeConsulta
        {
            get
            {
                if (_repositorioCidadeConsulta == null)
                    _repositorioCidadeConsulta = new RepositorioCidade(_conexao, _transacao, repEstado);
                return _repositorioCidadeConsulta;
            }
        }

        private IServicoCidade _servicoCidade;
        public IServicoCidade ServicoCidade
        {
            get
            {
                if (_servicoCidade == null)
                    _servicoCidade = new ServicoCidade(repCidade, repCidadeConsulta, ServicoPermissao);
                return _servicoCidade;
            }
        }
        //=====================================================================
        // Empresa
        private IRepositorioEmpresa _repositorioEmpresa;
        private IRepositorioEmpresa repEmpresa
        {
            get
            {
                if (_repositorioEmpresa == null)
                    _repositorioEmpresa = new RepositorioEmpresa(_conexao, _transacao);
                return _repositorioEmpresa;
            }
        }

        private IRepositorioEmpresaConsulta _repositorioEmpresaConsulta;
        private IRepositorioEmpresaConsulta repEmpresaConsulta
        {
            get
            {
                if (_repositorioEmpresaConsulta == null)
                    _repositorioEmpresaConsulta = new RepositorioEmpresa(_conexao, _transacao);
                return _repositorioEmpresaConsulta;
            }
        }

        private IServicoEmpresa _servicoEmpresa;
        public IServicoEmpresa ServicoEmpresa
        {
            get
            {
                if (_servicoEmpresa == null)
                    _servicoEmpresa = new ServicoEmpresa(repEmpresa, repEmpresaConsulta, ServicoPermissao);
                return _servicoEmpresa;
            }
        }
        //=====================================================================
        // Forma de Pagamento
        private IRepositorioFormaPagto _repositorioFormaPagto;
        private IRepositorioFormaPagto repFormaPagto
        {
            get
            {
                if (_repositorioFormaPagto == null)
                    _repositorioFormaPagto = new RepositorioFormaPagto(_conexao, _transacao);
                return _repositorioFormaPagto;
            }
        }

        private IRepositorioFormaPagtoConsulta _repositorioFormaPagtoConsulta;
        private IRepositorioFormaPagtoConsulta repFormaPagtoConsulta
        {
            get
            {
                if (_repositorioFormaPagtoConsulta == null)
                    _repositorioFormaPagtoConsulta = new RepositorioFormaPagto(_conexao, _transacao);
                return _repositorioFormaPagtoConsulta;
            }
        }

        private IServicoFormaPagto _servicoFormaPagto;
        public IServicoFormaPagto ServicoFormaPagto
        {
            get
            {
                if (_servicoFormaPagto == null)
                    _servicoFormaPagto = new ServicoFormaPagto(repFormaPagto, repFormaPagtoConsulta, ServicoPermissao);
                return _servicoFormaPagto;
            }
        }
        //=====================================================================
        // Vendedor
        private IRepositorioVendedor _repositorioVendedor;
        private IRepositorioVendedor repVendedor
        {
            get
            {
                if (_repositorioVendedor == null)
                    _repositorioVendedor = new RepositorioVendedor(_conexao, _transacao);
                return _repositorioVendedor;
            }
        }

        private IRepositorioVendedorConsulta _repositorioVendedorConsulta;
        private IRepositorioVendedorConsulta repVendedorConsulta
        {
            get
            {
                if (_repositorioVendedorConsulta == null)
                    _repositorioVendedorConsulta = new RepositorioVendedor(_conexao, _transacao);
                return _repositorioVendedorConsulta;
            }
        }

        private IServicoVendedor _servicoVendedor;
        public IServicoVendedor ServicoVendedor
        {
            get
            {
                if (_servicoVendedor == null)
                    _servicoVendedor = new ServicoVendedor(repVendedor, repVendedorConsulta, ServicoPermissao);
                return _servicoVendedor;
            }
        }
        //=====================================================================
        // Fornecedor Tipo Empresa
        private IRepositorioFornecedorTipoEmpresa _repositorioFornecedorTipoEmpresa;
        private IRepositorioFornecedorTipoEmpresa repFornecedorTipoEmpresa
        {
            get
            {
                if (_repositorioFornecedorTipoEmpresa == null)
                    _repositorioFornecedorTipoEmpresa = new RepositorioFornecedorTipoEmpresa(_conexao, _transacao);
                return _repositorioFornecedorTipoEmpresa;
            }
        }

        private IRepositorioFornecedorTipoEmpresaConsulta _repositorioFornecedorTipoEmpresaConsulta;
        private IRepositorioFornecedorTipoEmpresaConsulta repTipoEmpresaConsulta
        {
            get
            {
                if (_repositorioFornecedorTipoEmpresaConsulta == null)
                    _repositorioFornecedorTipoEmpresaConsulta = new RepositorioFornecedorTipoEmpresa(_conexao, _transacao);
                return _repositorioFornecedorTipoEmpresaConsulta;
            }
        }

        public IServicoFornecedorTipoEmpresa ServicoFornecedorTipoEmpresa
        {
            get
            {
                return new ServicoFornecedorTipoEmpresa(repFornecedorTipoEmpresa,
                    repTipoEmpresaConsulta, ServicoPermissao);
            }
        }
        //=====================================================================
        // Unidade Texto
        private IRepositorioUnidadeTexto repUnidadeTexto { get { return new RepositorioUnidadeTexto(_conexao, _transacao); } }
        private IRepositorioUnidadeTextoConsulta repUnidadeTextoConsulta { get { return new RepositorioUnidadeTexto(_conexao, _transacao); } }
        public IServicoUnidadeTexto ServicoUnidadeTexto { get { return new ServicoUnidadeTexto(repUnidadeTexto, repUnidadeTextoConsulta, ServicoPermissao); } }
        //=====================================================================
        // TabCodigo
        private IRepositorioTabCodigo repTabCodigo { get { return new RepositorioTabCodigo(_conexao); } }
        public IServicoTabCodigo ServicoTabCodigo { get { return new ServicoTabCodigo(repTabCodigo); } }
        //=====================================================================
        // Unidade
        private IRepositorioUnidade repUnidade { get { return new RepositorioUnidade(_conexao, _transacao, repUnidadeTexto); } }
        private IRepositorioUnidadeConsulta repUnidadeConsulta { get { return new RepositorioUnidade(_conexao, _transacao, repUnidadeTexto); } }
        public IServicoUnidade ServicoUnidade { get { return new ServicoUnidade(repUnidade, repUnidadeConsulta, ServicoPermissao); } }
        //=====================================================================
        // Conta Banco
        private IRepositorioContaBanco _repositorioContaBanco;
        private IRepositorioContaBanco repContaBanco
        {
            get
            {
                if (_repositorioContaBanco == null)
                    _repositorioContaBanco = new RepositorioContaBanco(_conexao, _transacao);
                return _repositorioContaBanco;
            }
        }

        private IRepositorioContaBancoConsulta _repositorioContaBancoConsulta;
        private IRepositorioContaBancoConsulta repContaBancoConsulta
        {
            get
            {
                if (_repositorioContaBancoConsulta == null)
                    _repositorioContaBancoConsulta = new RepositorioContaBanco(_conexao, _transacao);
                return _repositorioContaBancoConsulta;
            }
        }

        private IServicoContaBanco _servicoContaBanco;
        public IServicoContaBanco ServicoContaBanco
        {
            get
            {
                if (_servicoContaBanco == null)
                    _servicoContaBanco = new ServicoContaBanco(repContaBanco, repContaBancoConsulta, ServicoPermissao);
                return _servicoContaBanco;
            }
        }
        //=====================================================================
        // parametros
        private IRepositorioParametro repParametro { get { return new RepositorioParametro(_conexao, _transacao); } }
        private IRepositorioParametroConsulta repParametroConsulta { get { return new RepositorioParametro(_conexao, _transacao); } }
        public IServicoParametro ServicoParametro { get { return new ServicoParametro(repParametro, repParametroConsulta, ServicoPermissao); } }
        //=====================================================================
        // cliente
        private IRepositorioCliente _repositorioCliente;
        private IRepositorioCliente repCliente
        {
            get
            {
                if (_repositorioCliente == null)
                    _repositorioCliente = new RepositorioCliente(_conexao, _transacao, repCidade, repVendedor, repFormaPagto);
                return _repositorioCliente;
            }
        }

        private IRepositorioClienteConsulta _repositorioClienteConsulta;
        private IRepositorioClienteConsulta repClienteConsulta
        {
            get
            {
                if (_repositorioClienteConsulta == null)
                    _repositorioClienteConsulta = new RepositorioCliente(_conexao, _transacao, repCidade, repVendedor, repFormaPagto);
                return _repositorioClienteConsulta;
            }
        }

        private IServicoCliente _servicoCliente;
        public IServicoCliente ServicoCliente
        {
            get
            {
                if (_servicoCliente == null)
                    _servicoCliente = new ServicoCliente(repCliente, repClienteConsulta, ServicoPermissao, ServicoPessoaCredito);
                return _servicoCliente;
            }
        }
        //=====================================================================
        // Contato
        private IRepositorioContato _repositorioContato;
        private IRepositorioContato repContato
        {
            get
            {
                if (_repositorioContato == null)
                    _repositorioContato = new RepositorioContato(_conexao, _transacao);
                return _repositorioContato;
            }
        }

        private IRepositorioContatoConsulta _repositorioContatoConsulta;
        private IRepositorioContatoConsulta repContatoConsulta
        {
            get
            {
                if (_repositorioContatoConsulta == null)
                    _repositorioContatoConsulta = new RepositorioContato(_conexao, _transacao);
                return _repositorioContatoConsulta;
            }
        }

        private IServicoContato _servicoContato;
        public IServicoContato ServicoContato
        {
            get
            {
                if (_servicoContato == null)
                    _servicoContato = new ServicoContato(repContato, repContatoConsulta, ServicoPermissao);
                return _servicoContato;
            }
        }
        //=====================================================================
        // Endereco de Entrega
        private IRepositorioEnderecoEntrega _repositorioEnderecoEntrega;
        private IRepositorioEnderecoEntrega repEnderecoEntrega
        {
            get
            {
                if (_repositorioEnderecoEntrega == null)
                    _repositorioEnderecoEntrega = new RepositorioEnderecoEntrega(_conexao, _transacao);
                return _repositorioEnderecoEntrega;
            }
        }

        private IServicoEnderecoEntrega _servicoEnderecoEntrega;
        public IServicoEnderecoEntrega ServicoEnderecoEntrega
        {
            get
            {
                if (_servicoEnderecoEntrega == null)
                    _servicoEnderecoEntrega = new ServicoEnderecoEntrega(repEnderecoEntrega, ServicoPermissao);
                return _servicoEnderecoEntrega;
            }
        }
        //=====================================================================
        // Fornecedor

        private IRepositorioFornecedor _repositorioFornecedor;
        private IRepositorioFornecedor repFornecedor
        {
            get
            {
                if (_repositorioFornecedor == null)
                    _repositorioFornecedor = new RepositorioFornecedor(_conexao, _transacao, repCidade, repFornecedorTipoEmpresa);
                return _repositorioFornecedor;
            }
        }

        private IRepositorioFornecedorConsulta _repositorioFornecedorConsulta;
        private IRepositorioFornecedorConsulta repFornecedorConsulta
        {
            get
            {
                if (_repositorioFornecedorConsulta == null)
                    _repositorioFornecedorConsulta = new RepositorioFornecedor(_conexao, _transacao, repCidade, repFornecedorTipoEmpresa);
                return _repositorioFornecedorConsulta;
            }
        }

        private IServicoFornecedor _servicoFornecedor;
        public IServicoFornecedor ServicoFornecedor
        {
            get
            {
                if (_servicoFornecedor == null)
                    _servicoFornecedor = new ServicoFornecedor(repFornecedor, repFornecedorConsulta, ServicoPermissao, repCidade, repEstado);
                return _servicoFornecedor;
            }
        }
        //=====================================================================
        // Produto
        private IRepositorioProduto _repositorioProduto;
        private IRepositorioProduto repProduto
        {
            get
            {
                if (_repositorioProduto == null)
                    _repositorioProduto = new RepositorioProduto(_conexao, _transacao, repUnidade, repGrupo);
                return _repositorioProduto;
            }
        }
        private IRepositorioProdutoConsulta _repositorioProdutoConsulta;
        private IRepositorioProdutoConsulta repProdutoConsulta
        {
            get
            {
                if (_repositorioProdutoConsulta == null)
                    _repositorioProdutoConsulta = new RepositorioProduto(_conexao, _transacao, repUnidade, repGrupo);
                return _repositorioProdutoConsulta;
            }
        }

        private IServicoProduto _servicoProduto;
        public IServicoProduto ServicoProduto
        {
            get
            {
                if (_servicoProduto == null)
                    _servicoProduto = new ServicoProduto(repProduto, repProdutoConsulta, ServicoPermissao);
                return _servicoProduto;
            }
        }
        //=====================================================================
        // Transportadora
        private IRepositorioTransportadora _repositorioTransportadora;
        private IRepositorioTransportadora repTransportadora
        {
            get
            {
                if (_repositorioTransportadora == null)
                    _repositorioTransportadora = new RepositorioTransportadora(_conexao, _transacao, repCidade);
                return _repositorioTransportadora;
            }
        }

        private IRepositorioTransportadoraConsulta _repositorioTransportadoraConsulta;
        private IRepositorioTransportadoraConsulta repTransportadoraConsulta
        {
            get
            {
                if (_repositorioTransportadoraConsulta == null)
                    _repositorioTransportadoraConsulta = new RepositorioTransportadora(_conexao, _transacao, repCidade);
                return _repositorioTransportadoraConsulta;
            }
        }

        private IServicoTransportadora _servicoTransportadora;
        public IServicoTransportadora ServicoTransportadora
        {
            get
            {
                if (_servicoTransportadora == null)
                    _servicoTransportadora = new ServicoTransportadora(repTransportadora, repTransportadoraConsulta, ServicoPermissao, repCidade, repEstado);
                return _servicoTransportadora;
            }
        }
        //=====================================================================
        // Motorista
        private IRepositorioMotorista _repositorioMotorista;
        private IRepositorioMotorista repMotorista
        {
            get
            {
                if (_repositorioMotorista == null)
                    _repositorioMotorista = new RepositorioMotorista(_conexao, _transacao, repCidade, repTransportadora);
                return _repositorioMotorista;
            }
        }

        private IRepositorioMotoristaConsulta _repositorioMotoristaConsulta;
        private IRepositorioMotoristaConsulta repMotoristaConsulta
        {
            get
            {
                if (_repositorioMotoristaConsulta == null)
                    _repositorioMotoristaConsulta = new RepositorioMotorista(_conexao, _transacao, repCidade, repTransportadora);
                return _repositorioMotoristaConsulta;
            }
        }

        private IServicoMotorista _servicoMotorista;
        public IServicoMotorista ServicoMotorista
        {
            get
            {
                if (_servicoMotorista == null)
                    _servicoMotorista = new ServicoMotorista(repMotorista, repMotoristaConsulta, ServicoPermissao);
                return _servicoMotorista;
            }
        }
        //=====================================================================
        // Pedido

        private IRepositorioPedido _repositorioPedido;
        private IRepositorioPedido repPedido
        {
            get
            {
                if (_repositorioPedido == null)
                    _repositorioPedido = new RepositorioPedido(_conexao, _transacao, repCliente, repVendedor, repFornecedor);
                return _repositorioPedido;
            }
        }

        private IRepositorioPedidoConsulta _repositorioPedidoConsulta;
        private IRepositorioPedidoConsulta repPedidoConsulta
        {
            get
            {
                if (_repositorioPedidoConsulta == null)
                    _repositorioPedidoConsulta = new RepositorioPedido(_conexao, _transacao, repCliente, repVendedor, repFornecedor);
                return _repositorioPedidoConsulta;
            }
        }

        private IServicoPedido _servicoPedido;
        public IServicoPedido ServicoPedido
        {
            get
            {
                if (_servicoPedido == null)
                    _servicoPedido = new ServicoPedido(repPedido, repPedidoConsulta, ServicoPermissao, repConta, repCarga, repPedidoItem);
                return _servicoPedido;
            }
        }

        //private IServicoPedido _servicoPedido;
        //public IServicoPedido ServicoPedido => _servicoPedido = _servicoPedido ?? new ServicoPedido(
        //    repPedido, repPedidoConsulta, ServicoPermissao, ServicoCarga, ServicoPedidoItem);
        //public IServicoPedido ServicoPedido => _servicoPedido = _servicoPedido ?? new ServicoPedido(
        //    repPedido, repPedidoConsulta, ServicoPermissao, ServicoConta,  ServicoPedidoItem);
        //=====================================================================
        // Carga

        private IRepositorioCarga _repositorioCarga;
        private IRepositorioCarga repCarga
        {
            get
            {
                if (_repositorioCarga == null)
                    _repositorioCarga = new RepositorioCarga(_conexao, _transacao);
                return _repositorioCarga;
            }
        }

        private IRepositorioCargaConsulta _repositorioCargaConsulta;
        private IRepositorioCargaConsulta repCargaConsulta
        {
            get
            {
                if (_repositorioCargaConsulta == null)
                    _repositorioCargaConsulta = new RepositorioCarga(_conexao, _transacao);
                return _repositorioCargaConsulta;
            }
        }

        private IServicoCarga _servicoCarga;
        public IServicoCarga ServicoCarga
        {
            get
            {
                if (_servicoCarga == null)
                _servicoCarga = new ServicoCarga(repCarga, repCargaConsulta,
                    ServicoPermissao, repPedido, repCliente, repFornecedor, ServicoConta, ServicoCadObs, ServicoCargaVencimento);
                return _servicoCarga;
            }
        }
        //=====================================================================
        // Conta

        private IRepositorioConta _repositorioConta;
        private IRepositorioConta repConta
        {
            get
            {
                if (_repositorioConta == null)
                    _repositorioConta = new RepositorioConta(_conexao, _transacao, repContaBanco, repFormaPagto, repCliente, repFornecedor);
                return _repositorioConta;
            }
        }

        private IRepositorioContaConsulta _repositorioContaConsulta;
        private IRepositorioContaConsulta repContaConsulta
        {
            get
            {
                if (_repositorioContaConsulta == null)
                    _repositorioContaConsulta = new RepositorioConta(_conexao, _transacao, repContaBanco, repFormaPagto, repCliente, repFornecedor);
                return _repositorioContaConsulta;
            }
        }

        private IServicoConta _servicoConta;
        public IServicoConta ServicoConta
        {
            get
            {
                if (_servicoConta == null)
                    _servicoConta = new ServicoConta(repConta, repContaConsulta, ServicoPermissao, ServicoObsConta, repCarga);
                return _servicoConta;
            }
        }
        //=====================================================================
        // Carga Vencimento
        private IRepositorioCargaVencimento _repositorioCargaVencimento;
        private IRepositorioCargaVencimento repCargaVencimento
        {
            get
            {
                if (_repositorioCargaVencimento == null)
                    _repositorioCargaVencimento = new RepositorioCargaVencimento(_conexao, _transacao);
                return _repositorioCargaVencimento;
            }
        }

        private IServicoCargaVencimento _servicoCargaVencimento;
        public IServicoCargaVencimento ServicoCargaVencimento
        {
            get
            {
                if (_servicoCargaVencimento == null)
                    _servicoCargaVencimento = new ServicoCargaVencimento(_conexao, _transacao, repCargaVencimento);
                return _servicoCargaVencimento;
            }
        }
        //=====================================================================
        // Pessoa Credito
        private IRepositorioPessoaCredito _repositorioPessoaCredito;
        private IRepositorioPessoaCredito repPessoaCredito
        {
            get
            {
                if (_repositorioPessoaCredito == null)
                    _repositorioPessoaCredito = new RepositorioPessoaCredito(_conexao, _transacao);
                return _repositorioPessoaCredito;
            }
        }

        private IServicoPessoaCredito _servicoPessoaCredito;
        public IServicoPessoaCredito ServicoPessoaCredito
        {
            get
            {
                if (_servicoPessoaCredito == null)
                    _servicoPessoaCredito = new ServicoPessoaCredito(repPessoaCredito);
                return _servicoPessoaCredito;
            }
        }
        //=====================================================================
        // ObsConta
        private IRepositorioObsConta _repositorioObsConta;
        private IRepositorioObsConta repObsConta
        {
            get
            {
                if (_repositorioObsConta == null)
                    _repositorioObsConta = new RepositorioObsConta(_conexao, _transacao);
                return _repositorioObsConta;
            }
        }

        private IServicoObsConta _servicoObsConta;
        public IServicoObsConta ServicoObsConta
        {
            get
            {
                if (_servicoObsConta == null)
                    _servicoObsConta = new ServicoObsConta(repObsConta);
                return _servicoObsConta;
            }
        }
        //=====================================================================
        // PedidoItem
        private IRepositorioPedidoItem _repositorioPedidoItem;
        private IRepositorioPedidoItem repPedidoItem
        {
            get
            {
                if (_repositorioPedidoItem == null)
                    _repositorioPedidoItem = new RepositorioPedidoItem(_conexao, _transacao);
                return _repositorioPedidoItem;
            }
        }

        private IServicoPedidoItem _servicoPedidoItem;
        public IServicoPedidoItem ServicoPedidoItem
        {
            get
            {
                if (_servicoPedidoItem == null)
                    _servicoPedidoItem = new ServicoPedidoItem(repPedidoItem);
                return _servicoPedidoItem;
            }
        }
    }
}
