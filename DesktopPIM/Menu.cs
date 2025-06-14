﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopPIM
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            this.FormClosed += Menu_FormClosed;
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void botaoConsulta_Click(object sender, EventArgs e)
        {
            Gerenciamento gerenciamento = new Gerenciamento();
            gerenciamento.Show();
            this.Hide();
        }

        private void botaoGerenciamentoAdm_Click(object sender, EventArgs e)
        {
            GerenciamentoAdm gerenciamentoadm = new GerenciamentoAdm();
            gerenciamentoadm.Show();
            this.Hide();
        }

        private void botaoRelatorio_Click(object sender, EventArgs e)
        {
            Produtos produtos = new Produtos();
            produtos.Show();
            this.Hide();
        }
    }
}
