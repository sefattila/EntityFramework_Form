using TelProject.BLL.Services;
using TelProject.DATA.Entities;

namespace _4_EF_TelProject
{
    public partial class Form1 : Form
    {
        PersonServices personServices;
        Person person;
        public Form1()
        {
            InitializeComponent();
            personServices = new PersonServices();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Person> persons = personServices.GetActive();
            FillList(persons);
            ButtonsSetting(false);
        }

        private void FillList(List<Person> persons)
        {
            lvKisiler.Items.Clear();
            foreach (Person person in persons)
            {
                ListViewItem listView = new ListViewItem();
                listView.Text = person.Id.ToString();
                listView.SubItems.Add(person.FirstName);
                listView.SubItems.Add(person.LastName);
                listView.SubItems.Add(person.Phone);

                lvKisiler.Items.Add(listView);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            person = new Person();
            person.FirstName = txtAd.Text;
            person.LastName = txtSoyad.Text;
            person.Phone = mtxtTelefon.Text;

            personServices.Add(person);
            FillList(personServices.GetActive());

        }

        private void lvKisiler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvKisiler.SelectedItems.Count > 0)
            {
                int id = Convert.ToInt32(lvKisiler.SelectedItems[0].SubItems[0].Text);
                person = personServices.Get(id);

                txtAd.Text = person.FirstName;
                txtSoyad.Text = person.LastName;
                mtxtTelefon.Text = person.Phone;
                ButtonsSetting(false);
            }
            else
            {
                ClearText();
                person = null;
                ButtonsSetting(true);
            }
        }

        private void ClearText()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            mtxtTelefon.Clear();
        }

        private void ButtonsSetting(bool set)
        {
            btnKaydet.Enabled = set;
            btnGuncelle.Enabled = !set;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (person != null)
            {
                person.FirstName = txtAd.Text;
                person.LastName = txtSoyad.Text;
                person.Phone = mtxtTelefon.Text;

                personServices.Update(person);
                FillList(personServices.GetActive());
                ButtonsSetting(true);
                ClearText();
                person = null;
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvKisiler.SelectedItems.Count > 0)
            {
                person = personServices.Get(person.Id);
                personServices.Delete(person);
                ButtonsSetting(true);
                ClearText();
                FillList(personServices.GetActive());
            }
        }

        private void adresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (lvKisiler.SelectedItems.Count > 0)
            {
                this.Hide();
                Form2 form2 = new Form2(person.Id);
                form2.ShowDialog();
                this.Show();
            }
        }
    }
}