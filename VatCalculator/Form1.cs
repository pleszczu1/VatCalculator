using System;
using System.Windows.Forms;

namespace VatCalculator
{
    public partial class VatCalculatorForm : Form
    {
        
        public VatCalculatorForm()
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
                Decimal netAmountNumber = Decimal.Parse(netAmount.Text);
                Decimal vatRateNumber = Decimal.Parse(vat.Text);
                Decimal vatNumber = calculateVat(netAmountNumber, vatRateNumber);
                vatValue.Text = vatNumber.ToString();
                gross.Text = (netAmountNumber + vatNumber).ToString();
        }

        private Decimal calculateVat(Decimal netAmountNumber, Decimal vatRateNumber)
        {
            return netAmountNumber * vatRateNumber / 100;
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
