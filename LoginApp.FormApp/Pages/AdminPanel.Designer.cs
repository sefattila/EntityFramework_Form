namespace LoginApp.FormApp.Pages
{
    partial class AdminPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvPassive = new System.Windows.Forms.ListView();
            this.chId = new System.Windows.Forms.ColumnHeader();
            this.chFirstName = new System.Windows.Forms.ColumnHeader();
            this.chLastName = new System.Windows.Forms.ColumnHeader();
            this.chUserName = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lvLastTen = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvPassive
            // 
            this.lvPassive.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chFirstName,
            this.chLastName,
            this.chUserName});
            this.lvPassive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPassive.FullRowSelect = true;
            this.lvPassive.GridLines = true;
            this.lvPassive.Location = new System.Drawing.Point(3, 25);
            this.lvPassive.Name = "lvPassive";
            this.lvPassive.Size = new System.Drawing.Size(443, 213);
            this.lvPassive.TabIndex = 0;
            this.lvPassive.UseCompatibleStateImageBehavior = false;
            this.lvPassive.View = System.Windows.Forms.View.Details;
            // 
            // chId
            // 
            this.chId.Text = "Id";
            // 
            // chFirstName
            // 
            this.chFirstName.Text = "Ad";
            this.chFirstName.Width = 90;
            // 
            // chLastName
            // 
            this.chLastName.Text = "Soyad";
            this.chLastName.Width = 100;
            // 
            // chUserName
            // 
            this.chUserName.Text = "Kullanıcı Adı";
            this.chUserName.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvPassive);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 241);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Onay Bekleyen Kullanıcılar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLogOut);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(957, 380);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Admin Panel";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(775, 320);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(170, 48);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Çıkış Yap";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lvLastTen);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(493, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 241);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Son 10 Not";
            // 
            // lvLastTen
            // 
            this.lvLastTen.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvLastTen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLastTen.FullRowSelect = true;
            this.lvLastTen.GridLines = true;
            this.lvLastTen.Location = new System.Drawing.Point(3, 25);
            this.lvLastTen.Name = "lvLastTen";
            this.lvLastTen.Size = new System.Drawing.Size(443, 213);
            this.lvLastTen.TabIndex = 0;
            this.lvLastTen.UseCompatibleStateImageBehavior = false;
            this.lvLastTen.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Başlık";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Not";
            this.columnHeader3.Width = 300;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 380);
            this.Controls.Add(this.groupBox2);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lvPassive;
        private ColumnHeader chId;
        private ColumnHeader chFirstName;
        private ColumnHeader chLastName;
        private ColumnHeader chUserName;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnLogOut;
        private ListView lvLastTen;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}