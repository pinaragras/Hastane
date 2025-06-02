namespace Hastane
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.txtHastaSifre = new System.Windows.Forms.TextBox();
            this.mskHastaTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHastaAd = new System.Windows.Forms.TextBox();
            this.txtHastaSoyad = new System.Windows.Forms.TextBox();
            this.lblHastaAd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHastaKayit = new System.Windows.Forms.Button();
            this.cmbHastaCinsiyet = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtHastaSifre
            // 
            this.txtHastaSifre.Location = new System.Drawing.Point(178, 315);
            this.txtHastaSifre.Name = "txtHastaSifre";
            this.txtHastaSifre.Size = new System.Drawing.Size(188, 36);
            this.txtHastaSifre.TabIndex = 6;
            this.txtHastaSifre.UseSystemPasswordChar = true;
            // 
            // mskHastaTC
            // 
            this.mskHastaTC.Location = new System.Drawing.Point(178, 274);
            this.mskHastaTC.Mask = "00000000000";
            this.mskHastaTC.Name = "mskHastaTC";
            this.mskHastaTC.Size = new System.Drawing.Size(188, 36);
            this.mskHastaTC.TabIndex = 4;
            this.mskHastaTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "T.C. Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 46);
            this.label1.TabIndex = 9;
            this.label1.Text = "Yeni Üyelik Kaydı";
            // 
            // txtHastaAd
            // 
            this.txtHastaAd.Location = new System.Drawing.Point(178, 148);
            this.txtHastaAd.Name = "txtHastaAd";
            this.txtHastaAd.Size = new System.Drawing.Size(188, 36);
            this.txtHastaAd.TabIndex = 1;
            // 
            // txtHastaSoyad
            // 
            this.txtHastaSoyad.Location = new System.Drawing.Point(178, 190);
            this.txtHastaSoyad.Name = "txtHastaSoyad";
            this.txtHastaSoyad.Size = new System.Drawing.Size(188, 36);
            this.txtHastaSoyad.TabIndex = 2;
            // 
            // lblHastaAd
            // 
            this.lblHastaAd.AutoSize = true;
            this.lblHastaAd.Location = new System.Drawing.Point(127, 156);
            this.lblHastaAd.Name = "lblHastaAd";
            this.lblHastaAd.Size = new System.Drawing.Size(45, 28);
            this.lblHastaAd.TabIndex = 15;
            this.lblHastaAd.Text = "Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 16;
            this.label5.Text = "Soyad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cinsiyet:";
            // 
            // btnHastaKayit
            // 
            this.btnHastaKayit.BackColor = System.Drawing.Color.SpringGreen;
            this.btnHastaKayit.Location = new System.Drawing.Point(209, 377);
            this.btnHastaKayit.Name = "btnHastaKayit";
            this.btnHastaKayit.Size = new System.Drawing.Size(112, 38);
            this.btnHastaKayit.TabIndex = 7;
            this.btnHastaKayit.Text = "Üye Ol";
            this.btnHastaKayit.UseVisualStyleBackColor = false;
            this.btnHastaKayit.Click += new System.EventHandler(this.btnHastaKayit_Click);
            // 
            // cmbHastaCinsiyet
            // 
            this.cmbHastaCinsiyet.FormattingEnabled = true;
            this.cmbHastaCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbHastaCinsiyet.Location = new System.Drawing.Point(178, 232);
            this.cmbHastaCinsiyet.Name = "cmbHastaCinsiyet";
            this.cmbHastaCinsiyet.Size = new System.Drawing.Size(188, 36);
            this.cmbHastaCinsiyet.TabIndex = 3;
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.btnHastaKayit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(440, 469);
            this.Controls.Add(this.cmbHastaCinsiyet);
            this.Controls.Add(this.btnHastaKayit);
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
            this.Name = "FrmHastaKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Üyelik Oluştur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHastaSifre;
        private System.Windows.Forms.MaskedTextBox mskHastaTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHastaAd;
        private System.Windows.Forms.TextBox txtHastaSoyad;
        private System.Windows.Forms.Label lblHastaAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHastaKayit;
        private System.Windows.Forms.ComboBox cmbHastaCinsiyet;
    }
}