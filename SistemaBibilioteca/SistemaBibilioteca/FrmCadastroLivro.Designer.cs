namespace SistemaBibilioteca
{
    partial class FrmCadastroLivro
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
            this.dgvLivro = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAdicionarLivro = new System.Windows.Forms.Button();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtNumeroPaginas = new System.Windows.Forms.TextBox();
            this.lblNumeroDePaginas = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.btnAtualizarLivro = new System.Windows.Forms.Button();
            this.btnExcluirLivro = new System.Windows.Forms.Button();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblISBNPesquisar = new System.Windows.Forms.Label();
            this.btnPesquisarLivro = new System.Windows.Forms.Button();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.MaskedTextBox();
            this.txtAnoPublicacao = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLivro
            // 
            this.dgvLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivro.Location = new System.Drawing.Point(80, 288);
            this.dgvLivro.Name = "dgvLivro";
            this.dgvLivro.Size = new System.Drawing.Size(553, 150);
            this.dgvLivro.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(31, 49);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(43, 16);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Título:";
            // 
            // btnAdicionarLivro
            // 
            this.btnAdicionarLivro.Location = new System.Drawing.Point(28, 216);
            this.btnAdicionarLivro.Name = "btnAdicionarLivro";
            this.btnAdicionarLivro.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionarLivro.TabIndex = 2;
            this.btnAdicionarLivro.Text = "Adicionar";
            this.btnAdicionarLivro.UseVisualStyleBackColor = true;
            this.btnAdicionarLivro.Click += new System.EventHandler(this.btnAdicionarLivro_Click);
            // 
            // txtTitulo
            // 
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.Location = new System.Drawing.Point(80, 44);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(350, 24);
            this.txtTitulo.TabIndex = 3;
            // 
            // txtAutor
            // 
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.Location = new System.Drawing.Point(80, 92);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(346, 24);
            this.txtAutor.TabIndex = 5;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(33, 97);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(41, 16);
            this.lblAutor.TabIndex = 4;
            this.lblAutor.Text = "Autor:";
            // 
            // txtNumeroPaginas
            // 
            this.txtNumeroPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroPaginas.Location = new System.Drawing.Point(580, 44);
            this.txtNumeroPaginas.Name = "txtNumeroPaginas";
            this.txtNumeroPaginas.Size = new System.Drawing.Size(100, 24);
            this.txtNumeroPaginas.TabIndex = 7;
            // 
            // lblNumeroDePaginas
            // 
            this.lblNumeroDePaginas.AutoSize = true;
            this.lblNumeroDePaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroDePaginas.Location = new System.Drawing.Point(442, 49);
            this.lblNumeroDePaginas.Name = "lblNumeroDePaginas";
            this.lblNumeroDePaginas.Size = new System.Drawing.Size(132, 16);
            this.lblNumeroDePaginas.TabIndex = 6;
            this.lblNumeroDePaginas.Text = "Número De Páginas:";
            // 
            // txtPreco
            // 
            this.txtPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreco.Location = new System.Drawing.Point(495, 92);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 24);
            this.txtPreco.TabIndex = 9;
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(443, 97);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(46, 16);
            this.lblPreco.TabIndex = 8;
            this.lblPreco.Text = "Preço:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(268, 146);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(126, 16);
            this.lblAno.TabIndex = 10;
            this.lblAno.Text = "Ano De Publicação:";
            // 
            // btnAtualizarLivro
            // 
            this.btnAtualizarLivro.Location = new System.Drawing.Point(151, 216);
            this.btnAtualizarLivro.Name = "btnAtualizarLivro";
            this.btnAtualizarLivro.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizarLivro.TabIndex = 12;
            this.btnAtualizarLivro.Text = "Atualizar";
            this.btnAtualizarLivro.UseVisualStyleBackColor = true;
            // 
            // btnExcluirLivro
            // 
            this.btnExcluirLivro.Location = new System.Drawing.Point(271, 216);
            this.btnExcluirLivro.Name = "btnExcluirLivro";
            this.btnExcluirLivro.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirLivro.TabIndex = 13;
            this.btnExcluirLivro.Text = "Excluir";
            this.btnExcluirLivro.UseVisualStyleBackColor = true;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(446, 215);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(100, 24);
            this.txtPesquisa.TabIndex = 15;
            // 
            // lblISBNPesquisar
            // 
            this.lblISBNPesquisar.AutoSize = true;
            this.lblISBNPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBNPesquisar.Location = new System.Drawing.Point(399, 220);
            this.lblISBNPesquisar.Name = "lblISBNPesquisar";
            this.lblISBNPesquisar.Size = new System.Drawing.Size(41, 16);
            this.lblISBNPesquisar.TabIndex = 14;
            this.lblISBNPesquisar.Text = "ISBN:";
            // 
            // btnPesquisarLivro
            // 
            this.btnPesquisarLivro.Location = new System.Drawing.Point(564, 215);
            this.btnPesquisarLivro.Name = "btnPesquisarLivro";
            this.btnPesquisarLivro.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisarLivro.TabIndex = 16;
            this.btnPesquisarLivro.Text = "Pesquisar";
            this.btnPesquisarLivro.UseVisualStyleBackColor = true;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(33, 146);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(41, 16);
            this.lblISBN.TabIndex = 17;
            this.lblISBN.Text = "ISBN:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(80, 145);
            this.txtISBN.Mask = "000-0-0000-0000-0";
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(131, 20);
            this.txtISBN.TabIndex = 19;
            // 
            // txtAnoPublicacao
            // 
            this.txtAnoPublicacao.Location = new System.Drawing.Point(413, 146);
            this.txtAnoPublicacao.Mask = "00/00/0000";
            this.txtAnoPublicacao.Name = "txtAnoPublicacao";
            this.txtAnoPublicacao.Size = new System.Drawing.Size(100, 20);
            this.txtAnoPublicacao.TabIndex = 20;
            this.txtAnoPublicacao.ValidatingType = typeof(System.DateTime);
            // 
            // FrmCadastroLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 450);
            this.Controls.Add(this.txtAnoPublicacao);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.btnPesquisarLivro);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.lblISBNPesquisar);
            this.Controls.Add(this.btnExcluirLivro);
            this.Controls.Add(this.btnAtualizarLivro);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.txtNumeroPaginas);
            this.Controls.Add(this.lblNumeroDePaginas);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.btnAdicionarLivro);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvLivro);
            this.Name = "FrmCadastroLivro";
            this.Text = "Cadastro De Livro";
            this.Load += new System.EventHandler(this.FrmCadastroLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLivro;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAdicionarLivro;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtNumeroPaginas;
        private System.Windows.Forms.Label lblNumeroDePaginas;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Button btnAtualizarLivro;
        private System.Windows.Forms.Button btnExcluirLivro;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblISBNPesquisar;
        private System.Windows.Forms.Button btnPesquisarLivro;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.MaskedTextBox txtISBN;
        private System.Windows.Forms.MaskedTextBox txtAnoPublicacao;
    }
}