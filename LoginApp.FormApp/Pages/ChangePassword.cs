using LoginApp.BLL.UserService;
using LoginApp.CORE.Entities;
using LoginApp.DAL.Concretes;
using LoginApp.DAL.Context;
using LoginApp.DAL.Interfaces;
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
    public partial class ChangePassword : Form
    {
        private Users _user;
        private AppDbContext _context;
        private IUserDAL _userDAL;
        private IUserService _userService;
        public ChangePassword(Users user)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _userDAL = new UserDAL(_context);
            _userService = new UserService(_userDAL);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOldPassword.Text != null && txtNewPassword.Text != null && txtConfirmPassword != null)
                {
                    if (txtOldPassword.Text == _user.Password)
                    {
                        if (txtNewPassword.Text==txtConfirmPassword.Text)
                        {
                            if (_userService.PasswordControl(_user.Password))
                            {
                                _user.Password = txtNewPassword.Text;
                                _userService.Update(_user);
                            }
                        }
                        else MessageBox.Show("Girilen Yeni Şifreler Uyuşmuyo");
                    }
                    else MessageBox.Show("Mevcut Şifrenizi Yanlış Girdiniz");
                }
                else MessageBox.Show("Bütün Girdileri Doğru Bir Şekilde Doldurunuz");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
