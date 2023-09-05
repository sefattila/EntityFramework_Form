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
    }
}
