using System;
using System.Windows.Forms;

namespace VatCalculator
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            netValue.Text = netAmount.Text;
            vatValue.Text = (Double.Parse(netAmount.Text) * Double.Parse(vat.Text)/100).ToString();
            gross.Text = ((Double.Parse(netAmount.Text)+(Double.Parse(netAmount.Text) * Double.Parse(vat.Text) / 100))).ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            netAmount.Clear();
            vat.Clear();
            netValue.ResetText();
            vatValue.ResetText();
            gross.ResetText();

        }

        private void vat_TextChanged(object sender, EventArgs e)
        {

        }

        private void netValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void vatValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void grossAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void amount(object sender, EventArgs e)
        {

        }

    
    }
}
