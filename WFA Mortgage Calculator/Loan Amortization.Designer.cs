namespace gregMurray_Project2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputBox = new System.Windows.Forms.GroupBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.aprLabel = new System.Windows.Forms.Label();
            this.termLabel = new System.Windows.Forms.Label();
            this.loanAmtLabel = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAmortize = new System.Windows.Forms.Button();
            this.txtAPR = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtMPayment = new System.Windows.Forms.TextBox();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.txtLoanAmt = new System.Windows.Forms.TextBox();
            this.outputList = new System.Windows.Forms.ListBox();
            this.inputBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Controls.Add(this.totalLabel);
            this.inputBox.Controls.Add(this.monthLabel);
            this.inputBox.Controls.Add(this.aprLabel);
            this.inputBox.Controls.Add(this.termLabel);
            this.inputBox.Controls.Add(this.loanAmtLabel);
            this.inputBox.Controls.Add(this.btnClear);
            this.inputBox.Controls.Add(this.btnAmortize);
            this.inputBox.Controls.Add(this.txtAPR);
            this.inputBox.Controls.Add(this.txtTotal);
            this.inputBox.Controls.Add(this.txtMPayment);
            this.inputBox.Controls.Add(this.txtTerm);
            this.inputBox.Controls.Add(this.txtLoanAmt);
            this.inputBox.Location = new System.Drawing.Point(22, 24);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(317, 393);
            this.inputBox.TabIndex = 0;
            this.inputBox.TabStop = false;
            this.inputBox.Text = "Loan Input Box";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(27, 254);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(94, 13);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total Amount Paid";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(27, 202);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(88, 13);
            this.monthLabel.TabIndex = 10;
            this.monthLabel.Text = "Monthly Payment";
            // 
            // aprLabel
            // 
            this.aprLabel.AutoSize = true;
            this.aprLabel.Location = new System.Drawing.Point(27, 141);
            this.aprLabel.Name = "aprLabel";
            this.aprLabel.Size = new System.Drawing.Size(69, 13);
            this.aprLabel.TabIndex = 9;
            this.aprLabel.Text = "APR Percent";
            // 
            // termLabel
            // 
            this.termLabel.AutoSize = true;
            this.termLabel.Location = new System.Drawing.Point(27, 95);
            this.termLabel.Name = "termLabel";
            this.termLabel.Size = new System.Drawing.Size(94, 13);
            this.termLabel.TabIndex = 8;
            this.termLabel.Text = "Term (Years: 1-50)";
            // 
            // loanAmtLabel
            // 
            this.loanAmtLabel.AutoSize = true;
            this.loanAmtLabel.Location = new System.Drawing.Point(27, 48);
            this.loanAmtLabel.Name = "loanAmtLabel";
            this.loanAmtLabel.Size = new System.Drawing.Size(70, 13);
            this.loanAmtLabel.TabIndex = 7;
            this.loanAmtLabel.Text = "Loan Amount";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(124, 313);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(171, 38);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAmortize
            // 
            this.btnAmortize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmortize.Location = new System.Drawing.Point(27, 313);
            this.btnAmortize.Name = "btnAmortize";
            this.btnAmortize.Size = new System.Drawing.Size(72, 38);
            this.btnAmortize.TabIndex = 5;
            this.btnAmortize.Text = "Amortize";
            this.btnAmortize.UseVisualStyleBackColor = true;
            this.btnAmortize.Click += new System.EventHandler(this.btnAmortize_Click);
            // 
            // txtAPR
            // 
            this.txtAPR.Location = new System.Drawing.Point(124, 134);
            this.txtAPR.Name = "txtAPR";
            this.txtAPR.Size = new System.Drawing.Size(187, 20);
            this.txtAPR.TabIndex = 2;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(124, 247);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(187, 20);
            this.txtTotal.TabIndex = 4;
            // 
            // txtMPayment
            // 
            this.txtMPayment.Location = new System.Drawing.Point(124, 195);
            this.txtMPayment.Name = "txtMPayment";
            this.txtMPayment.ReadOnly = true;
            this.txtMPayment.Size = new System.Drawing.Size(187, 20);
            this.txtMPayment.TabIndex = 3;
            this.txtMPayment.TextChanged += new System.EventHandler(this.txtMPayment_TextChanged);
            // 
            // txtTerm
            // 
            this.txtTerm.Location = new System.Drawing.Point(124, 88);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(187, 20);
            this.txtTerm.TabIndex = 1;
            // 
            // txtLoanAmt
            // 
            this.txtLoanAmt.Location = new System.Drawing.Point(124, 48);
            this.txtLoanAmt.Name = "txtLoanAmt";
            this.txtLoanAmt.Size = new System.Drawing.Size(187, 20);
            this.txtLoanAmt.TabIndex = 0;
            this.txtLoanAmt.TextChanged += new System.EventHandler(this.txtLoanAmt_TextChanged);
            // 
            // outputList
            // 
            this.outputList.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputList.Location = new System.Drawing.Point(345, 24);
            this.outputList.Name = "outputList";
            this.outputList.Size = new System.Drawing.Size(443, 394);
            this.outputList.TabIndex = 1;
            this.outputList.TabStop = false;
            this.outputList.SelectedIndexChanged += new System.EventHandler(this.outputList_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.outputList);
            this.Controls.Add(this.inputBox);
            this.Name = "Form1";
            this.Text = "Loan Amortization";
            this.inputBox.ResumeLayout(false);
            this.inputBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputBox;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label aprLabel;
        private System.Windows.Forms.Label termLabel;
        private System.Windows.Forms.Label loanAmtLabel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAmortize;
        private System.Windows.Forms.TextBox txtAPR;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtMPayment;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.TextBox txtLoanAmt;
        private System.Windows.Forms.ListBox outputList;
    }
}

