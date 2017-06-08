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
    }
}
