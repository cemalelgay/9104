using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenderAsButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int ilksayi, ikincisayi;
        private void ButtonClick(object sender, EventArgs e)
        {
            Button remzi = sender as Button;
            //Button ramiz = (Button)sender;

            //MessageBox.Show(remzi.Text + " e bastın.");

            label1.Text = remzi.Text;
        }
    }
}
