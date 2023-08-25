namespace _3_NorthwindCompany
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.musteriListToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniMusteriToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Id = new System.Windows.Forms.ColumnHeader();
            this.ComponyName = new System.Windows.Forms.ColumnHeader();
            this.ContactName = new System.Windows.Forms.ColumnHeader();
            this.ContactTitle = new System.Windows.Forms.ColumnHeader();
            this.Address = new System.Windows.Forms.ColumnHeader();
            this.City = new System.Windows.Forms.ColumnHeader();
            this.Country = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.musteriListToolStrip,
            this.yeniMusteriToolStrip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // musteriListToolStrip
            // 
            this.musteriListToolStrip.Name = "musteriListToolStrip";
            this.musteriListToolStrip.Size = new System.Drawing.Size(94, 20);
            this.musteriListToolStrip.Text = "Müşteri Listesi";
            this.musteriListToolStrip.Click += new System.EventHandler(this.musteriListToolStrip_Click);
            // 
            // yeniMusteriToolStrip
            // 
            this.yeniMusteriToolStrip.Name = "yeniMusteriToolStrip";
            this.yeniMusteriToolStrip.Size = new System.Drawing.Size(84, 20);
            this.yeniMusteriToolStrip.Text = "Yeni Müşteri";
            this.yeniMusteriToolStrip.Click += new System.EventHandler(this.yeniMusteriToolStrip_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Id,
            this.ComponyName,
            this.ContactName,
            this.ContactTitle,
            this.Address,
            this.City,
            this.Country});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 50);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(808, 379);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // Id
            // 
            this.Id.Text = "ID";
            // 
            // ComponyName
            // 
            this.ComponyName.Text = "Compony Name";
            this.ComponyName.Width = 150;
            // 
            // ContactName
            // 
            this.ContactName.Text = "Contact Name";
            this.ContactName.Width = 150;
            // 
            // ContactTitle
            // 
            this.ContactTitle.Text = "Contact Title";
            this.ContactTitle.Width = 80;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 200;
            // 
            // City
            // 
            this.City.Text = "City";
            this.City.Width = 80;
            // 
            // Country
            // 
            this.Country.Text = "Country";
            this.Country.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 429);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem musteriListToolStrip;
        private ToolStripMenuItem yeniMusteriToolStrip;
        private ListView listView1;
        private ColumnHeader Id;
        private ColumnHeader ComponyName;
        private ColumnHeader ContactName;
        private ColumnHeader ContactTitle;
        private ColumnHeader Address;
        private ColumnHeader City;
        private ColumnHeader Country;
    }
}