namespace KentKart_OOP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioBtnOgrenci = new System.Windows.Forms.RadioButton();
            this.RadioBtnOgretmen = new System.Windows.Forms.RadioButton();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.RadioBtnTam = new System.Windows.Forms.RadioButton();
            this.LstBoxYolcular = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtOkulAdi = new System.Windows.Forms.TextBox();
            this.GBoxOkulAdi = new System.Windows.Forms.GroupBox();
            this.TxtBakiye = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.GBoxOkulAdi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtBakiye);
            this.groupBox1.Controls.Add(this.GBoxOkulAdi);
            this.groupBox1.Controls.Add(this.RadioBtnTam);
            this.groupBox1.Controls.Add(this.RadioBtnOgretmen);
            this.groupBox1.Controls.Add(this.BtnEkle);
            this.groupBox1.Controls.Add(this.RadioBtnOgrenci);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kart Oluştur";
            // 
            // RadioBtnOgrenci
            // 
            this.RadioBtnOgrenci.AutoSize = true;
            this.RadioBtnOgrenci.Location = new System.Drawing.Point(6, 48);
            this.RadioBtnOgrenci.Name = "RadioBtnOgrenci";
            this.RadioBtnOgrenci.Size = new System.Drawing.Size(76, 21);
            this.RadioBtnOgrenci.TabIndex = 1;
            this.RadioBtnOgrenci.TabStop = true;
            this.RadioBtnOgrenci.Text = "Öğrenci";
            this.RadioBtnOgrenci.UseVisualStyleBackColor = true;
            this.RadioBtnOgrenci.CheckedChanged += new System.EventHandler(this.RadioBtnOgrenci_CheckedChanged);
            // 
            // RadioBtnOgretmen
            // 
            this.RadioBtnOgretmen.AutoSize = true;
            this.RadioBtnOgretmen.Location = new System.Drawing.Point(6, 72);
            this.RadioBtnOgretmen.Name = "RadioBtnOgretmen";
            this.RadioBtnOgretmen.Size = new System.Drawing.Size(89, 21);
            this.RadioBtnOgretmen.TabIndex = 2;
            this.RadioBtnOgretmen.TabStop = true;
            this.RadioBtnOgretmen.Text = "Öğretmen";
            this.RadioBtnOgretmen.UseVisualStyleBackColor = true;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(6, 101);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(100, 29);
            this.BtnEkle.TabIndex = 3;
            this.BtnEkle.Text = "EKLE";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // RadioBtnTam
            // 
            this.RadioBtnTam.AutoSize = true;
            this.RadioBtnTam.Location = new System.Drawing.Point(6, 26);
            this.RadioBtnTam.Name = "RadioBtnTam";
            this.RadioBtnTam.Size = new System.Drawing.Size(54, 21);
            this.RadioBtnTam.TabIndex = 4;
            this.RadioBtnTam.TabStop = true;
            this.RadioBtnTam.Text = "Tam";
            this.RadioBtnTam.UseVisualStyleBackColor = true;
            // 
            // LstBoxYolcular
            // 
            this.LstBoxYolcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LstBoxYolcular.FormattingEnabled = true;
            this.LstBoxYolcular.ItemHeight = 16;
            this.LstBoxYolcular.Location = new System.Drawing.Point(9, 180);
            this.LstBoxYolcular.Name = "LstBoxYolcular";
            this.LstBoxYolcular.Size = new System.Drawing.Size(296, 116);
            this.LstBoxYolcular.TabIndex = 1;
            this.LstBoxYolcular.DoubleClick += new System.EventHandler(this.LstBoxYolcular_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yolcular";
            // 
            // TxtOkulAdi
            // 
            this.TxtOkulAdi.Location = new System.Drawing.Point(6, 29);
            this.TxtOkulAdi.Name = "TxtOkulAdi";
            this.TxtOkulAdi.Size = new System.Drawing.Size(117, 23);
            this.TxtOkulAdi.TabIndex = 5;
            // 
            // GBoxOkulAdi
            // 
            this.GBoxOkulAdi.Controls.Add(this.TxtOkulAdi);
            this.GBoxOkulAdi.Enabled = false;
            this.GBoxOkulAdi.Location = new System.Drawing.Point(126, 64);
            this.GBoxOkulAdi.Name = "GBoxOkulAdi";
            this.GBoxOkulAdi.Size = new System.Drawing.Size(148, 61);
            this.GBoxOkulAdi.TabIndex = 6;
            this.GBoxOkulAdi.TabStop = false;
            this.GBoxOkulAdi.Text = "Okul Adi";
            // 
            // TxtBakiye
            // 
            this.TxtBakiye.Location = new System.Drawing.Point(126, 35);
            this.TxtBakiye.Name = "TxtBakiye";
            this.TxtBakiye.Size = new System.Drawing.Size(148, 23);
            this.TxtBakiye.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(123, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bakiye";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 312);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstBoxYolcular);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GBoxOkulAdi.ResumeLayout(false);
            this.GBoxOkulAdi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioBtnTam;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.RadioButton RadioBtnOgretmen;
        private System.Windows.Forms.RadioButton RadioBtnOgrenci;
        private System.Windows.Forms.ListBox LstBoxYolcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtOkulAdi;
        private System.Windows.Forms.GroupBox GBoxOkulAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBakiye;
    }
}

