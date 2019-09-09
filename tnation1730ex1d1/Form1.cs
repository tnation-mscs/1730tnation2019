using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tnation1730ex1d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountCanada.Text = "0.00";
            txtRateCanada.Text = "0.759438";

            txtAmountEuro.Text = "0.00";
            txtRateEuro.Text = "1.10498";

            txtAmountUAE.Text = "0.00";
            txtRateUAE.Text = "0.272294";

            txtAmountSouthKorea.Text = "0.00";
            txtRateSouthKorea.Text = "0.000838945";
        }

        private void canadaTextChanged(object sender, EventArgs e)
        {
            txtUSDCanada.Text = (
                Convert.ToDecimal(txtAmountCanada.Text)
                * Convert.ToDecimal(txtRateCanada.Text)
                ).ToString("0.00");
        }

        private void euroTextChanged(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (
                Convert.ToDecimal(txtAmountEuro.Text)
                * Convert.ToDecimal(txtRateEuro.Text)
                ).ToString("0.00");
        }

        private void uaeTextChanged(object sender, EventArgs e)
        {
            txtUSDUAE.Text = (
                Convert.ToDecimal(txtAmountUAE.Text)
                * Convert.ToDecimal(txtRateUAE.Text)
                ).ToString("0.00");
        }

        private void southkoreaTextChanged(object sender, EventArgs e)
        {
            txtUSDSouthKorea.Text = (
                Convert.ToDecimal(txtAmountSouthKorea.Text)
                * Convert.ToDecimal(txtRateSouthKorea.Text)
                ).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDCanada.Text)
                + Convert.ToDecimal(txtUSDEuro.Text)
                + Convert.ToDecimal(txtUSDSouthKorea.Text)
                + Convert.ToDecimal(txtUSDUAE.Text)
                ).ToString("0.00");
        }
    }
}
