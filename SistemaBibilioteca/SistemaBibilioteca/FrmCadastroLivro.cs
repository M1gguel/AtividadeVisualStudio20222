using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBibilioteca
{
    public partial class FrmCadastroLivro : Form
    {
        public string conexaoStringlivro;
        private SqlConnection conexaoDBLivro;
        public FrmCadastroLivro()
        {
            InitializeComponent();

            conexaoStringlivro = "Data Source=MAR0625645W10-1;Initial Catalog=Biblioteca;Integrated Security=True";

            conexaoDBLivro = new SqlConnection(conexaoStringlivro);
        }


        private void FrmCadastroLivro_Load(object sender, EventArgs e)
        {
            carregarDadosLivros();
        }

        private void carregarDadosLivros()
        {
            try 
            {
                conexaoDBLivro.Open();

                string sql = "SELECT * FROM Livros";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conexaoDBLivro);

                DataTable dataTableLivro = new DataTable();
                adapter.Fill(dataTableLivro);

                dgvLivro.DataSource = dataTableLivro;

                conexaoDBLivro.Close();
            }
            catch (SqlException ex) 
            {
                MessageBox.Show("erro ao carregar os dados: " + ex);
            }

        }

        private void btnAdicionarLivro_Click(object sender, EventArgs e)
        {
            try 
            {
                string sql = "INSERT INTO Livros(Titulo,Autor,NumeroPagina,preco,AnoPublicacao,ISBN) VALUES(@Titulo,@Autor,@NumeroPagina,@preco,@AnoPublicacao,@ISBN)";
                conexaoDBLivro.Open();

                SqlCommand sqlcmd2 = new SqlCommand(sql, conexaoDBLivro);

                sqlcmd2.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                sqlcmd2.Parameters.AddWithValue("@Autor",  txtAutor.Text);
                sqlcmd2.Parameters.AddWithValue("@NumeroPagina", txtNumeroPaginas.Text);
                sqlcmd2.Parameters.AddWithValue("@preco", txtPreco.Text);

                DateTime anopublicacao;
                DateTime.TryParse(txtAnoPublicacao.Text, out anopublicacao);

                sqlcmd2.Parameters.AddWithValue("@AnoPublicacao", anopublicacao);
                sqlcmd2.Parameters.AddWithValue("@ISBN", txtISBN.Text);                 

                sqlcmd2.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso!");

                conexaoDBLivro.Close();

                carregarDadosLivros();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao inserir os dados: " + ex);

            }
        }
    }
}
