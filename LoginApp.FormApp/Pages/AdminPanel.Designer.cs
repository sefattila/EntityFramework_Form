﻿namespace LoginApp.FormApp.Pages
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
            lvPassive = new ListView();
            chId = new ColumnHeader();
            chFirstName = new ColumnHeader();
            chLastName = new ColumnHeader();
            chUserName = new ColumnHeader();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            btnLogOut = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lvPassive
            // 
            lvPassive.Columns.AddRange(new ColumnHeader[] { chId, chFirstName, chLastName, chUserName });
            lvPassive.Dock = DockStyle.Fill;
            lvPassive.FullRowSelect = true;
            lvPassive.GridLines = true;
            lvPassive.Location = new Point(3, 25);
            lvPassive.Name = "lvPassive";
            lvPassive.Size = new Size(443, 213);
            lvPassive.TabIndex = 0;
            lvPassive.UseCompatibleStateImageBehavior = false;
            lvPassive.View = View.Details;
            // 
            // chId
            // 
            chId.Text = "Id";
            // 
            // chFirstName
            // 
            chFirstName.Text = "Ad";
            chFirstName.Width = 90;
            // 
            // chLastName
            // 
            chLastName.Text = "Soyad";
            chLastName.Width = 100;
            // 
            // chUserName
            // 
            chUserName.Text = "Kullanıcı Adı";
            chUserName.Width = 120;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lvPassive);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 47);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(449, 241);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Onay Bekleyen Kullanıcılar";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnLogOut);
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(957, 380);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Admin Panel";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listView1);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(493, 47);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(449, 241);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kayıt Olan Son 10 Kullanıcı";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(3, 25);
            listView1.Name = "listView1";
            listView1.Size = new Size(443, 213);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ad";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyad";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Kullanıcı Adı";
            columnHeader4.Width = 120;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(775, 320);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(170, 48);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Çıkış Yap";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 380);
            Controls.Add(groupBox2);
            Name = "AdminPanel";
            Text = "AdminPanel";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
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
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
    }
}