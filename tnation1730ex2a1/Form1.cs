using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tnation1730ex2a1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            int subtotal = Convert.ToInt32(subtotalTxt.Text);
            decimal discountPercent = Convert.ToInt32(discountpercentTxt.Text);
            decimal discountAmount = subtotal * discountPercent / 100;
            discountamountTxt.Text = discountAmount.ToString("0.00");

            decimal total = subtotal - discountAmount;
            totalTxt.Text = total.ToString("0.00");
            subtotalTxt.Focus();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
