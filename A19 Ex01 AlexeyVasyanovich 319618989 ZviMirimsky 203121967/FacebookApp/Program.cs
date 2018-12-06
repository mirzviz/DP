using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

// $G$ RUL-004 (-20) Wrong zip name format / folder name format
// $G$ RUL-999 (-10) Wrong subject name

// $G$ SFN-999 (-10) exception wehn leaving app without signing in

// $G$ THE-001 (-22) your grade on diagrams document - 78. please see comments inside the document. (40% of your grade).


namespace FacebookApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}
