namespace GeradorCPF
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
            this.lblcpf = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.lblgerador = new System.Windows.Forms.Label();
            this.txtgerar = new System.Windows.Forms.TextBox();
            this.btnvalidar = new System.Windows.Forms.Button();
            this.btngerar = new System.Windows.Forms.Button();
            this.lblcondição = new System.Windows.Forms.Label();
            this.lblCPFaprovado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblcpf
            // 
            this.lblcpf.AutoSize = true;
            this.lblcpf.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblcpf.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcpf.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblcpf.Location = new System.Drawing.Point(155, 20);
            this.lblcpf.Name = "lblcpf";
            this.lblcpf.Size = new System.Drawing.Size(199, 32);
            this.lblcpf.TabIndex = 0;
            this.lblcpf.Text = "Digite seu CPF:";
            // 
            // txtCPF
            // 
            this.txtCPF.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCPF.Location = new System.Drawing.Point(78, 76);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(355, 47);
            this.txtCPF.TabIndex = 1;
            // 
            // lblgerador
            // 
            this.lblgerador.AutoSize = true;
            this.lblgerador.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblgerador.Font = new System.Drawing.Font("Book Antiqua", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgerador.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblgerador.Location = new System.Drawing.Point(137, 235);
            this.lblgerador.Name = "lblgerador";
            this.lblgerador.Size = new System.Drawing.Size(217, 32);
            this.lblgerador.TabIndex = 2;
            this.lblgerador.Text = "Gerador de CPF:";
            // 
            // txtgerar
            // 
            this.txtgerar.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtgerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgerar.Location = new System.Drawing.Point(78, 290);
            this.txtgerar.Name = "txtgerar";
            this.txtgerar.Size = new System.Drawing.Size(355, 47);
            this.txtgerar.TabIndex = 3;
            // 
            // btnvalidar
            // 
            this.btnvalidar.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvalidar.Location = new System.Drawing.Point(161, 157);
            this.btnvalidar.Name = "btnvalidar";
            this.btnvalidar.Size = new System.Drawing.Size(140, 45);
            this.btnvalidar.TabIndex = 4;
            this.btnvalidar.Text = "Validar CPF";
            this.btnvalidar.UseVisualStyleBackColor = true;
            this.btnvalidar.Click += new System.EventHandler(this.btnvalidar_Click);
            // 
            // btngerar
            // 
            this.btngerar.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngerar.Location = new System.Drawing.Point(161, 365);
            this.btngerar.Name = "btngerar";
            this.btngerar.Size = new System.Drawing.Size(140, 45);
            this.btngerar.TabIndex = 5;
            this.btngerar.Text = "Gerar CPF";
            this.btngerar.UseVisualStyleBackColor = true;
            // 
            // lblcondição
            // 
            this.lblcondição.AutoSize = true;
            this.lblcondição.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcondição.Location = new System.Drawing.Point(324, 169);
            this.lblcondição.Name = "lblcondição";
            this.lblcondição.Size = new System.Drawing.Size(43, 20);
            this.lblcondição.TabIndex = 6;
            this.lblcondição.Text = "CPF:";
            this.lblcondição.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCPFaprovado
            // 
            this.lblCPFaprovado.AutoSize = true;
            this.lblCPFaprovado.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFaprovado.Location = new System.Drawing.Point(373, 169);
            this.lblCPFaprovado.Name = "lblCPFaprovado";
            this.lblCPFaprovado.Size = new System.Drawing.Size(14, 20);
            this.lblCPFaprovado.TabIndex = 7;
            this.lblCPFaprovado.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(512, 450);
            this.Controls.Add(this.lblCPFaprovado);
            this.Controls.Add(this.lblcondição);
            this.Controls.Add(this.btngerar);
            this.Controls.Add(this.btnvalidar);
            this.Controls.Add(this.txtgerar);
            this.Controls.Add(this.lblgerador);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.lblcpf);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Sistema CPF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcpf;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label lblgerador;
        private System.Windows.Forms.TextBox txtgerar;
        private System.Windows.Forms.Button btnvalidar;
        private System.Windows.Forms.Button btngerar;
        private System.Windows.Forms.Label lblcondição;
        private System.Windows.Forms.Label lblCPFaprovado;
    }
}

