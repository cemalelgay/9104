using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeKadarKaldi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            double gunlukSaat = Convert.ToInt32(GunlukSaatTxtB.Text);

            //int gun = 10000 / gunlukSaat;
            //int ay = gun / 30;
            //int yil = gun / 365;

            //MessageBox.Show("Gün : " + gun + "\nAy : " + ay + "\n Yıl : " + yil);


            if (gunlukSaat > 24)
            {
                MessageBox.Show("Hatalı Giriş");
                GunlukSaatTxtB.Text = "";
            }
            else
            {
                double oran = gunlukSaat / 24;
                MessageBox.Show(80 * oran + "");
                //MessageBox.Show((80 * oran).ToString());
            }
            
        }
    }
}
