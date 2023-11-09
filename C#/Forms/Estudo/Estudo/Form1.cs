using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_n_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_res_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int n, resultado;

            n = Convert.ToInt32(txt_n.Text);

            resultado = n * 2;

            txt_res.Text = Convert.ToString(resultado);
        }
    }
}
