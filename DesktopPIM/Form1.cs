using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DesktopPIM
{
    public partial class FazendaTech : Form
    {

        string conectarBD = "Server=LAPTOP-UJ4JFIKG;Database=master;User Id=mauro; Password=123456";
        public FazendaTech()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void botaoLogin_Click(object sender, EventArgs e)
        {
            string usuario = campoUsuario.Text;
            string senha = campoSenha.Text;

            if (usuario == "" || senha == "")
            {
                MessageBox.Show("Nenhum campo pode estar vazio");
                return;
            }

            using(SqlConnection conexao = new SqlConnection(conectarBD)) 
            { 
                try
                {
                    conexao.Open();
                    string query = "SELECT * FROM Administradores";
                    SqlCommand comando = new SqlCommand(query, conexao);
                    SqlDataReader leitor = comando.ExecuteReader();

                    bool loginValido = false;

                    while (leitor.Read())
                    {
                        string usuarioBD = leitor["Email"].ToString();
                        string senhaBD = leitor["Senha"].ToString();

                        if (usuario == usuarioBD && senha == senhaBD)
                        {
                            MessageBox.Show("Login Concluido");
                            Gerenciamento gerenciamento = new Gerenciamento();
                            gerenciamento.Show();
                            this.Hide();
                            loginValido = true;
                            break;
                        }
                    }
                    leitor.Close();

                    if (!loginValido)
                    {
                        MessageBox.Show("Usuario ou senha incorretos");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void FazendaTech_Load(object sender, EventArgs e)
        {

        }
    }
}
