using LoginApp.BLL.UserService;
using LoginApp.CORE.Entities;
using LoginApp.DAL.Concretes;
using LoginApp.DAL.Context;
using LoginApp.DAL.Interfaces;
using LoginApp.FormApp.Utilities;
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
            _user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOldPassword.Text.Length > 0 && txtNewPassword.Text.Length > 0 && txtConfirmPassword.Text.Length > 0)
                {
                    if (txtOldPassword.Text == _user.Password)
                    {
                        if (txtNewPassword.Text == txtConfirmPassword.Text)
                        {
                            if (_userService.PasswordControl(txtNewPassword.Text))
                            {
                                _user.Password = txtNewPassword.Text;
                                _userService.Update(_user);
                                Helper.Clear(this.Controls);
                                MessageBox.Show("Şifre Değiştirildi");
                            }
                            else MessageBox.Show("Şifre Özel Karakter, Sayı İçermeli ve 6 Karakterden Fazla Olmalı");
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
