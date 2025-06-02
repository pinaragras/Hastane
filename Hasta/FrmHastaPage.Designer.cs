namespace Hastane
{
    partial class FrmHastaPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mskHTC = new System.Windows.Forms.MaskedTextBox();
            this.txtHSifre = new System.Windows.Forms.TextBox();
            this.btnHGir = new System.Windows.Forms.Button();
            this.lnkHKayit = new System.Windows.Forms.LinkLabel();
            this.btnHGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Giris Paneli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "T.C. Kimlik No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Şifre:";
            // 
            // mskHTC
            // 
            this.mskHTC.Location = new System.Drawing.Point(264, 190);
            this.mskHTC.Mask = "00000000000";
            this.mskHTC.Name = "mskHTC";
            this.mskHTC.Size = new System.Drawing.Size(188, 36);
            this.mskHTC.TabIndex = 1;
            this.mskHTC.ValidatingType = typeof(int);
            // 
            // txtHSifre
            // 
            this.txtHSifre.Location = new System.Drawing.Point(264, 247);
            this.txtHSifre.Name = "txtHSifre";
            this.txtHSifre.Size = new System.Drawing.Size(188, 36);
            this.txtHSifre.TabIndex = 2;
            this.txtHSifre.UseSystemPasswordChar = true;
            // 
            // btnHGir
            // 
            this.btnHGir.BackColor = System.Drawing.Color.SpringGreen;
            this.btnHGir.Location = new System.Drawing.Point(264, 314);
            this.btnHGir.Name = "btnHGir";
            this.btnHGir.Size = new System.Drawing.Size(86, 37);
            this.btnHGir.TabIndex = 3;
            this.btnHGir.Text = "Giriş";
            this.btnHGir.UseVisualStyleBackColor = false;
            this.btnHGir.Click += new System.EventHandler(this.btnHGir_Click);
            // 
            // lnkHKayit
            // 
            this.lnkHKayit.AutoSize = true;
            this.lnkHKayit.Location = new System.Drawing.Point(470, 250);
            this.lnkHKayit.Name = "lnkHKayit";
            this.lnkHKayit.Size = new System.Drawing.Size(75, 28);
            this.lnkHKayit.TabIndex = 5;
            this.lnkHKayit.TabStop = true;
            this.lnkHKayit.Text = "Üye Ol";
            this.lnkHKayit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkHKayit_LinkClicked);
            // 
            // btnHGeri
            // 
            this.btnHGeri.BackColor = System.Drawing.Color.LightCoral;
            this.btnHGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHGeri.Location = new System.Drawing.Point(370, 314);
            this.btnHGeri.Name = "btnHGeri";
            this.btnHGeri.Size = new System.Drawing.Size(82, 37);
            this.btnHGeri.TabIndex = 4;
            this.btnHGeri.Text = "Geri";
            this.btnHGeri.UseVisualStyleBackColor = false;
            this.btnHGeri.Click += new System.EventHandler(this.btnHGeri_Click);
            // 
            // FrmHastaPage
            // 
            this.AcceptButton = this.btnHGir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CancelButton = this.btnHGeri;
            this.ClientSize = new System.Drawing.Size(643, 459);
            this.Controls.Add(this.btnHGeri);
            this.Controls.Add(this.lnkHKayit);
            this.Controls.Add(this.btnHGir);
            this.Controls.Add(this.txtHSifre);
            this.Controls.Add(this.mskHTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmHastaPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Giriş Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mskHTC;
        private System.Windows.Forms.TextBox txtHSifre;
        private System.Windows.Forms.Button btnHGir;
        private System.Windows.Forms.LinkLabel lnkHKayit;
        private System.Windows.Forms.Button btnHGeri;
    }
}