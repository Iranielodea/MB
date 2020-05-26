namespace Comercial.UI.Formularios
{
    partial class frmPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.Num_Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cod_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalLiquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtData = new Comercial.UI.Objetos.ucData();
            this.UsrCliente = new Comercial.UI.PesquisasGerais.UsrPesquisa();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbCancelado = new System.Windows.Forms.RadioButton();
            this.rbEntregue = new System.Windows.Forms.RadioButton();
            this.rbAberto = new System.Windows.Forms.RadioButton();
            this.UsrFornecedor = new Comercial.UI.PesquisasGerais.UsrPesquisa();
            this.txtPercComissao = new Comercial.UI.Objetos.ucValor();
            this.UsrContato = new Comercial.UI.PesquisasGerais.UsrPesquisa();
            this.UsrVendedor = new Comercial.UI.PesquisasGerais.UsrPesquisa();
            this.UsrUsina = new Comercial.UI.PesquisasGerais.UsrPesquisa();
            this.txtValorComissao = new Comercial.UI.Objetos.ucValor();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDataInicial = new Comercial.UI.Objetos.ucData();
            this.txtDataFinal = new Comercial.UI.Objetos.ucData();
            this.label9 = new System.Windows.Forms.Label();
            this.UsrClienteFiltro = new Comercial.UI.PesquisasGerais.UsrPesquisa();
            this.UsrFornecedorFiltro = new Comercial.UI.PesquisasGerais.UsrPesquisa();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumPedidoFiltro = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbCanceladoFiltro = new System.Windows.Forms.RadioButton();
            this.rbTodosFiltro = new System.Windows.Forms.RadioButton();
            this.rbEntregueFiltro = new System.Windows.Forms.RadioButton();
            this.rbAbertoFiltro = new System.Windows.Forms.RadioButton();
            this.tabControl1.SuspendLayout();
            this.tpPesquisa.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpEditar.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tbPrincipal.SuspendLayout();
            this.tpFiltro.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tpFiltroPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(867, 534);
            // 
            // tpPesquisa
            // 
            this.tpPesquisa.Controls.Add(this.dgvDados);
            this.tpPesquisa.Size = new System.Drawing.Size(859, 504);
            this.tpPesquisa.Controls.SetChildIndex(this.groupBox1, 0);
            this.tpPesquisa.Controls.SetChildIndex(this.groupBox2, 0);
            this.tpPesquisa.Controls.SetChildIndex(this.dgvDados, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(853, 60);
            // 
            // btnFiltro
            // 
            this.toolTip1.SetToolTip(this.btnFiltro, "F4");
            // 
            // btnSair
            // 
            this.toolTip1.SetToolTip(this.btnSair, "ESC");
            // 
            // btnExcluir
            // 
            this.toolTip1.SetToolTip(this.btnExcluir, "F3");
            // 
            // btnEditar
            // 
            this.toolTip1.SetToolTip(this.btnEditar, "F2");
            // 
            // btnNovo
            // 
            this.toolTip1.SetToolTip(this.btnNovo, "Insert");
            // 
            // groupBox1
            // 
            this.groupBox1.Size = new System.Drawing.Size(853, 64);
            this.groupBox1.TabIndex = 0;
            // 
            // txtTexto
            // 
            this.txtTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTexto_KeyDown);
            // 
            // cbCampos
            // 
            this.cbCampos.Size = new System.Drawing.Size(204, 25);
            // 
            // tpEditar
            // 
            this.tpEditar.Size = new System.Drawing.Size(859, 504);
            // 
            // groupBox3
            // 
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.None;
            // 
            // btnVoltar2
            // 
            this.toolTip1.SetToolTip(this.btnVoltar2, "ESC");
            // 
            // btnSalvar
            // 
            this.toolTip1.SetToolTip(this.btnSalvar, "F8");
            // 
            // tabControl2
            // 
            this.tabControl2.Size = new System.Drawing.Size(853, 498);
            // 
            // tbPrincipal
            // 
            this.tbPrincipal.Controls.Add(this.label7);
            this.tbPrincipal.Controls.Add(this.label6);
            this.tbPrincipal.Controls.Add(this.label5);
            this.tbPrincipal.Controls.Add(this.txtValorComissao);
            this.tbPrincipal.Controls.Add(this.UsrUsina);
            this.tbPrincipal.Controls.Add(this.UsrVendedor);
            this.tbPrincipal.Controls.Add(this.UsrContato);
            this.tbPrincipal.Controls.Add(this.txtPercComissao);
            this.tbPrincipal.Controls.Add(this.UsrFornecedor);
            this.tbPrincipal.Controls.Add(this.groupBox5);
            this.tbPrincipal.Controls.Add(this.UsrCliente);
            this.tbPrincipal.Controls.Add(this.txtData);
            this.tbPrincipal.Controls.Add(this.txtCodigo);
            this.tbPrincipal.Controls.Add(this.label3);
            this.tbPrincipal.Size = new System.Drawing.Size(845, 468);
            // 
            // btnImprimir
            // 
            this.toolTip1.SetToolTip(this.btnImprimir, "F6");
            // 
            // btnFiltrar
            // 
            this.toolTip1.SetToolTip(this.btnFiltrar, "F5");
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // tpFiltroPrincipal
            // 
            this.tpFiltroPrincipal.Controls.Add(this.groupBox6);
            this.tpFiltroPrincipal.Controls.Add(this.txtNumPedidoFiltro);
            this.tpFiltroPrincipal.Controls.Add(this.label10);
            this.tpFiltroPrincipal.Controls.Add(this.UsrFornecedorFiltro);
            this.tpFiltroPrincipal.Controls.Add(this.UsrClienteFiltro);
            this.tpFiltroPrincipal.Controls.Add(this.txtDataFinal);
            this.tpFiltroPrincipal.Controls.Add(this.label9);
            this.tpFiltroPrincipal.Controls.Add(this.txtDataInicial);
            this.tpFiltroPrincipal.Controls.Add(this.label8);
            // 
            // dgvDados
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num_Pedido,
            this.Data,
            this.Cod_Cliente,
            this.NomeCliente,
            this.Situacao,
            this.TotalLiquido});
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.Location = new System.Drawing.Point(3, 67);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(853, 374);
            this.dgvDados.TabIndex = 1;
            this.dgvDados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDados_KeyDown);
            // 
            // Num_Pedido
            // 
            this.Num_Pedido.DataPropertyName = "Num_Pedido";
            this.Num_Pedido.HeaderText = "Nº Pedido";
            this.Num_Pedido.Name = "Num_Pedido";
            // 
            // Data
            // 
            this.Data.DataPropertyName = "Data";
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.Width = 80;
            // 
            // Cod_Cliente
            // 
            this.Cod_Cliente.DataPropertyName = "Cod_Cliente";
            this.Cod_Cliente.HeaderText = "Código Cliente";
            this.Cod_Cliente.Name = "Cod_Cliente";
            // 
            // NomeCliente
            // 
            this.NomeCliente.DataPropertyName = "NomeCliente";
            this.NomeCliente.HeaderText = "Nome Cliente";
            this.NomeCliente.Name = "NomeCliente";
            this.NomeCliente.Width = 300;
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "Situacao";
            this.Situacao.HeaderText = "Situação";
            this.Situacao.Name = "Situacao";
            // 
            // TotalLiquido
            // 
            this.TotalLiquido.DataPropertyName = "Total_Liquido";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.TotalLiquido.DefaultCellStyle = dataGridViewCellStyle2;
            this.TotalLiquido.HeaderText = "Total";
            this.TotalLiquido.Name = "TotalLiquido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nº Pedido";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(30, 31);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(79, 23);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(126, 31);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(94, 23);
            this.txtData.TabIndex = 4;
            // 
            // UsrCliente
            // 
            this.UsrCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrCliente.Location = new System.Drawing.Point(236, 7);
            this.UsrCliente.Margin = new System.Windows.Forms.Padding(4);
            this.UsrCliente.Modificou = false;
            this.UsrCliente.Name = "UsrCliente";
            this.UsrCliente.Size = new System.Drawing.Size(463, 53);
            this.UsrCliente.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Silver;
            this.groupBox5.Controls.Add(this.rbCancelado);
            this.groupBox5.Controls.Add(this.rbEntregue);
            this.groupBox5.Controls.Add(this.rbAberto);
            this.groupBox5.Location = new System.Drawing.Point(706, 31);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(133, 100);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Situação:";
            // 
            // rbCancelado
            // 
            this.rbCancelado.AutoSize = true;
            this.rbCancelado.Location = new System.Drawing.Point(24, 73);
            this.rbCancelado.Name = "rbCancelado";
            this.rbCancelado.Size = new System.Drawing.Size(100, 21);
            this.rbCancelado.TabIndex = 2;
            this.rbCancelado.Text = "Cancelado";
            this.rbCancelado.UseVisualStyleBackColor = true;
            // 
            // rbEntregue
            // 
            this.rbEntregue.AutoSize = true;
            this.rbEntregue.Location = new System.Drawing.Point(24, 49);
            this.rbEntregue.Name = "rbEntregue";
            this.rbEntregue.Size = new System.Drawing.Size(83, 21);
            this.rbEntregue.TabIndex = 1;
            this.rbEntregue.Text = "Entregue";
            this.rbEntregue.UseVisualStyleBackColor = true;
            // 
            // rbAberto
            // 
            this.rbAberto.AutoSize = true;
            this.rbAberto.Checked = true;
            this.rbAberto.Location = new System.Drawing.Point(24, 22);
            this.rbAberto.Name = "rbAberto";
            this.rbAberto.Size = new System.Drawing.Size(70, 21);
            this.rbAberto.TabIndex = 0;
            this.rbAberto.TabStop = true;
            this.rbAberto.Text = "Aberto";
            this.rbAberto.UseVisualStyleBackColor = true;
            // 
            // UsrFornecedor
            // 
            this.UsrFornecedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrFornecedor.Location = new System.Drawing.Point(30, 57);
            this.UsrFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.UsrFornecedor.Modificou = false;
            this.UsrFornecedor.Name = "UsrFornecedor";
            this.UsrFornecedor.Size = new System.Drawing.Size(498, 53);
            this.UsrFornecedor.TabIndex = 7;
            // 
            // txtPercComissao
            // 
            this.txtPercComissao.CasasDecimais = Comercial.UI.Objetos.ucValor.Casas.Quatro;
            this.txtPercComissao.Location = new System.Drawing.Point(546, 80);
            this.txtPercComissao.Name = "txtPercComissao";
            this.txtPercComissao.Size = new System.Drawing.Size(107, 23);
            this.txtPercComissao.TabIndex = 8;
            // 
            // UsrContato
            // 
            this.UsrContato.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrContato.Location = new System.Drawing.Point(30, 107);
            this.UsrContato.Margin = new System.Windows.Forms.Padding(4);
            this.UsrContato.Modificou = false;
            this.UsrContato.Name = "UsrContato";
            this.UsrContato.Size = new System.Drawing.Size(498, 53);
            this.UsrContato.TabIndex = 9;
            // 
            // UsrVendedor
            // 
            this.UsrVendedor.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrVendedor.Location = new System.Drawing.Point(30, 159);
            this.UsrVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.UsrVendedor.Modificou = false;
            this.UsrVendedor.Name = "UsrVendedor";
            this.UsrVendedor.Size = new System.Drawing.Size(498, 53);
            this.UsrVendedor.TabIndex = 10;
            // 
            // UsrUsina
            // 
            this.UsrUsina.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrUsina.Location = new System.Drawing.Point(30, 206);
            this.UsrUsina.Margin = new System.Windows.Forms.Padding(4);
            this.UsrUsina.Modificou = false;
            this.UsrUsina.Name = "UsrUsina";
            this.UsrUsina.Size = new System.Drawing.Size(498, 53);
            this.UsrUsina.TabIndex = 11;
            // 
            // txtValorComissao
            // 
            this.txtValorComissao.CasasDecimais = Comercial.UI.Objetos.ucValor.Casas.Quatro;
            this.txtValorComissao.Location = new System.Drawing.Point(546, 229);
            this.txtValorComissao.Name = "txtValorComissao";
            this.txtValorComissao.Size = new System.Drawing.Size(107, 23);
            this.txtValorComissao.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "(%) Comissão";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(543, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Valor Comissão";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Data";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Data de";
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Location = new System.Drawing.Point(84, 19);
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(89, 23);
            this.txtDataInicial.TabIndex = 2;
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Location = new System.Drawing.Point(215, 19);
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(89, 23);
            this.txtDataFinal.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(179, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Até";
            // 
            // UsrClienteFiltro
            // 
            this.UsrClienteFiltro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrClienteFiltro.Location = new System.Drawing.Point(19, 49);
            this.UsrClienteFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.UsrClienteFiltro.Modificou = false;
            this.UsrClienteFiltro.Name = "UsrClienteFiltro";
            this.UsrClienteFiltro.Size = new System.Drawing.Size(613, 53);
            this.UsrClienteFiltro.TabIndex = 5;
            // 
            // UsrFornecedorFiltro
            // 
            this.UsrFornecedorFiltro.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrFornecedorFiltro.Location = new System.Drawing.Point(19, 100);
            this.UsrFornecedorFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.UsrFornecedorFiltro.Modificou = false;
            this.UsrFornecedorFiltro.Name = "UsrFornecedorFiltro";
            this.UsrFornecedorFiltro.Size = new System.Drawing.Size(613, 53);
            this.UsrFornecedorFiltro.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Nº Pedido";
            // 
            // txtNumPedidoFiltro
            // 
            this.txtNumPedidoFiltro.Location = new System.Drawing.Point(21, 177);
            this.txtNumPedidoFiltro.Name = "txtNumPedidoFiltro";
            this.txtNumPedidoFiltro.Size = new System.Drawing.Size(100, 23);
            this.txtNumPedidoFiltro.TabIndex = 8;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.Color.Silver;
            this.groupBox6.Controls.Add(this.rbCanceladoFiltro);
            this.groupBox6.Controls.Add(this.rbTodosFiltro);
            this.groupBox6.Controls.Add(this.rbEntregueFiltro);
            this.groupBox6.Controls.Add(this.rbAbertoFiltro);
            this.groupBox6.Location = new System.Drawing.Point(639, 49);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 125);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Situação:";
            // 
            // rbCanceladoFiltro
            // 
            this.rbCanceladoFiltro.AutoSize = true;
            this.rbCanceladoFiltro.Location = new System.Drawing.Point(19, 76);
            this.rbCanceladoFiltro.Name = "rbCanceladoFiltro";
            this.rbCanceladoFiltro.Size = new System.Drawing.Size(100, 21);
            this.rbCanceladoFiltro.TabIndex = 2;
            this.rbCanceladoFiltro.Text = "Cancelado";
            this.rbCanceladoFiltro.UseVisualStyleBackColor = true;
            // 
            // rbTodosFiltro
            // 
            this.rbTodosFiltro.AutoSize = true;
            this.rbTodosFiltro.Checked = true;
            this.rbTodosFiltro.Location = new System.Drawing.Point(19, 98);
            this.rbTodosFiltro.Name = "rbTodosFiltro";
            this.rbTodosFiltro.Size = new System.Drawing.Size(63, 21);
            this.rbTodosFiltro.TabIndex = 3;
            this.rbTodosFiltro.TabStop = true;
            this.rbTodosFiltro.Text = "Todos";
            this.rbTodosFiltro.UseVisualStyleBackColor = true;
            // 
            // rbEntregueFiltro
            // 
            this.rbEntregueFiltro.AutoSize = true;
            this.rbEntregueFiltro.Location = new System.Drawing.Point(19, 49);
            this.rbEntregueFiltro.Name = "rbEntregueFiltro";
            this.rbEntregueFiltro.Size = new System.Drawing.Size(83, 21);
            this.rbEntregueFiltro.TabIndex = 1;
            this.rbEntregueFiltro.Text = "Entregue";
            this.rbEntregueFiltro.UseVisualStyleBackColor = true;
            // 
            // rbAbertoFiltro
            // 
            this.rbAbertoFiltro.AutoSize = true;
            this.rbAbertoFiltro.Location = new System.Drawing.Point(19, 22);
            this.rbAbertoFiltro.Name = "rbAbertoFiltro";
            this.rbAbertoFiltro.Size = new System.Drawing.Size(70, 21);
            this.rbAbertoFiltro.TabIndex = 0;
            this.rbAbertoFiltro.Text = "Aberto";
            this.rbAbertoFiltro.UseVisualStyleBackColor = true;
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(867, 534);
            this.Name = "frmPedido";
            this.Text = "Pedidos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmGrupo_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tpPesquisa.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpEditar.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tbPrincipal.ResumeLayout(false);
            this.tbPrincipal.PerformLayout();
            this.tpFiltro.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabControl3.ResumeLayout(false);
            this.tpFiltroPrincipal.ResumeLayout(false);
            this.tpFiltroPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private Objetos.ucValor txtValorComissao;
        private PesquisasGerais.UsrPesquisa UsrUsina;
        private PesquisasGerais.UsrPesquisa UsrVendedor;
        private PesquisasGerais.UsrPesquisa UsrContato;
        private Objetos.ucValor txtPercComissao;
        private PesquisasGerais.UsrPesquisa UsrFornecedor;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbCancelado;
        private System.Windows.Forms.RadioButton rbEntregue;
        private System.Windows.Forms.RadioButton rbAberto;
        private PesquisasGerais.UsrPesquisa UsrCliente;
        private Objetos.ucData txtData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalLiquido;
        private PesquisasGerais.UsrPesquisa UsrClienteFiltro;
        private Objetos.ucData txtDataFinal;
        private System.Windows.Forms.Label label9;
        private Objetos.ucData txtDataInicial;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumPedidoFiltro;
        private System.Windows.Forms.Label label10;
        private PesquisasGerais.UsrPesquisa UsrFornecedorFiltro;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbTodosFiltro;
        private System.Windows.Forms.RadioButton rbEntregueFiltro;
        private System.Windows.Forms.RadioButton rbAbertoFiltro;
        private System.Windows.Forms.RadioButton rbCanceladoFiltro;
    }
}
