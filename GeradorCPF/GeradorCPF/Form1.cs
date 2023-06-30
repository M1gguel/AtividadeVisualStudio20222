using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeradorCPF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnvalidar_Click(object sender, EventArgs e)
        {
            bool ValidarCPF(string cpf)
            {
                int soma1 = 0;
                for (int i = 0; i < 9; i++)
                {
                    soma1 += (cpf[i] - '0') * (10 - i);
                }

                int resto1 = soma1 % 11;
                int digitoVerificador1 = resto1 < 2 ? 0 : 11 - resto1;

                if ((cpf[9] - '0') != digitoVerificador1)
                {
                    return false;
                }

                int soma2 = 0;
                for (int i = 0; i < 10; i++)
                {
                    soma2 += (cpf[i] - '0') * (11 - i);
                }

                int resto2 = soma2 % 11;
                int digitoVerificador2 = resto2 < 2 ? 0 : 11 - resto2;

                if ((cpf[10] - '0') != digitoVerificador2)
                {
                    return false;
                    txtCPF.Text = cpf.ToString();

                    if ()
                    {
                        lblCPFaprovado.Text = "Aprovado";
                        lblCPFaprovado.ForeColor = Color.Green;
                    }
                    else
                    {
                        lblCPFaprovado.Text = "Reprovado";
                        lblCPFaprovado.ForeColor = Color.Red;
                    }   
                }

                return true;
            }
        }
    }
}