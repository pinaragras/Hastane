namespace Hastane
{
    partial class FrmHastaBilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaBilgi));
            this.cmbHastaCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnHastaGuncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHastaAd = new System.Windows.Forms.Label();
            this.txtHastaSoyad = new System.Windows.Forms.TextBox();
            this.txtHastaAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHastaSifre = new System.Windows.Forms.TextBox();
            this.mskHastaTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbHastaCinsiyet
            // 
            this.cmbHastaCinsiyet.FormattingEnabled = true;
            this.cmbHastaCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbHastaCinsiyet.Location = new System.Drawing.Point(183, 262);
            this.cmbHastaCinsiyet.Name = "cmbHastaCinsiyet";
            this.cmbHastaCinsiyet.Size = new System.Drawing.Size(188, 36);
            this.cmbHastaCinsiyet.TabIndex = 3;
            // 
            // btnHastaGuncelle
            // 
            this.btnHastaGuncelle.BackColor = System.Drawing.Color.SpringGreen;
            this.btnHastaGuncelle.Location = new System.Drawing.Point(214, 407);
            this.btnHastaGuncelle.Name = "btnHastaGuncelle";
            this.btnHastaGuncelle.Size = new System.Drawing.Size(112, 38);
            this.btnHastaGuncelle.TabIndex = 33;
            this.btnHastaGuncelle.Text = "Güncelle";
            this.btnHastaGuncelle.UseVisualStyleBackColor = false;
            this.btnHastaGuncelle.Click += new System.EventHandler(this.btnHastaGuncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 31;
            this.label6.Text = "Cinsiyet:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 30;
            this.label5.Text = "Soyad:";
            // 
            // lblHastaAd
            // 
            this.lblHastaAd.AutoSize = true;
            this.lblHastaAd.Location = new System.Drawing.Point(132, 186);
            this.lblHastaAd.Name = "lblHastaAd";
            this.lblHastaAd.Size = new System.Drawing.Size(45, 28);
            this.lblHastaAd.TabIndex = 29;
            this.lblHastaAd.Text = "Ad:";
            // 
            // txtHastaSoyad
            // 
            this.txtHastaSoyad.Location = new System.Drawing.Point(183, 220);
            this.txtHastaSoyad.Name = "txtHastaSoyad";
            this.txtHastaSoyad.Size = new System.Drawing.Size(188, 36);
            this.txtHastaSoyad.TabIndex = 2;
            // 
            // txtHastaAd
            // 
            this.txtHastaAd.Location = new System.Drawing.Point(183, 178);
            this.txtHastaAd.Name = "txtHastaAd";
            this.txtHastaAd.Size = new System.Drawing.Size(188, 36);
            this.txtHastaAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 46);
            this.label1.TabIndex = 25;
            this.label1.Text = "Hasta Bilgi Güncelle";
            // 
            // txtHastaSifre
            // 
            this.txtHastaSifre.Location = new System.Drawing.Point(183, 345);
            this.txtHastaSifre.Name = "txtHastaSifre";
            this.txtHastaSifre.Size = new System.Drawing.Size(188, 36);
            this.txtHastaSifre.TabIndex = 6;
            // 
            // mskHastaTC
            // 
            this.mskHastaTC.Enabled = false;
            this.mskHastaTC.Location = new System.Drawing.Point(183, 304);
            this.mskHastaTC.Mask = "00000000000";
            this.mskHastaTC.Name = "mskHastaTC";
            this.mskHastaTC.Size = new System.Drawing.Size(188, 36);
            this.mskHastaTC.TabIndex = 4;
            this.mskHastaTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 21;
            this.label2.Text = "T.C. Kimlik No:";
            // 
            // FrmHastaBilgi
            // 
            this.AcceptButton = this.btnHastaGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(450, 518);
            this.Controls.Add(this.cmbHastaCinsiyet);
            this.Controls.Add(this.btnHastaGuncelle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHastaAd);
            this.Controls.Add(this.txtHastaSoyad);
            this.Controls.Add(this.txtHastaAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHastaSifre);
            this.Controls.Add(this.mskHastaTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaBilgi";
            this.Text = "Hasta Bilgi Güncelle";
            this.Load += new System.EventHandler(this.FrmHastaBilgi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbHastaCinsiyet;
        private System.Windows.Forms.Button btnHastaGuncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHastaAd;
        private System.Windows.Forms.TextBox txtHastaSoyad;
        private System.Windows.Forms.TextBox txtHastaAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHastaSifre;
        private System.Windows.Forms.MaskedTextBox mskHastaTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}