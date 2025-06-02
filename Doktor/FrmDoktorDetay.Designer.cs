namespace Hastane
{
    partial class FrmDoktorDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkBilgiDuzelt = new System.Windows.Forms.LinkLabel();
            this.lblDoktorTC = new System.Windows.Forms.Label();
            this.lblDAdSoyad = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rchSikayeti = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCikis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.lnkBilgiDuzelt);
            this.groupBox1.Controls.Add(this.lblDoktorTC);
            this.groupBox1.Controls.Add(this.lblDAdSoyad);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(25, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 170);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişisel Bilgiler";
            // 
            // lnkBilgiDuzelt
            // 
            this.lnkBilgiDuzelt.AutoSize = true;
            this.lnkBilgiDuzelt.Location = new System.Drawing.Point(232, 23);
            this.lnkBilgiDuzelt.Name = "lnkBilgiDuzelt";
            this.lnkBilgiDuzelt.Size = new System.Drawing.Size(134, 28);
            this.lnkBilgiDuzelt.TabIndex = 21;
            this.lnkBilgiDuzelt.TabStop = true;
            this.lnkBilgiDuzelt.Text = "Bilgi Düzenle";
            this.lnkBilgiDuzelt.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBilgiDuzelt_LinkClicked);
            // 
            // lblDoktorTC
            // 
            this.lblDoktorTC.AutoSize = true;
            this.lblDoktorTC.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDoktorTC.Location = new System.Drawing.Point(164, 73);
            this.lblDoktorTC.Name = "lblDoktorTC";
            this.lblDoktorTC.Size = new System.Drawing.Size(144, 28);
            this.lblDoktorTC.TabIndex = 20;
            this.lblDoktorTC.Text = "00000000000";
            // 
            // lblDAdSoyad
            // 
            this.lblDAdSoyad.AutoSize = true;
            this.lblDAdSoyad.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDAdSoyad.Location = new System.Drawing.Point(164, 114);
            this.lblDAdSoyad.Name = "lblDAdSoyad";
            this.lblDAdSoyad.Size = new System.Drawing.Size(101, 28);
            this.lblDAdSoyad.TabIndex = 19;
            this.lblDAdSoyad.Text = "Null Null";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 18;
            this.label2.Text = "T.C. Kimlik No:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 28);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ad Soyad:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(422, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(821, 669);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Randevu Listesi";
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
            this.dataGridView1.Size = new System.Drawing.Size(815, 634);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rchSikayeti);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(25, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 315);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Detay";
            // 
            // rchSikayeti
            // 
            this.rchSikayeti.Location = new System.Drawing.Point(36, 92);
            this.rchSikayeti.Name = "rchSikayeti";
            this.rchSikayeti.Size = new System.Drawing.Size(303, 198);
            this.rchSikayeti.TabIndex = 28;
            this.rchSikayeti.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "Hasta Şikayeti";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCikis);
            this.groupBox4.Location = new System.Drawing.Point(25, 530);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(378, 161);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Hızlı Erişim";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(113, 66);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(126, 40);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // FrmDoktorDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1258, 721);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorDetay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor ve Randevu Detayları";
            this.Load += new System.EventHandler(this.FrmDoktorDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel lnkBilgiDuzelt;
        private System.Windows.Forms.Label lblDoktorTC;
        private System.Windows.Forms.Label lblDAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rchSikayeti;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCikis;
    }
}