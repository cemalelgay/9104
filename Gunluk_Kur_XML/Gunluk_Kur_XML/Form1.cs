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

namespace Gunluk_Kur_XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        XmlDocument xmlDoc;
        DateTime tarih;

        private void Form1_Load(object sender, EventArgs e)
        {
            xmlDoc = new XmlDocument();

            //http://www.tcmb.gov.tr/kurlar/201612/29122016.xml
            xmlDoc.Load("http://www.tcmb.gov.tr/kurlar/today.xml");
            tarih = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
        }

        bool dolarState, euroState, poundState;

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int gun = dateTimePicker1.Value.Day;
            int ay = dateTimePicker1.Value.Month;
            int yil = dateTimePicker1.Value.Year;
            string strgun, stray;

            if (gun <= 9)
            {
                strgun = "0" + gun;
            }
            else
            {
                strgun = gun.ToString();
            }

            if (ay <= 9)
            {
                stray = "0" + ay;
            }
            else
            {
                stray = ay.ToString();
            }

            try
            {
                xmlDoc.Load("http://www.tcmb.gov.tr/kurlar/" + yil + stray + "/" + strgun + stray + yil + ".xml");
                tarih = Convert.ToDateTime(xmlDoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);
            }
            catch (Exception)
            {
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Selected = false;
            }

            if (comboBox1.SelectedItem.ToString() == "USD")
            {
                #region Dolar
                if (dataGridView1.Rows.Count != 1)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Dolar")
                        {
                            dolarState = true;
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }

                    if (!dolarState)
                    {
                        string USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
                        dataGridView1.Rows.Add("Dolar", tarih.ToString("dd/MM/yy"), USD);
                    }
                }
                else
                {
                    string USD = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
                    dataGridView1.Rows.Add("Dolar", tarih.ToString("dd/MM/yy"), USD);
                }
                #endregion

            }
            else if (comboBox1.SelectedItem.ToString() == "EUR")
            {
                #region Euro
                if (dataGridView1.Rows.Count != 1)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Euro")
                        {
                            euroState = true;
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }

                    if (!euroState)
                    {
                        string EUR = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
                        dataGridView1.Rows.Add("Euro", tarih.ToString("dd/MM/yy"), EUR);
                    }
                }
                else
                {
                    string EUR = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
                    dataGridView1.Rows.Add("Euro", tarih.ToString("dd/MM/yy"), EUR);
                }
                #endregion
            }
            else
            {
                #region Pound
                if (dataGridView1.Rows.Count != 1)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Pound")
                        {
                            poundState = true;
                            dataGridView1.Rows[i].Selected = true;
                            break;
                        }
                    }

                    if (!poundState)
                    {
                        string GBP = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
                        dataGridView1.Rows.Add("Pound", tarih.ToString("dd/MM/yy"), GBP);
                    }
                }
                else
                {
                    string GBP = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='GBP']/BanknoteSelling").InnerXml;
                    dataGridView1.Rows.Add("Pound", tarih.ToString("dd/MM/yy"), GBP);
                }
                #endregion
                
            }
        }
    }
}
