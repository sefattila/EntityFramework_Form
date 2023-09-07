using LoginApp.CORE.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp.FormApp.Pages
{
    public partial class UserPanel : Form
    {
        private Users _user;
        public UserPanel(Users user)
        {
            InitializeComponent();
            _user = user;
        }
    }
}
