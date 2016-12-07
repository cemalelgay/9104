namespace SenderAsButton
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
            this.Btn8 = new System.Windows.Forms.Button();
            this.Btn5 = new System.Windows.Forms.Button();
            this.Btn3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn8
            // 
            this.Btn8.Location = new System.Drawing.Point(102, 12);
            this.Btn8.Name = "Btn8";
            this.Btn8.Size = new System.Drawing.Size(39, 33);
            this.Btn8.TabIndex = 5;
            this.Btn8.Text = "8";
            this.Btn8.UseVisualStyleBackColor = true;
            this.Btn8.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Btn5
            // 
            this.Btn5.Location = new System.Drawing.Point(57, 12);
            this.Btn5.Name = "Btn5";
            this.Btn5.Size = new System.Drawing.Size(39, 33);
            this.Btn5.TabIndex = 4;
            this.Btn5.Text = "5";
            this.Btn5.UseVisualStyleBackColor = true;
            this.Btn5.Click += new System.EventHandler(this.ButtonClick);
            // 
            // Btn3
            // 
            this.Btn3.Location = new System.Drawing.Point(12, 12);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(39, 33);
            this.Btn3.TabIndex = 3;
            this.Btn3.Text = "3";
            this.Btn3.UseVisualStyleBackColor = true;
            this.Btn3.Click += new System.EventHandler(this.ButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(149, 71);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn8);
            this.Controls.Add(this.Btn5);
            this.Controls.Add(this.Btn3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn8;
        private System.Windows.Forms.Button Btn5;
        private System.Windows.Forms.Button Btn3;
        private System.Windows.Forms.Label label1;
    }
}

