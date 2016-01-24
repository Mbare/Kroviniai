using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Baigiamasis
{
    public partial class Duomenuivedimoforma : Form
    {
        public Duomenuivedimoforma()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Apskaiciavimoforma f = new Apskaiciavimoforma();
            f.Show();

            int ilgis = Int32.Parse(textBoxilgis.Text);
            int plotis = Int32.Parse(textBoxplotis.Text);
            int aukstis = Int32.Parse(textBoxaukstis.Text);
            int svoris = Int32.Parse(textBoxsvoris.Text);
            int kiekis = Int32.Parse(textBoxkiekis.Text);
            int atstumas = Int32.Parse(textBoxatstumas.Text);

            double suma = svoris * kiekis * (atstumas / 10);
           
            Label kazkas = (Label)f.Controls.Find("labelsuma", true)[0];
            kazkas.Text = suma.ToString();


        }
    }
}
