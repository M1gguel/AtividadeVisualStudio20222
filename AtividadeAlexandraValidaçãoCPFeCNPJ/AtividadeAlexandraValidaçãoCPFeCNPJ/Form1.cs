using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AtividadeAlexandraValidaçãoCPFeCNPJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnValidar_Click(object sender, EventArgs e)
        {
            if (RdCPF.Checked)
            {
                string cpf = CpfOuCnpj.Text;
                string cpfSemCaracteres = cpf.Replace(".", "").Replace("-", "");
                int numero;

                int[] cpfInt = cpfSemCaracteres.Select(digito => Convert.ToInt32(digito.ToString())).ToArray();
                int soma1 = 0, soma2 = 0;
                int resto1 = 0, resto2 = 0;

                for (int i = 0; i < 9; i++)
                {
                    soma1 += cpfInt[i] * (10 - i);
                    resto1 = (soma1 * 10) % 11;
                }

                for (int i = 0; i < 10; i++)
                {
                    soma2 += cpfInt[i] * (11 - i);
                    resto2 = (soma2 * 10) % 11;
                }

                resto1 = (resto1 == 10 || resto1 == 11) ? 0 : resto1;
                resto2 = (resto2 == 10 || resto2 == 11) ? 0 : resto2;

                string cpfFormatado = $"{cpf.Substring(0, 3)}.{cpf.Substring(3, 3)}.{cpf.Substring(6, 3)}-{cpf.Substring(9, 2)}";

                if (resto1 == cpfInt[9] && resto2 == cpfInt[10])

                {
                    MessageBox.Show("Seu CPF é válido", "CPF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else

                {
                    MessageBox.Show("Seu CPF é inválido, Tente novamente", "CPF", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }

            if (RdCNPJ.Checked)
            {
                int[] peso1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] peso2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

                string cnpj = CpfOuCnpj.Text;

                int[] numerosInteiro = cnpj.Select(digito => Convert.ToInt32(digito.ToString())).ToArray();

                int soma1 = 0;

                for (int i = 0; i < 12; i++)
                {
                    soma1 += numerosInteiro[i] * peso1[i];
                }

                int resto1 = soma1 % 11;

                if (resto1 < 2)
                {
                    resto1 = 0;
                }
                else
                {
                    resto1 = 11 - resto1;
                }

                int soma2 = 0;

                for (int i = 0; i < 13; i++)
                {
                    soma2 += numerosInteiro[i] * peso2[i];
                }

                int resto2 = soma2 % 11;

                if (resto2 < 2)
                {
                    resto2 = 0;
                }
                else
                {
                    resto2 = 11 - resto2;
                }

                string cnpjFormatado = $"{cnpj.Substring(0, 2)}.{cnpj.Substring(2, 3)}.{cnpj.Substring(5, 3)}/{cnpj.Substring(8, 4)}-{cnpj.Substring(12, 2)}";

                if (resto1 == numerosInteiro[12] && resto2 == numerosInteiro[13])
                {
                    MessageBox.Show("Seu CNPJ é válido", "CNPJ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Seu CNPJ é inválido, Tente novamente", "CNPJ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
        
    



            

        
        
   

