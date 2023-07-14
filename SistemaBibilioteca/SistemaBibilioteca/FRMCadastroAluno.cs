using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBibilioteca
{
    public partial class FRMCadastroAluno : Form
    {
        public string conexãoString;
        private SqlConnection conexaoDB;
    
        public FRMCadastroAluno()
        {
            InitializeComponent();

            //String de conexão
            conexãoString = "Data Source=MAR0625645W10-1;Initial Catalog=Biblioteca;Integrated Security=True";

            //Inicializando a conexão com o Banco de dados
            conexaoDB = new SqlConnection(conexãoString);
        }

        private void FRMCadastroAluno_Load(object sender, EventArgs e)
        {
            carregarDadosAlunos();
        }

        private void carregarDadosAlunos()
        {
            try
            {
                conexaoDB.Open();
                string sql = "SELECT * FROM Alunos";

                SqlDataAdapter adapter = new SqlDataAdapter (sql, conexaoDB);

                DataTable dataTable = new DataTable();
                adapter.Fill (dataTable);

                dgvAlunos.DataSource = dataTable;

                conexaoDB.Close();
            }
            catch (SqlException ex)  
            {
                MessageBox.Show("erro ao carregar os dados: " + ex);
            }
        }

        private void btnAdcionarAluno_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO Alunos(Nome,CPF,Email,Telefone,Celular,Data_Nascimento) VALUES(@Nome,@CPF,@Email,@Telefone,@Celular,@Data_Nascimento)";
                conexaoDB.Open();
                SqlCommand sqlCmd = new SqlCommand (sql, conexaoDB);

                sqlCmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                sqlCmd.Parameters.AddWithValue("@CPF", TxtCPF.Text);
                sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                sqlCmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                sqlCmd.Parameters.AddWithValue("@Celular",txtCelular.Text);
                DateTime dataNascimento;
                DateTime.TryParse (TxtDateNascimento.Text, out  dataNascimento);
                sqlCmd.Parameters.AddWithValue("@Data_Nascimento", dataNascimento);

                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso!");

                conexaoDB.Close();

                carregarDadosAlunos();
            }
            catch (SqlException ex) 
            {
                MessageBox.Show ("Erro ao inserir os dados: "+ ex);
            }
        }
    }
}
