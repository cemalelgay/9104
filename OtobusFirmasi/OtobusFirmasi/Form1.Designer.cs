namespace OtobusFirmasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CBoxOtobusTuru = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelTravego = new System.Windows.Forms.Panel();
            this.PanelSetra = new System.Windows.Forms.Panel();
            this.GBoxMusteriBilgileri = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.LabelOtobusTuru = new System.Windows.Forms.Label();
            this.LabelKoltukNo = new System.Windows.Forms.Label();
            this.GBoxCinsiyet = new System.Windows.Forms.GroupBox();
            this.RbtnKadin = new System.Windows.Forms.RadioButton();
            this.RBtnErkek = new System.Windows.Forms.RadioButton();
            this.TxtYolcuIsim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GBoxMusteriBilgileri.SuspendLayout();
            this.GBoxCinsiyet.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(86, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(621, 127);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CBoxOtobusTuru
            // 
            this.CBoxOtobusTuru.FormattingEnabled = true;
            this.CBoxOtobusTuru.Items.AddRange(new object[] {
            "Travego",
            "Setra"});
            this.CBoxOtobusTuru.Location = new System.Drawing.Point(86, 169);
            this.CBoxOtobusTuru.Name = "CBoxOtobusTuru";
            this.CBoxOtobusTuru.Size = new System.Drawing.Size(121, 21);
            this.CBoxOtobusTuru.TabIndex = 1;
            this.CBoxOtobusTuru.SelectedIndexChanged += new System.EventHandler(this.CBoxOtobusTuru_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Otobüs Türü";
            // 
            // PanelTravego
            // 
            this.PanelTravego.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelTravego.Location = new System.Drawing.Point(222, 150);
            this.PanelTravego.Name = "PanelTravego";
            this.PanelTravego.Size = new System.Drawing.Size(171, 392);
            this.PanelTravego.TabIndex = 3;
            // 
            // PanelSetra
            // 
            this.PanelSetra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelSetra.Location = new System.Drawing.Point(222, 150);
            this.PanelSetra.Name = "PanelSetra";
            this.PanelSetra.Size = new System.Drawing.Size(171, 392);
            this.PanelSetra.TabIndex = 4;
            // 
            // GBoxMusteriBilgileri
            // 
            this.GBoxMusteriBilgileri.Controls.Add(this.label4);
            this.GBoxMusteriBilgileri.Controls.Add(this.label3);
            this.GBoxMusteriBilgileri.Controls.Add(this.BtnKaydet);
            this.GBoxMusteriBilgileri.Controls.Add(this.LabelOtobusTuru);
            this.GBoxMusteriBilgileri.Controls.Add(this.LabelKoltukNo);
            this.GBoxMusteriBilgileri.Controls.Add(this.GBoxCinsiyet);
            this.GBoxMusteriBilgileri.Controls.Add(this.TxtYolcuIsim);
            this.GBoxMusteriBilgileri.Controls.Add(this.label2);
            this.GBoxMusteriBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GBoxMusteriBilgileri.Location = new System.Drawing.Point(408, 150);
            this.GBoxMusteriBilgileri.Name = "GBoxMusteriBilgileri";
            this.GBoxMusteriBilgileri.Size = new System.Drawing.Size(299, 201);
            this.GBoxMusteriBilgileri.TabIndex = 5;
            this.GBoxMusteriBilgileri.TabStop = false;
            this.GBoxMusteriBilgileri.Text = "Müşteri Bilgileri";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Otobus Türü :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Koltuk No :";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(9, 160);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(145, 35);
            this.BtnKaydet.TabIndex = 5;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // LabelOtobusTuru
            // 
            this.LabelOtobusTuru.AutoSize = true;
            this.LabelOtobusTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelOtobusTuru.Location = new System.Drawing.Point(103, 140);
            this.LabelOtobusTuru.Name = "LabelOtobusTuru";
            this.LabelOtobusTuru.Size = new System.Drawing.Size(10, 13);
            this.LabelOtobusTuru.TabIndex = 4;
            this.LabelOtobusTuru.Text = "-";
            // 
            // LabelKoltukNo
            // 
            this.LabelKoltukNo.AutoSize = true;
            this.LabelKoltukNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelKoltukNo.Location = new System.Drawing.Point(84, 120);
            this.LabelKoltukNo.Name = "LabelKoltukNo";
            this.LabelKoltukNo.Size = new System.Drawing.Size(13, 13);
            this.LabelKoltukNo.TabIndex = 3;
            this.LabelKoltukNo.Text = "0";
            // 
            // GBoxCinsiyet
            // 
            this.GBoxCinsiyet.Controls.Add(this.RbtnKadin);
            this.GBoxCinsiyet.Controls.Add(this.RBtnErkek);
            this.GBoxCinsiyet.Location = new System.Drawing.Point(9, 69);
            this.GBoxCinsiyet.Name = "GBoxCinsiyet";
            this.GBoxCinsiyet.Size = new System.Drawing.Size(145, 48);
            this.GBoxCinsiyet.TabIndex = 2;
            this.GBoxCinsiyet.TabStop = false;
            this.GBoxCinsiyet.Text = "Cinsiyet";
            // 
            // RbtnKadin
            // 
            this.RbtnKadin.AutoSize = true;
            this.RbtnKadin.Location = new System.Drawing.Point(81, 19);
            this.RbtnKadin.Name = "RbtnKadin";
            this.RbtnKadin.Size = new System.Drawing.Size(57, 17);
            this.RbtnKadin.TabIndex = 4;
            this.RbtnKadin.Text = "Kadın";
            this.RbtnKadin.UseVisualStyleBackColor = true;
            // 
            // RBtnErkek
            // 
            this.RBtnErkek.AutoSize = true;
            this.RBtnErkek.Location = new System.Drawing.Point(6, 19);
            this.RBtnErkek.Name = "RBtnErkek";
            this.RBtnErkek.Size = new System.Drawing.Size(58, 17);
            this.RBtnErkek.TabIndex = 3;
            this.RBtnErkek.Text = "Erkek";
            this.RBtnErkek.UseVisualStyleBackColor = true;
            // 
            // TxtYolcuIsim
            // 
            this.TxtYolcuIsim.Location = new System.Drawing.Point(9, 43);
            this.TxtYolcuIsim.Name = "TxtYolcuIsim";
            this.TxtYolcuIsim.Size = new System.Drawing.Size(145, 20);
            this.TxtYolcuIsim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ad Soyad";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 546);
            this.Controls.Add(this.GBoxMusteriBilgileri);
            this.Controls.Add(this.PanelSetra);
            this.Controls.Add(this.PanelTravego);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBoxOtobusTuru);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GBoxMusteriBilgileri.ResumeLayout(false);
            this.GBoxMusteriBilgileri.PerformLayout();
            this.GBoxCinsiyet.ResumeLayout(false);
            this.GBoxCinsiyet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox CBoxOtobusTuru;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PanelTravego;
        private System.Windows.Forms.Panel PanelSetra;
        private System.Windows.Forms.GroupBox GBoxMusteriBilgileri;
        private System.Windows.Forms.TextBox TxtYolcuIsim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GBoxCinsiyet;
        private System.Windows.Forms.RadioButton RbtnKadin;
        private System.Windows.Forms.RadioButton RBtnErkek;
        private System.Windows.Forms.Label LabelOtobusTuru;
        private System.Windows.Forms.Label LabelKoltukNo;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

