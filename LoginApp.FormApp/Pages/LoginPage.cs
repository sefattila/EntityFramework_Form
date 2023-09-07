using LoginApp.BLL.UserService;
using LoginApp.CORE.Entities;
using LoginApp.CORE.Enums;
using LoginApp.DAL.Concretes;
using LoginApp.DAL.Context;
using LoginApp.DAL.Interfaces;
using LoginApp.FormApp.Pages;
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

namespace LoginApp.FormApp
{
    public partial class LoginPage : Form
    {
        private AppDbContext _context;

        private IUserDAL _userDAL;
        private IUserService _userService;

        private Users _user;
        public LoginPage()
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
                _user = new Users();
                _user = _userService.GetUser(txtUserName.Text, txtPassword.Text);
                if (_user.Account == Account.User)
                {
                    this.Hide();
                    MessageBox.Show("Giriş Başarılı");
                    UserPanel userPanel = new UserPanel(_user);
                    userPanel.ShowDialog();
                    this.Close();
                    _user = null;
                }
                else if (_user.Account == Account.Admin)
                {
                    this.Hide();
                    MessageBox.Show($"{_user.FirstName} {_user.LastName}\nAdmin Olarak Giriş Yapıldı");
                    AdminPanel adminPanel = new AdminPanel(_user);
                    adminPanel.ShowDialog();
                    this.Close();
                    _user = null;
                }
            }
            catch (Exception ex)
            {
                _user = null;
                MessageBox.Show(ex.Message);
                Helper.Clear(this.Controls);
            }
        }
    }
}
