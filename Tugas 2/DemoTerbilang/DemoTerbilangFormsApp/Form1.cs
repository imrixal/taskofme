using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerbilangLibrary;

namespace DemoTerbilangFormsApp
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

        private void cekBtn_Click(object sender, EventArgs e)
        {
            
            int cek = int.Parse(textNominal.Text);
            Terbilang terbilang = new Terbilang();
            hasilBox.Items.Clear();
            hasilBox.Items.Add(terbilang.TerbilangIndonesia(cek));

        }

        private void hasilBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
