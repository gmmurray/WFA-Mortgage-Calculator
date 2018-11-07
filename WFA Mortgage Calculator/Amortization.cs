using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gregMurray_Project2
{
    /// <summary>
    /// Amortization is a custom class with private fields principalAmount, interestRate, duration, monthlyPayment, and remainingBalance.
    /// Each variable has its own respective property with get/set functionality. The purpose of the class is to have all of the information for each 
    /// amortization schedule in one place, with accompanying methods to make any necessary calculations.
    /// </summary>

    public class Amortization
    {
        private double principalAmount;
        private double interestRate;
        private int duration;
        private double monthlyPayment;
        private double remainingBalance;

        // principalAmount property with get/set
        public double PrincipalAmount
        {
            get
            {
                return principalAmount;
            }
            set
            {
                principalAmount = value;
            }
        }

        // interestRate property with get/set
        public double InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                interestRate = value;
            }
        }

        //duration property with get/set
        public int Duration
        {
            get
            {
                return duration;
            }
            set
            {
                duration = value;
            }
        }

        // monthlyPayment property with get/set
        public double MonthlyPayment
        {
            get
            {
                return monthlyPayment;
            }
            set
            {
                monthlyPayment = value;
            }
        }

        // remainingBalance property with get/set
        public double RemainingBalance
        {
            get
            {
                return remainingBalance;
            }
            set
            {
                remainingBalance = value;
            }
        }

        // Amortization constructor - use yearly interest rate and yearly term when class is instantiated
        public Amortization(double principal, double interest, int term)
        {
            principalAmount = principal;
            interestRate = interest/12;
            duration = term * 12;
            remainingBalance = principal;
        }

        // Calculate monthly payment using formula, gives this value to the monthlyPayment variable and returns this value
        public double CalcMonthlyPayment()
        {
            double rate, principal, term;
            double fixedPayment = 0;
            
            rate = InterestRate;
            term = Duration;
            principal = PrincipalAmount;

            double baseNum = 1 + rate; // Amount to be raised to "term" exponent in formula
            double expNum = Math.Pow(baseNum, term); // Exponentiated result

            MonthlyPayment = principal * ((rate * expNum) / (expNum - 1)); // Set monthlyPayment
            fixedPayment = MonthlyPayment;

            return fixedPayment;
        }

        // Calculate monthly interest paid using the remaining balance (which is initialized as the principal amount and updated each month) and the interest rate 
        public double CalcMonthlyInterestPaid()
        {
            double result;

            result = RemainingBalance * InterestRate;

            return result;
        }

        // Calculate amount of principal paid per payment by subracting the interest paid that month from the fixed monthly payment
        public double CalcPrincipalPaid()
        {
            double interestPaid;
            double mPayment = MonthlyPayment;
            double result;

            interestPaid = CalcMonthlyInterestPaid();
            result = mPayment - interestPaid;

            return result;

        }

        // Calculate remaining principal by subracting result of CalcPrincipalPaid() from the total remaining principal 
        public double CalcRemainingPrincipal()
        {
            double principalPaid = CalcPrincipalPaid();
            double result = RemainingBalance - principalPaid;

            return result;
        }

        // Update the remaining principal to keep track of this variable distinct from the original principal amount
        public void UpdateRemainingPrincipal()
        {
            RemainingBalance = CalcRemainingPrincipal();
        }

    }
}
