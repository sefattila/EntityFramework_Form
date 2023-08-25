using _3_NorthwindCompany.AppDbContext;
using _3_NorthwindCompany.Models;

namespace _3_NorthwindCompany
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dbNorthwindContext = new NorthwindContext();
            customer = new Customer();
        }
        NorthwindContext dbNorthwindContext;
        Customer customer;
        private void musteriListToolStrip_Click(object sender, EventArgs e)
        {
            ListViewDoldur();
        }
        private void ListViewDoldur()
        {
            listView1.Items.Clear();
            List<Customer> customers = dbNorthwindContext.Customers.ToList();
            foreach (Customer customer in customers)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = customer.CustomerId.ToString();
                listViewItem.SubItems.Add(customer.CompanyName);
                listViewItem.SubItems.Add(customer.ContactName);
                listViewItem.SubItems.Add(customer.ContactTitle);
                listViewItem.SubItems.Add(customer.Address);
                listViewItem.SubItems.Add(customer.City);
                listViewItem.SubItems.Add(customer.Country);

                listView1.Items.Add(listViewItem);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            YeniMusteri yeniMusteri = new YeniMusteri();
            if (listView1.SelectedItems.Count > 0)
            {
                string id = listView1.SelectedItems[0].SubItems[0].Text;
                customer = dbNorthwindContext.Customers.FirstOrDefault(p => p.CustomerId == id);


            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            string id = string.Empty;
            if (listView1.SelectedItems.Count > 0)
            {
                id = listView1.SelectedItems[0].SubItems[0].Text;
            }
            YeniMusteri yeniMusteri = new YeniMusteri(id,dbNorthwindContext,customer);
            yeniMusteri.ShowDialog();
        }

        private void yeniMusteriToolStrip_Click(object sender, EventArgs e)
        {
            YeniMusteri yeniMusteri = new YeniMusteri();
            yeniMusteri.ShowDialog();
        }
    }
}