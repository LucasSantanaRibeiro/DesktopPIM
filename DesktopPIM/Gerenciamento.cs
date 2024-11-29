using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void Gerenciamento_Load(object sender, EventArgs e)
        {

        }

        private void botaoAdicionar_Click(object sender, EventArgs e)
        {

            String nome = adicionarNome.Text;
            String desc = adicionarDesc.Text;
            String imagem = adicionarImagem.Text;
            int id; int.TryParse(adicionarID.Text, out id);
            float preco; float.TryParse(adicionarPreco.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out preco);
            int qtd; int.TryParse(adicionarQtd.Text, out qtd);

            using (SqlConnection conexao = new SqlConnection(conectarBD))
            {
                try
                {
                    conexao.Open();
                    string query = "INSERT INTO Produto (ID_produto, nome, preco, descricao, qtd_disponivel, imagem) VALUES (@id, @nome, @preco, @descricao, @qtd_disponivel, @imagem)";
                    SqlCommand comando = new SqlCommand(query, conexao);

                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@nome", nome);
                    comando.Parameters.AddWithValue("@preco", preco);
                    comando.Parameters.AddWithValue("@descricao", desc);
                    comando.Parameters.AddWithValue("@qtd_disponivel", qtd);
                    comando.Parameters.AddWithValue("@imagem", imagem);

                    int linhasAfetadas = comando.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                    MessageBox.Show("Produto adicionado com sucesso!");
                    adicionarNome.Clear();
                    adicionarDesc.Clear();
                    adicionarImagem.Clear();
                    adicionarID.Clear();
                    adicionarPreco.Clear();
                    adicionarQtd.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Algo deu errado. Verifique os dados.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void botaoExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você tem certeza que deseja excluir este produto?","Confirmar Exclusão",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                try
                {
                    string id = idProduto.Text;

                    using (SqlConnection conexao = new SqlConnection(conectarBD))
                    {
                        conexao.Open();

                        string query = "DELETE FROM Produto WHERE ID_produto = @id";
                        SqlCommand comando = new SqlCommand(query, conexao);
                        comando.Parameters.AddWithValue("@id", id);

                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas > 0)
                        {
                            MessageBox.Show("Produto excluído com sucesso!");
                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado ou não foi possível excluir.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("A exclusão foi cancelada.");
            }
        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }

        private void alterarImagemBotao_Click(object sender, EventArgs e)
        {

            string id = idProduto.Text;
            String novaImagem = alterarImagemTexto.Text;

            using (SqlConnection conexao = new SqlConnection(conectarBD))
            {
                try
                {
                    conexao.Open();
                    string query = "UPDATE Produto SET imagem='" + novaImagem + "'WHERE ID_produto=" + id;
                    SqlCommand comando = new SqlCommand(query, conexao);
                    SqlDataReader leitor = comando.ExecuteReader();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void adicionarImagem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
