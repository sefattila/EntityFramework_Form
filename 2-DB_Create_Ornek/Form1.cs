
using _2_DB_Create_Ornek.AppDbContext;
using _2_DB_Create_Ornek.Models;
using System.Reflection;

namespace _2_DB_Create_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            kisiContext = new KisiContext();
            ListeYaz();
            ListViewDoldur();
            SetButtons(true);
        }
        KisiContext kisiContext;
        Kisi kisi;
        private void button1_Click(object sender, EventArgs e)
        {
            Kisi kisi = new Kisi();
            kisi.KisiId = (int)numericUpDown1.Value;
            kisi.KisiAd = textBox1.Text;
            kisi.KisiSoyad = textBox2.Text;
            kisi.DogumTarihi = dateTimePicker1.Value;
            kisi.Telefon = textBox3.Text;
            kisi.Adres = richTextBox1.Text;
            kisi.Sehir = textBox4.Text;

            kisiContext.Kisis.Add(kisi);
            kisiContext.SaveChanges();
            ListeYaz();
            ListViewDoldur();
            Temizle();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                //I.Yöntem
                int id = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                kisi = kisiContext.Kisis.FirstOrDefault(a => a.KisiId == id);

                numericUpDown1.Value = kisi.KisiId;
                textBox1.Text = kisi.KisiAd;
                textBox2.Text = kisi.KisiSoyad;
                dateTimePicker1.Value = kisi.DogumTarihi.Value;
                textBox3.Text = kisi.Telefon;
                richTextBox1.Text = kisi.Adres;
                textBox4.Text = kisi.Sehir;

                SetButtons(false);
            }
            else
            {
                SetButtons(true);
                kisi = null;
                Temizle();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kisi != null)
            {
                kisiContext.Kisis.Remove(kisi);
                kisiContext.SaveChanges();
                ListViewDoldur();
                Temizle();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            kisi.KisiAd = textBox1.Text;
            kisi.KisiSoyad = textBox2.Text;
            kisi.DogumTarihi = dateTimePicker1.Value;
            kisi.Telefon = textBox3.Text;
            kisi.Adres = richTextBox1.Text;
            kisi.Sehir = textBox4.Text;

            kisiContext.Kisis.Update(kisi);
            kisiContext.SaveChanges();
            Temizle();
            SetButtons(true);
            kisi = null;
            ListViewDoldur();
        }
        private void Temizle()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
                else if (control is NumericUpDown)
                {
                    NumericUpDown numeric = (NumericUpDown)control;
                    numeric.Value = 0;
                }
                else if (control is DateTimePicker)
                {
                    DateTimePicker date = (DateTimePicker)control;
                    date.Value = DateTime.Now;
                }
                else if (control is RichTextBox)
                {
                    RichTextBox richText = (RichTextBox)control;
                    richText.Clear();
                }
            }
        }



        private void SetButtons(bool set)
        {
            if (set)
            {
                button1.Enabled = true;
                btnGuncelle.Enabled = false;
                button2.Enabled = false;
                numericUpDown1.Enabled = true;
            }
            else
            {

                button1.Enabled = false;
                btnGuncelle.Enabled = true;
                button2.Enabled = true;
                numericUpDown1.Enabled = false;
            }
        }
        private void ListeYaz()
        {
            List<Kisi> kisiler = kisiContext.Kisis.ToList();
            listBox1.Items.Clear();
            foreach (Kisi kisi1 in kisiler)
            {
                listBox1.Items.Add($"{kisi1.KisiId} {kisi1.KisiAd} {kisi1.KisiSoyad}" +
                    $"{kisi1.DogumTarihi} {kisi1.Telefon} {kisi1.Adres} {kisi1.Sehir}");
            }
        }
        private void ListViewDoldur()
        {
            listView1.Items.Clear();
            List<Kisi> kisiler = kisiContext.Kisis.ToList();
            foreach (Kisi kisi in kisiler)
            {
                //bu şekilde ilk veriyide kabul eder
                //ListViewItem listView = new ListViewItem(kisi.KisiId.ToString()); 
                ListViewItem listView = new ListViewItem();
                listView.Text = kisi.KisiId.ToString();
                listView.SubItems.Add(kisi.KisiAd);
                listView.SubItems.Add(kisi.KisiSoyad);
                listView.SubItems.Add(kisi.DogumTarihi.ToString());
                listView.SubItems.Add(kisi.Telefon);
                listView.SubItems.Add(kisi.Adres);
                listView.SubItems.Add(kisi.Sehir);

                listView1.Items.Add(listView);
            }
        }
    }
}