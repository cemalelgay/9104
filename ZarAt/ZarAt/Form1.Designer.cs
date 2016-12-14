namespace ZarAt
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
            this.Zar1 = new System.Windows.Forms.PictureBox();
            this.zar2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Zar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zar2)).BeginInit();
            this.SuspendLayout();
            // 
            // Zar1
            // 
            this.Zar1.Location = new System.Drawing.Point(12, 12);
            this.Zar1.Name = "Zar1";
            this.Zar1.Size = new System.Drawing.Size(101, 79);
            this.Zar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Zar1.TabIndex = 0;
            this.Zar1.TabStop = false;
            this.Zar1.Click += new System.EventHandler(this.Zar1_Click);
            // 
            // zar2
            // 
            this.zar2.Location = new System.Drawing.Point(128, 12);
            this.zar2.Name = "zar2";
            this.zar2.Size = new System.Drawing.Size(101, 79);
            this.zar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.zar2.TabIndex = 1;
            this.zar2.TabStop = false;
            this.zar2.Click += new System.EventHandler(this.zar2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 115);
            this.Controls.Add(this.zar2);
            this.Controls.Add(this.Zar1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Zar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zar2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected internal System.Windows.Forms.PictureBox Zar1;
        protected internal System.Windows.Forms.PictureBox zar2;
    }
}

