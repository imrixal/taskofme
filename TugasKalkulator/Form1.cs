using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasKalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double a, b, hasil;

            if (comboBox1.SelectedIndex == 0)
            {
                a = Double.Parse(nilaiA.Text);
                b = Double.Parse(nilaiB.Text);
                hasil = a + b;
                textHasil.Text = hasil.ToString();
            }

            else if (comboBox1.SelectedIndex == 1)
            {
                a = Double.Parse(nilaiA.Text);
                b = Double.Parse(nilaiB.Text);
                hasil = a - b;
                textHasil.Text = hasil.ToString();
            }

            else if (comboBox1.SelectedIndex == 2)
            {
                a = Double.Parse(nilaiA.Text);
                b = Double.Parse(nilaiB.Text);
                hasil = a * b;
                textHasil.Text = hasil.ToString();
            }

            else if (comboBox1.SelectedIndex == 3)
            {
                a = Double.Parse(nilaiA.Text);
                b = Double.Parse(nilaiB.Text);
                hasil = a / b;
                textHasil.Text = hasil.ToString();
            }
        }
    }
}
