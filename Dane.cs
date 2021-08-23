using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Belka_Stalowa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double moment = double.Parse(textBox1.Text);
            double silaPoprzeczna = double.Parse(textBox2.Text);
            double silaOsiowa = double.Parse(textBox3.Text);

            string Profil = (textBox7.Text);
            double Wskaznik = double.Parse(textBox6.Text);
            double PoleSci = double.Parse(textBox5.Text);
            double PolePow = double.Parse(textBox4.Text);
            double dlugosc = double.Parse(textBox10.Text);

            var fy =0;
            //stal
            if (radioButton1.Checked)
            {
                fy = 235;
            }
            if (radioButton2.Checked)
            {
                fy = 275;
            }
            if (radioButton3.Checked)
            {
                fy = 355;
            }
            double NcRd=0;
            double NtRd=0;

            //ściskanie
            if (radioButton4.Checked)
            {
                NcRd = PolePow * fy;
                double wytezenieN = (silaOsiowa*1000) / NcRd;
                Math.Round(wytezenieN, 2);
                label21.Text = Math.Round(wytezenieN,2).ToString();
            }
            if (radioButton5.Checked)
            {
                NtRd = PolePow * fy;
                double wytezenieN = (silaOsiowa*1000) / NtRd;
                Math.Round(wytezenieN, 2);
                label22.Text = Math.Round(wytezenieN,2).ToString();
            }
            //zginanie
            double Mcrd = 0;
            Mcrd = Wskaznik * fy;
            double wytezenieM = (moment * 1000 * 1000) / Mcrd;
            Math.Round(wytezenieM, 2);
            label23.Text = Math.Round(wytezenieM,2).ToString();

            //ścinanie
            double Vpl = 0;
            Vpl = PoleSci / (fy * Math.Sqrt(3));
            double wytezenieV = (silaPoprzeczna * 1000 / Vpl);
            Math.Round(wytezenieV,2);
            label24.Text = Math.Round(wytezenieV,2).ToString();
        }
    }
}
