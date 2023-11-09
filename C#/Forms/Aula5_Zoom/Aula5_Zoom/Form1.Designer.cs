namespace Aula5_Zoom
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_menor = new System.Windows.Forms.Button();
            this.btn_maior = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.pic_picture = new System.Windows.Forms.PictureBox();
            this.open = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Aula5_Zoom.Properties.Resources.AAAABSwy1UUO5XRbka3cZCsQ1qpCdzbud6_P2i1GinUuLZHUUj_cuPJHF7DrjVl2eUFcnED4TAyOTB_pcNityCddVDVe9oke0ZWks8YwkNZ2jPRl;
            this.pictureBox1.Location = new System.Drawing.Point(-6, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btn_menor
            // 
            this.btn_menor.BackColor = System.Drawing.Color.Black;
            this.btn_menor.BackgroundImage = global::Aula5_Zoom.Properties.Resources.pngegg;
            this.btn_menor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_menor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_menor.ForeColor = System.Drawing.Color.Red;
            this.btn_menor.Location = new System.Drawing.Point(359, 525);
            this.btn_menor.Name = "btn_menor";
            this.btn_menor.Size = new System.Drawing.Size(165, 53);
            this.btn_menor.TabIndex = 3;
            this.btn_menor.UseVisualStyleBackColor = false;
            this.btn_menor.Click += new System.EventHandler(this.Btn_menor_Click);
            // 
            // btn_maior
            // 
            this.btn_maior.BackColor = System.Drawing.Color.Black;
            this.btn_maior.BackgroundImage = global::Aula5_Zoom.Properties.Resources.kisspng_signal_clip_art_sina_5ae013ab28ea46_8032885915246345391676;
            this.btn_maior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_maior.ForeColor = System.Drawing.Color.Red;
            this.btn_maior.Location = new System.Drawing.Point(13, 525);
            this.btn_maior.Name = "btn_maior";
            this.btn_maior.Size = new System.Drawing.Size(165, 53);
            this.btn_maior.TabIndex = 2;
            this.btn_maior.UseVisualStyleBackColor = false;
            this.btn_maior.Click += new System.EventHandler(this.Btn_maior_Click);
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.Black;
            this.btn_open.BackgroundImage = global::Aula5_Zoom.Properties.Resources.icone_document_rouge1;
            this.btn_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_open.ForeColor = System.Drawing.Color.Red;
            this.btn_open.Location = new System.Drawing.Point(184, 525);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(169, 53);
            this.btn_open.TabIndex = 1;
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.Btn_open_Click);
            // 
            // pic_picture
            // 
            this.pic_picture.Image = global::Aula5_Zoom.Properties.Resources.patrick_bateman__render__1__by_wtfbooomsh_dfd30qr_fullview;
            this.pic_picture.Location = new System.Drawing.Point(-6, 164);
            this.pic_picture.Name = "pic_picture";
            this.pic_picture.Size = new System.Drawing.Size(543, 335);
            this.pic_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_picture.TabIndex = 0;
            this.pic_picture.TabStop = false;
            // 
            // open
            // 
            this.open.FileName = "openFileDialog1";
            this.open.Filter = "Todasasimagens|*bmp;*.png;*.gif;*.jpg|ImagensPNG|*.png";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(535, 633);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_menor);
            this.Controls.Add(this.btn_maior);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.pic_picture);
            this.Name = "Form1";
            this.Text = "American Psycho";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_picture;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_maior;
        private System.Windows.Forms.Button btn_menor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog open;
    }
}

