using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_pavao_23_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_sp_Click(object sender, EventArgs e)
        {
            Tempo t1 = new Tempo();
            t1.AdcSeg(61);
            label1.Text=t1.ImprimirTempo();
        }

        private void Btn_cp_Click(object sender, EventArgs e)
        {
            Tempo t2 = new Tempo(10,10,20,25,30);

            t2.AdcDia(4);
            t2.AdcHora(24);
            t2.AdcMin(5);
            label1.Text = t2.ImprimirTempo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
