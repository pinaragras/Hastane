namespace Hastane
{
    partial class FrmSekreterDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSekreterTC = new System.Windows.Forms.Label();
            this.lblSAdSoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chcDurum = new System.Windows.Forms.CheckBox();
            this.mskTC = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.mskTarih = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cmbDoktor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mskSaat = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRdvGuncelle = new System.Windows.Forms.Button();
            this.btnRdvSil = new System.Windows.Forms.Button();
            this.btnRdvKaydet = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnBransPanel = new System.Windows.Forms.Button();
            this.btnDrPanel = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSekreterTC);
            this.groupBox1.Controls.Add(this.lblSAdSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(22, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // lblSekreterTC
            // 
            this.lblSekreterTC.AutoSize = true;
            this.lblSekreterTC.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSekreterTC.Location = new System.Drawing.Point(159, 73);
            this.lblSekreterTC.Name = "lblSekreterTC";
            this.lblSekreterTC.Size = new System.Drawing.Size(144, 28);
            this.lblSekreterTC.TabIndex = 20;
            this.lblSekreterTC.Text = "00000000000";
            // 
            // lblSAdSoyad
            // 
            this.lblSAdSoyad.AutoSize = true;
            this.lblSAdSoyad.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSAdSoyad.Location = new System.Drawing.Point(159, 114);
            this.lblSAdSoyad.Name = "lblSAdSoyad";
            this.lblSAdSoyad.Size = new System.Drawing.Size(101, 28);
            this.lblSAdSoyad.TabIndex = 19;
            this.lblSAdSoyad.Text = "Null Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "T.C. Kimlik No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ad Soyad:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chcDurum);
            this.groupBox3.Controls.Add(this.mskTC);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.mskTarih);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtID);
            this.groupBox3.Controls.Add(this.cmbDoktor);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.mskSaat);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cmbBrans);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(415, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 552);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Paneli";
            // 
            // chcDurum
            // 
            this.chcDurum.AutoSize = true;
            this.chcDurum.Enabled = false;
            this.chcDurum.Location = new System.Drawing.Point(150, 340);
            this.chcDurum.Name = "chcDurum";
            this.chcDurum.Size = new System.Drawing.Size(80, 32);
            this.chcDurum.TabIndex = 7;
            this.chcDurum.Text = "Aktif";
            this.chcDurum.UseVisualStyleBackColor = true;
            // 
            // mskTC
            // 
            this.mskTC.Enabled = false;
            this.mskTC.Location = new System.Drawing.Point(114, 283);
            this.mskTC.Mask = "00000000000";
            this.mskTC.Name = "mskTC";
            this.mskTC.Size = new System.Drawing.Size(211, 36);
            this.mskTC.TabIndex = 6;
            this.mskTC.ValidatingType = typeof(int);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 28);
            this.label9.TabIndex = 25;
            this.label9.Text = "Hasta TC:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 28);
            this.label8.TabIndex = 24;
            this.label8.Text = "Durum:";
            // 
            // mskTarih
            // 
            this.mskTarih.Location = new System.Drawing.Point(114, 115);
            this.mskTarih.Mask = "00/00/0000";
            this.mskTarih.Name = "mskTarih";
            this.mskTarih.Size = new System.Drawing.Size(211, 36);
            this.mskTarih.TabIndex = 2;
            this.mskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 28);
            this.label7.TabIndex = 23;
            this.label7.Text = "Doktor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 28);
            this.label6.TabIndex = 22;
            this.label6.Text = "Branş:";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(114, 73);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(211, 36);
            this.txtID.TabIndex = 1;
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.Enabled = false;
            this.cmbDoktor.FormattingEnabled = true;
            this.cmbDoktor.Location = new System.Drawing.Point(114, 241);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Size = new System.Drawing.Size(211, 36);
            this.cmbDoktor.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "Saat:";
            // 
            // mskSaat
            // 
            this.mskSaat.Location = new System.Drawing.Point(114, 157);
            this.mskSaat.Mask = "00:00";
            this.mskSaat.Name = "mskSaat";
            this.mskSaat.Size = new System.Drawing.Size(211, 36);
            this.mskSaat.TabIndex = 3;
            this.mskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 28);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tarih:";
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Location = new System.Drawing.Point(114, 199);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(211, 36);
            this.cmbBrans.TabIndex = 4;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "ID:";
            // 
            // btnRdvGuncelle
            // 
            this.btnRdvGuncelle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRdvGuncelle.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnRdvGuncelle.Enabled = false;
            this.btnRdvGuncelle.Location = new System.Drawing.Point(128, 189);
            this.btnRdvGuncelle.Name = "btnRdvGuncelle";
            this.btnRdvGuncelle.Size = new System.Drawing.Size(120, 38);
            this.btnRdvGuncelle.TabIndex = 10;
            this.btnRdvGuncelle.Text = "Güncelle";
            this.btnRdvGuncelle.UseVisualStyleBackColor = false;
            this.btnRdvGuncelle.Click += new System.EventHandler(this.btnRdvGuncelle_Click);
            // 
            // btnRdvSil
            // 
            this.btnRdvSil.BackColor = System.Drawing.Color.LightCoral;
            this.btnRdvSil.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRdvSil.Location = new System.Drawing.Point(189, 145);
            this.btnRdvSil.Name = "btnRdvSil";
            this.btnRdvSil.Size = new System.Drawing.Size(100, 38);
            this.btnRdvSil.TabIndex = 9;
            this.btnRdvSil.Text = "Sil";
            this.btnRdvSil.UseVisualStyleBackColor = false;
            this.btnRdvSil.Click += new System.EventHandler(this.btnRdvSil_Click);
            // 
            // btnRdvKaydet
            // 
            this.btnRdvKaydet.BackColor = System.Drawing.Color.Lime;
            this.btnRdvKaydet.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRdvKaydet.Location = new System.Drawing.Point(78, 145);
            this.btnRdvKaydet.Name = "btnRdvKaydet";
            this.btnRdvKaydet.Size = new System.Drawing.Size(105, 38);
            this.btnRdvKaydet.TabIndex = 8;
            this.btnRdvKaydet.Text = "Kaydet";
            this.btnRdvKaydet.UseVisualStyleBackColor = false;
            this.btnRdvKaydet.Click += new System.EventHandler(this.btnRdvKaydet_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(789, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(488, 347);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branşlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(482, 312);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnCikis);
            this.groupBox6.Controls.Add(this.btnListele);
            this.groupBox6.Controls.Add(this.btnBransPanel);
            this.groupBox6.Controls.Add(this.btnDrPanel);
            this.groupBox6.Location = new System.Drawing.Point(22, 598);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(751, 138);
            this.groupBox6.TabIndex = 6;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Hızlı Erişim";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(386, 54);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(183, 46);
            this.btnListele.TabIndex = 3;
            this.btnListele.Text = "Randevu Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnBransPanel
            // 
            this.btnBransPanel.Location = new System.Drawing.Point(216, 54);
            this.btnBransPanel.Name = "btnBransPanel";
            this.btnBransPanel.Size = new System.Drawing.Size(164, 46);
            this.btnBransPanel.TabIndex = 2;
            this.btnBransPanel.Text = "Branş Paneli";
            this.btnBransPanel.UseVisualStyleBackColor = true;
            this.btnBransPanel.Click += new System.EventHandler(this.btnBransPanel_Click);
            // 
            // btnDrPanel
            // 
            this.btnDrPanel.Location = new System.Drawing.Point(47, 54);
            this.btnDrPanel.Name = "btnDrPanel";
            this.btnDrPanel.Size = new System.Drawing.Size(163, 46);
            this.btnDrPanel.TabIndex = 1;
            this.btnDrPanel.Text = "Doktor Paneli";
            this.btnDrPanel.UseVisualStyleBackColor = true;
            this.btnDrPanel.Click += new System.EventHandler(this.btnDrPanel_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(792, 389);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(488, 347);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Doktorlar";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(482, 312);
            this.dataGridView2.TabIndex = 5;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRdvGuncelle);
            this.groupBox2.Controls.Add(this.btnRdvKaydet);
            this.groupBox2.Controls.Add(this.btnRdvSil);
            this.groupBox2.Location = new System.Drawing.Point(22, 220);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 362);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu İşlemleri";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.LightCoral;
            this.btnCikis.Location = new System.Drawing.Point(628, 54);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(90, 46);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1294, 748);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter ve Randuvu Detayları";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSekreterTC;
        private System.Windows.Forms.Label lblSAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRdvKaydet;
        private System.Windows.Forms.CheckBox chcDurum;
        private System.Windows.Forms.MaskedTextBox mskTC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mskTarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cmbDoktor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mskSaat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnBransPanel;
        private System.Windows.Forms.Button btnDrPanel;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnRdvGuncelle;
        private System.Windows.Forms.Button btnRdvSil;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCikis;
    }
}