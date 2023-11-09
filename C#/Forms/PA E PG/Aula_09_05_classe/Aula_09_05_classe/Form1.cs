using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_09_05_classe
{
    public partial class Form1 : Form
    {
        Geometria geo = new Geometria();

        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_quadrado_Click(object sender, EventArgs e)
        {
            MessageBox.Show(geo.Quadrado(10).ToString());
        }

        private void Btn_retangulo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(geo.Retangulo(2, 50).ToString());
        }

        private void Btn_cilindro_Click(object sender, EventArgs e)
        {
            MessageBox.Show(geo.Cilindro(3, 50).ToString());
        }

        private void Btn_paralelepipedo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(geo.Paralelepipedo(12, 50, 13).ToString());
        }

        private void Btn_divisao_Click(object sender, EventArgs e)
        {
            int resultado;

            resultado = geo.Divisao(30, 2);
            label1.Text = resultado.ToString();

        }

        private void Btn_fatorial_Click(object sender, EventArgs e)
        {
            label1.Text = geo.Fatorial(3).ToString();
        }

        private void Btn_pa_Click(object sender, EventArgs e)
        {
            MessageBox.Show(geo.PA(15,2,5).ToString());

        }

        private void Btn_pg_Click(object sender, EventArgs e)
        {
            MessageBox.Show(geo.PG(2, 3, 4).ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
