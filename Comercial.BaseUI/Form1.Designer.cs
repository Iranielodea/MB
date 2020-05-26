namespace Comercial.BaseUI
{
    partial class Form1
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
            this.tabControle = new System.Windows.Forms.TabControl();
            this.tpPesquisar = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbCampos = new System.Windows.Forms.ComboBox();
            this.tpEditar = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpPrincipal = new System.Windows.Forms.TabPage();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.tpFiltrar = new System.Windows.Forms.TabPage();
            this.tabControle.SuspendLayout();
            this.tpPesquisar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpEditar.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpPrincipal.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControle
            // 
            this.tabControle.Controls.Add(this.tpPesquisar);
            this.tabControle.Controls.Add(this.tpEditar);
            this.tabControle.Controls.Add(this.tpFiltrar);
            this.tabControle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControle.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControle.Location = new System.Drawing.Point(0, 0);
            this.tabControle.Name = "tabControle";
            this.tabControle.SelectedIndex = 0;
            this.tabControle.Size = new System.Drawing.Size(800, 450);
            this.tabControle.TabIndex = 0;
            // 
            // tpPesquisar
            // 
            this.tpPesquisar.BackColor = System.Drawing.Color.Silver;
            this.tpPesquisar.Controls.Add(this.panel2);
            this.tpPesquisar.Controls.Add(this.panel1);
            this.tpPesquisar.Location = new System.Drawing.Point(4, 26);
            this.tpPesquisar.Name = "tpPesquisar";
            this.tpPesquisar.Padding = new System.Windows.Forms.Padding(3);
            this.tpPesquisar.Size = new System.Drawing.Size(792, 420);
            this.tpPesquisar.TabIndex = 0;
            this.tpPesquisar.Text = "Pesquisa";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnExcluir);
            this.panel2.Controls.Add(this.btnFiltrar);
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.btnNovo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(639, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 347);
            this.panel2.TabIndex = 1;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Black;
            this.btnExcluir.Location = new System.Drawing.Point(9, 84);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(136, 33);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "E&xcluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.Black;
            this.btnFiltrar.Location = new System.Drawing.Point(9, 123);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(136, 33);
            this.btnFiltrar.TabIndex = 6;
            this.btnFiltrar.Text = "&Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(9, 162);
            this.btnSair.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(136, 33);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(9, 45);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(136, 33);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.BackColor = System.Drawing.Color.Transparent;
            this.btnNovo.FlatAppearance.BorderSize = 0;
            this.btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.ForeColor = System.Drawing.Color.Black;
            this.btnNovo.Location = new System.Drawing.Point(9, 6);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(136, 33);
            this.btnNovo.TabIndex = 1;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = false;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtTexto);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbbCampos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 67);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(657, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AllowDrop = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(275, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Texto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTexto
            // 
            this.txtTexto.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.Location = new System.Drawing.Point(322, 20);
            this.txtTexto.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(313, 24);
            this.txtTexto.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Campos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbCampos
            // 
            this.cbbCampos.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbCampos.FormattingEnabled = true;
            this.cbbCampos.Location = new System.Drawing.Point(81, 19);
            this.cbbCampos.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cbbCampos.Name = "cbbCampos";
            this.cbbCampos.Size = new System.Drawing.Size(173, 25);
            this.cbbCampos.TabIndex = 3;
            // 
            // tpEditar
            // 
            this.tpEditar.BackColor = System.Drawing.Color.DarkGray;
            this.tpEditar.Controls.Add(this.tabControl2);
            this.tpEditar.Controls.Add(this.panel3);
            this.tpEditar.Location = new System.Drawing.Point(4, 26);
            this.tpEditar.Name = "tpEditar";
            this.tpEditar.Padding = new System.Windows.Forms.Padding(3);
            this.tpEditar.Size = new System.Drawing.Size(792, 420);
            this.tpEditar.TabIndex = 1;
            this.tpEditar.Text = "Editar";
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tpPrincipal);
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(635, 414);
            this.tabControl2.TabIndex = 13;
            // 
            // tpPrincipal
            // 
            this.tpPrincipal.BackColor = System.Drawing.Color.Silver;
            this.tpPrincipal.Controls.Add(this.txtNome);
            this.tpPrincipal.Controls.Add(this.label4);
            this.tpPrincipal.Controls.Add(this.txtCodigo);
            this.tpPrincipal.Controls.Add(this.label3);
            this.tpPrincipal.Location = new System.Drawing.Point(4, 26);
            this.tpPrincipal.Name = "tpPrincipal";
            this.tpPrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrincipal.Size = new System.Drawing.Size(627, 384);
            this.tpPrincipal.TabIndex = 0;
            this.tpPrincipal.Text = "Principal";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(15, 78);
            this.txtNome.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(495, 22);
            this.txtNome.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 60);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Descrição";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(15, 33);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(53, 22);
            this.txtCodigo.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Código";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Controls.Add(this.btnSalvar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(639, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 414);
            this.panel3.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(9, 45);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 33);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.Transparent;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(9, 6);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(136, 33);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // tpFiltrar
            // 
            this.tpFiltrar.BackColor = System.Drawing.Color.DarkGray;
            this.tpFiltrar.Location = new System.Drawing.Point(4, 26);
            this.tpFiltrar.Name = "tpFiltrar";
            this.tpFiltrar.Padding = new System.Windows.Forms.Padding(3);
            this.tpFiltrar.Size = new System.Drawing.Size(792, 420);
            this.tpFiltrar.TabIndex = 2;
            this.tpFiltrar.Text = "Filtrar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base";
            this.tabControle.ResumeLayout(false);
            this.tpPesquisar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tpEditar.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tpPrincipal.ResumeLayout(false);
            this.tpPrincipal.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TabControl tabControle;
        public System.Windows.Forms.TabPage tpPesquisar;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.TabPage tpEditar;
        public System.Windows.Forms.TabPage tpFiltrar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cbbCampos;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtTexto;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Button btnNovo;
        public System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnFiltrar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.Button btnCancelar;
        public System.Windows.Forms.Button btnSalvar;
        public System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.TabControl tabControl2;
        public System.Windows.Forms.TabPage tpPrincipal;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCodigo;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Panel panel2;
    }
}

