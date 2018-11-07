using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gregMurray_Project2
{
    public partial class Form1 : Form
    {
        // Field variable to track total number of user errors
        int errorCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void outputList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAmortize_Click(object sender, EventArgs e)
        {
            // Returns 0 if any errors in conversion
            double convertedAmt = convertAmt(); 
            double convertedAPR = convertAPR(); 
            int convertedTerm = convertTerm();

            // Exit program if user fails on their fourth incorrect attempt at providing valid input
            while (errorCount < 4)
            {
                // Error message for no input
                if (convertedAmt == 0 && convertedAPR == 0 && convertedTerm == 0)
                {
                    MessageBox.Show("Please input the Loan Amount, Term, and APR to create an Amortization Schedule.", "No Input");
                }

                // Error message, color change, and focus for invalid loan amount input
                else if (convertedAmt == 0 || convertedAmt < 1000 || convertedAmt > 1000000)
                {
                    errorCount++;
                    if (errorCount < 4)
                    {
                        MessageBox.Show("Please enter a valid input for the Loan Amount", "Invalid Input");
                        txtLoanAmt.BackColor = Color.LightPink;
                        txtLoanAmt.Focus();
                        txtLoanAmt.Clear();
                        outputList.Items.Clear();
                    }

                }

                // Error message, color change, and focus for invalid loan APR input
                else if (convertedAPR == 0 || convertedAPR < 0.01 || convertedAPR > 0.1)
                {
                    errorCount++;
                    if (errorCount < 4)
                    {
                        MessageBox.Show("Please enter a valid input for the Loan APR", "Invalid Input");
                        txtAPR.BackColor = Color.LightPink;
                        txtAPR.Focus();
                        txtAPR.Clear();
                        outputList.Items.Clear();
                    }

                }

                // Error message, color change, and focus for invalid loan term input
                else if (convertedTerm == 0 || convertedTerm > 50)
                {
                    errorCount++;
                    if (errorCount < 4)
                    {
                        MessageBox.Show("Please enter a valid input for the Loan Term", "Invalid Input");
                        txtTerm.BackColor = Color.LightPink;
                        txtTerm.Focus();
                        txtTerm.Clear();
                        outputList.Items.Clear();
                    }
                }

                // Create amortization schedule once all inputs are valid
                else
                {
                    createSchedule(convertedAmt, convertedAPR, convertedTerm);
                }

                break;
            }

            // Exit program due to errors
            if (errorCount >= 4)
            {
                MessageBox.Show("Too many invalid inputs, exiting program.", "Error");
                Application.Exit();
            } 
        }
        
        // Clear all control outputs
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLoanAmt.Clear();
            txtTerm.Clear();
            txtAPR.Clear();
            txtMPayment.Clear();
            txtTotal.Clear();
            outputList.Items.Clear();

            txtLoanAmt.BackColor = Color.White;
            txtTerm.BackColor = Color.White;
            txtAPR.BackColor = Color.White;
        }

        // Returns loan amount as double, or 0 if there was no input 
        private double convertAmt()
        {
            string amtInput = txtLoanAmt.Text;
            double amtResult;
            bool success = double.TryParse(amtInput, out amtResult);

            if (success)
            {
                return amtResult;
            }
            else
            {
                return 0;
            }
        }

        // Returns term length as int, or 0 if there was no input
        private int convertTerm()
        {
            string termInput = txtTerm.Text;
            int termResult;
            bool success = int.TryParse(termInput, out termResult);

            if (success)
            {
                return termResult;
            }
            else
            {
                return 0;
            }
        }

        // Returns apr percentage as double, or 0 if there was no input
        private double convertAPR()
        {
            string aprInput = txtAPR.Text;
            double aprResult;
            bool success = double.TryParse(aprInput, out aprResult);

            if (success)
            {
                return aprResult / 100; //convert to percentage
            }
            else
            {
                return 0;
            }
        }

        private void txtLoanAmt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMPayment_TextChanged(object sender, EventArgs e)
        {

        }

        // Creates the Amortization schedule      
        private void createSchedule(double loanAmount, double aprAmount, int termLength)
        {
            Amortization newAmorSchedule = new Amortization(loanAmount, aprAmount, termLength);
            txtLoanAmt.BackColor = Color.White;
            txtTerm.BackColor = Color.White;
            txtAPR.BackColor = Color.White;

            newAmorSchedule.CalcMonthlyPayment();

            double totalInterestPaid = newAmorSchedule.CalcMonthlyInterestPaid(); // Total interest paid starts as first month's monthly interest payment
            double totalPaid;
            int durationLength = newAmorSchedule.Duration;

            // Strings to format output to ListBox control
            string headerFormatString = "{0,-5} | {1,11}  | {2,8}  | {3,8}  | {4,13}";
            string dataFormatString = "{0,5} | {1,11:C2}  | {2,8:C2}  | {3,8:C2}  | {4,13:C2}";

            // Output to text boxes and listbox
            txtMPayment.Text = newAmorSchedule.MonthlyPayment.ToString("C");
            outputList.Items.Add(string.Format(headerFormatString, "Month", "Principal", "Int/Pmt", "Prn/Pmt", "Tot Int Paid"));            
            outputList.Items.Add("-------------------------------------------------------------------------------------");

            for (int i = 0; i < durationLength; i++)
            {
                outputList.Items.Add(string.Format(dataFormatString, i + 1, newAmorSchedule.CalcRemainingPrincipal(), newAmorSchedule.CalcMonthlyInterestPaid(), newAmorSchedule.CalcPrincipalPaid(), totalInterestPaid));
                newAmorSchedule.UpdateRemainingPrincipal();
                totalInterestPaid += newAmorSchedule.CalcMonthlyInterestPaid();
            }

            totalPaid = newAmorSchedule.PrincipalAmount + totalInterestPaid; //Total loan repayment is equal to the principal amount plus the total interest paid on the loan
            txtTotal.Text = totalPaid.ToString("C");
        }
    }

}
