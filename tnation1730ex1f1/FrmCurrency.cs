using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tnation1730ex1f1
{
    public partial class FrmCurrency : Form
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnUAE.BackgroundImage = picUAEDim.Image;
            btnSouthKorea.BackgroundImage = picSouthKoreaDim.Image;
            lblCurrency.Text = btnCanada.Text + ": ";
            txtRate.Text = "0.759438";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Focus();
        }

        private void BtnCanada_Click(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnUAE.BackgroundImage = picUAEDim.Image;
            btnSouthKorea.BackgroundImage = picSouthKoreaDim.Image;
            lblCurrency.Text = btnCanada.Text + ": ";
            txtRate.Text = "0.759438";
            txtUSDollars.Text = "0.00";
            txtCurrency.Focus();
        }

        private void BtnEuro_Click(object sender, EventArgs e)
        {
            btnEuro.BackgroundImage = picEuro.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnUAE.BackgroundImage = picUAEDim.Image;
            btnSouthKorea.BackgroundImage = picSouthKoreaDim.Image;
            lblCurrency.Text = btnEuro.Text + ": ";
            txtRate.Text = "1.10498";
            txtUSDollars.Text = "0.00";
            txtCurrency.Focus();
        }

        private void BtnUAE_Click(object sender, EventArgs e)
        {
            btnUAE.BackgroundImage = picUAE.Image;
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnSouthKorea.BackgroundImage = picSouthKoreaDim.Image;
            lblCurrency.Text = btnUAE.Text + ": ";
            txtRate.Text = "0.272294";
            txtUSDollars.Text = "0.00";
            txtCurrency.Focus();
        }

        private void BtnSouthKorea_Click(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanadaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnUAE.BackgroundImage = picUAEDim.Image;
            btnSouthKorea.BackgroundImage = picSouthKorea.Image;
            lblCurrency.Text = btnSouthKorea.Text + ": ";
            txtRate.Text = "0.000838945";
            txtUSDollars.Text = "0.00";
            txtCurrency.Focus();
        }

        private void TxtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text = (
                Convert.ToDecimal(txtCurrency.Text)
                * Convert.ToDecimal(txtRate.Text)
                ).ToString("0.00");
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDollars.Text)
                + Convert.ToDecimal(txtTotalUSD.Text)
                ).ToString("0.00");
            lblEquation.Text = lblEquation.Text + " + " + txtUSDollars.Text;
            txtCurrency.Focus();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            btnCanada.BackgroundImage = picCanada.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            btnUAE.BackgroundImage = picUAEDim.Image;
            btnSouthKorea.BackgroundImage = picSouthKoreaDim.Image;
            lblCurrency.Text = btnCanada.Text + ": ";
            txtRate.Text = "0.759438";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Text = "0.00";
            lblEquation.Text = "";
            txtCurrency.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
