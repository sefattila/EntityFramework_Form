using _4_EF_TelProject.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelProject.BLL.Services;
using TelProject.DATA.Entities;

namespace _4_EF_TelProject
{
    public partial class Form2 : Form
    {
        int _personId;
        AddressServices _addressServices;
        Address _address;
        public Form2(int personId)
        {
            InitializeComponent();
            this._personId = personId;
            this._addressServices= new AddressServices();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            List<Address> addresses=_addressServices.GetActive(_personId);
            FillList(addresses);
            ButtonSettings(true);
        }

        private void FillList(List<Address> addresses)
        {
            lvAdresler.Items.Clear();
            foreach (Address address in addresses)
            {
                ListViewItem listView=new ListViewItem();
                listView.Text=address.Id.ToString();
                listView.SubItems.Add(address.City);
                listView.SubItems.Add(address.Town);
                listView.SubItems.Add(address.AddressDetail);

                lvAdresler.Items.Add(listView);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            _address = new Address();
            _address.PersonId = _personId;
            _address.City=txtSehir.Text;
            _address.Town=txtSehir.Text;
            _address.AddressDetail=txtAdresDetay.Text;

            _addressServices.Add(_address);
            _address = null;
            FillList(_addressServices.GetActive(_personId));
            Helper.Clear(this.Controls);
            ButtonSettings(true);
        }

        private void ButtonSettings(bool set)
        {
            btnKaydet.Enabled = set;
            btnGuncelle.Enabled = !set;
            btnSil.Enabled = !set;
        }

        private void lvAdresler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvAdresler.SelectedItems.Count>0)
            {
                int id = Convert.ToInt32(lvAdresler.SelectedItems[0].SubItems[0].Text);
                _address = _addressServices.Get(id);
                txtSehir.Text = _address.City;
                txtIlce.Text= _address.Town;
                txtAdresDetay.Text= _address.AddressDetail;
                ButtonSettings(true);
            }
            else
            {
                ButtonSettings(true);
                Helper.Clear(this.Controls);
                _address = null;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if(_address!= null)
            {
                _address.City = txtSehir.Text;
                _address.Town = txtSehir.Text;
                _address.AddressDetail = txtAdresDetay.Text;

                _addressServices.Update(_address);
                FillList(_addressServices.GetActive(_personId));
                ButtonSettings(true);
                Helper.Clear(this.Controls);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(_address!= null)
            {
                _addressServices.Delete(_address);
                FillList(_addressServices.GetActive(_personId));
                ButtonSettings(true);
                Helper.Clear(this.Controls);
            }
        }
    }
}
