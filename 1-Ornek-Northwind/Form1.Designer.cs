namespace _1_Ornek_Northwind
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
            this.btnCalisanGetir = new System.Windows.Forms.Button();
            this.lBoxCalisanGetir = new System.Windows.Forms.ListBox();
            this.btnCalisanEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalisanGetir
            // 
            this.btnCalisanGetir.Location = new System.Drawing.Point(29, 12);
            this.btnCalisanGetir.Name = "btnCalisanGetir";
            this.btnCalisanGetir.Size = new System.Drawing.Size(150, 77);
            this.btnCalisanGetir.TabIndex = 0;
            this.btnCalisanGetir.Text = "btnCalisanGetir";
            this.btnCalisanGetir.UseVisualStyleBackColor = true;
            this.btnCalisanGetir.Click += new System.EventHandler(this.button1_Click);
            // 
            // lBoxCalisanGetir
            // 
            this.lBoxCalisanGetir.FormattingEnabled = true;
            this.lBoxCalisanGetir.ItemHeight = 15;
            this.lBoxCalisanGetir.Location = new System.Drawing.Point(12, 109);
            this.lBoxCalisanGetir.Name = "lBoxCalisanGetir";
            this.lBoxCalisanGetir.Size = new System.Drawing.Size(466, 214);
            this.lBoxCalisanGetir.TabIndex = 1;
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.Location = new System.Drawing.Point(238, 12);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(150, 77);
            this.btnCalisanEkle.TabIndex = 2;
            this.btnCalisanEkle.Text = "button2";
            this.btnCalisanEkle.UseVisualStyleBackColor = true;
            this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 342);
            this.Controls.Add(this.btnCalisanEkle);
            this.Controls.Add(this.lBoxCalisanGetir);
            this.Controls.Add(this.btnCalisanGetir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCalisanGetir;
        private ListBox lBoxCalisanGetir;
        private Button btnCalisanEkle;
    }
}