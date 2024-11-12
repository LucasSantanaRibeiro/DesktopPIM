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
    public partial class GerenciamentoAdm : Form
    {

        string conectarBD = "Server=fazendatech.database.windows.net;Database=Fazendatech;User Id=fazendatech; Password=Fazenda123";
        public GerenciamentoAdm()
        {
            InitializeComponent();
            CarregarDados();
            ConfigurarColunas();
            MascararSenhaComAsteriscos();
            this.FormClosed += Adm_FormClosed;
        }

        private void GerenciamentoAdm_Load(object sender, EventArgs e)
        {

        }

        private void Adm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CarregarDados()
        {
            using (SqlConnection conexao = new SqlConnection(conectarBD))
            {
                try
                {
                    conexao.Open();
                    string query = "SELECT id, nome, email, senha FROM Administradores";
                    SqlCommand comando = new SqlCommand(query, conexao);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tabela = new DataTable();
                    adaptador.Fill(tabela);
                    dataGridView1.ReadOnly = true;
                    dataGridView1.DataSource = tabela;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void MascararSenhaComAsteriscos()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["senha"].Value != null)
                {
                    row.Cells["senha"].Value = new string('*', row.Cells["senha"].Value.ToString().Length);
                }
            }
        }

        private void ConfigurarColunas()
        {

            dataGridView1.Columns["id"].Width = 50; 
            dataGridView1.Columns["nome"].Width = 100; 
            dataGridView1.Columns["email"].Width = 150;
            dataGridView1.Columns["senha"].Width = 150;
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
