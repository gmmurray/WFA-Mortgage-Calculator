using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gregMurray_Project2
{
    static class Program
    {
        /// <summary>
        /// TODO: format ListBox output and go through assignment sheet/rubric
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
