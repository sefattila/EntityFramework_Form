using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EF_TelProject.Utilities
{
    public class Helper
    {
        public static void Clear(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if(control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
                else if(control is MaskedTextBox)
                {
                    MaskedTextBox maskedTextBox= (MaskedTextBox)control;
                    maskedTextBox.Clear();
                }
                else if(control is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)control;
                    Clear(groupBox.Controls);
                }
            }
        }
    }
}
