using LoginApp.BLL.UserService;
using LoginApp.CORE.Entities;
using LoginApp.DAL.Concretes;
using LoginApp.DAL.Context;
using LoginApp.DAL.Interfaces;
using LoginApp.FormApp.Utilities;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class RegisterPage : Form
    {
        private AppDbContext _appDbContext;

        private IUserDAL _userDAL;
        private IUserService _userService;
        private Users _user;
        public RegisterPage()
        {
            InitializeComponent();
            _appDbContext= new AppDbContext();

            _userDAL = new UserDAL(_appDbContext);
            _userService= new UserService(_userDAL);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _user = new Users();
            try
            {
                _user.FirstName = txtFirstName.Text;
                _user.LastName = txtLastName.Text;
                _user.UserName = txtUserName.Text;
                _user.Password = txtPassword.Text;

                _userService.Create(_user);
                Helper.Clear(this.Controls);
                MessageBox.Show("Kayıt Başarılı Adminin Hesabı Onaylamasını Bekleyiniz");
                _user = null;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Helper.Clear(this.Controls);
            }
        }
    }
}
