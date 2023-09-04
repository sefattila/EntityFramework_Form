using _4_KisiEkleme.Contexts;
using _4_KisiEkleme.Models;

namespace _4_KisiEkleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var context = new KisiContext())
            {
                Listele(context);
            };
        }
        Kisi kisi;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new KisiContext())
            {
                kisi = new Kisi();
                kisi.Ad = txtFirstName.Text;
                kisi.Soyad = txtLastName.Text;
                kisi.Tel = mtxtPhone.Text;
                context.Kisis.Add(kisi);
                context.SaveChanges();
                Listele(context);
            }
        }

        void Listele(KisiContext context)
        {
            lvPeople.Items.Clear();
            List<Kisi> kisiler = context.Kisis.ToList();
            foreach (var item in kisiler)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = item.KisiId.ToString();
                listViewItem.SubItems.Add(item.Ad);
                listViewItem.SubItems.Add(item.Soyad);
                listViewItem.SubItems.Add(item.Tel);

                lvPeople.Items.Add(listViewItem);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var context = new KisiContext())
            {
                kisi.Ad = txtFirstName.Text;
                kisi.Soyad = txtLastName.Text;
                kisi.Tel = mtxtPhone.Text;
                context.Kisis.Update(kisi);
                context.SaveChanges();
                Listele(context);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            using (var context = new KisiContext())
            {
                context.Kisis.Remove(kisi);
                context.SaveChanges();
                Listele(context);
            }
        }

        private void lvPeople_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var context = new KisiContext())
            {
                if (lvPeople.SelectedItems.Count > 0)
                {
                    int id = Convert.ToInt32(lvPeople.SelectedItems[0].SubItems[0].Text);
                    kisi = context.Kisis.FirstOrDefault(x => x.KisiId == id);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (var context = new KisiContext())
            {
                var kisiGetir = context.Kisis.Where(x => x.Ad.Contains(txtSearch.Text) || x.Soyad.Contains(txtSearch.Text));
                lvPeople.Items.Clear();
                foreach (var item in kisiGetir)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = item.KisiId.ToString();
                    listViewItem.SubItems.Add(item.Ad);
                    listViewItem.SubItems.Add(item.Soyad);
                    listViewItem.SubItems.Add(item.Tel);

                    lvPeople.Items.Add(listViewItem);
                }
            }
        }

        private void lvPeople_DoubleClick(object sender, EventArgs e)
        {
            txtFirstName.Text = kisi.Ad;
            txtLastName.Text = kisi.Soyad;
            mtxtPhone.Text = kisi.Tel;
        }
    }
}