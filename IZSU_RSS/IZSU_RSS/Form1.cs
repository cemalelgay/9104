using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace IZSU_RSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList barajTitleList, barajDescriptionList, barajDateList;
        XmlNodeList kesintiTitleList, kesintiDescriptionList, kesintiDateList;
        
        XmlNodeList haberTitleList, haberLinkList, haberDateList;
        private void BtnGetir_Click(object sender, EventArgs e)
        {
            #region Baraj
            xmlDoc.Load("http://www.izsu.gov.tr/Pages/rss.aspx?rssId=3");

            barajTitleList = xmlDoc.SelectNodes("//channel/item/title");
            barajDescriptionList = xmlDoc.SelectNodes("//channel/item/description"); //Doluluk Yüzde Değeri
            barajDateList = xmlDoc.SelectNodes("//channel/item/pubDate");

            for (int i = 0; i < barajTitleList.Count; i++)
            {
                Baraj b = new Baraj(barajTitleList[i].InnerText, barajDescriptionList[i].InnerText);
                b.tarih = Convert.ToDateTime(barajDateList[i].InnerText);
                listBox1.Items.Add(b);
            }
            #endregion

            #region SuKesintisi
            xmlDoc.Load("http://www.izsu.gov.tr/Pages/rss.aspx?rssId=2");

            kesintiTitleList = xmlDoc.SelectNodes("//channel/item/title");
            kesintiDescriptionList = xmlDoc.SelectNodes("//channel/item/description");
            kesintiDateList = xmlDoc.SelectNodes("//channel/item/pubDate");

            for (int i = 0; i < kesintiTitleList.Count; i++)
            {
                Kesinti k = new Kesinti(kesintiTitleList[i].InnerText, kesintiDescriptionList[i].InnerText);
                k.tarih = Convert.ToDateTime(kesintiDateList[i].InnerText);
                listBox2.Items.Add(k);
            }
            #endregion

            #region Haberler
            xmlDoc.Load("http://www.izsu.gov.tr/Pages/rss.aspx?rssId=1");

            haberTitleList = xmlDoc.SelectNodes("//channel/item/title");
            haberLinkList = xmlDoc.SelectNodes("//channel/item/link");
            haberDateList = xmlDoc.SelectNodes("//channel/item/pubDate");

            for (int i = 0; i < haberTitleList.Count; i++)
            {
                Haber h = new Haber(haberTitleList[i].InnerText, haberLinkList[i].InnerText);
                h.tarih = Convert.ToDateTime(haberDateList[i].InnerText);
                listBox3.Items.Add(h);
            }
            #endregion

            //Listedeki elemanları seçme
            //while (true)
            //{
            //    for (int i = 0; i < listBox1.Items.Count; i++)
            //    {
            //        listBox1.SelectedItem = listBox1.Items[i];
            //    }
            //}
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Suları Boşa Harcama!");
        }
        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            Kesinti k = (Kesinti)listBox2.SelectedItem;
            webBrowser1.DocumentText = k.aciklama;
        }
        private void listBox3_DoubleClick(object sender, EventArgs e)
        {
            Haber h = (Haber)listBox3.SelectedItem;
            webBrowser1.Navigate("http://www.izsu.gov.tr" + h.link);
        }
    }
}
