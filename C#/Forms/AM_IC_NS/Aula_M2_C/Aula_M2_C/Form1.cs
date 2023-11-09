using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_M2_C
{
    public partial class Form1 : Form
    {
        Color originalcolor;


        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_calcular_Click(object sender, EventArgs e)
        {
            double fast, time, dist;

            time = Convert.ToDouble(txt_time.Text);
            dist = Convert.ToDouble(txt_dist.Text);

            fast = dist / time;

            txt_fast.Text = Convert.ToString(fast);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            originalcolor = btn_calcular.BackColor;
        }

        private void Btn_calcular_MouseEnter(object sender, EventArgs e)
        {
            btn_calcular.BackColor = Color.Black;
            btn_calcular.ForeColor = Color.White;
        }

        private void Btn_calcular_MouseLeave(object sender, EventArgs e)
        {
            btn_calcular.BackColor = originalcolor;
            btn_calcular.ForeColor = Color.Black;
        }

        private void Btn_limpar_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_confirm_Click(object sender, EventArgs e)
        {
            this.BackColor = painel_rgb.BackColor;
            painel_rgb.Visible = false;
        }

        private void Btn_changecolor_Click(object sender, EventArgs e)
        {   
            painel_rgb.Visible = true;
        }

        private void Numeric_red_ValueChanged(object sender, EventArgs e)
        {
            painel_rgb.BackColor = Color.FromArgb(Convert.ToInt16(numeric_red.Value),
                                                  Convert.ToInt16(numeric_green.Value),
                                                  Convert.ToInt16(numeric_blue.Value));
        }

        private void Numeric_green_ValueChanged(object sender, EventArgs e)
        {
            painel_rgb.BackColor = Color.FromArgb(Convert.ToInt16(numeric_red.Value),
                                                  Convert.ToInt16(numeric_green.Value),
                                                  Convert.ToInt16(numeric_blue.Value));
        }

        private void Numeric_blue_ValueChanged(object sender, EventArgs e)
        {
            painel_rgb.BackColor = Color.FromArgb(Convert.ToInt16(numeric_red.Value),
                                                  Convert.ToInt16(numeric_green.Value),
                                                  Convert.ToInt16(numeric_blue.Value));
        }
    }
}
