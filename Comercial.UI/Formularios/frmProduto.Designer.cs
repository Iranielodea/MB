namespace Comercial.UI.Formularios
{
    partial class frmProduto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.UsrGrupo = new Comercial.UI.PesquisasGerais.UsrPesquisa();
            this.txtValorVenda = new Comercial.UI.Objetos.ucValor();
            this.UsrUnidade = new Comercial.UI.PesquisasGerais.UsrPesquisa();
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
            this.SuspendLayout();
            // 
            // tpPesquisa
            // 
            this.tpPesquisa.Controls.Add(this.dgvDados);
            this.tpPesquisa.Controls.SetChildIndex(this.groupBox1, 0);
            this.tpPesquisa.Controls.SetChildIndex(this.groupBox2, 0);
            this.tpPesquisa.Controls.SetChildIndex(this.dgvDados, 0);
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
            // txtTexto
            // 
            this.txtTexto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTexto_KeyDown);
            // 
            // cbCampos
            // 
            this.cbCampos.Size = new System.Drawing.Size(204, 25);
            // 
            // btnVoltar2
            // 
            this.toolTip1.SetToolTip(this.btnVoltar2, "ESC");
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(10, 11);
            this.toolTip1.SetToolTip(this.btnSalvar, "F8");
            // 
            // tbPrincipal
            // 
            this.tbPrincipal.Controls.Add(this.UsrUnidade);
            this.tbPrincipal.Controls.Add(this.UsrGrupo);
            this.tbPrincipal.Controls.Add(this.txtValorVenda);
            this.tbPrincipal.Controls.Add(this.label10);
            this.tbPrincipal.Controls.Add(this.label7);
            this.tbPrincipal.Controls.Add(this.txtReferencia);
            this.tbPrincipal.Controls.Add(this.label6);
            this.tbPrincipal.Controls.Add(this.label5);
            this.tbPrincipal.Controls.Add(this.txtDescricao);
            this.tbPrincipal.Controls.Add(this.txtCodigo);
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
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descricao,
            this.Sigla});
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.Location = new System.Drawing.Point(3, 67);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(692, 374);
            this.dgvDados.TabIndex = 3;
            this.dgvDados.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDados_KeyDown);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Cod_Produto";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Descricao
            // 
            this.Descricao.DataPropertyName = "Desc_Produto";
            this.Descricao.HeaderText = "Nome";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 450;
            // 
            // Sigla
            // 
            this.Sigla.DataPropertyName = "Sigla";
            this.Sigla.HeaderText = "Unidade";
            this.Sigla.Name = "Sigla";
            this.Sigla.Width = 65;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(19, 86);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(464, 23);
            this.txtDescricao.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(19, 35);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(55, 23);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Código";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nome";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Referência";
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(19, 140);
            this.txtReferencia.MaxLength = 15;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(131, 23);
            this.txtReferencia.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "Valor Venda";
            // 
            // UsrGrupo
            // 
            this.UsrGrupo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrGrupo.Location = new System.Drawing.Point(19, 170);
            this.UsrGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.UsrGrupo.Modificou = false;
            this.UsrGrupo.Name = "UsrGrupo";
            this.UsrGrupo.Size = new System.Drawing.Size(470, 53);
            this.UsrGrupo.TabIndex = 4;
            // 
            // txtValorVenda
            // 
            this.txtValorVenda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtValorVenda.CasasDecimais = Comercial.UI.Objetos.ucValor.Casas.Duas;
            this.txtValorVenda.Location = new System.Drawing.Point(19, 245);
            this.txtValorVenda.Margin = new System.Windows.Forms.Padding(155, 133, 155, 133);
            this.txtValorVenda.Name = "txtValorVenda";
            this.txtValorVenda.Size = new System.Drawing.Size(89, 24);
            this.txtValorVenda.TabIndex = 5;
            // 
            // UsrUnidade
            // 
            this.UsrUnidade.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrUnidade.Location = new System.Drawing.Point(183, 116);
            this.UsrUnidade.Margin = new System.Windows.Forms.Padding(4);
            this.UsrUnidade.Modificou = false;
            this.UsrUnidade.Name = "UsrUnidade";
            this.UsrUnidade.Size = new System.Drawing.Size(306, 53);
            this.UsrUnidade.TabIndex = 3;
            // 
            // frmProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.ClientSize = new System.Drawing.Size(706, 534);
            this.Name = "frmProduto";
            this.Text = "Produto";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmProduto_FormClosed);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private Objetos.ucValor txtValorVenda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sigla;
        private PesquisasGerais.UsrPesquisa UsrGrupo;
        private PesquisasGerais.UsrPesquisa UsrUnidade;
    }
}
