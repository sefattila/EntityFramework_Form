﻿namespace LoginApp.FormApp.Pages
{
    partial class UserPanel
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            richTextBox1 = new RichTextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            lvTexts = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            btnChangePassword = new Button();
            btnLogOut = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(474, 219);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Paneli";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 0;
            label1.Text = "Başlık";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 75);
            label2.Name = "label2";
            label2.Size = new Size(36, 21);
            label2.TabIndex = 0;
            label2.Text = "Not";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(68, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(190, 25);
            textBox1.TabIndex = 1;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(68, 75);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(190, 123);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(304, 44);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 40);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Kaydet";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(304, 90);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 40);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(304, 136);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 40);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lvTexts
            // 
            lvTexts.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvTexts.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lvTexts.FullRowSelect = true;
            lvTexts.GridLines = true;
            lvTexts.Location = new Point(0, 235);
            lvTexts.Name = "lvTexts";
            lvTexts.Size = new Size(474, 215);
            lvTexts.TabIndex = 1;
            lvTexts.UseCompatibleStateImageBehavior = false;
            lvTexts.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Başlık";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Not";
            columnHeader3.Width = 300;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChangePassword.Location = new Point(188, 477);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(134, 40);
            btnChangePassword.TabIndex = 3;
            btnChangePassword.Text = "Şifremi Değiştir";
            btnChangePassword.UseVisualStyleBackColor = true;
            // 
            // btnLogOut
            // 
            btnLogOut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.Location = new Point(328, 477);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(134, 40);
            btnLogOut.TabIndex = 3;
            btnLogOut.Text = "Çıkış Yap";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // UserPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 527);
            Controls.Add(btnLogOut);
            Controls.Add(btnChangePassword);
            Controls.Add(lvTexts);
            Controls.Add(groupBox1);
            Name = "UserPanel";
            Text = "UserPanel";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private ListView lvTexts;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button btnChangePassword;
        private Button btnLogOut;
    }
}