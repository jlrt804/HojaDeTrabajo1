using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HT1
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

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, h;
            a = Math.Pow(int.Parse(i1.Text), 2);
            b = Math.Pow(int.Parse(i2.Text), 2);
            h = Math.Sqrt(a + b);
            MessageBox.Show(h.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char[] c = i1.Text.ToCharArray();
            int j;
            bool a, ee, i, o, u;
            a = ee = i = o = u = false;

            for (j=0; j<c.Length;j++) {
                if (c[j] == 'a' | c[j] == 'á' | c[j] == 'A' | c[j] == 'Á') {
                    a = true;
                } else if (c[j] == 'e' | c[j] == 'é' | c[j] == 'E' | c[j] == 'É') {
                    ee = true;
                } else if (c[j] == 'i' | c[j] == 'í' | c[j] == 'I' | c[j] == 'Í') {
                    i = true;
                } else if (c[j] == 'o' | c[j] == 'ó' | c[j] == 'O' | c[j] == 'Ó') {
                    o = true;
                } else if (c[j] == 'u' | c[j] == 'ú' | c[j] == 'U' | c[j] == 'Ú') {
                    u = true;
                }
            }

            if (a == true && ee == true && i == true && o == true && u == true)
            {
                MessageBox.Show("CUMPLE");
            }
            else {
                MessageBox.Show("NO CUMPLE");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cadena = i1.Text + " " + i2.Text;
            char[] c = cadena.ToCharArray();
            string temp="";
            int j;

            for (j=c.Length-1;j>-1;j--) {
                temp += c[j];
            }
            MessageBox.Show(temp);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double resultado;
            resultado = (int.Parse(i3.Text) * int.Parse(i2.Text)) / int.Parse(i1.Text);
            MessageBox.Show(resultado.ToString());
        }
    }
}
