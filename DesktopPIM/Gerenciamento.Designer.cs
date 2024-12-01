namespace DesktopPIM
{
    partial class Gerenciamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.idProduto = new System.Windows.Forms.TextBox();
            this.botaoPesquisa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mostrarNomeProduto = new System.Windows.Forms.Label();
            this.mostrarPrecoProduto = new System.Windows.Forms.Label();
            this.mostrarDescProduto = new System.Windows.Forms.Label();
            this.mostrarQuantidadeProduto = new System.Windows.Forms.Label();
            this.alterarNomeTexto = new System.Windows.Forms.TextBox();
            this.alterarNomeBotao = new System.Windows.Forms.Button();
            this.alterarPrecoBotao = new System.Windows.Forms.Button();
            this.alterarPrecoTexto = new System.Windows.Forms.TextBox();
            this.alterarDescBotao = new System.Windows.Forms.Button();
            this.alterarDescTexto = new System.Windows.Forms.TextBox();
            this.alterarQtdBotao = new System.Windows.Forms.Button();
            this.alterarQtdTexto = new System.Windows.Forms.TextBox();
            this.mostrarImagem = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.adicionarQtd = new System.Windows.Forms.TextBox();
            this.adicionarDesc = new System.Windows.Forms.TextBox();
            this.botaoAdicionar = new System.Windows.Forms.Button();
            this.adicionarPreco = new System.Windows.Forms.TextBox();
            this.adicionarNome = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.adicionarImagem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.adicionarID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.botaoVoltar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.alterarImagemTexto = new System.Windows.Forms.TextBox();
            this.alterarImagemBotao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mostrarImagem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(299, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id do produto";
            // 
            // idProduto
            // 
            this.idProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.idProduto.Location = new System.Drawing.Point(303, 266);
            this.idProduto.Name = "idProduto";
            this.idProduto.Size = new System.Drawing.Size(124, 20);
            this.idProduto.TabIndex = 8;
            this.idProduto.TextChanged += new System.EventHandler(this.idProduto_TextChanged);
            // 
            // botaoPesquisa
            // 
            this.botaoPesquisa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPesquisa.Location = new System.Drawing.Point(237, 303);
            this.botaoPesquisa.Name = "botaoPesquisa";
            this.botaoPesquisa.Size = new System.Drawing.Size(124, 39);
            this.botaoPesquisa.TabIndex = 9;
            this.botaoPesquisa.Text = "Pesquisar";
            this.botaoPesquisa.UseVisualStyleBackColor = true;
            this.botaoPesquisa.Click += new System.EventHandler(this.botaoPesquisa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(146, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome do produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(423, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Preço do produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(131, 544);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 23);
            this.label4.TabIndex = 14;
            this.label4.Text = "Descrição do produto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(404, 544);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Quantidade disponível";
            // 
            // mostrarNomeProduto
            // 
            this.mostrarNomeProduto.AutoSize = true;
            this.mostrarNomeProduto.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarNomeProduto.ForeColor = System.Drawing.Color.White;
            this.mostrarNomeProduto.Location = new System.Drawing.Point(186, 409);
            this.mostrarNomeProduto.Name = "mostrarNomeProduto";
            this.mostrarNomeProduto.Size = new System.Drawing.Size(61, 23);
            this.mostrarNomeProduto.TabIndex = 17;
            this.mostrarNomeProduto.Text = "Nome";
            this.mostrarNomeProduto.Visible = false;
            // 
            // mostrarPrecoProduto
            // 
            this.mostrarPrecoProduto.AutoSize = true;
            this.mostrarPrecoProduto.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarPrecoProduto.ForeColor = System.Drawing.Color.White;
            this.mostrarPrecoProduto.Location = new System.Drawing.Point(480, 409);
            this.mostrarPrecoProduto.Name = "mostrarPrecoProduto";
            this.mostrarPrecoProduto.Size = new System.Drawing.Size(62, 23);
            this.mostrarPrecoProduto.TabIndex = 18;
            this.mostrarPrecoProduto.Text = "Preço";
            this.mostrarPrecoProduto.Visible = false;
            // 
            // mostrarDescProduto
            // 
            this.mostrarDescProduto.AutoSize = true;
            this.mostrarDescProduto.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarDescProduto.ForeColor = System.Drawing.Color.White;
            this.mostrarDescProduto.Location = new System.Drawing.Point(92, 585);
            this.mostrarDescProduto.Name = "mostrarDescProduto";
            this.mostrarDescProduto.Size = new System.Drawing.Size(55, 23);
            this.mostrarDescProduto.TabIndex = 19;
            this.mostrarDescProduto.Text = "Desc";
            this.mostrarDescProduto.Visible = false;
            // 
            // mostrarQuantidadeProduto
            // 
            this.mostrarQuantidadeProduto.AutoSize = true;
            this.mostrarQuantidadeProduto.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarQuantidadeProduto.ForeColor = System.Drawing.Color.White;
            this.mostrarQuantidadeProduto.Location = new System.Drawing.Point(489, 585);
            this.mostrarQuantidadeProduto.Name = "mostrarQuantidadeProduto";
            this.mostrarQuantidadeProduto.Size = new System.Drawing.Size(43, 23);
            this.mostrarQuantidadeProduto.TabIndex = 20;
            this.mostrarQuantidadeProduto.Text = "Qtd";
            this.mostrarQuantidadeProduto.Visible = false;
            // 
            // alterarNomeTexto
            // 
            this.alterarNomeTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alterarNomeTexto.Location = new System.Drawing.Point(147, 452);
            this.alterarNomeTexto.Name = "alterarNomeTexto";
            this.alterarNomeTexto.Size = new System.Drawing.Size(161, 20);
            this.alterarNomeTexto.TabIndex = 21;
            // 
            // alterarNomeBotao
            // 
            this.alterarNomeBotao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarNomeBotao.Location = new System.Drawing.Point(170, 491);
            this.alterarNomeBotao.Name = "alterarNomeBotao";
            this.alterarNomeBotao.Size = new System.Drawing.Size(107, 34);
            this.alterarNomeBotao.TabIndex = 22;
            this.alterarNomeBotao.Text = "Alterar";
            this.alterarNomeBotao.UseVisualStyleBackColor = true;
            this.alterarNomeBotao.Click += new System.EventHandler(this.alterarNomeBotao_Click);
            // 
            // alterarPrecoBotao
            // 
            this.alterarPrecoBotao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarPrecoBotao.Location = new System.Drawing.Point(449, 491);
            this.alterarPrecoBotao.Name = "alterarPrecoBotao";
            this.alterarPrecoBotao.Size = new System.Drawing.Size(107, 34);
            this.alterarPrecoBotao.TabIndex = 24;
            this.alterarPrecoBotao.Text = "Alterar";
            this.alterarPrecoBotao.UseVisualStyleBackColor = true;
            this.alterarPrecoBotao.Click += new System.EventHandler(this.alterarPrecoBotao_Click);
            // 
            // alterarPrecoTexto
            // 
            this.alterarPrecoTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alterarPrecoTexto.Location = new System.Drawing.Point(424, 448);
            this.alterarPrecoTexto.Name = "alterarPrecoTexto";
            this.alterarPrecoTexto.Size = new System.Drawing.Size(161, 20);
            this.alterarPrecoTexto.TabIndex = 23;
            // 
            // alterarDescBotao
            // 
            this.alterarDescBotao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarDescBotao.Location = new System.Drawing.Point(170, 678);
            this.alterarDescBotao.Name = "alterarDescBotao";
            this.alterarDescBotao.Size = new System.Drawing.Size(107, 34);
            this.alterarDescBotao.TabIndex = 26;
            this.alterarDescBotao.Text = "Alterar";
            this.alterarDescBotao.UseVisualStyleBackColor = true;
            this.alterarDescBotao.Click += new System.EventHandler(this.alterarDescBotao_Click);
            // 
            // alterarDescTexto
            // 
            this.alterarDescTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alterarDescTexto.Location = new System.Drawing.Point(147, 629);
            this.alterarDescTexto.Name = "alterarDescTexto";
            this.alterarDescTexto.Size = new System.Drawing.Size(161, 20);
            this.alterarDescTexto.TabIndex = 25;
            // 
            // alterarQtdBotao
            // 
            this.alterarQtdBotao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarQtdBotao.Location = new System.Drawing.Point(449, 678);
            this.alterarQtdBotao.Name = "alterarQtdBotao";
            this.alterarQtdBotao.Size = new System.Drawing.Size(107, 34);
            this.alterarQtdBotao.TabIndex = 28;
            this.alterarQtdBotao.Text = "Alterar";
            this.alterarQtdBotao.UseVisualStyleBackColor = true;
            this.alterarQtdBotao.Click += new System.EventHandler(this.alterarQtdBotao_Click);
            // 
            // alterarQtdTexto
            // 
            this.alterarQtdTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alterarQtdTexto.Location = new System.Drawing.Point(427, 629);
            this.alterarQtdTexto.Name = "alterarQtdTexto";
            this.alterarQtdTexto.Size = new System.Drawing.Size(161, 20);
            this.alterarQtdTexto.TabIndex = 27;
            // 
            // mostrarImagem
            // 
            this.mostrarImagem.Location = new System.Drawing.Point(635, 570);
            this.mostrarImagem.Name = "mostrarImagem";
            this.mostrarImagem.Size = new System.Drawing.Size(339, 179);
            this.mostrarImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mostrarImagem.TabIndex = 29;
            this.mostrarImagem.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DesktopPIM.Properties.Resources.fazenda;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(635, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 25F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(614, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(429, 39);
            this.label6.TabIndex = 31;
            this.label6.Text = "Gerenciamento de Produtos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(254, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(223, 39);
            this.label7.TabIndex = 32;
            this.label7.Text = "Alterar/Excluir";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 25F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(1086, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(280, 39);
            this.label8.TabIndex = 33;
            this.label8.Text = "Adicionar Produto";
            // 
            // adicionarQtd
            // 
            this.adicionarQtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adicionarQtd.Location = new System.Drawing.Point(1004, 511);
            this.adicionarQtd.Name = "adicionarQtd";
            this.adicionarQtd.Size = new System.Drawing.Size(161, 20);
            this.adicionarQtd.TabIndex = 48;
            // 
            // adicionarDesc
            // 
            this.adicionarDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adicionarDesc.Location = new System.Drawing.Point(1250, 420);
            this.adicionarDesc.Name = "adicionarDesc";
            this.adicionarDesc.Size = new System.Drawing.Size(161, 20);
            this.adicionarDesc.TabIndex = 46;
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoAdicionar.Location = new System.Drawing.Point(1093, 570);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(202, 56);
            this.botaoAdicionar.TabIndex = 45;
            this.botaoAdicionar.Text = "Adicionar";
            this.botaoAdicionar.UseVisualStyleBackColor = true;
            this.botaoAdicionar.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // adicionarPreco
            // 
            this.adicionarPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adicionarPreco.Location = new System.Drawing.Point(1004, 420);
            this.adicionarPreco.Name = "adicionarPreco";
            this.adicionarPreco.Size = new System.Drawing.Size(161, 20);
            this.adicionarPreco.TabIndex = 44;
            // 
            // adicionarNome
            // 
            this.adicionarNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adicionarNome.Location = new System.Drawing.Point(1250, 334);
            this.adicionarNome.Name = "adicionarNome";
            this.adicionarNome.Size = new System.Drawing.Size(161, 20);
            this.adicionarNome.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(986, 467);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(204, 23);
            this.label13.TabIndex = 37;
            this.label13.Text = "Quantidade disponível";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(1233, 381);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(199, 23);
            this.label14.TabIndex = 36;
            this.label14.Text = "Descrição do produto";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(1002, 381);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 23);
            this.label15.TabIndex = 35;
            this.label15.Text = "Preço do produto";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(1249, 285);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(162, 23);
            this.label16.TabIndex = 34;
            this.label16.Text = "Nome do produto";
            // 
            // adicionarImagem
            // 
            this.adicionarImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adicionarImagem.Location = new System.Drawing.Point(1250, 511);
            this.adicionarImagem.Name = "adicionarImagem";
            this.adicionarImagem.Size = new System.Drawing.Size(161, 20);
            this.adicionarImagem.TabIndex = 50;
            this.adicionarImagem.TextChanged += new System.EventHandler(this.adicionarImagem_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1256, 467);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 23);
            this.label9.TabIndex = 49;
            this.label9.Text = "URL da imagem";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // adicionarID
            // 
            this.adicionarID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adicionarID.Location = new System.Drawing.Point(1004, 334);
            this.adicionarID.Name = "adicionarID";
            this.adicionarID.Size = new System.Drawing.Size(161, 20);
            this.adicionarID.TabIndex = 52;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(1019, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 23);
            this.label10.TabIndex = 51;
            this.label10.Text = "ID do produto";
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoExcluir.Location = new System.Drawing.Point(376, 303);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(124, 39);
            this.botaoExcluir.TabIndex = 53;
            this.botaoExcluir.Text = "Excluir";
            this.botaoExcluir.UseVisualStyleBackColor = true;
            this.botaoExcluir.Click += new System.EventHandler(this.botaoExcluir_Click);
            // 
            // botaoVoltar
            // 
            this.botaoVoltar.Font = new System.Drawing.Font("Arial", 12F);
            this.botaoVoltar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botaoVoltar.Location = new System.Drawing.Point(43, 45);
            this.botaoVoltar.Name = "botaoVoltar";
            this.botaoVoltar.Size = new System.Drawing.Size(265, 61);
            this.botaoVoltar.TabIndex = 54;
            this.botaoVoltar.Text = "Voltar ao menu";
            this.botaoVoltar.UseVisualStyleBackColor = true;
            this.botaoVoltar.Click += new System.EventHandler(this.botaoVoltar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(646, 467);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(299, 23);
            this.label11.TabIndex = 55;
            this.label11.Text = "Imagem do produto (inserir URL)";
            // 
            // alterarImagemTexto
            // 
            this.alterarImagemTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alterarImagemTexto.Location = new System.Drawing.Point(711, 501);
            this.alterarImagemTexto.Name = "alterarImagemTexto";
            this.alterarImagemTexto.Size = new System.Drawing.Size(178, 20);
            this.alterarImagemTexto.TabIndex = 56;
            // 
            // alterarImagemBotao
            // 
            this.alterarImagemBotao.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarImagemBotao.Location = new System.Drawing.Point(747, 527);
            this.alterarImagemBotao.Name = "alterarImagemBotao";
            this.alterarImagemBotao.Size = new System.Drawing.Size(107, 34);
            this.alterarImagemBotao.TabIndex = 57;
            this.alterarImagemBotao.Text = "Alterar";
            this.alterarImagemBotao.UseVisualStyleBackColor = true;
            this.alterarImagemBotao.Click += new System.EventHandler(this.alterarImagemBotao_Click);
            // 
            // Gerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1550, 1061);
            this.Controls.Add(this.alterarImagemBotao);
            this.Controls.Add(this.alterarImagemTexto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.botaoVoltar);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.adicionarID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.adicionarImagem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.adicionarQtd);
            this.Controls.Add(this.adicionarDesc);
            this.Controls.Add(this.botaoAdicionar);
            this.Controls.Add(this.adicionarPreco);
            this.Controls.Add(this.adicionarNome);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mostrarImagem);
            this.Controls.Add(this.alterarQtdBotao);
            this.Controls.Add(this.alterarQtdTexto);
            this.Controls.Add(this.alterarDescBotao);
            this.Controls.Add(this.alterarDescTexto);
            this.Controls.Add(this.alterarPrecoBotao);
            this.Controls.Add(this.alterarPrecoTexto);
            this.Controls.Add(this.alterarNomeBotao);
            this.Controls.Add(this.alterarNomeTexto);
            this.Controls.Add(this.mostrarQuantidadeProduto);
            this.Controls.Add(this.mostrarDescProduto);
            this.Controls.Add(this.mostrarPrecoProduto);
            this.Controls.Add(this.mostrarNomeProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.botaoPesquisa);
            this.Controls.Add(this.idProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Gerenciamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciamento";
            this.Load += new System.EventHandler(this.Gerenciamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mostrarImagem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idProduto;
        private System.Windows.Forms.Button botaoPesquisa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label mostrarNomeProduto;
        private System.Windows.Forms.Label mostrarPrecoProduto;
        private System.Windows.Forms.Label mostrarDescProduto;
        private System.Windows.Forms.Label mostrarQuantidadeProduto;
        private System.Windows.Forms.TextBox alterarNomeTexto;
        private System.Windows.Forms.Button alterarNomeBotao;
        private System.Windows.Forms.Button alterarPrecoBotao;
        private System.Windows.Forms.TextBox alterarPrecoTexto;
        private System.Windows.Forms.Button alterarDescBotao;
        private System.Windows.Forms.TextBox alterarDescTexto;
        private System.Windows.Forms.Button alterarQtdBotao;
        private System.Windows.Forms.TextBox alterarQtdTexto;
        private System.Windows.Forms.PictureBox mostrarImagem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox adicionarQtd;
        private System.Windows.Forms.TextBox adicionarDesc;
        private System.Windows.Forms.Button botaoAdicionar;
        private System.Windows.Forms.TextBox adicionarPreco;
        private System.Windows.Forms.TextBox adicionarNome;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox adicionarImagem;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox adicionarID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button botaoExcluir;
        private System.Windows.Forms.Button botaoVoltar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox alterarImagemTexto;
        private System.Windows.Forms.Button alterarImagemBotao;
    }
}