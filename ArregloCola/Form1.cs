using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArregloCola
{
    public partial class Form1 : Form
    {
        int NumDatos = 0;
        Random objeto = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnEncolar_Click_1(object sender, EventArgs e)
        {
            if (NumDatos == 5)
            {
                MessageBox.Show("Cola llena");
            }
            else
            {
                NumDatos++;
                txt0.Text = Convert.ToString(NumDatos);
                if (NumDatos == 1)
                {
                    txt1.Text = Convert.ToString(objeto.Next(1, 99));
                    txt1.Visible = true;
                }
                if (NumDatos == 2)
                {
                    txt2.Text = Convert.ToString(objeto.Next(1, 99));
                    txt2.Visible = true;
                }
                if (NumDatos == 3)
                {
                    txt3.Text = Convert.ToString(objeto.Next(1, 99));
                    txt3.Visible = true;
                }
                if (NumDatos == 4)
                {
                    txt4.Text = Convert.ToString(objeto.Next(1, 99));
                    txt4.Visible = true;
                }
                if (NumDatos == 5)
                {
                    txt5.Text = Convert.ToString(objeto.Next(1, 99));
                    txt5.Visible = true;
                }
            }
        }

        private void btnDesencolar_Click(object sender, EventArgs e)
        {
            if(NumDatos == 0)
            {
                MessageBox.Show("La cola esta vacia");
            }
            else
            {
                txt1.Text = txt2.Text;
                txt2.Text = txt3.Text;
                txt3.Text = txt4.Text;
                txt4.Text = txt5.Text;
                if (NumDatos == 1) txt1.Visible = false;
                if (NumDatos == 2) txt2.Visible = false;
                if (NumDatos == 3) txt3.Visible = false;
                if (NumDatos == 4) txt4.Visible = false;
                if (NumDatos == 5) txt5.Visible = false;
                NumDatos--;
                txt0.Text = Convert.ToString(NumDatos);

            }
        }
    }
}
