using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınav_1_1473
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTutar_Click(object sender, EventArgs e)
        {
            double dolar = Convert.ToDouble(txtDolar.Text);     
            double miktar= Convert.ToDouble(txtMiktar.Text);

            double sonuc =dolar*miktar;

            lblTutar.Text = sonuc.ToString();
        }
    }
}
                                                                         