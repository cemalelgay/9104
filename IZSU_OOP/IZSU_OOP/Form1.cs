using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IZSU_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Abone _abone = new Abone();
            _abone.AboneNo = TxtAboneNo.Text;
            _abone.AdSoyad = TxtAdSoyad.Text;
            _abone.OncekiSayac = int.Parse(TxtOncekiSayac.Text);
            _abone.SonSayac = int.Parse(TxtSonSayac.Text);

            string aboneTuru = RadioBtnEv.Checked == true ? "Ev" : "Kurum";
            aboneTuru = RadioBtnKurum.Checked == true ? "Kurum" : "Ev";
            _abone.AboneTuru = aboneTuru;

            ListBoxOdenecekler.Items.Add(_abone);
        }

        private void ListBoxOdenecekler_DoubleClick(object sender, EventArgs e)
        {
            Abone _abone = (Abone)ListBoxOdenecekler.SelectedItem;
            double odeme = _abone.OdemeHesapla(_abone.OncekiSayac, _abone.SonSayac, _abone.AboneTuru);

            DialogResult result = MessageBox.Show("Ödeme Tutarı: " + odeme + "\nÖdeme Yapmak İstiyor Musunu?" , "Ödeme Ekranı", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ListBoxOdenenler.Items.Add(_abone);
                ListBoxOdenecekler.Items.Remove(_abone);
            }
        }

        
        private void ListBoxOdenenler_DoubleClick(object sender, EventArgs e)
        {
            Abone _abone = (Abone)ListBoxOdenenler.SelectedItem;
            Form2 frm = new Form2(_abone);
            frm.Show();
        }
    }
}
