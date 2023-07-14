namespace SistemaBibilioteca
{
    partial class FRMCadastroAluno
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnAdcionarAluno = new System.Windows.Forms.Button();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblCodigoCliente = new System.Windows.Forms.Label();
            this.txtPesquisarAluno = new System.Windows.Forms.TextBox();
            this.btnAtualizarAluno = new System.Windows.Forms.Button();
            this.btnExcluirAluno = new System.Windows.Forms.Button();
            this.btnPesquisarAluno = new System.Windows.Forms.Button();
            this.TxtDateNascimento = new System.Windows.Forms.MaskedTextBox();
            this.TxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(42, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(46, 17);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(94, 26);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(348, 24);
            this.txtNome.TabIndex = 1;
            // 
            // btnAdcionarAluno
            // 
            this.btnAdcionarAluno.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdcionarAluno.Location = new System.Drawing.Point(48, 214);
            this.btnAdcionarAluno.Name = "btnAdcionarAluno";
            this.btnAdcionarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnAdcionarAluno.TabIndex = 2;
            this.btnAdcionarAluno.Text = "Adicionar";
            this.btnAdcionarAluno.UseVisualStyleBackColor = true;
            this.btnAdcionarAluno.Click += new System.EventHandler(this.btnAdcionarAluno_Click);
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAlunos.Location = new System.Drawing.Point(30, 260);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlunos.Size = new System.Drawing.Size(660, 161);
            this.dgvAlunos.TabIndex = 11;
            this.dgvAlunos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlunos_CellDoubleClick);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(43, 78);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 17);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(94, 72);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(222, 24);
            this.txtEmail.TabIndex = 5;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(45, 119);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(60, 17);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(453, 30);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(35, 17);
            this.lblCPF.TabIndex = 8;
            this.lblCPF.Text = "CPF:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(377, 73);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(131, 17);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Data De Nascimento:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(355, 117);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(54, 17);
            this.lblCelular.TabIndex = 12;
            this.lblCelular.Text = "Celular:";
            // 
            // lblCodigoCliente
            // 
            this.lblCodigoCliente.AutoSize = true;
            this.lblCodigoCliente.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoCliente.Location = new System.Drawing.Point(412, 218);
            this.lblCodigoCliente.Name = "lblCodigoCliente";
            this.lblCodigoCliente.Size = new System.Drawing.Size(79, 17);
            this.lblCodigoCliente.TabIndex = 13;
            this.lblCodigoCliente.Text = "Cód.Cliente:";
            // 
            // txtPesquisarAluno
            // 
            this.txtPesquisarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarAluno.Location = new System.Drawing.Point(494, 212);
            this.txtPesquisarAluno.Name = "txtPesquisarAluno";
            this.txtPesquisarAluno.Size = new System.Drawing.Size(100, 24);
            this.txtPesquisarAluno.TabIndex = 15;
            this.txtPesquisarAluno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPesquisar_KeyUp);
            // 
            // btnAtualizarAluno
            // 
            this.btnAtualizarAluno.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizarAluno.Location = new System.Drawing.Point(167, 215);
            this.btnAtualizarAluno.Name = "btnAtualizarAluno";
            this.btnAtualizarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarAluno.TabIndex = 16;
            this.btnAtualizarAluno.Text = "Atualizar";
            this.btnAtualizarAluno.UseVisualStyleBackColor = true;
            this.btnAtualizarAluno.Click += new System.EventHandler(this.btnAtualizarAluno_Click);
            // 
            // btnExcluirAluno
            // 
            this.btnExcluirAluno.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirAluno.Location = new System.Drawing.Point(279, 215);
            this.btnExcluirAluno.Name = "btnExcluirAluno";
            this.btnExcluirAluno.Size = new System.Drawing.Size(72, 23);
            this.btnExcluirAluno.TabIndex = 17;
            this.btnExcluirAluno.Text = "Excluir";
            this.btnExcluirAluno.UseVisualStyleBackColor = true;
            this.btnExcluirAluno.Click += new System.EventHandler(this.btnExcluirAluno_Click);
            // 
            // btnPesquisarAluno
            // 
            this.btnPesquisarAluno.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarAluno.Location = new System.Drawing.Point(613, 215);
            this.btnPesquisarAluno.Name = "btnPesquisarAluno";
            this.btnPesquisarAluno.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarAluno.TabIndex = 18;
            this.btnPesquisarAluno.Text = "Pesquisar";
            this.btnPesquisarAluno.UseVisualStyleBackColor = true;
            this.btnPesquisarAluno.Click += new System.EventHandler(this.btnPesquisarAluno_Click);
            // 
            // TxtDateNascimento
            // 
            this.TxtDateNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDateNascimento.Location = new System.Drawing.Point(514, 73);
            this.TxtDateNascimento.Mask = "00/00/0000";
            this.TxtDateNascimento.Name = "TxtDateNascimento";
            this.TxtDateNascimento.Size = new System.Drawing.Size(134, 24);
            this.TxtDateNascimento.TabIndex = 19;
            this.TxtDateNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // TxtCPF
            // 
            this.TxtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCPF.Location = new System.Drawing.Point(496, 27);
            this.TxtCPF.Mask = "000\\.000\\.000-00";
            this.TxtCPF.Name = "TxtCPF";
            this.TxtCPF.Size = new System.Drawing.Size(194, 24);
            this.TxtCPF.TabIndex = 20;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(111, 114);
            this.txtTelefone.Mask = "(999) 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(194, 24);
            this.txtTelefone.TabIndex = 21;
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(415, 114);
            this.txtCelular.Mask = "(999) 00000-0000";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(194, 24);
            this.txtCelular.TabIndex = 22;
            // 
            // FRMCadastroAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 450);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.TxtCPF);
            this.Controls.Add(this.TxtDateNascimento);
            this.Controls.Add(this.btnPesquisarAluno);
            this.Controls.Add(this.btnExcluirAluno);
            this.Controls.Add(this.btnAtualizarAluno);
            this.Controls.Add(this.txtPesquisarAluno);
            this.Controls.Add(this.lblCodigoCliente);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.btnAdcionarAluno);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Name = "FRMCadastroAluno";
            this.Text = "Cadastro Aluno";
            this.Load += new System.EventHandler(this.FRMCadastroAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAdcionarAluno;
        private System.Windows.Forms.DataGridView dgvAlunos;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblCodigoCliente;
        private System.Windows.Forms.TextBox txtPesquisarAluno;
        private System.Windows.Forms.Button btnAtualizarAluno;
        private System.Windows.Forms.Button btnExcluirAluno;
        private System.Windows.Forms.Button btnPesquisarAluno;
        private System.Windows.Forms.MaskedTextBox TxtDateNascimento;
        private System.Windows.Forms.MaskedTextBox TxtCPF;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCelular;
    }
}

