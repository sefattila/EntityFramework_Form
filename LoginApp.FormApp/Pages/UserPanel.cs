using LoginApp.BLL.TextService;
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
    public partial class UserPanel : Form
    {
        private Users _user;
        private Text _text;
        private AppDbContext _context;

        private ITextDAL _textDAL;
        private ITextService _textService;

        private int _userId;
        public UserPanel(Users user)
        {
            InitializeComponent();
            _context = new AppDbContext();
            _textDAL = new TextDAL(_context);
            _textService = new TextService(_textDAL);
            _user = user;
            _userId = _user.Id;
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {
            IList<Text> texts = _textService.GetDefaults(x => x.UserId == _userId);
            FillList(texts);
            ButtonSettings(true);
        }

        private void FillList(IList<Text> texts)
        {
            lvTexts.Items.Clear();
            foreach (var item in texts)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.Id.ToString();
                listViewItem.SubItems.Add(item.Title);
                listViewItem.SubItems.Add(item.TextDetail);

                lvTexts.Items.Add(listViewItem);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _text = new Text();
            _text.Title = txtTitle.Text;
            _text.TextDetail = rtDetail.Text;
            _text.UserId = _userId;

            _textService.Create(_text);
            _text = null;
            FillList(_textService.GetDefaults(x => x.UserId == _userId));
            Helper.Clear(this.Controls);
            ButtonSettings(true);
        }
        private void ButtonSettings(bool set)
        {
            btnAdd.Enabled = set;
            btnUpdate.Enabled = !set;
            btnDelete.Enabled = !set;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_text != null)
            {
                _text.Title = txtTitle.Text;
                _text.TextDetail = rtDetail.Text;

                _textService.Update(_text);
                FillList(_textService.GetDefaults(x => x.UserId == _userId));
                ButtonSettings(true);
                Helper.Clear(this.Controls);
            }
        }

        private void lvTexts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTexts.SelectedItems.Count > 0)
            {
                int id = Convert.ToInt32(lvTexts.SelectedItems[0].SubItems[0].Text);
                _text = _textService.GetDefaultById(id);
                _text.Title = txtTitle.Text;
                _text.TextDetail = rtDetail.Text;
                ButtonSettings(false);
            }
            else
            {
                ButtonSettings(true);
                Helper.Clear(this.Controls);
                _text = null;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_text != null)
            {
                _textService.Delete(_text);
                FillList(_textService.GetDefaults(x => x.UserId == _userId));
                ButtonSettings(true);
                Helper.Clear(this.Controls);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changePassword = new ChangePassword(_user);
            changePassword.ShowDialog();
            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz?", "Çıkış", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
                _user = null;
            }
            else return;
        }

        private void lvTexts_DoubleClick(object sender, EventArgs e)
        {
            if (lvTexts.SelectedItems.Count > 0)
            {
                int id = Convert.ToInt32(lvTexts.SelectedItems[0].SubItems[0].Text);
                _text = _textService.GetDefaultById(id);
                txtTitle.Text = _text.Title.ToString();
                rtDetail.Text = _text.TextDetail.ToString();
                ButtonSettings(false);
            }
            else return;
        }
    }
}
