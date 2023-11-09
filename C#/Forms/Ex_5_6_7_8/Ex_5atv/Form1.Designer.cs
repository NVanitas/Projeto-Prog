namespace Ex_5atv
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
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_calcular_n = new System.Windows.Forms.Button();
            this.btn_calcular_c = new System.Windows.Forms.Button();
            this.btn_calcular_calota = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(161, 76);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(177, 67);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "Calcular Altura";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_calcular_n
            // 
            this.btn_calcular_n.Location = new System.Drawing.Point(161, 149);
            this.btn_calcular_n.Name = "btn_calcular_n";
            this.btn_calcular_n.Size = new System.Drawing.Size(177, 67);
            this.btn_calcular_n.TabIndex = 1;
            this.btn_calcular_n.Text = "Calcular Newton";
            this.btn_calcular_n.UseVisualStyleBackColor = true;
            this.btn_calcular_n.Click += new System.EventHandler(this.btn_calcular_n_Click);
            // 
            // btn_calcular_c
            // 
            this.btn_calcular_c.Location = new System.Drawing.Point(161, 222);
            this.btn_calcular_c.Name = "btn_calcular_c";
            this.btn_calcular_c.Size = new System.Drawing.Size(177, 67);
            this.btn_calcular_c.TabIndex = 2;
            this.btn_calcular_c.Text = "Calcular Coroa";
            this.btn_calcular_c.UseVisualStyleBackColor = true;
            this.btn_calcular_c.Click += new System.EventHandler(this.btn_calcular_c_Click);
            // 
            // btn_calcular_calota
            // 
            this.btn_calcular_calota.Location = new System.Drawing.Point(161, 295);
            this.btn_calcular_calota.Name = "btn_calcular_calota";
            this.btn_calcular_calota.Size = new System.Drawing.Size(177, 59);
            this.btn_calcular_calota.TabIndex = 3;
            this.btn_calcular_calota.Text = "Calcular Calota";
            this.btn_calcular_calota.UseVisualStyleBackColor = true;
            this.btn_calcular_calota.Click += new System.EventHandler(this.btn_calcular_calota_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_calcular_calota);
            this.Controls.Add(this.btn_calcular_c);
            this.Controls.Add(this.btn_calcular_n);
            this.Controls.Add(this.btn_calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_calcular_n;
        private System.Windows.Forms.Button btn_calcular_c;
        private System.Windows.Forms.Button btn_calcular_calota;
    }
}

