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

namespace DesktopPIM
{
    public partial class Gerenciamento : Form
    {

        string conectarBD = "Server=fazendatech.database.windows.net;Database=Fazendatech;User Id=fazendatech; Password=Fazenda123";

        public Gerenciamento()
        {
            InitializeComponent();
            this.FormClosed += Consulta_FormClosed;
        }

        private void Consulta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void idProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void botaoPesquisa_Click(object sender, EventArgs e)
        {
            string id = idProduto.Text;

            using (SqlConnection conexao = new SqlConnection(conectarBD))
            {
                try
                {
                    conexao.Open();
                    string query = "SELECT * FROM Produto where ID_produto=" + id;
                    SqlCommand comando = new SqlCommand(query, conexao);
                    SqlDataReader leitor = comando.ExecuteReader();
     

                    while (leitor.Read())
                    {
                        mostrarNomeProduto.Text = leitor["nome"].ToString();
                        mostrarPrecoProduto.Text = leitor["preco"].ToString();
                        mostrarDescProduto.Text = leitor["descricao"].ToString();
                        mostrarQuantidadeProduto.Text = leitor["qtd_disponivel"].ToString();
                        mostrarImagem.ImageLocation = leitor["imagem"].ToString();

                        mostrarNomeProduto.Visible = true;
                        mostrarPrecoProduto.Visible = true;
                        mostrarDescProduto.Visible = true;
                        mostrarQuantidadeProduto.Visible = true;
                    }

                    leitor.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void alterarNomeBotao_Click(object sender, EventArgs e)
        {
            string id = idProduto.Text;
            String novoNome = alterarNomeTexto.Text;

            using (SqlConnection conexao = new SqlConnection(conectarBD))
            {
                try
                {
                    conexao.Open();
                    string query = "UPDATE Produto SET nome='" + novoNome + "'WHERE ID_produto=" + id;
                    SqlCommand comando = new SqlCommand(query, conexao);
                    SqlDataReader leitor = comando.ExecuteReader();

                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void alterarPrecoBotao_Click(object sender, EventArgs e)
        {
            string id = idProduto.Text;
            String novoPreco = alterarPrecoTexto.Text;

            using (SqlConnection conexao = new SqlConnection(conectarBD))
            {
                try
                {
                    conexao.Open();
                    string query = "UPDATE Produto SET preco='" + novoPreco + "'WHERE ID_produto=" + id;
                    SqlCommand comando = new SqlCommand(query, conexao);
                    SqlDataReader leitor = comando.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void alterarDescBotao_Click(object sender, EventArgs e)
        {
            string id = idProduto.Text;
            String novaDesc = alterarDescTexto.Text;

            using (SqlConnection conexao = new SqlConnection(conectarBD))
            {
                try
                {
                    conexao.Open();
                    string query = "UPDATE Produto SET descricao='" + novaDesc + "'WHERE ID_produto=" + id;
                    SqlCommand comando = new SqlCommand(query, conexao);
                    SqlDataReader leitor = comando.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void alterarQtdBotao_Click(object sender, EventArgs e)
        {
            string id = idProduto.Text;
            String novaQtd = alterarQtdTexto.Text;

            using (SqlConnection conexao = new SqlConnection(conectarBD))
            {
                try
                {
                    conexao.Open();
                    string query = "UPDATE Produto SET qtd_disponivel='" + novaQtd + "'WHERE ID_produto=" + id;
                    SqlCommand comando = new SqlCommand(query, conexao);
                    SqlDataReader leitor = comando.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

     
    }
}
