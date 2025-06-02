namespace Hastane
{
    partial class FrmMainPage
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainPage));
            this.btnHastaGir = new System.Windows.Forms.Button();
            this.btnDoktorGir = new System.Windows.Forms.Button();
            this.btnSekreterGir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHastaGir
            // 
            this.btnHastaGir.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnHastaGir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHastaGir.BackgroundImage")));
            this.btnHastaGir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHastaGir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHastaGir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHastaGir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHastaGir.Location = new System.Drawing.Point(41, 293);
            this.btnHastaGir.Name = "btnHastaGir";
            this.btnHastaGir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHastaGir.Size = new System.Drawing.Size(183, 177);
            this.btnHastaGir.TabIndex = 0;
            this.btnHastaGir.UseVisualStyleBackColor = false;
            this.btnHastaGir.Click += new System.EventHandler(this.btnHastaGir_Click);
            // 
            // btnDoktorGir
            // 
            this.btnDoktorGir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoktorGir.BackgroundImage")));
            this.btnDoktorGir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktorGir.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDoktorGir.Location = new System.Drawing.Point(249, 293);
            this.btnDoktorGir.Name = "btnDoktorGir";
            this.btnDoktorGir.Size = new System.Drawing.Size(183, 177);
            this.btnDoktorGir.TabIndex = 1;
            this.btnDoktorGir.UseVisualStyleBackColor = false;
            this.btnDoktorGir.Click += new System.EventHandler(this.btnDoktorGir_Click);
            // 
            // btnSekreterGir
            // 
            this.btnSekreterGir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSekreterGir.BackgroundImage")));
            this.btnSekreterGir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSekreterGir.Location = new System.Drawing.Point(462, 293);
            this.btnSekreterGir.Name = "btnSekreterGir";
            this.btnSekreterGir.Size = new System.Drawing.Size(183, 177);
            this.btnSekreterGir.TabIndex = 2;
            this.btnSekreterGir.UseVisualStyleBackColor = false;
            this.btnSekreterGir.Click += new System.EventHandler(this.btnSekreterGir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta Girişi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(273, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Doktor Girişi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sekreter Girişi";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(466, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(413, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = "Özel Kalp Hastanesi";
            // 
            // FrmMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(687, 580);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSekreterGir);
            this.Controls.Add(this.btnDoktorGir);
            this.Controls.Add(this.btnHastaGir);
            this.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmMainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoşgeldiniz...";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHastaGir;
        private System.Windows.Forms.Button btnDoktorGir;
        private System.Windows.Forms.Button btnSekreterGir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

