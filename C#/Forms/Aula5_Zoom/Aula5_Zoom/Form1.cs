using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula5_Zoom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_maior_Click(object sender, EventArgs e)
        {
            if (pic_picture.Width <= 60000 && pic_picture.Height <= 60000)
            {
                pic_picture.Width = Convert.ToInt32(pic_picture.Width * 1.25);
                pic_picture.Height = Convert.ToInt32(pic_picture.Height * 1.25);
            }
            else
            {
                MessageBox.Show("Limite de tamanho...Atingido!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void Btn_menor_Click(object sender, EventArgs e)
        {
            if (pic_picture.Width >= 10 && pic_picture.Height >= 10)
            {
                pic_picture.Width = Convert.ToInt32(pic_picture.Width / 1.25);
                pic_picture.Height = Convert.ToInt32(pic_picture.Height / 1.25);
            }
            else
            {
                MessageBox.Show("Limite de tamanho...Atingido!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void Btn_open_Click(object sender, EventArgs e)
        {
            try
            {
                open.ShowDialog();
                pic_picture.Load(open.FileName);
            }
            catch
            {
                MessageBox.Show("Limite de tamanho...Atingido!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }//fecha btnabrir
        }
    }
}
