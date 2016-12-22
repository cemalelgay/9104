using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Constructor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void BtnOlustur_Click(object sender, EventArgs e)
        {
            string yeniPozisyon = CBoxPozisyon.SelectedItem.ToString();

            Oyuncu oyuncu3 = new Oyuncu();

            MessageBox.Show(oyuncu3.adi + " "  + oyuncu3.formaNo);

            Oyuncu _oyuncu = new Oyuncu("Şehmuz", "Altay");

            MessageBox.Show(_oyuncu.adi + " " + _oyuncu.takimi + " " + _oyuncu.formaNo);

            Oyuncu oyuncu2 = new Oyuncu("Şehmuz", "Altay", yeniPozisyon, 9);

            MessageBox.Show(oyuncu2.adi + " " + oyuncu2.takimi + " " + oyuncu2.pozisyonu + " " + oyuncu2.formaNo);

        }
    }
}
