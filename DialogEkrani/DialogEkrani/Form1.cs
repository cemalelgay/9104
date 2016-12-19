using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialogEkrani
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text != "")
            {
                ListBox.Items.Add(TxtAd.Text);
            }

            TxtAd.Clear(); //TxtAd.Text = "";
            TxtAd.Focus();
            TxtAd.ForeColor = Color.Purple;
        }

        private void ListBox_DoubleClick(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek İstiyor Musun?", "Onay Ekranı", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ListBox.Items.RemoveAt(ListBox.SelectedIndex);
            }
            else if (result == DialogResult.No)
            {

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Hepsi Silincek?", "Onay Ekranı", MessageBoxButtons.OKCancel);

            if (result == DialogResult.OK)
            {
                ListBox.Items.Clear();
            }
            
        }
    }
}
