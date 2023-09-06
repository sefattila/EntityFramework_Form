using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginApp.FormApp.Utilities
{
    public class Helper
    {
        public static void Clear(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
                if (control is RichTextBox)
                {
                    RichTextBox richTextBox = (RichTextBox)control;
                    richTextBox.Clear();
                }
                if (control is GroupBox)
                {
                    GroupBox groupBox = (GroupBox)control;
                    Clear(groupBox.Controls);
                }
            }
        }
    }
}
