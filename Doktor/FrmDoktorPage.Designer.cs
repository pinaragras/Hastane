namespace Hastane
{
    partial class FrmDoktorPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorPage));
            this.btnDGir = new System.Windows.Forms.Button();
            this.txtDSifre = new System.Windows.Forms.TextBox();
            this.mskDTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDGir
            // 
            this.btnDGir.BackColor = System.Drawing.Color.SpringGreen;
            this.btnDGir.Location = new System.Drawing.Point(252, 303);
            this.btnDGir.Name = "btnDGir";
            this.btnDGir.Size = new System.Drawing.Size(86, 37);
            this.btnDGir.TabIndex = 3;
            this.btnDGir.Text = "Giriş";
            this.btnDGir.UseVisualStyleBackColor = false;
            this.btnDGir.Click += new System.EventHandler(this.btnDGir_Click);
            // 
            // txtDSifre
            // 
            this.txtDSifre.Location = new System.Drawing.Point(252, 244);
            this.txtDSifre.Name = "txtDSifre";
            this.txtDSifre.Size = new System.Drawing.Size(188, 36);
            this.txtDSifre.TabIndex = 2;
            this.txtDSifre.UseSystemPasswordChar = true;
            // 
            // mskDTC
            // 
            this.mskDTC.Location = new System.Drawing.Point(252, 187);
            this.mskDTC.Mask = "00000000000";
            this.mskDTC.Name = "mskDTC";
            this.mskDTC.Size = new System.Drawing.Size(188, 36);
            this.mskDTC.TabIndex = 1;
            this.mskDTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "T.C. Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Doktor Giris Paneli";
            // 
            // btnDGeri
            // 
            this.btnDGeri.BackColor = System.Drawing.Color.LightCoral;
            this.btnDGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDGeri.Location = new System.Drawing.Point(358, 303);
            this.btnDGeri.Name = "btnDGeri";
            this.btnDGeri.Size = new System.Drawing.Size(82, 37);
            this.btnDGeri.TabIndex = 4;
            this.btnDGeri.Text = "Geri";
            this.btnDGeri.UseVisualStyleBackColor = false;
            this.btnDGeri.Click += new System.EventHandler(this.btnDGeri_Click);
            // 
            // FrmDoktorPage
            // 
            this.AcceptButton = this.btnDGir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CancelButton = this.btnDGeri;
            this.ClientSize = new System.Drawing.Size(641, 462);
            this.Controls.Add(this.btnDGeri);
            this.Controls.Add(this.btnDGir);
            this.Controls.Add(this.txtDSifre);
            this.Controls.Add(this.mskDTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmDoktorPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Giriş Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDGir;
        private System.Windows.Forms.TextBox txtDSifre;
        private System.Windows.Forms.MaskedTextBox mskDTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDGeri;
    }
}