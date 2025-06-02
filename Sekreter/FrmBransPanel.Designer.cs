namespace Hastane
{
    partial class FrmBransPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBransPanel));
            this.btnBGuncelle = new System.Windows.Forms.Button();
            this.btnBSil = new System.Windows.Forms.Button();
            this.btnBEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.lblHastaAd = new System.Windows.Forms.Label();
            this.txtBransID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBransAd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBGuncelle
            // 
            this.btnBGuncelle.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBGuncelle.Location = new System.Drawing.Point(262, 255);
            this.btnBGuncelle.Name = "btnBGuncelle";
            this.btnBGuncelle.Size = new System.Drawing.Size(120, 38);
            this.btnBGuncelle.TabIndex = 5;
            this.btnBGuncelle.Text = "Güncelle";
            this.btnBGuncelle.UseVisualStyleBackColor = false;
            this.btnBGuncelle.Click += new System.EventHandler(this.btnBGuncelle_Click);
            // 
            // btnBSil
            // 
            this.btnBSil.BackColor = System.Drawing.Color.LightCoral;
            this.btnBSil.Location = new System.Drawing.Point(172, 255);
            this.btnBSil.Name = "btnBSil";
            this.btnBSil.Size = new System.Drawing.Size(84, 38);
            this.btnBSil.TabIndex = 4;
            this.btnBSil.Text = "Sil";
            this.btnBSil.UseVisualStyleBackColor = false;
            this.btnBSil.Click += new System.EventHandler(this.btnBSil_Click);
            // 
            // btnBEkle
            // 
            this.btnBEkle.BackColor = System.Drawing.Color.Lime;
            this.btnBEkle.Location = new System.Drawing.Point(79, 255);
            this.btnBEkle.Name = "btnBEkle";
            this.btnBEkle.Size = new System.Drawing.Size(87, 38);
            this.btnBEkle.TabIndex = 3;
            this.btnBEkle.Text = "Ekle";
            this.btnBEkle.UseVisualStyleBackColor = false;
            this.btnBEkle.Click += new System.EventHandler(this.btnBEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(415, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(565, 284);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 28);
            this.label5.TabIndex = 64;
            this.label5.Text = "Branş Ad:";
            // 
            // lblHastaAd
            // 
            this.lblHastaAd.AutoSize = true;
            this.lblHastaAd.Location = new System.Drawing.Point(90, 131);
            this.lblHastaAd.Name = "lblHastaAd";
            this.lblHastaAd.Size = new System.Drawing.Size(98, 28);
            this.lblHastaAd.TabIndex = 63;
            this.lblHastaAd.Text = "Branş ID:";
            // 
            // txtBransID
            // 
            this.txtBransID.Enabled = false;
            this.txtBransID.Location = new System.Drawing.Point(194, 123);
            this.txtBransID.Name = "txtBransID";
            this.txtBransID.Size = new System.Drawing.Size(188, 36);
            this.txtBransID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 46);
            this.label1.TabIndex = 60;
            this.label1.Text = "Brans Düzenle";
            // 
            // txtBransAd
            // 
            this.txtBransAd.Location = new System.Drawing.Point(194, 173);
            this.txtBransAd.Name = "txtBransAd";
            this.txtBransAd.Size = new System.Drawing.Size(188, 36);
            this.txtBransAd.TabIndex = 65;
            // 
            // FrmBransPanel
            // 
            this.AcceptButton = this.btnBEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1012, 389);
            this.Controls.Add(this.txtBransAd);
            this.Controls.Add(this.btnBGuncelle);
            this.Controls.Add(this.btnBSil);
            this.Controls.Add(this.btnBEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblHastaAd);
            this.Controls.Add(this.txtBransID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmBransPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branş Yönetim Paneli";
            this.Load += new System.EventHandler(this.FrmBransPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBGuncelle;
        private System.Windows.Forms.Button btnBSil;
        private System.Windows.Forms.Button btnBEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblHastaAd;
        private System.Windows.Forms.TextBox txtBransID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBransAd;
    }
}