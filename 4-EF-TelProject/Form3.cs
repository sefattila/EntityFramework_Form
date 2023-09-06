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
    public partial class Form3 : Form
    {
        PersonServices _personServices;
        public Form3()
        {
            InitializeComponent();
            _personServices= new PersonServices();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            List<Person> persons=_personServices.GetActive();
            foreach (Person person in persons)
            {
                ListViewItem listView=new ListViewItem();
                listView.Text = person.FirstName + " " + person.LastName;
                listView.Tag=person;

                lvKisiler.Items.Add(listView);
            }
        }

        private void lvKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvKisiler.SelectedItems.Count>0)
            {
                Person person = (Person)lvKisiler.FocusedItem.Tag;
                List<Address> addresses = person.Addresses.ToList();
                FillList(addresses);
            }
            else
            {
                lvAdresler.Items.Clear();
            }
        }

        private void FillList(List<Address> addresses)
        {
            lvAdresler.Items.Clear();
            foreach (Address address in addresses)
            {
                ListViewItem listViewItem=new ListViewItem();
                listViewItem.Text = address.City;
                listViewItem.SubItems.Add(address.Town);
                listViewItem.SubItems.Add(address.AddressDetail);

                lvAdresler.Items.Add(listViewItem);
            }
        }
    }
}
