using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

 namespace Sweet_Bay_Point_Of_Sale.General
{
   public class ApplicationSetting
    {
       public static string ConnectionString()
       {

           return ConfigurationManager.ConnectionStrings["rbx"].ConnectionString;
       }

    }
}
