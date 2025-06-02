namespace Hastane
{
    partial class FrmDoktorPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorPanel));
            this.label5 = new System.Windows.Forms.Label();
            this.lblHastaAd = new System.Windows.Forms.Label();
            this.txtDoktorSoyad = new System.Windows.Forms.TextBox();
            this.txtDoktorAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mskDoktorTC = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDoktorSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDEkle = new System.Windows.Forms.Button();
            this.btnDSil = new System.Windows.Forms.Button();
            this.btnDGuncelle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.lblUnvan = new System.Windows.Forms.Label();
            this.txtUnvan = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 49;
            this.label5.Text = "Soyad:";
            // 
            // lblHastaAd
            // 
            this.lblHastaAd.AutoSize = true;
            this.lblHastaAd.Location = new System.Drawing.Point(146, 164);
            this.lblHastaAd.Name = "lblHastaAd";
            this.lblHastaAd.Size = new System.Drawing.Size(45, 28);
            this.lblHastaAd.TabIndex = 48;
            this.lblHastaAd.Text = "Ad:";
            // 
            // txtDoktorSoyad
            // 
            this.txtDoktorSoyad.Location = new System.Drawing.Point(197, 198);
            this.txtDoktorSoyad.Name = "txtDoktorSoyad";
            this.txtDoktorSoyad.Size = new System.Drawing.Size(188, 36);
            this.txtDoktorSoyad.TabIndex = 2;
            // 
            // txtDoktorAd
            // 
            this.txtDoktorAd.Location = new System.Drawing.Point(197, 156);
            this.txtDoktorAd.Name = "txtDoktorAd";
            this.txtDoktorAd.Size = new System.Drawing.Size(188, 36);
            this.txtDoktorAd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 46);
            this.label1.TabIndex = 45;
            this.label1.Text = "Doktor Düzenle";
            // 
            // mskDoktorTC
            // 
            this.mskDoktorTC.Location = new System.Drawing.Point(197, 282);
            this.mskDoktorTC.Mask = "00000000000";
            this.mskDoktorTC.Name = "mskDoktorTC";
            this.mskDoktorTC.Size = new System.Drawing.Size(188, 36);
            this.mskDoktorTC.TabIndex = 4;
            this.mskDoktorTC.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 50;
            this.label2.Text = "T.C. Kimlik No:";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(197, 324);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(188, 36);
            this.cmbBrans.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 28);
            this.label6.TabIndex = 52;
            this.label6.Text = "Branş:";
            // 
            // txtDoktorSifre
            // 
            this.txtDoktorSifre.Location = new System.Drawing.Point(197, 366);
            this.txtDoktorSifre.Name = "txtDoktorSifre";
            this.txtDoktorSifre.Size = new System.Drawing.Size(188, 36);
            this.txtDoktorSifre.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 54;
            this.label3.Text = "Şifre:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(420, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(782, 312);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnDEkle
            // 
            this.btnDEkle.BackColor = System.Drawing.Color.Lime;
            this.btnDEkle.Location = new System.Drawing.Point(61, 428);
            this.btnDEkle.Name = "btnDEkle";
            this.btnDEkle.Size = new System.Drawing.Size(87, 38);
            this.btnDEkle.TabIndex = 7;
            this.btnDEkle.Text = "Ekle";
            this.btnDEkle.UseVisualStyleBackColor = false;
            this.btnDEkle.Click += new System.EventHandler(this.btnDEkle_Click);
            // 
            // btnDSil
            // 
            this.btnDSil.BackColor = System.Drawing.Color.LightCoral;
            this.btnDSil.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDSil.Location = new System.Drawing.Point(165, 428);
            this.btnDSil.Name = "btnDSil";
            this.btnDSil.Size = new System.Drawing.Size(84, 38);
            this.btnDSil.TabIndex = 8;
            this.btnDSil.Text = "Sil";
            this.btnDSil.UseVisualStyleBackColor = false;
            this.btnDSil.Click += new System.EventHandler(this.btnDSil_Click);
            // 
            // btnDGuncelle
            // 
            this.btnDGuncelle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDGuncelle.Location = new System.Drawing.Point(265, 428);
            this.btnDGuncelle.Name = "btnDGuncelle";
            this.btnDGuncelle.Size = new System.Drawing.Size(120, 38);
            this.btnDGuncelle.TabIndex = 9;
            this.btnDGuncelle.Text = "Güncelle";
            this.btnDGuncelle.UseVisualStyleBackColor = false;
            this.btnDGuncelle.Click += new System.EventHandler(this.btnDGuncelle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 28);
            this.label4.TabIndex = 61;
            this.label4.Text = "Cinsiyet:";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(197, 240);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(188, 36);
            this.cmbCinsiyet.TabIndex = 3;
            // 
            // lblUnvan
            // 
            this.lblUnvan.AutoSize = true;
            this.lblUnvan.Location = new System.Drawing.Point(112, 122);
            this.lblUnvan.Name = "lblUnvan";
            this.lblUnvan.Size = new System.Drawing.Size(79, 28);
            this.lblUnvan.TabIndex = 63;
            this.lblUnvan.Text = "Unvan:";
            // 
            // txtUnvan
            // 
            this.txtUnvan.Location = new System.Drawing.Point(197, 114);
            this.txtUnvan.Name = "txtUnvan";
            this.txtUnvan.Size = new System.Drawing.Size(188, 36);
            this.txtUnvan.TabIndex = 62;
            // 
            // FrmDoktorPanel
            // 
            this.AcceptButton = this.btnDEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1227, 554);
            this.Controls.Add(this.lblUnvan);
            this.Controls.Add(this.txtUnvan);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDGuncelle);
            this.Controls.Add(this.btnDSil);
            this.Controls.Add(this.btnDEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtDoktorSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.mskDoktorTC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHastaAd);
            this.Controls.Add(this.txtDoktorSoyad);
            this.Controls.Add(this.txtDoktorAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Yönetim Paneli";
            this.Load += new System.EventHandler(this.FrmDoktorPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHastaAd;
        private System.Windows.Forms.TextBox txtDoktorSoyad;
        private System.Windows.Forms.TextBox txtDoktorAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskDoktorTC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDoktorSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDEkle;
        private System.Windows.Forms.Button btnDSil;
        private System.Windows.Forms.Button btnDGuncelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label lblUnvan;
        private System.Windows.Forms.TextBox txtUnvan;
    }
}