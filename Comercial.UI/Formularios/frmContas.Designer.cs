namespace Comercial.UI.Formularios
{
    partial class frmContas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.Id_Conta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Emissao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Vencto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Pagar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_Pago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.btnCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalRecebido = new System.Windows.Forms.TextBox();
            this.lblRecebido = new System.Windows.Forms.Label();
            this.txtTotalReceber = new System.Windows.Forms.TextBox();
            this.lblReceber = new System.Windows.Forms.Label();
            this.txtDataEmissao = new Comercial.UI.Objetos.ucData();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDataVencto = new Comercial.UI.Objetos.ucData();
            this.txtValorPagar = new Comercial.UI.Objetos.ucValor();
            this.lblValor = new System.Windows.Forms.Label();
            this.grSituacao = new System.Windows.Forms.GroupBox();
            this.rbPago = new System.Windows.Forms.RadioButton();
            this.rbAberto = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDataPagto = new Comercial.UI.Objetos.ucData();
            this.label11 = new System.Windows.Forms.Label();
            this.txtValorPago = new Comercial.UI.Objetos.ucValor();
            this.label13 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.grpDuplicar = new System.Windows.Forms.GroupBox();
            this.txtQtdeTitulos = new Comercial.UI.Objetos.ucValor();
            this.label15 = new System.Windows.Forms.Label();
            this.UsrFormaPagto = new Comercial.UI.PesquisasGerais.UsrPesquisa();
            this.UsrContaBanco = new Comercial.UI.PesquisasGerais.UsrPesquisa();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.grSituacao.SuspendLayout();
            this.grpDuplicar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(800, 534);
            // 
            // tpPesquisa
            // 
            this.tpPesquisa.Controls.Add(this.groupBox5);
            this.tpPesquisa.Controls.Add(this.dgvDados);
            this.tpPesquisa.Size = new System.Drawing.Size(792, 504);
            this.tpPesquisa.Controls.SetChildIndex(this.groupBox1, 0);
            this.tpPesquisa.Controls.SetChildIndex(this.groupBox2, 0);
            this.tpPesquisa.Controls.SetChildIndex(this.dgvDados, 0);
            this.tpPesquisa.Controls.SetChildIndex(this.groupBox5, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Size = new System.Drawing.Size(786, 60);
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
            this.groupBox1.Controls.Add(this.txtDocumento);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCliente);
            this.groupBox1.Controls.Add(this.txtNomeCliente);
            this.groupBox1.Controls.Add(this.txtCodCliente);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Size = new System.Drawing.Size(786, 64);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.Controls.SetChildIndex(this.label1, 0);
            this.groupBox1.Controls.SetChildIndex(this.label2, 0);
            this.groupBox1.Controls.SetChildIndex(this.cbCampos, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtTexto, 0);
            this.groupBox1.Controls.SetChildIndex(this.lblCliente, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtCodCliente, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtNomeCliente, 0);
            this.groupBox1.Controls.SetChildIndex(this.btnCliente, 0);
            this.groupBox1.Controls.SetChildIndex(this.label5, 0);
            this.groupBox1.Controls.SetChildIndex(this.txtDocumento, 0);
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(362, 12);
            this.txtTexto.Size = new System.Drawing.Size(65, 23);
            this.txtTexto.Visible = false;
            this.txtTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTexto_KeyDown);
            // 
            // cbCampos
            // 
            this.cbCampos.Location = new System.Drawing.Point(192, 12);
            this.cbCampos.Size = new System.Drawing.Size(63, 25);
            this.cbCampos.Visible = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(145, 15);
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(301, 12);
            this.label1.Visible = false;
            // 
            // tpEditar
            // 
            this.tpEditar.Size = new System.Drawing.Size(792, 504);
            // 
            // groupBox3
            // 
            this.groupBox3.Size = new System.Drawing.Size(786, 60);
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
            this.tabControl2.Size = new System.Drawing.Size(786, 498);
            // 
            // tbPrincipal
            // 
            this.tbPrincipal.Controls.Add(this.UsrContaBanco);
            this.tbPrincipal.Controls.Add(this.UsrFormaPagto);
            this.tbPrincipal.Controls.Add(this.grpDuplicar);
            this.tbPrincipal.Controls.Add(this.label14);
            this.tbPrincipal.Controls.Add(this.txtDias);
            this.tbPrincipal.Controls.Add(this.txtObservacao);
            this.tbPrincipal.Controls.Add(this.label13);
            this.tbPrincipal.Controls.Add(this.label11);
            this.tbPrincipal.Controls.Add(this.txtValorPago);
            this.tbPrincipal.Controls.Add(this.label10);
            this.tbPrincipal.Controls.Add(this.txtDataPagto);
            this.tbPrincipal.Controls.Add(this.grSituacao);
            this.tbPrincipal.Controls.Add(this.lblValor);
            this.tbPrincipal.Controls.Add(this.txtValorPagar);
            this.tbPrincipal.Controls.Add(this.label7);
            this.tbPrincipal.Controls.Add(this.txtDataVencto);
            this.tbPrincipal.Controls.Add(this.label6);
            this.tbPrincipal.Controls.Add(this.txtDataEmissao);
            this.tbPrincipal.Controls.Add(this.label4);
            this.tbPrincipal.Controls.Add(this.txtDescricao);
            this.tbPrincipal.Controls.Add(this.txtCodigo);
            this.tbPrincipal.Controls.Add(this.label3);
            this.tbPrincipal.Size = new System.Drawing.Size(778, 468);
            // 
            // btnImprimir
            // 
            this.toolTip1.SetToolTip(this.btnImprimir, "F6");
            // 
            // btnFiltrar
            // 
            this.toolTip1.SetToolTip(this.btnFiltrar, "F5");
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
            this.Id_Conta,
            this.Documento,
            this.Dias,
            this.Data_Emissao,
            this.Data_Vencto,
            this.Valor_Pagar,
            this.Data_Pago,
            this.Valor_Pago,
            this.Situacao});
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDados.Location = new System.Drawing.Point(3, 67);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(786, 312);
            this.dgvDados.TabIndex = 1;
            this.dgvDados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDados_KeyDown);
            // 
            // Id_Conta
            // 
            this.Id_Conta.DataPropertyName = "Id_Conta";
            this.Id_Conta.HeaderText = "Id";
            this.Id_Conta.Name = "Id_Conta";
            this.Id_Conta.Visible = false;
            // 
            // Documento
            // 
            this.Documento.DataPropertyName = "Documento";
            this.Documento.HeaderText = "Documento";
            this.Documento.Name = "Documento";
            // 
            // Dias
            // 
            this.Dias.DataPropertyName = "Dias";
            this.Dias.HeaderText = "Dias";
            this.Dias.Name = "Dias";
            this.Dias.Width = 60;
            // 
            // Data_Emissao
            // 
            this.Data_Emissao.DataPropertyName = "Data_Emissao";
            this.Data_Emissao.HeaderText = "Data Emissão";
            this.Data_Emissao.Name = "Data_Emissao";
            // 
            // Data_Vencto
            // 
            this.Data_Vencto.DataPropertyName = "Data_Vencto";
            this.Data_Vencto.HeaderText = "Data Vencto";
            this.Data_Vencto.Name = "Data_Vencto";
            // 
            // Valor_Pagar
            // 
            this.Valor_Pagar.DataPropertyName = "Valor_Pagar";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.Valor_Pagar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Valor_Pagar.HeaderText = "Valor Pagar";
            this.Valor_Pagar.Name = "Valor_Pagar";
            // 
            // Data_Pago
            // 
            this.Data_Pago.DataPropertyName = "Data_Pago";
            this.Data_Pago.HeaderText = "Data Pagto";
            this.Data_Pago.Name = "Data_Pago";
            // 
            // Valor_Pago
            // 
            this.Valor_Pago.DataPropertyName = "Valor_Pago";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Valor_Pago.DefaultCellStyle = dataGridViewCellStyle3;
            this.Valor_Pago.HeaderText = "Valor Pago";
            this.Valor_Pago.Name = "Valor_Pago";
            // 
            // Situacao
            // 
            this.Situacao.DataPropertyName = "Situacao";
            this.Situacao.HeaderText = "Sit.";
            this.Situacao.Name = "Situacao";
            this.Situacao.Width = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(647, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código";
            this.label3.Visible = false;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(650, 32);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(79, 23);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.Visible = false;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(20, 32);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(169, 23);
            this.txtDescricao.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Documento";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(8, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(54, 17);
            this.lblCliente.TabIndex = 4;
            this.lblCliente.Text = "Cliente";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Location = new System.Drawing.Point(11, 35);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(61, 23);
            this.txtCodCliente.TabIndex = 0;
            this.txtCodCliente.Leave += new System.EventHandler(this.txtCodCliente_Leave);
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(78, 35);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(428, 23);
            this.txtNomeCliente.TabIndex = 1;
            this.txtNomeCliente.Leave += new System.EventHandler(this.txtNomeCliente_Leave);
            // 
            // btnCliente
            // 
            this.btnCliente.Location = new System.Drawing.Point(512, 33);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(38, 27);
            this.btnCliente.TabIndex = 7;
            this.btnCliente.TabStop = false;
            this.btnCliente.Text = "...";
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(562, 35);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(219, 23);
            this.txtDocumento.TabIndex = 2;
            this.txtDocumento.Leave += new System.EventHandler(this.txtDocumento_Leave);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Silver;
            this.groupBox5.Controls.Add(this.txtSaldo);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.txtTotalRecebido);
            this.groupBox5.Controls.Add(this.lblRecebido);
            this.groupBox5.Controls.Add(this.txtTotalReceber);
            this.groupBox5.Controls.Add(this.lblReceber);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 379);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(786, 62);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(319, 36);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(132, 23);
            this.txtSaldo.TabIndex = 5;
            this.txtSaldo.TabStop = false;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(319, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Saldo";
            // 
            // txtTotalRecebido
            // 
            this.txtTotalRecebido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalRecebido.Location = new System.Drawing.Point(169, 36);
            this.txtTotalRecebido.Name = "txtTotalRecebido";
            this.txtTotalRecebido.ReadOnly = true;
            this.txtTotalRecebido.Size = new System.Drawing.Size(132, 23);
            this.txtTotalRecebido.TabIndex = 3;
            this.txtTotalRecebido.TabStop = false;
            this.txtTotalRecebido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRecebido
            // 
            this.lblRecebido.AutoSize = true;
            this.lblRecebido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecebido.Location = new System.Drawing.Point(169, 19);
            this.lblRecebido.Name = "lblRecebido";
            this.lblRecebido.Size = new System.Drawing.Size(70, 16);
            this.lblRecebido.TabIndex = 2;
            this.lblRecebido.Text = "Recebido";
            // 
            // txtTotalReceber
            // 
            this.txtTotalReceber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalReceber.Location = new System.Drawing.Point(11, 36);
            this.txtTotalReceber.Name = "txtTotalReceber";
            this.txtTotalReceber.ReadOnly = true;
            this.txtTotalReceber.Size = new System.Drawing.Size(132, 23);
            this.txtTotalReceber.TabIndex = 1;
            this.txtTotalReceber.TabStop = false;
            this.txtTotalReceber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblReceber
            // 
            this.lblReceber.AutoSize = true;
            this.lblReceber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceber.Location = new System.Drawing.Point(11, 19);
            this.lblReceber.Name = "lblReceber";
            this.lblReceber.Size = new System.Drawing.Size(62, 16);
            this.lblReceber.TabIndex = 0;
            this.lblReceber.Text = "Receber";
            // 
            // txtDataEmissao
            // 
            this.txtDataEmissao.Location = new System.Drawing.Point(205, 32);
            this.txtDataEmissao.Name = "txtDataEmissao";
            this.txtDataEmissao.Size = new System.Drawing.Size(93, 23);
            this.txtDataEmissao.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(202, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data Emissão";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Data Vencimento";
            // 
            // txtDataVencto
            // 
            this.txtDataVencto.Location = new System.Drawing.Point(376, 32);
            this.txtDataVencto.Name = "txtDataVencto";
            this.txtDataVencto.Size = new System.Drawing.Size(121, 23);
            this.txtDataVencto.TabIndex = 4;
            this.txtDataVencto.Leave += new System.EventHandler(this.txtDataVencto_Leave);
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.CasasDecimais = Comercial.UI.Objetos.ucValor.Casas.Duas;
            this.txtValorPagar.Location = new System.Drawing.Point(512, 32);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(93, 23);
            this.txtValorPagar.TabIndex = 5;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(520, 12);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(85, 17);
            this.lblValor.TabIndex = 9;
            this.lblValor.Text = "Valor Pagar";
            // 
            // grSituacao
            // 
            this.grSituacao.BackColor = System.Drawing.Color.Silver;
            this.grSituacao.Controls.Add(this.rbPago);
            this.grSituacao.Controls.Add(this.rbAberto);
            this.grSituacao.Location = new System.Drawing.Point(20, 125);
            this.grSituacao.Name = "grSituacao";
            this.grSituacao.Size = new System.Drawing.Size(121, 89);
            this.grSituacao.TabIndex = 8;
            this.grSituacao.TabStop = false;
            this.grSituacao.Text = "Situação";
            this.grSituacao.Leave += new System.EventHandler(this.grSituacao_Leave);
            // 
            // rbPago
            // 
            this.rbPago.AutoSize = true;
            this.rbPago.Location = new System.Drawing.Point(13, 49);
            this.rbPago.Name = "rbPago";
            this.rbPago.Size = new System.Drawing.Size(61, 21);
            this.rbPago.TabIndex = 1;
            this.rbPago.Text = "Pago";
            this.rbPago.UseVisualStyleBackColor = true;
            // 
            // rbAberto
            // 
            this.rbAberto.AutoSize = true;
            this.rbAberto.Checked = true;
            this.rbAberto.Location = new System.Drawing.Point(13, 22);
            this.rbAberto.Name = "rbAberto";
            this.rbAberto.Size = new System.Drawing.Size(70, 21);
            this.rbAberto.TabIndex = 0;
            this.rbAberto.TabStop = true;
            this.rbAberto.Text = "Aberto";
            this.rbAberto.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(154, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Data Pagamento";
            // 
            // txtDataPagto
            // 
            this.txtDataPagto.Location = new System.Drawing.Point(157, 145);
            this.txtDataPagto.Name = "txtDataPagto";
            this.txtDataPagto.Size = new System.Drawing.Size(121, 23);
            this.txtDataPagto.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Valor Pago";
            // 
            // txtValorPago
            // 
            this.txtValorPago.CasasDecimais = Comercial.UI.Objetos.ucValor.Casas.Duas;
            this.txtValorPago.Location = new System.Drawing.Point(157, 191);
            this.txtValorPago.Name = "txtValorPago";
            this.txtValorPago.Size = new System.Drawing.Size(120, 23);
            this.txtValorPago.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 282);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Observação";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(20, 302);
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(418, 88);
            this.txtObservacao.TabIndex = 13;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(313, 32);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(47, 23);
            this.txtDias.TabIndex = 4;
            this.txtDias.Leave += new System.EventHandler(this.txtDias_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(310, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "Dias";
            // 
            // grpDuplicar
            // 
            this.grpDuplicar.BackColor = System.Drawing.Color.Silver;
            this.grpDuplicar.Controls.Add(this.txtQtdeTitulos);
            this.grpDuplicar.Controls.Add(this.label15);
            this.grpDuplicar.Location = new System.Drawing.Point(538, 302);
            this.grpDuplicar.Name = "grpDuplicar";
            this.grpDuplicar.Size = new System.Drawing.Size(134, 83);
            this.grpDuplicar.TabIndex = 14;
            this.grpDuplicar.TabStop = false;
            // 
            // txtQtdeTitulos
            // 
            this.txtQtdeTitulos.CasasDecimais = Comercial.UI.Objetos.ucValor.Casas.Inteira;
            this.txtQtdeTitulos.Location = new System.Drawing.Point(16, 39);
            this.txtQtdeTitulos.Name = "txtQtdeTitulos";
            this.txtQtdeTitulos.Size = new System.Drawing.Size(93, 23);
            this.txtQtdeTitulos.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(94, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Nro de Títulos";
            // 
            // UsrFormaPagto
            // 
            this.UsrFormaPagto.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrFormaPagto.Location = new System.Drawing.Point(20, 62);
            this.UsrFormaPagto.Margin = new System.Windows.Forms.Padding(4);
            this.UsrFormaPagto.Modificou = false;
            this.UsrFormaPagto.Name = "UsrFormaPagto";
            this.UsrFormaPagto.Size = new System.Drawing.Size(483, 53);
            this.UsrFormaPagto.TabIndex = 6;
            // 
            // UsrContaBanco
            // 
            this.UsrContaBanco.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrContaBanco.Location = new System.Drawing.Point(20, 221);
            this.UsrContaBanco.Margin = new System.Windows.Forms.Padding(4);
            this.UsrContaBanco.Modificou = false;
            this.UsrContaBanco.Name = "UsrContaBanco";
            this.UsrContaBanco.Size = new System.Drawing.Size(418, 53);
            this.UsrContaBanco.TabIndex = 11;
            // 
            // frmContas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Name = "frmContas";
            this.Text = "Contas a Receber";
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.grSituacao.ResumeLayout(false);
            this.grSituacao.PerformLayout();
            this.grpDuplicar.ResumeLayout(false);
            this.grpDuplicar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalRecebido;
        private System.Windows.Forms.Label lblRecebido;
        private System.Windows.Forms.TextBox txtTotalReceber;
        private System.Windows.Forms.Label lblReceber;
        private System.Windows.Forms.Label lblValor;
        private Objetos.ucValor txtValorPagar;
        private System.Windows.Forms.Label label7;
        private Objetos.ucData txtDataVencto;
        private System.Windows.Forms.Label label6;
        private Objetos.ucData txtDataEmissao;
        private System.Windows.Forms.GroupBox grSituacao;
        private System.Windows.Forms.RadioButton rbPago;
        private System.Windows.Forms.RadioButton rbAberto;
        private System.Windows.Forms.Label label11;
        private Objetos.ucValor txtValorPago;
        private System.Windows.Forms.Label label10;
        private Objetos.ucData txtDataPagto;
        private System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Conta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Documento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dias;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Emissao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Vencto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Pagar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data_Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_Pago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.GroupBox grpDuplicar;
        private Objetos.ucValor txtQtdeTitulos;
        private System.Windows.Forms.Label label15;
        private PesquisasGerais.UsrPesquisa UsrContaBanco;
        private PesquisasGerais.UsrPesquisa UsrFormaPagto;
    }
}
