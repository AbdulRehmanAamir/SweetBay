using Sweet_Bay_Point_Of_Sale.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sweet_Bay_Point_Of_Sale
{
    static class Program
    {
        
        static void Main()
       {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new loginform());
        }
    }
}
