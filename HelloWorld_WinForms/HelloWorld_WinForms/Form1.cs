using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld_WinForms
{
    public partial class IlkForm : Form
    {
        public IlkForm()
        {
            InitializeComponent();
        }

        private void IlkForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Merhaba İzmir");
        }

        private void KaydetBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ad: " + AdTxtB.Text + "\nSifre: " + SifreTxtB.Text);
        }
    }
}
