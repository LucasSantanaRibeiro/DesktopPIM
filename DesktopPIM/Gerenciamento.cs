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

        string conectarBD = "Server=LAPTOP-UJ4JFIKG;Database=master;User Id=mauro; Password=123456";

        public Gerenciamento()
        {
            InitializeComponent();
            this.FormClosed += Gerenciamento_FormClosed;
        }

        private void Gerenciamento_FormClosed(object sender, FormClosedEventArgs e)
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
    }
}
