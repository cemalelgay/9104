using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtobusFirmasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CBoxOtobusTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBoxOtobusTuru.SelectedItem.ToString() == "Setra")
            {
                PanelSetra.Visible = true;
                PanelTravego.Visible = false;
            }
            else if (CBoxOtobusTuru.SelectedItem.ToString() == "Travego")
            {
                PanelTravego.Visible = true;
                PanelSetra.Visible = false;
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button secilenKoltuk = sender as Button;
            LabelKoltukNo.Text = secilenKoltuk.Text;
            LabelOtobusTuru.Text = CBoxOtobusTuru.SelectedItem.ToString();

            RBtnErkek.Checked = false;
            RbtnKadin.Checked = false;

            #region KayıtlıYolcuVarsaBilgileriniGetirme
            if (LabelOtobusTuru.Text == "Travego")
            {
                string yolcu = travegoYolcularIsim[int.Parse(secilenKoltuk.Text) - 1];
                if (yolcu != "")
                {
                    TxtYolcuIsim.Text = yolcu;

                    #region ÖncekiKoltukDurumu
                    string oncekiVeyaSonrakiCinsiyet;
                    int KoltukNo = int.Parse(LabelKoltukNo.Text);
                    if (KoltukNo % 2 == 0)
                    {
                        int bakilacakKoltuk = int.Parse(LabelKoltukNo.Text) - 1;

                        oncekiVeyaSonrakiCinsiyet = travegoYolcularCinsiyet[bakilacakKoltuk - 1];

                        if (oncekiVeyaSonrakiCinsiyet == "Erkek")
                        {
                            RbtnKadin.Enabled = false;
                        }
                        else if (oncekiVeyaSonrakiCinsiyet == "Kadın")
                        {
                            RBtnErkek.Enabled = false;
                        }
                        else
                        {
                            RBtnErkek.Enabled = true;
                            RbtnKadin.Enabled = true;
                        }
                    }
                    else
                    {
                        int bakilacakKoltuk = int.Parse(LabelKoltukNo.Text) + 1;

                        oncekiVeyaSonrakiCinsiyet = travegoYolcularCinsiyet[bakilacakKoltuk - 1];

                        if (oncekiVeyaSonrakiCinsiyet == "Erkek")
                        {
                            RbtnKadin.Enabled = false;
                        }
                        else if (oncekiVeyaSonrakiCinsiyet == "Kadın")
                        {
                            RBtnErkek.Enabled = false;
                        }
                        else
                        {
                            RBtnErkek.Enabled = true;
                            RbtnKadin.Enabled = true;
                        }
                    }
                    #endregion
                    
                    #region CinsiyeteGöreGörünümAyarlama
                    string kendiCinsiyeti = travegoYolcularCinsiyet[int.Parse(secilenKoltuk.Text) - 1];
                    if (kendiCinsiyeti == "Erkek")
                    {
                        RBtnErkek.Checked = true;
                        secilenKoltuk.BackColor = Color.Blue;
                    }
                    else if (kendiCinsiyeti == "Kadın")
                    {
                        RbtnKadin.Checked = true;
                        secilenKoltuk.BackColor = Color.Pink;
                    }
                    #endregion

                }
            }
            else
            {
                string yolcu = setraYolcularIsim[int.Parse(secilenKoltuk.Text) - 1];
                if (yolcu != "")
                {
                    TxtYolcuIsim.Text = yolcu;

                    #region ÖncekiKoltukDurumu
                    string oncekiVeyaSonrakiCinsiyet;
                    int KoltukNo = int.Parse(LabelKoltukNo.Text);
                    if (KoltukNo % 2 == 0)
                    {
                        int bakilacakKoltuk = int.Parse(LabelKoltukNo.Text) - 1;

                        oncekiVeyaSonrakiCinsiyet = setraYolcularCinsiyet[bakilacakKoltuk - 1];

                        if (oncekiVeyaSonrakiCinsiyet == "Erkek")
                        {
                            RbtnKadin.Enabled = false;
                        }
                        else if (oncekiVeyaSonrakiCinsiyet == "Kadın")
                        {
                            RBtnErkek.Enabled = false;
                        }
                        else
                        {
                            RBtnErkek.Enabled = true;
                            RbtnKadin.Enabled = true;
                        }
                    }
                    else
                    {
                        int bakilacakKoltuk = int.Parse(LabelKoltukNo.Text) + 1;

                        oncekiVeyaSonrakiCinsiyet = setraYolcularCinsiyet[bakilacakKoltuk - 1];

                        if (oncekiVeyaSonrakiCinsiyet == "Erkek")
                        {
                            RbtnKadin.Enabled = false;
                        }
                        else if (oncekiVeyaSonrakiCinsiyet == "Kadın")
                        {
                            RBtnErkek.Enabled = false;
                        }
                        else
                        {
                            RBtnErkek.Enabled = true;
                            RbtnKadin.Enabled = true;
                        }
                    }
                    #endregion

                    #region CinsiyeteGöreGörünümAyarlama
                    string kendiCinsiyeti = setraYolcularCinsiyet[int.Parse(secilenKoltuk.Text) - 1];
                    if (kendiCinsiyeti == "Erkek")
                    {
                        RBtnErkek.Checked = true;
                        secilenKoltuk.BackColor = Color.Blue;
                    }
                    else if (kendiCinsiyeti == "Kadın")
                    {
                        RbtnKadin.Checked = true;
                        secilenKoltuk.BackColor = Color.Pink;
                    }
                    #endregion
                }
            }
            #endregion
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PanelTravego.Visible = false;
            PanelSetra.Visible = false;

            #region KoltuklariOlusturmaTravego
            int counter = 1;
            for (int i = 0; i < 12; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((j != 2 || i == 11) && (i != 5 || j < 2))
                    {
                        Button btn = new Button();
                        btn.Click += Button_Click;
                        btn.Width = 30;
                        btn.Height = 30;
                        btn.Text = counter + ""; // counter.ToString();
                        //btn.BackColor = Color.FromArgb(135, 144, 180);
                        btn.BackColor = RenkOlustur(counter, "Travego");
                        btn.Left = (btn.Width * j);
                        btn.Top = (btn.Height * i);
                        PanelTravego.Controls.Add(btn);
                        counter++;
                    }
                }
            }
            #endregion

            #region KoltuklariOlusturmaSetra
            counter = 1;
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if ((j != 2 || i == 12) && (i != 6 || j < 2))
                    {
                        Button btn = new Button();
                        btn.Click += Button_Click;
                        btn.Width = 30;
                        btn.Height = 30;
                        btn.Text = counter + ""; // counter.ToString();
                        //btn.BackColor = Color.FromArgb(135, 144, 180);
                        btn.BackColor = RenkOlustur(counter, "Setra");
                        btn.Left = (btn.Width * j);
                        btn.Top = (btn.Height * i);
                        PanelSetra.Controls.Add(btn);
                        counter++;
                    }
                }
            }
            #endregion
        }

        string[] travegoYolcularIsim = new string[60];
        string[] setraYolcularIsim = new string[60];
        string[] travegoYolcularCinsiyet = new string[60];
        string[] setraYolcularCinsiyet = new string[60];

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            #region YolcuKayıt
            if (LabelOtobusTuru.Text == "Travego")
            {
                travegoYolcularIsim[int.Parse(LabelKoltukNo.Text) - 1] = TxtYolcuIsim.Text;

                string cinsiyet;

                if (RBtnErkek.Checked)
                {
                    cinsiyet = "Erkek";
                }
                else
                {
                    cinsiyet = "Kadın";
                }

                travegoYolcularCinsiyet[int.Parse(LabelKoltukNo.Text) - 1] = cinsiyet;
            }
            else
            {
                setraYolcularIsim[int.Parse(LabelKoltukNo.Text) - 1] = TxtYolcuIsim.Text;

                string cinsiyet;

                if (RBtnErkek.Checked)
                {
                    cinsiyet = "Erkek";
                }
                else
                {
                    cinsiyet = "Kadın";
                }

                setraYolcularCinsiyet[int.Parse(LabelKoltukNo.Text) - 1] = cinsiyet;
            }
            #endregion

            PanelTravego.Controls.Clear();
            PanelSetra.Controls.Clear();

            Form1_Load(sender, e);

            CBoxOtobusTuru.SelectedItem = LabelOtobusTuru.Text;
            CBoxOtobusTuru_SelectedIndexChanged(sender, e);

            TxtYolcuIsim.Text = "";
            LabelKoltukNo.Text = "0";
            LabelOtobusTuru.Text = "-";
        }

        private Color RenkOlustur(int koltukNo, string otobusTuru)
        {
            Color color;

            if (otobusTuru == "Travego")
            {
                string cinsiyet = travegoYolcularCinsiyet[koltukNo - 1];

                if (cinsiyet == "Erkek")
                {
                    color = Color.Blue;
                }
                else if (cinsiyet == "Kadın")
                {
                    color = Color.Pink;
                }
                else
                {
                    color = Color.FromArgb(135, 144, 180);
                }
            }
            else
            {
                string cinsiyet = setraYolcularCinsiyet[koltukNo - 1];

                if (cinsiyet == "Erkek")
                {
                    color = Color.Blue;
                }
                else if (cinsiyet == "Kadın")
                {
                    color = Color.Pink;
                }
                else
                {
                    color = Color.FromArgb(135, 144, 180);
                }
            }

            return color;
        }
    }
}
