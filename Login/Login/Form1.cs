using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {        
            string UsuarioTemp = txtUsuario.Text;
            string SenhaTemp = txtSenha.Text;

            List<string> listaDeCadastros = new List<string>();
            listaDeCadastros.Add("sonic4666");

            List<string> listaDeSenhas = new List<string>();
            listaDeSenhas.Add("soniceosaneis");

            if (listaDeCadastros.Contains(UsuarioTemp) && listaDeSenhas.Contains(SenhaTemp)) 
            {
                MessageBox.Show("O login foi feito com sucesso!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("O Login está inválido, Tente Novamente", "Login" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }    

    }
}
