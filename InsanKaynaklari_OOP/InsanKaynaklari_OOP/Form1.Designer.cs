﻿namespace InsanKaynaklari_OOP
{
    partial class Form1
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
            this.ComboBoxElemanTuru = new System.Windows.Forms.ComboBox();
            this.NumericSskNo = new System.Windows.Forms.NumericUpDown();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.LstBoxCalisanlar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumericMaas = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NumericSatisAdeti = new System.Windows.Forms.NumericUpDown();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSskNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMaas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSatisAdeti)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxElemanTuru
            // 
            this.ComboBoxElemanTuru.FormattingEnabled = true;
            this.ComboBoxElemanTuru.Items.AddRange(new object[] {
            "Satış Temsilcisi"});
            this.ComboBoxElemanTuru.Location = new System.Drawing.Point(85, 12);
            this.ComboBoxElemanTuru.Name = "ComboBoxElemanTuru";
            this.ComboBoxElemanTuru.Size = new System.Drawing.Size(121, 21);
            this.ComboBoxElemanTuru.TabIndex = 0;
            // 
            // NumericSskNo
            // 
            this.NumericSskNo.Location = new System.Drawing.Point(85, 49);
            this.NumericSskNo.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericSskNo.Name = "NumericSskNo";
            this.NumericSskNo.Size = new System.Drawing.Size(120, 20);
            this.NumericSskNo.TabIndex = 2;
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEkle.Location = new System.Drawing.Point(14, 149);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(191, 36);
            this.BtnEkle.TabIndex = 3;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // LstBoxCalisanlar
            // 
            this.LstBoxCalisanlar.FormattingEnabled = true;
            this.LstBoxCalisanlar.Location = new System.Drawing.Point(224, 12);
            this.LstBoxCalisanlar.Name = "LstBoxCalisanlar";
            this.LstBoxCalisanlar.Size = new System.Drawing.Size(209, 173);
            this.LstBoxCalisanlar.TabIndex = 4;
            this.LstBoxCalisanlar.DoubleClick += new System.EventHandler(this.LstBoxCalisanlar_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Eleman Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "SSK No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Maaş";
            // 
            // NumericMaas
            // 
            this.NumericMaas.DecimalPlaces = 2;
            this.NumericMaas.Location = new System.Drawing.Point(85, 80);
            this.NumericMaas.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NumericMaas.Name = "NumericMaas";
            this.NumericMaas.Size = new System.Drawing.Size(120, 20);
            this.NumericMaas.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Satiş Adeti";
            // 
            // NumericSatisAdeti
            // 
            this.NumericSatisAdeti.Location = new System.Drawing.Point(85, 112);
            this.NumericSatisAdeti.Name = "NumericSatisAdeti";
            this.NumericSatisAdeti.Size = new System.Drawing.Size(99, 20);
            this.NumericSatisAdeti.TabIndex = 9;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(185, 110);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(22, 23);
            this.BtnGuncelle.TabIndex = 11;
            this.BtnGuncelle.Text = "G";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 280);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumericSatisAdeti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumericMaas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstBoxCalisanlar);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.NumericSskNo);
            this.Controls.Add(this.ComboBoxElemanTuru);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumericSskNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericMaas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSatisAdeti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxElemanTuru;
        private System.Windows.Forms.NumericUpDown NumericSskNo;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.ListBox LstBoxCalisanlar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown NumericMaas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NumericSatisAdeti;
        private System.Windows.Forms.Button BtnGuncelle;
    }
}

