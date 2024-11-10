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
            this.botaoGerenciar = new System.Windows.Forms.Button();
            this.botaoConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DesktopPIM.Properties.Resources.fazenda;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(324, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // botaoGerenciar
            // 
            this.botaoGerenciar.Font = new System.Drawing.Font("Arial", 12F);
            this.botaoGerenciar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botaoGerenciar.Location = new System.Drawing.Point(174, 341);
            this.botaoGerenciar.Name = "botaoGerenciar";
            this.botaoGerenciar.Size = new System.Drawing.Size(277, 56);
            this.botaoGerenciar.TabIndex = 7;
            this.botaoGerenciar.Text = "Gerenciamento";
            this.botaoGerenciar.UseVisualStyleBackColor = true;
            // 
            // botaoConsulta
            // 
            this.botaoConsulta.Font = new System.Drawing.Font("Arial", 12F);
            this.botaoConsulta.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.botaoConsulta.Location = new System.Drawing.Point(626, 341);
            this.botaoConsulta.Name = "botaoConsulta";
            this.botaoConsulta.Size = new System.Drawing.Size(277, 56);
            this.botaoConsulta.TabIndex = 8;
            this.botaoConsulta.Text = "Consulta";
            this.botaoConsulta.UseVisualStyleBackColor = true;
            this.botaoConsulta.Click += new System.EventHandler(this.botaoConsulta_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1039, 573);
            this.Controls.Add(this.botaoConsulta);
            this.Controls.Add(this.botaoGerenciar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button botaoGerenciar;
        private System.Windows.Forms.Button botaoConsulta;
    }
}