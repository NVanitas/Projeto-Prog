using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_M1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnsomar_Click(object sender, EventArgs e)
        {
            int v1, v2, result;

            v1 = Convert.ToInt32(txtv1.Text);
            v2 = Convert.ToInt32(txtv2.Text);

            result = v1 + v2;

            txtresult.Text = Convert.ToString(result);
        }

        private void Btnlimpar_Click(object sender, EventArgs e)
        {
            txtv1.Clear();
            txtv2.Clear();
            txtresult.Clear();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
