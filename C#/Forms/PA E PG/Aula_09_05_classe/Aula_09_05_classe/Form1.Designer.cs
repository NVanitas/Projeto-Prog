namespace Aula_09_05_classe
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
            this.btn_quadrado = new System.Windows.Forms.Button();
            this.btn_retangulo = new System.Windows.Forms.Button();
            this.btn_cilindro = new System.Windows.Forms.Button();
            this.btn_paralelepipedo = new System.Windows.Forms.Button();
            this.btn_divisao = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fatorial = new System.Windows.Forms.Button();
            this.btn_pa = new System.Windows.Forms.Button();
            this.btn_pg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_quadrado
            // 
            this.btn_quadrado.Location = new System.Drawing.Point(71, 45);
            this.btn_quadrado.Name = "btn_quadrado";
            this.btn_quadrado.Size = new System.Drawing.Size(195, 63);
            this.btn_quadrado.TabIndex = 0;
            this.btn_quadrado.Text = "Quadrado";
            this.btn_quadrado.UseVisualStyleBackColor = true;
            this.btn_quadrado.Click += new System.EventHandler(this.Btn_quadrado_Click);
            // 
            // btn_retangulo
            // 
            this.btn_retangulo.Location = new System.Drawing.Point(71, 154);
            this.btn_retangulo.Name = "btn_retangulo";
            this.btn_retangulo.Size = new System.Drawing.Size(195, 63);
            this.btn_retangulo.TabIndex = 1;
            this.btn_retangulo.Text = "Retângulo";
            this.btn_retangulo.UseVisualStyleBackColor = true;
            this.btn_retangulo.Click += new System.EventHandler(this.Btn_retangulo_Click);
            // 
            // btn_cilindro
            // 
            this.btn_cilindro.Location = new System.Drawing.Point(71, 262);
            this.btn_cilindro.Name = "btn_cilindro";
            this.btn_cilindro.Size = new System.Drawing.Size(195, 68);
            this.btn_cilindro.TabIndex = 2;
            this.btn_cilindro.Text = "Cilindro";
            this.btn_cilindro.UseVisualStyleBackColor = true;
            this.btn_cilindro.Click += new System.EventHandler(this.Btn_cilindro_Click);
            // 
            // btn_paralelepipedo
            // 
            this.btn_paralelepipedo.Location = new System.Drawing.Point(71, 356);
            this.btn_paralelepipedo.Name = "btn_paralelepipedo";
            this.btn_paralelepipedo.Size = new System.Drawing.Size(195, 66);
            this.btn_paralelepipedo.TabIndex = 3;
            this.btn_paralelepipedo.Text = "Paralelepipedo";
            this.btn_paralelepipedo.UseVisualStyleBackColor = true;
            this.btn_paralelepipedo.Click += new System.EventHandler(this.Btn_paralelepipedo_Click);
            // 
            // btn_divisao
            // 
            this.btn_divisao.Location = new System.Drawing.Point(314, 45);
            this.btn_divisao.Name = "btn_divisao";
            this.btn_divisao.Size = new System.Drawing.Size(152, 62);
            this.btn_divisao.TabIndex = 4;
            this.btn_divisao.Text = "Divisão";
            this.btn_divisao.UseVisualStyleBackColor = true;
            this.btn_divisao.Click += new System.EventHandler(this.Btn_divisao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(526, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // btn_fatorial
            // 
            this.btn_fatorial.Location = new System.Drawing.Point(315, 157);
            this.btn_fatorial.Name = "btn_fatorial";
            this.btn_fatorial.Size = new System.Drawing.Size(150, 59);
            this.btn_fatorial.TabIndex = 6;
            this.btn_fatorial.Text = "Fatorial";
            this.btn_fatorial.UseVisualStyleBackColor = true;
            this.btn_fatorial.Click += new System.EventHandler(this.Btn_fatorial_Click);
            // 
            // btn_pa
            // 
            this.btn_pa.Location = new System.Drawing.Point(315, 262);
            this.btn_pa.Name = "btn_pa";
            this.btn_pa.Size = new System.Drawing.Size(150, 68);
            this.btn_pa.TabIndex = 7;
            this.btn_pa.Text = "PA";
            this.btn_pa.UseVisualStyleBackColor = true;
            this.btn_pa.Click += new System.EventHandler(this.Btn_pa_Click);
            // 
            // btn_pg
            // 
            this.btn_pg.Location = new System.Drawing.Point(315, 366);
            this.btn_pg.Name = "btn_pg";
            this.btn_pg.Size = new System.Drawing.Size(151, 56);
            this.btn_pg.TabIndex = 8;
            this.btn_pg.Text = "PG";
            this.btn_pg.UseVisualStyleBackColor = true;
            this.btn_pg.Click += new System.EventHandler(this.Btn_pg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_pg);
            this.Controls.Add(this.btn_pa);
            this.Controls.Add(this.btn_fatorial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_divisao);
            this.Controls.Add(this.btn_paralelepipedo);
            this.Controls.Add(this.btn_cilindro);
            this.Controls.Add(this.btn_retangulo);
            this.Controls.Add(this.btn_quadrado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quadrado;
        private System.Windows.Forms.Button btn_retangulo;
        private System.Windows.Forms.Button btn_cilindro;
        private System.Windows.Forms.Button btn_paralelepipedo;
        private System.Windows.Forms.Button btn_divisao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_fatorial;
        private System.Windows.Forms.Button btn_pa;
        private System.Windows.Forms.Button btn_pg;
    }
}

