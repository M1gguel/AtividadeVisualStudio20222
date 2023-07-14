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
        DataGridViewRow RegistroSelecionado;
    
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

            btnExcluirAluno.Enabled = false;
            btnAtualizarAluno.Enabled = false;

            txtNome.TabIndex = 0;
            TxtCPF.TabIndex = 1;
            txtEmail.TabIndex = 2;
            TxtDateNascimento.TabIndex = 3;
            txtTelefone.TabIndex = 4;
            txtCelular.TabIndex = 5;
            btnAdcionarAluno.TabIndex = 6;
            btnAtualizarAluno.TabIndex = 7;
            btnExcluirAluno.TabIndex = 8;
            txtPesquisarAluno.TabIndex = 9;
            btnPesquisarAluno.TabIndex = 10;
            dgvAlunos.TabIndex = 11;
        }

        private void carregarDadosAlunos(int id = 0)
        {
            try
            {
                conexaoDB.Open();
                string sql;
                if (id  == 0)
                {
                    sql = "SELECT * FROM Alunos";
                }
                else
                {
                    sql = "SELECT * FROM Alunos WHERE ID_Aluno="+id;
                }
               

                SqlDataAdapter adapter = new SqlDataAdapter (sql, conexaoDB);

                DataTable dataTable = new DataTable();
                adapter.Fill (dataTable);

                dataTable.Columns["ID_Aluno"].ColumnName = "ID";
                dataTable.Columns["Data_Nascimento"].ColumnName = "Data De Nascimento";

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

        private void dgvAlunos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if  (e.RowIndex >= 0) 
            {
                RegistroSelecionado = dgvAlunos.Rows[e.RowIndex];

                txtNome.Text = RegistroSelecionado.Cells["Nome"].Value.ToString();
                TxtCPF.Text = RegistroSelecionado.Cells["CPF"].Value.ToString();
                txtEmail.Text = RegistroSelecionado.Cells["Email"].Value.ToString();
                txtTelefone.Text = RegistroSelecionado.Cells["Telefone"].Value.ToString();
                txtCelular.Text = RegistroSelecionado.Cells["Celular"].Value.ToString();
                TxtDateNascimento.Text = RegistroSelecionado.Cells["Data De Nascimento"].Value.ToString();

                btnAdcionarAluno.Enabled = false;
                btnAtualizarAluno.Enabled = true;
                btnExcluirAluno.Enabled = true;
            }         
        }

        private void btnAtualizarAluno_Click(object sender, EventArgs e)
        {
            try
            {
                int ID_Aluno = Convert.ToInt32(RegistroSelecionado.Cells["ID"].Value.ToString());

                string sql = "UPDATE Alunos SET Nome=@Nome,CPF=@CPF,Email=@Email,Telefone=@Telefone,Celular=@Celular,Data_Nascimento=@Data_Nascimento WHERE ID_Aluno=@ID_Aluno";
                conexaoDB.Open();
                SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                sqlCmd.Parameters.AddWithValue("ID_Aluno", ID_Aluno);
                sqlCmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                sqlCmd.Parameters.AddWithValue("@CPF", TxtCPF.Text);
                sqlCmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                sqlCmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text);
                sqlCmd.Parameters.AddWithValue("@Celular", txtCelular.Text);
                DateTime dataNascimento;
                DateTime.TryParse(TxtDateNascimento.Text, out dataNascimento);
                sqlCmd.Parameters.AddWithValue("@Data_Nascimento", dataNascimento);

                sqlCmd.ExecuteNonQuery();

                MessageBox.Show("Sucesso a atualizar o cadastro!");

                conexaoDB.Close();

                carregarDadosAlunos();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Erro ao atualizar os dados: " + ex);
            }
        }

        private void btnExcluirAluno_Click(object sender, EventArgs e)
        {
            if (RegistroSelecionado != null) 
            {
                DialogResult resultado = MessageBox.Show("Deseja confirmar há excluir o aluno?","Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes) 
                {
                    try
                    {
                        int ID_Aluno = Convert.ToInt32(RegistroSelecionado.Cells["ID"].Value.ToString());

                        string sql = "DELETE FROM Alunos WHERE ID_Aluno=@ID_Aluno";
                        conexaoDB.Open();
                        SqlCommand sqlCmd = new SqlCommand(sql, conexaoDB);

                        sqlCmd.Parameters.AddWithValue("ID_Aluno", ID_Aluno);                     
                        sqlCmd.ExecuteNonQuery();

                        MessageBox.Show("Aluno excluído com Sucesso!");

                        conexaoDB.Close();

                        carregarDadosAlunos();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao excluir os dados: " + ex);
                    }
                }
            }
        }

        private void btnPesquisarAluno_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(txtPesquisarAluno.Text, out id))
            {
                carregarDadosAlunos(id);
            }
            else 
            {
                MessageBox.Show("Código do aluno inválido");
            }
        }

        private void txtPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            carregarDadosAlunos();
        }
    }
}