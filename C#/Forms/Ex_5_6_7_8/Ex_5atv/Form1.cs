using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_5atv
{
    public partial class Form1 : Form
    {
        Altura h = new Altura();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            MessageBox.Show(h.Calcular(2, 3).ToString());
        }

        private void btn_calcular_n_Click(object sender, EventArgs e)
        {
            MessageBox.Show(h.Newton(1,2, 3,4).ToString());
        }

        private void btn_calcular_c_Click(object sender, EventArgs e)
        {
            MessageBox.Show(h.Coroa(10, 2).ToString());
        }

        private void btn_calcular_calota_Click(object sender, EventArgs e)
        {
            MessageBox.Show(h.Calota(2, 2).ToString());
        }
    }
}
