namespace AtividadeAlexandraValidaçãoCPFeCNPJ
{
    partial class Form1
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
            this.RdCPF = new System.Windows.Forms.RadioButton();
            this.RdCNPJ = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.CpfOuCnpj = new System.Windows.Forms.TextBox();
            this.BtnValidar = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.validarCPFECNPJToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validarEGerarCPFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RdCPF
            // 
            this.RdCPF.AutoSize = true;
            this.RdCPF.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdCPF.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RdCPF.Location = new System.Drawing.Point(47, 122);
            this.RdCPF.Name = "RdCPF";
            this.RdCPF.Size = new System.Drawing.Size(75, 32);
            this.RdCPF.TabIndex = 0;
            this.RdCPF.TabStop = true;
            this.RdCPF.Text = "CPF";
            this.RdCPF.UseVisualStyleBackColor = true;
            // 
            // RdCNPJ
            // 
            this.RdCNPJ.AutoSize = true;
            this.RdCNPJ.Font = new System.Drawing.Font("Book Antiqua", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdCNPJ.Location = new System.Drawing.Point(263, 122);
            this.RdCNPJ.Name = "RdCNPJ";
            this.RdCNPJ.Size = new System.Drawing.Size(90, 32);
            this.RdCNPJ.TabIndex = 1;
            this.RdCNPJ.TabStop = true;
            this.RdCNPJ.Text = "CNPJ";
            this.RdCNPJ.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Validação de CPF e CNPJ";
            // 
            // CpfOuCnpj
            // 
            this.CpfOuCnpj.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CpfOuCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CpfOuCnpj.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CpfOuCnpj.Location = new System.Drawing.Point(32, 187);
            this.CpfOuCnpj.Name = "CpfOuCnpj";
            this.CpfOuCnpj.Size = new System.Drawing.Size(342, 31);
            this.CpfOuCnpj.TabIndex = 3;
            // 
            // BtnValidar
            // 
            this.BtnValidar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnValidar.Location = new System.Drawing.Point(47, 262);
            this.BtnValidar.Name = "BtnValidar";
            this.BtnValidar.Size = new System.Drawing.Size(91, 39);
            this.BtnValidar.TabIndex = 6;
            this.BtnValidar.Text = "Ok";
            this.BtnValidar.UseVisualStyleBackColor = true;
            this.BtnValidar.Click += new System.EventHandler(this.BtnValidar_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancel.Location = new System.Drawing.Point(247, 262);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(117, 39);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Text = "Cancelar";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validarCPFECNPJToolStripMenuItem,
            this.validarEGerarCPFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // validarCPFECNPJToolStripMenuItem
            // 
            this.validarCPFECNPJToolStripMenuItem.Name = "validarCPFECNPJToolStripMenuItem";
            this.validarCPFECNPJToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.validarCPFECNPJToolStripMenuItem.Text = "Validar CPF e CNPJ";
            // 
            // validarEGerarCPFToolStripMenuItem
            // 
            this.validarEGerarCPFToolStripMenuItem.Name = "validarEGerarCPFToolStripMenuItem";
            this.validarEGerarCPFToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.validarEGerarCPFToolStripMenuItem.Text = "Validar e Gerar CPF";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 350);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnValidar);
            this.Controls.Add(this.CpfOuCnpj);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RdCNPJ);
            this.Controls.Add(this.RdCPF);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RdCPF;
        private System.Windows.Forms.RadioButton RdCNPJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CpfOuCnpj;
        private System.Windows.Forms.Button BtnValidar;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem validarCPFECNPJToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validarEGerarCPFToolStripMenuItem;
    }
}

