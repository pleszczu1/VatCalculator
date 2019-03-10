namespace VatCalculator
{
    partial class VatCalculatorForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculate = new System.Windows.Forms.Button();
            this.netAmount = new System.Windows.Forms.TextBox();
            this.lblEnterEmount = new System.Windows.Forms.Label();
            this.lblNetValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vat = new System.Windows.Forms.TextBox();
            this.lblVatRate = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.netValue = new System.Windows.Forms.Label();
            this.vatValue = new System.Windows.Forms.Label();
            this.gross = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCalculate.Location = new System.Drawing.Point(360, 40);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(138, 34);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calculate VAT";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // netAmount
            // 
            this.netAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.netAmount.Location = new System.Drawing.Point(37, 40);
            this.netAmount.Name = "netAmount";
            this.netAmount.Size = new System.Drawing.Size(121, 34);
            this.netAmount.TabIndex = 1;
            this.netAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.netAmount.TextChanged += new System.EventHandler(this.amount);
            // 
            // lblEnterEmount
            // 
            this.lblEnterEmount.AutoSize = true;
            this.lblEnterEmount.Location = new System.Drawing.Point(34, 20);
            this.lblEnterEmount.Name = "lblEnterEmount";
            this.lblEnterEmount.Size = new System.Drawing.Size(117, 17);
            this.lblEnterEmount.TabIndex = 2;
            this.lblEnterEmount.Text = "Enter the amount";
            this.lblEnterEmount.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNetValue
            // 
            this.lblNetValue.AutoSize = true;
            this.lblNetValue.Location = new System.Drawing.Point(34, 91);
            this.lblNetValue.Name = "lblNetValue";
            this.lblNetValue.Size = new System.Drawing.Size(68, 17);
            this.lblNetValue.TabIndex = 6;
            this.lblNetValue.Text = "Net value";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "VAT value";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Gross amount";
            // 
            // vat
            // 
            this.vat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vat.Location = new System.Drawing.Point(208, 40);
            this.vat.Name = "vat";
            this.vat.Size = new System.Drawing.Size(117, 34);
            this.vat.TabIndex = 9;
            this.vat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.vat.TextChanged += new System.EventHandler(this.vat_TextChanged);
            // 
            // lblVatRate
            // 
            this.lblVatRate.AutoSize = true;
            this.lblVatRate.Location = new System.Drawing.Point(205, 20);
            this.lblVatRate.Name = "lblVatRate";
            this.lblVatRate.Size = new System.Drawing.Size(51, 17);
            this.lblVatRate.TabIndex = 10;
            this.lblVatRate.Text = "VAT %";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClear.Location = new System.Drawing.Point(360, 111);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(138, 34);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // netValue
            // 
            this.netValue.AutoSize = true;
            this.netValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.netValue.Location = new System.Drawing.Point(34, 111);
            this.netValue.Name = "netValue";
            this.netValue.Size = new System.Drawing.Size(0, 29);
            this.netValue.TabIndex = 12;
            // 
            // vatValue
            // 
            this.vatValue.AutoSize = true;
            this.vatValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.vatValue.Location = new System.Drawing.Point(36, 186);
            this.vatValue.Name = "vatValue";
            this.vatValue.Size = new System.Drawing.Size(0, 29);
            this.vatValue.TabIndex = 13;
            // 
            // gross
            // 
            this.gross.AutoSize = true;
            this.gross.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gross.Location = new System.Drawing.Point(36, 262);
            this.gross.Name = "gross";
            this.gross.Size = new System.Drawing.Size(0, 29);
            this.gross.TabIndex = 14;
            // 
            // VatCalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 450);
            this.Controls.Add(this.gross);
            this.Controls.Add(this.vatValue);
            this.Controls.Add(this.netValue);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblVatRate);
            this.Controls.Add(this.vat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNetValue);
            this.Controls.Add(this.lblEnterEmount);
            this.Controls.Add(this.netAmount);
            this.Controls.Add(this.btnCalculate);
            this.MaximizeBox = false;
            this.Name = "VatCalculatorForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VATCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox netAmount;
        private System.Windows.Forms.Label lblEnterEmount;
        private System.Windows.Forms.Label lblNetValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox vat;
        private System.Windows.Forms.Label lblVatRate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label netValue;
        private System.Windows.Forms.Label vatValue;
        private System.Windows.Forms.Label gross;
    }
}

