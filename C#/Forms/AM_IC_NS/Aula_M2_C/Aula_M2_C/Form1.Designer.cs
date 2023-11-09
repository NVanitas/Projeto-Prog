namespace Aula_M2_C
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
            this.btn_limpar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_time = new System.Windows.Forms.TextBox();
            this.txt_fast = new System.Windows.Forms.TextBox();
            this.txt_dist = new System.Windows.Forms.TextBox();
            this.painel_rgb = new System.Windows.Forms.Panel();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_changecolor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numeric_red = new System.Windows.Forms.NumericUpDown();
            this.numeric_green = new System.Windows.Forms.NumericUpDown();
            this.numeric_blue = new System.Windows.Forms.NumericUpDown();
            this.painel_rgb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_blue)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(66, 289);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(165, 82);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.Btn_calcular_Click);
            this.btn_calcular.MouseEnter += new System.EventHandler(this.Btn_calcular_MouseEnter);
            this.btn_calcular.MouseLeave += new System.EventHandler(this.Btn_calcular_MouseLeave);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(376, 289);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(167, 82);
            this.btn_limpar.TabIndex = 1;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.Btn_limpar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Velocidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tempo:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Distância:";
            // 
            // txt_time
            // 
            this.txt_time.Location = new System.Drawing.Point(237, 129);
            this.txt_time.Name = "txt_time";
            this.txt_time.Size = new System.Drawing.Size(306, 20);
            this.txt_time.TabIndex = 5;
            // 
            // txt_fast
            // 
            this.txt_fast.Enabled = false;
            this.txt_fast.Location = new System.Drawing.Point(237, 177);
            this.txt_fast.Name = "txt_fast";
            this.txt_fast.Size = new System.Drawing.Size(306, 20);
            this.txt_fast.TabIndex = 6;
            // 
            // txt_dist
            // 
            this.txt_dist.Location = new System.Drawing.Point(237, 82);
            this.txt_dist.Name = "txt_dist";
            this.txt_dist.Size = new System.Drawing.Size(306, 20);
            this.txt_dist.TabIndex = 7;
            // 
            // painel_rgb
            // 
            this.painel_rgb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.painel_rgb.Controls.Add(this.numeric_blue);
            this.painel_rgb.Controls.Add(this.numeric_green);
            this.painel_rgb.Controls.Add(this.numeric_red);
            this.painel_rgb.Controls.Add(this.label6);
            this.painel_rgb.Controls.Add(this.label5);
            this.painel_rgb.Controls.Add(this.label4);
            this.painel_rgb.Controls.Add(this.btn_confirm);
            this.painel_rgb.Location = new System.Drawing.Point(681, 85);
            this.painel_rgb.Name = "painel_rgb";
            this.painel_rgb.Size = new System.Drawing.Size(443, 289);
            this.painel_rgb.TabIndex = 8;
            this.painel_rgb.Visible = false;
            this.painel_rgb.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(125, 223);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(118, 43);
            this.btn_confirm.TabIndex = 0;
            this.btn_confirm.Text = "Ok";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.Btn_confirm_Click);
            // 
            // btn_changecolor
            // 
            this.btn_changecolor.Location = new System.Drawing.Point(845, 380);
            this.btn_changecolor.Name = "btn_changecolor";
            this.btn_changecolor.Size = new System.Drawing.Size(118, 41);
            this.btn_changecolor.TabIndex = 9;
            this.btn_changecolor.Text = "Mudar Cor";
            this.btn_changecolor.UseVisualStyleBackColor = true;
            this.btn_changecolor.Click += new System.EventHandler(this.Btn_changecolor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vermelho (R):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Verde (G):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Azul (B):";
            // 
            // numeric_red
            // 
            this.numeric_red.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_red.Location = new System.Drawing.Point(201, 32);
            this.numeric_red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_red.Name = "numeric_red";
            this.numeric_red.Size = new System.Drawing.Size(120, 20);
            this.numeric_red.TabIndex = 13;
            this.numeric_red.ValueChanged += new System.EventHandler(this.Numeric_red_ValueChanged);
            // 
            // numeric_green
            // 
            this.numeric_green.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_green.Location = new System.Drawing.Point(201, 77);
            this.numeric_green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_green.Name = "numeric_green";
            this.numeric_green.Size = new System.Drawing.Size(120, 20);
            this.numeric_green.TabIndex = 14;
            this.numeric_green.ValueChanged += new System.EventHandler(this.Numeric_green_ValueChanged);
            // 
            // numeric_blue
            // 
            this.numeric_blue.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numeric_blue.Location = new System.Drawing.Point(201, 121);
            this.numeric_blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numeric_blue.Name = "numeric_blue";
            this.numeric_blue.Size = new System.Drawing.Size(120, 20);
            this.numeric_blue.TabIndex = 15;
            this.numeric_blue.ValueChanged += new System.EventHandler(this.Numeric_blue_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 440);
            this.Controls.Add(this.painel_rgb);
            this.Controls.Add(this.txt_dist);
            this.Controls.Add(this.txt_fast);
            this.Controls.Add(this.txt_time);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_changecolor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_calcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.painel_rgb.ResumeLayout(false);
            this.painel_rgb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_blue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_time;
        private System.Windows.Forms.TextBox txt_fast;
        private System.Windows.Forms.TextBox txt_dist;
        private System.Windows.Forms.Panel painel_rgb;
        private System.Windows.Forms.NumericUpDown numeric_blue;
        private System.Windows.Forms.NumericUpDown numeric_green;
        private System.Windows.Forms.NumericUpDown numeric_red;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_changecolor;
        private System.Windows.Forms.Button btn_confirm;
    }
}

