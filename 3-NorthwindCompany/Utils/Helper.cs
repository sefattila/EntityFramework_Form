using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_NorthwindCompany.Utils
{
    public class Helper
    {
        public static void Temizle(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
            }
        }
    }
}
