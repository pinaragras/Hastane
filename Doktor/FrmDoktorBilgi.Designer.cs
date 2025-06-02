namespace Hastane
{
    partial class FrmDoktorBilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgi));
            this.cmbDrCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnDoktorGuncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHastaAd = new System.Windows.Forms.Label();
            this.txtDrSoyad = new System.Windows.Forms.TextBox();
            this.txtDrAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDrSifre = new System.Windows.Forms.TextBox();
            this.mskDrTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDrBrans = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbDrCinsiyet
            // 
            this.cmbDrCinsiyet.FormattingEnabled = true;
            this.cmbDrCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbDrCinsiyet.Location = new System.Drawing.Point(198, 226);
            this.cmbDrCinsiyet.Name = "cmbDrCinsiyet";
            this.cmbDrCinsiyet.Size = new System.Drawing.Size(188, 36);
            this.cmbDrCinsiyet.TabIndex = 3;
            // 
            // btnDoktorGuncelle
            // 
            this.btnDoktorGuncelle.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDoktorGuncelle.Location = new System.Drawing.Point(229, 414);
            this.btnDoktorGuncelle.Name = "btnDoktorGuncelle";
            this.btnDoktorGuncelle.Size = new System.Drawing.Size(112, 38);
            this.btnDoktorGuncelle.TabIndex = 7;
            this.btnDoktorGuncelle.Text = "Güncelle";
            this.btnDoktorGuncelle.UseVisualStyleBackColor = false;
            this.btnDoktorGuncelle.Click += new System.EventHandler(this.btnDoktorGuncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 28);
            this.label7.TabIndex = 46;
            this.label7.Text = "Branş:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 45;
            this.label6.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 44;
            this.label5.Text = "Soyad:";
            // 
            // lblHastaAd
            // 
            this.lblHastaAd.AutoSize = true;
            this.lblHastaAd.Location = new System.Drawing.Point(147, 150);
            this.lblHastaAd.Name = "lblHastaAd";
            this.lblHastaAd.Size = new System.Drawing.Size(45, 28);
            this.lblHastaAd.TabIndex = 43;
            this.lblHastaAd.Text = "Ad:";
            // 
            // txtDrSoyad
            // 
            this.txtDrSoyad.Location = new System.Drawing.Point(198, 184);
            this.txtDrSoyad.Name = "txtDrSoyad";
            this.txtDrSoyad.Size = new System.Drawing.Size(188, 36);
            this.txtDrSoyad.TabIndex = 2;
            // 
            // txtDrAd
            // 
            this.txtDrAd.Location = new System.Drawing.Point(198, 142);
            this.txtDrAd.Name = "txtDrAd";
            this.txtDrAd.Size = new System.Drawing.Size(188, 36);
            this.txtDrAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 46);
            this.label1.TabIndex = 39;
            this.label1.Text = "Doktor Bilgi Güncelle";
            // 
            // txtDrSifre
            // 
            this.txtDrSifre.Location = new System.Drawing.Point(198, 352);
            this.txtDrSifre.Name = "txtDrSifre";
            this.txtDrSifre.Size = new System.Drawing.Size(188, 36);
            this.txtDrSifre.TabIndex = 6;
            // 
            // mskDrTC
            // 
            this.mskDrTC.Enabled = false;
            this.mskDrTC.Location = new System.Drawing.Point(198, 268);
            this.mskDrTC.Mask = "00000000000";
            this.mskDrTC.Name = "mskDrTC";
            this.mskDrTC.Size = new System.Drawing.Size(188, 36);
            this.mskDrTC.TabIndex = 4;
            this.mskDrTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 360);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 36;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 35;
            this.label2.Text = "T.C. Kimlik No:";
            // 
            // cmbDrBrans
            // 
            this.cmbDrBrans.Enabled = false;
            this.cmbDrBrans.FormattingEnabled = true;
            this.cmbDrBrans.Location = new System.Drawing.Point(198, 310);
            this.cmbDrBrans.Name = "cmbDrBrans";
            this.cmbDrBrans.Size = new System.Drawing.Size(188, 36);
            this.cmbDrBrans.TabIndex = 5;
            // 
            // FrmDoktorBilgi
            // 
            this.AcceptButton = this.btnDoktorGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(499, 522);
            this.Controls.Add(this.cmbDrBrans);
            this.Controls.Add(this.cmbDrCinsiyet);
            this.Controls.Add(this.btnDoktorGuncelle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHastaAd);
            this.Controls.Add(this.txtDrSoyad);
            this.Controls.Add(this.txtDrAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDrSifre);
            this.Controls.Add(this.mskDrTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorBilgi";
            this.Text = "Doktor Bilgi Güncelle";
            this.Load += new System.EventHandler(this.FrmDoktorBilgi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDrCinsiyet;
        private System.Windows.Forms.Button btnDoktorGuncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHastaAd;
        private System.Windows.Forms.TextBox txtDrSoyad;
        private System.Windows.Forms.TextBox txtDrAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDrSifre;
        private System.Windows.Forms.MaskedTextBox mskDrTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbDrBrans;
    }
}