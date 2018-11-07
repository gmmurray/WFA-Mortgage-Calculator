using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gregMurray_Project2
{
    static class Project2
    {
        /// <summary>
        /// Name: Gregory Murray n01413862
        /// Project 2
        /// Due Date: October 30 2018
        /// 
        /// This program uses a custom Amortization class and Windows Forms to allow the user to input a Loan Amount, Term Period, and APR. The program calculates and displays 
        /// a full amortization schedule for the term specified by the user.
        /// 
        /// TODO: -go through assignment sheet/rubric
        ///       -comments
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());           
        }
    }
}
