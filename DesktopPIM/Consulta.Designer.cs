namespace DesktopPIM
{
    partial class Consulta
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DesktopPIM.Properties.Resources.fazenda;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(533, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Id do produto";
            // 
            // idProduto
            // 
            this.idProduto.Location = new System.Drawing.Point(537, 53);
            this.idProduto.Name = "idProduto";
            this.idProduto.Size = new System.Drawing.Size(124, 20);
            this.idProduto.TabIndex = 8;
            this.idProduto.TextChanged += new System.EventHandler(this.idProduto_TextChanged);
            // 
            // botaoPesquisa
            // 
            this.botaoPesquisa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoPesquisa.Location = new System.Drawing.Point(537, 99);
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
            this.label2.Location = new System.Drawing.Point(70, 256);
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
            this.label3.Location = new System.Drawing.Point(69, 319);
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
            this.label4.Location = new System.Drawing.Point(69, 379);
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
            this.label5.Location = new System.Drawing.Point(66, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 23);
            this.label5.TabIndex = 16;
            this.label5.Text = "Quantidade disponivel";
            // 
            // mostrarNomeProduto
            // 
            this.mostrarNomeProduto.AutoSize = true;
            this.mostrarNomeProduto.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarNomeProduto.ForeColor = System.Drawing.Color.White;
            this.mostrarNomeProduto.Location = new System.Drawing.Point(289, 256);
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
            this.mostrarPrecoProduto.Location = new System.Drawing.Point(289, 319);
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
            this.mostrarDescProduto.Location = new System.Drawing.Point(289, 379);
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
            this.mostrarQuantidadeProduto.Location = new System.Drawing.Point(289, 443);
            this.mostrarQuantidadeProduto.Name = "mostrarQuantidadeProduto";
            this.mostrarQuantidadeProduto.Size = new System.Drawing.Size(43, 23);
            this.mostrarQuantidadeProduto.TabIndex = 20;
            this.mostrarQuantidadeProduto.Text = "Qtd";
            this.mostrarQuantidadeProduto.Visible = false;
            // 
            // Gerenciamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1041, 585);
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
            this.Text = "Gerenciamento";
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
    }
}