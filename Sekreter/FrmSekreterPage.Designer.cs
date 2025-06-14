﻿namespace Hastane
{
    partial class FrmSekreterPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterPage));
            this.btnSGir = new System.Windows.Forms.Button();
            this.txtSSifre = new System.Windows.Forms.TextBox();
            this.mskSTC = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSGir
            // 
            this.btnSGir.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSGir.Location = new System.Drawing.Point(269, 305);
            this.btnSGir.Name = "btnSGir";
            this.btnSGir.Size = new System.Drawing.Size(86, 37);
            this.btnSGir.TabIndex = 3;
            this.btnSGir.Text = "Giriş";
            this.btnSGir.UseVisualStyleBackColor = false;
            this.btnSGir.Click += new System.EventHandler(this.btnSGir_Click);
            // 
            // txtSSifre
            // 
            this.txtSSifre.Location = new System.Drawing.Point(269, 238);
            this.txtSSifre.Name = "txtSSifre";
            this.txtSSifre.Size = new System.Drawing.Size(188, 36);
            this.txtSSifre.TabIndex = 2;
            this.txtSSifre.UseSystemPasswordChar = true;
            // 
            // mskSTC
            // 
            this.mskSTC.Location = new System.Drawing.Point(269, 181);
            this.mskSTC.Mask = "00000000000";
            this.mskSTC.Name = "mskSTC";
            this.mskSTC.Size = new System.Drawing.Size(188, 36);
            this.mskSTC.TabIndex = 1;
            this.mskSTC.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Şifre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "T.C. Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sekreter Giris Paneli";
            // 
            // btnSGeri
            // 
            this.btnSGeri.BackColor = System.Drawing.Color.LightCoral;
            this.btnSGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSGeri.Location = new System.Drawing.Point(375, 305);
            this.btnSGeri.Name = "btnSGeri";
            this.btnSGeri.Size = new System.Drawing.Size(82, 37);
            this.btnSGeri.TabIndex = 4;
            this.btnSGeri.Text = "Geri";
            this.btnSGeri.UseVisualStyleBackColor = false;
            this.btnSGeri.Click += new System.EventHandler(this.btnSGeri_Click);
            // 
            // FrmSekreterPage
            // 
            this.AcceptButton = this.btnSGir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.CancelButton = this.btnSGeri;
            this.ClientSize = new System.Drawing.Size(648, 459);
            this.Controls.Add(this.btnSGeri);
            this.Controls.Add(this.btnSGir);
            this.Controls.Add(this.txtSSifre);
            this.Controls.Add(this.mskSTC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sekreter Giriş Paneli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSGir;
        private System.Windows.Forms.TextBox txtSSifre;
        private System.Windows.Forms.MaskedTextBox mskSTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSGeri;
    }
}