﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomobil_OOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Porsche superAraba = new Porsche();
            //Tofas duldul = new Tofas();
            //Honda memurArabasi = new Honda();

            //MessageBox.Show(superAraba.Yazdir());
            //MessageBox.Show(superAraba.Calistir());

            //MessageBox.Show(duldul.Yazdir());
            //MessageBox.Show(duldul.Calistir());

            //MessageBox.Show(memurArabasi.Yazdir());
            //MessageBox.Show(memurArabasi.Calistir());

            Porsche superAraba = new Porsche();
            Tofas duldul = new Tofas();
            Honda memurArabasi = new Honda();

            MessageBox.Show(superAraba.ToString());
            MessageBox.Show(superAraba.Calistir());

            MessageBox.Show(duldul.ToString());
            MessageBox.Show(duldul.Calistir());

            MessageBox.Show(memurArabasi.ToString());
            MessageBox.Show(memurArabasi.Calistir());

        }
    }
}
