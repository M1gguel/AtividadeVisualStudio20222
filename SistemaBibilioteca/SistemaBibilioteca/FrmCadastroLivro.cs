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
        DataGridViewRow RegistroSelecionadoLivro;
        public FrmCadastroLivro()
        {
            InitializeComponent();

            conexaoStringlivro = "Data Source=MAR0625645W10-1;Initial Catalog=Biblioteca;Integrated Security=True";

            conexaoDBLivro = new SqlConnection(conexaoStringlivro);
        }


        private void FrmCadastroLivro_Load(object sender, EventArgs e)
        {
            carregarDadosLivros();


            btnExcluirLivro.Enabled = false;
            btnAdicionarLivro.Enabled = false;

            txtTitulo.TabIndex = 0;
            txtAutor.TabIndex = 1;
            txtNumeroPaginas.TabIndex = 2;
            txtPreco.TabIndex = 3;
            txtAnoPublicacao.TabIndex = 4;
            txtISBN.TabIndex = 5;
            btnAdicionarLivro.TabIndex = 6;
            btnAtualizarLivro.TabIndex = 7;
            btnExcluirLivro.TabIndex = 8;
            txtPesquisaLivro.TabIndex = 9;
            btnPesquisarLivro.TabIndex = 10;
            dgvLivro.TabIndex = 11;
        }

        private void carregarDadosLivros(int id = 0)
        {
            try 
            {
                conexaoDBLivro.Open();

                string sql;

                if (id == 0)
                {
                    sql = "SELECT * FROM Livros";
                }
                else
                {
                    sql = "SELECT * FROM Alunos WHERE ID_Livro=" + id;
                }

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conexaoDBLivro);

                DataTable dataTableLivro = new DataTable();
                adapter.Fill(dataTableLivro);


                dataTableLivro.Columns["iD_Livro"].ColumnName = "ID";
                dataTableLivro.Columns["NumeroPagina"].ColumnName = "Número De Páginas";
                dataTableLivro.Columns["preco"].ColumnName = "Preço";
                dataTableLivro.Columns["AnoPublicacao"].ColumnName = "Ano De Publicação";

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

        private void dgvLivro_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                RegistroSelecionadoLivro = dgvLivro.Rows[e.RowIndex];

                txtTitulo.Text = RegistroSelecionadoLivro.Cells["Titulo"].Value.ToString();
                txtAutor.Text = RegistroSelecionadoLivro.Cells["Autor"].Value.ToString();
                txtNumeroPaginas.Text = RegistroSelecionadoLivro.Cells["Número De Páginas"].Value.ToString();
                txtPreco.Text = RegistroSelecionadoLivro.Cells["Preço"].Value.ToString();
                txtAnoPublicacao.Text = RegistroSelecionadoLivro.Cells["Ano De Publicação"].Value.ToString();
                txtISBN.Text = RegistroSelecionadoLivro.Cells["ISBN"].Value.ToString();

                btnAdicionarLivro.Enabled = false;
                btnAtualizarLivro.Enabled = true;
                btnExcluirLivro.Enabled = true;
            }        
        }

        private void btnAtualizarLivro_Click(object sender, EventArgs e)
        {
            try
            {
                int ID_Livro = Convert.ToInt32(RegistroSelecionadoLivro.Cells["ID"].Value.ToString());
                string sql = "UPDATE Livros SET Titulo=@Titulo,Autor=@Autor,NumeroPagina=@NumeroPagina,preco=@preco,AnoPublicacao=@AnoPublicacao,ISBN=@ISBN WHERE ID_Livro=@ID_Livro";
                conexaoDBLivro.Open();

                SqlCommand sqlcmd2 = new SqlCommand(sql, conexaoDBLivro);

                sqlcmd2.Parameters.AddWithValue("ID_Livro", ID_Livro);
                sqlcmd2.Parameters.AddWithValue("@Titulo", txtTitulo.Text);
                sqlcmd2.Parameters.AddWithValue("@Autor", txtAutor.Text);
                sqlcmd2.Parameters.AddWithValue("@NumeroPagina", txtNumeroPaginas.Text);
                sqlcmd2.Parameters.AddWithValue("@preco", txtPreco.Text);
                sqlcmd2.Parameters.AddWithValue("@AnoPublicacao", txtAnoPublicacao.Text);
                sqlcmd2.Parameters.AddWithValue("@ISBN", txtISBN.Text);

                sqlcmd2.ExecuteNonQuery();

                MessageBox.Show("Sucesso a atualizar o cadastro!");

                conexaoDBLivro.Close();

                carregarDadosLivros();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao atualizar os dados: " + ex);

            }
        }

        private void btnExcluirLivro_Click(object sender, EventArgs e)
        {

            if (RegistroSelecionadoLivro != null)
            {
                DialogResult resultado = MessageBox.Show("Deseja confirmar há excluir o livro?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    try
                    {
                        int ID_Livro = Convert.ToInt32(RegistroSelecionadoLivro.Cells["ID"].Value.ToString());

                        string sql = "DELETE FROM Livros WHERE ID_Livro=@ID_Livro";
                        conexaoDBLivro.Open();
                        SqlCommand sqlCmd = new SqlCommand(sql, conexaoDBLivro);

                        sqlCmd.Parameters.AddWithValue("ID_Livro", ID_Livro);
                        sqlCmd.ExecuteNonQuery();

                        MessageBox.Show("Livro excluído com Sucesso!");

                        conexaoDBLivro.Close();

                        carregarDadosLivros();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao excluir os dados: " + ex);
                    }
                }
            }
        }

        private void btnPesquisarLivro_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtPesquisaLivro.Text, out id))
            {
                carregarDadosLivros(id);
            }
            else
            {
                MessageBox.Show("Código do aluno inválido");
            }
        }

        private void txtPesquisaLivro_KeyUp(object sender, KeyEventArgs e)
        {
            carregarDadosLivros();
        }
    }
}
