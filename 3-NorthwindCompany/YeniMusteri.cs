using _3_NorthwindCompany.AppDbContext;
using _3_NorthwindCompany.Models;
using _3_NorthwindCompany.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_NorthwindCompany
{
    public partial class YeniMusteri : Form
    {
        public string Id { get; set; }
        public NorthwindContext NorthwindContext { get; set; }
        public Customer Customer { get; set; }
        //Customer customer;
        //NorthwindContext dbNorthwindContext;
        public YeniMusteri()
        {
            //customer=new Customer();
            //dbNorthwindContext= new NorthwindContext();
            InitializeComponent();
        }
        public YeniMusteri(string id, NorthwindContext northwindContext, Customer customer)
        {
            this.NorthwindContext = northwindContext;
            this.Customer = customer;
            this.Id = id;
            InitializeComponent();
        }

        private void YeniMusteri_Load(object sender, EventArgs e)
        {
            if (Customer != null)
            {
                //Customer = NorthwindContext.Customers.FirstOrDefault(p => p.CustomerId == Id);
                txtCustomerID.Text = Customer.CustomerId;
                txtCompanyName.Text = Customer.CompanyName;
                txtContactName.Text = Customer.ContactName;
                txtContactTitle.Text = Customer.ContactTitle;
                txtAddress.Text = Customer.Address;
                txtCity.Text = Customer.City;
                txtCountry.Text = Customer.Country;
                btnKaydet.Enabled = true;
                txtCustomerID.Enabled = false;
            }
            else
            {
                btnKaydet.Text = "Ekle";
                btnSil.Enabled = false;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Customer != null)
            {
                //Customer.CustomerId = txtCustomerID.Text;
                Customer.CompanyName = txtCompanyName.Text;
                Customer.ContactName = txtContactName.Text;
                Customer.ContactTitle = txtContactTitle.Text;
                Customer.Address = txtAddress.Text;
                Customer.City = txtCity.Text;
                Customer.Country = txtCountry.Text;
                NorthwindContext.Customers.Update(Customer);
                NorthwindContext.SaveChanges();
                Helper.Temizle(this.Controls);
            }
            else
            {
                Customer = new Customer();
                NorthwindContext = new NorthwindContext();
                Customer.CustomerId = txtCustomerID.Text;
                Customer.CompanyName = txtCompanyName.Text;
                Customer.ContactName = txtContactName.Text;
                Customer.ContactTitle = txtContactTitle.Text;
                Customer.Address = txtAddress.Text;
                Customer.City = txtCity.Text;
                Customer.Country = txtCountry.Text;
                NorthwindContext.Customers.Add(Customer);
                NorthwindContext.SaveChanges();
                Helper.Temizle(this.Controls);
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Customer != null)
            {
                NorthwindContext.Customers.Remove(Customer);
                NorthwindContext.SaveChanges();
                Helper.Temizle(this.Controls);
            }
        }
        //private void Temizle()
        //{
        //    foreach (Control control in this.Controls)
        //    {
        //        if (control is TextBox)
        //        {
        //            TextBox textBox = (TextBox)control;
        //            textBox.Clear();
        //        }
        //        else if (control is NumericUpDown)
        //        {
        //            NumericUpDown numeric = (NumericUpDown)control;
        //            numeric.Value = 0;
        //        }
        //        else if (control is DateTimePicker)
        //        {
        //            DateTimePicker date = (DateTimePicker)control;
        //            date.Value = DateTime.Now;
        //        }
        //        else if (control is RichTextBox)
        //        {
        //            RichTextBox richText = (RichTextBox)control;
        //            richText.Clear();
        //        }
        //    }
        //}
    }
}
