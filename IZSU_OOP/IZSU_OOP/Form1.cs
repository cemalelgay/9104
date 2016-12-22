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

        public List<Abone> Aboneler = new List<Abone>();
        public List<Abone> Odenenler = new List<Abone>();
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

            ListBoxAboneler.Items.Add(_abone);
            Aboneler.Add(_abone);
        }

        private void ListBoxAboneler_DoubleClick(object sender, EventArgs e)
        {
            Abone _abone = (Abone)ListBoxAboneler.SelectedItem;
            double odeme = _abone.OdemeHesapla(_abone.OncekiSayac, _abone.SonSayac, _abone.AboneTuru);

            _abone.GuncelBorc = odeme;
            
            Form2 frm = new Form2(_abone);
            frm.Show();
            this.Hide();
        }

        
        private void ListBoxOdenenler_DoubleClick(object sender, EventArgs e)
        {
            Abone _abone = (Abone)ListBoxOdenenler.SelectedItem;
            Form2 frm = new Form2(_abone);
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Aboneler.Count != 0)
            {
                foreach (var item in Aboneler)
                {
                    ListBoxAboneler.Items.Add(item);
                }
            }

            if (Odenenler.Count != 0)
            {
                foreach (var item in Odenenler)
                {
                    ListBoxOdenenler.Items.Add(item);
                }
            }

        }
    }
}
