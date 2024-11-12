using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopPIM
{
    public partial class Produtos : Form
    {

        string conectarBD = "Server=fazendatech.database.windows.net;Database=Fazendatech;User Id=fazendatech; Password=Fazenda123";

        public Produtos()
        {
            InitializeComponent();
            CarregarDados();
            ConfigurarColunas();
            this.FormClosed += Produtos_FormClosed;
        }

        private void Produtos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Produtos_Load(object sender, EventArgs e)
        {

        }

        private void CarregarDados()
        {
            using (SqlConnection conexao = new SqlConnection(conectarBD))
            {
                try
                {
                    conexao.Open();
                    string query = "SELECT ID_produto, nome, preco, descricao,qtd_disponivel FROM Produto";
                    SqlCommand comando = new SqlCommand(query, conexao);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    dataGridView1.DataSource = tabela;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ConfigurarColunas()
        {

            dataGridView1.Columns["nome"].Width = 150;
            dataGridView1.Columns["preco"].Width = 100;
            dataGridView1.Columns["descricao"].Width = 283;
            dataGridView1.Columns["qtd_disponivel"].Width = 100;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }

        private void botaoVoltar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}
