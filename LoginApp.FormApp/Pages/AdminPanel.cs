using LoginApp.BLL.TextService;
using LoginApp.BLL.UserService;
using LoginApp.CORE.Entities;
using LoginApp.CORE.Enums;
using LoginApp.DAL.Concretes;
using LoginApp.DAL.Context;
using LoginApp.DAL.Interfaces;
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

namespace LoginApp.FormApp.Pages
{
    public partial class AdminPanel : Form
    {
        private Users _user;
        private AppDbContext _context;

        private IUserDAL _userDAL;
        private IUserService _userService;

        private ITextDAL _textDAL;
        private ITextService _textService;
        public AdminPanel(Users users)
        {
            InitializeComponent();
            _context = new AppDbContext();

            _userDAL = new UserDAL(_context);
            _userService = new UserService(_userDAL);
            _user = users;

            _textDAL = new TextDAL(_context);
            _textService = new TextService(_textDAL);



        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {
            IList<Text> lastTenText = _textService.GetLastTen();
            IList<Users> usersListPassive = _userService.GetPassive();

            PassiveUsersFill(usersListPassive);
            GetLastTen(lastTenText);
        }

        private void PassiveUsersFill(IList<Users> users)
        {
            lvPassive.Items.Clear();
            foreach (Users user in users)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = user.Id.ToString();
                listViewItem.SubItems.Add(user.FirstName);
                listViewItem.SubItems.Add(user.LastName);
                listViewItem.SubItems.Add(user.UserName);

                lvPassive.Items.Add(listViewItem);
            }
        }

        private void GetLastTen(IList<Text> users)
        {
            lvLastTen.Items.Clear();
            foreach (Text text in users)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = text.Id.ToString();
                listViewItem.SubItems.Add(text.Title);
                listViewItem.SubItems.Add(text.TextDetail);

                lvLastTen.Items.Add(listViewItem);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkış Yapmaya Emin Misin", "Uygulama Çıkış", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                _user = null;
                this.Close();
            }
            else return;
        }

        private void lvPassive_DoubleClick(object sender, EventArgs e)
        {
            int id=0;
            if(lvPassive.SelectedItems.Count > 0)
            {
                id = Convert.ToInt32(lvPassive.SelectedItems[0].SubItems[0].Text);
            }
            Users selectedUser = new Users();
            selectedUser = _userService.GetDefaultById(id);

            DialogResult result = MessageBox.Show("Kullanıcı Aktifleştirilsin Mi?", "Kullanıcı Aktifleştir", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                selectedUser.Account = Account.User;
                _userService.Update(selectedUser);
                PassiveUsersFill(_userService.GetPassive());
            }
            else return;
        }
    }
}
