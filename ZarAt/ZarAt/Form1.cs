using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarAt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Zar1.ImageLocation = System.IO.Path.GetFullPath("Resimler/6.png");
            zar2.ImageLocation = System.IO.Path.GetFullPath("Resimler/6.png");
        }

        private void Fincan()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(1, 7);
            Zar1.ImageLocation = System.IO.Path.GetFullPath("Resimler/" + sayi + ".png");
            sayi = rnd.Next(1, 7);
            zar2.ImageLocation = System.IO.Path.GetFullPath("Resimler/" + sayi + ".png");
        }

        private void Zar1_Click(object sender, EventArgs e)
        {
            Fincan();
        }

        private void zar2_Click(object sender, EventArgs e)
        {
            Fincan();
        }
    }
}
