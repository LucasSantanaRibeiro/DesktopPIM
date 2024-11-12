namespace DesktopPIM
{
    partial class Menu
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
            this.botaoGerenciamentoAdm = new System.Windows.Forms.Button();
            this.botaoGerenciarProdutos = new System.Windows.Forms.Button();
            this.botaoRelatorio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DesktopPIM.Properties.Resources.fazenda;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(346, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // botaoGerenciamentoAdm
            // 
            this.botaoGerenciamentoAdm.Font = new System.Drawing.Font("Arial", 12F);
            this.botaoGerenciamentoAdm.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botaoGerenciamentoAdm.Location = new System.Drawing.Point(346, 324);
            this.botaoGerenciamentoAdm.Name = "botaoGerenciamentoAdm";
            this.botaoGerenciamentoAdm.Size = new System.Drawing.Size(423, 62);
            this.botaoGerenciamentoAdm.TabIndex = 7;
            this.botaoGerenciamentoAdm.Text = "Gerenciamento de Administradores";
            this.botaoGerenciamentoAdm.UseVisualStyleBackColor = true;
            this.botaoGerenciamentoAdm.Click += new System.EventHandler(this.botaoGerenciamentoAdm_Click);
            // 
            // botaoGerenciarProdutos
            // 
            this.botaoGerenciarProdutos.Font = new System.Drawing.Font("Arial", 12F);
            this.botaoGerenciarProdutos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botaoGerenciarProdutos.Location = new System.Drawing.Point(346, 207);
            this.botaoGerenciarProdutos.Name = "botaoGerenciarProdutos";
            this.botaoGerenciarProdutos.Size = new System.Drawing.Size(423, 68);
            this.botaoGerenciarProdutos.TabIndex = 8;
            this.botaoGerenciarProdutos.Text = "Gerenciamento de Produtos";
            this.botaoGerenciarProdutos.UseVisualStyleBackColor = true;
            this.botaoGerenciarProdutos.Click += new System.EventHandler(this.botaoConsulta_Click);
            // 
            // botaoRelatorio
            // 
            this.botaoRelatorio.Font = new System.Drawing.Font("Arial", 12F);
            this.botaoRelatorio.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botaoRelatorio.Location = new System.Drawing.Point(346, 435);
            this.botaoRelatorio.Name = "botaoRelatorio";
            this.botaoRelatorio.Size = new System.Drawing.Size(423, 62);
            this.botaoRelatorio.TabIndex = 9;
            this.botaoRelatorio.Text = "Relatório de Produtos";
            this.botaoRelatorio.UseVisualStyleBackColor = true;
            this.botaoRelatorio.Click += new System.EventHandler(this.botaoRelatorio_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1064, 661);
            this.Controls.Add(this.botaoRelatorio);
            this.Controls.Add(this.botaoGerenciarProdutos);
            this.Controls.Add(this.botaoGerenciamentoAdm);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botaoGerenciamentoAdm;
        private System.Windows.Forms.Button botaoGerenciarProdutos;
        private System.Windows.Forms.Button botaoRelatorio;
    }
}