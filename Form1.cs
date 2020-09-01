using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double zahl1 = 0;
        double zahl2 = 0;
        double zahl3 = 0;
        double erg = 0;
        string calc = "";
        string zahlx = "";


        private void b_clear_Click(object sender, EventArgs e)
        {
            box_rechnung.Text = ("");
            box_ergebnis.Text = ("");
            zahlx = "";
            zahl3 = 0;
            zahl2 = 0;
            zahl1 = 0;
        }

        private void b_delete_Click(object sender, EventArgs e)
        {
            if (box_rechnung.Text.Length > 0 && zahlx.Length > 0)
            {
                box_rechnung.Text = box_rechnung.Text.Substring(0, box_rechnung.Text.Length - 1);
                zahlx = zahlx.Substring(0, zahlx.Length - 1);
            }
        }

        private void b_zahl1_Click(object sender, EventArgs e)
        {
            box_rechnung.Text += "1";
            zahlx += "1";
            label_zahlx.Text = zahlx;
        }

        private void b_zahl2_Click(object sender, EventArgs e)
        {
            box_rechnung.Text += "2";
            zahlx += "2";
            label_zahlx.Text = zahlx;
        }

        private void b_zahl3_Click(object sender, EventArgs e)
        {
            box_rechnung.Text += "3";
            zahlx += "3";
            label_zahlx.Text = zahlx;
        }

        private void b_zahl4_Click(object sender, EventArgs e)
        {
            box_rechnung.Text += "4";
            zahlx += "4";
            label_zahlx.Text = zahlx;
        }

        private void b_zahl5_Click(object sender, EventArgs e)
        {
            box_rechnung.Text += "5";
            zahlx += "5";
            label_zahlx.Text = zahlx;
        }

        private void b_zahl6_Click(object sender, EventArgs e)
        {
            box_rechnung.Text += "6";
            zahlx += "6";
            label_zahlx.Text = zahlx;
        }

        private void b_zahl7_Click(object sender, EventArgs e)
        {
            box_rechnung.Text += "7";
            zahlx += "7";
            label_zahlx.Text = zahlx;
        }

        private void b_zahl8_Click(object sender, EventArgs e)
        {
            box_rechnung.Text += "8";
            zahlx += "8";
            label_zahlx.Text = zahlx;
        }

        private void b_zahl9_Click(object sender, EventArgs e)
        {
            box_rechnung.Text += "9";
            zahlx += "9";
            label_zahlx.Text = zahlx;
        }

        private void b_zahl10_Click(object sender, EventArgs e)
        {
            box_rechnung.Text += "0";
            zahlx += "0";
            label_zahlx.Text = zahlx;
        }

        private void b_komma_Click(object sender, EventArgs e)
        {
            box_rechnung.Text += ",";
            zahlx += ",";
            label_zahlx.Text = zahlx;
        }

        private void b_plus_Click(object sender, EventArgs e)
        {
            zahl1 = Convert.ToDouble(zahlx);
            Convert.ToString(zahlx);
            zahlx = "";
            box_rechnung.Text += " + ";
            calc = "+";
        }

        private void b_minus_Click(object sender, EventArgs e)
        {
            zahl1 = Convert.ToDouble(zahlx);
            Convert.ToString(zahlx);
            zahlx = "";
            box_rechnung.Text += " - ";
            calc = "-";
        }

        private void b_mal_Click(object sender, EventArgs e)
        {
            zahl1 = Convert.ToDouble(zahlx);
            Convert.ToString(zahlx);
            zahlx = "";
            box_rechnung.Text += " x ";
            calc = "*";
        }

        private void b_geteilt_Click(object sender, EventArgs e)
        {
            zahl1 = Convert.ToDouble(zahlx);
            Convert.ToString(zahlx);
            zahlx = "";
            box_rechnung.Text += " : ";
            calc = "/";
        }

        private void b_prozent_Click(object sender, EventArgs e)
        {
            double prozentergebnis = zahl3 * Convert.ToDouble(box_prozent.Text) / 100;
            box_ergebnis.Text = Convert.ToString(prozentergebnis);
        }

    private void b_ergebnis_Click(object sender, EventArgs e)
        {
            if (calc == "+")
            {
                zahl2 = Convert.ToDouble(zahlx);
                erg = (zahl1 + zahl3) + zahl2;
                zahl3 = erg;
                box_ergebnis.Text = Convert.ToString(erg);
                label_zahl3.Text = Convert.ToString(erg);
                Convert.ToString(zahlx);
                zahlx = "0";
                Convert.ToDouble(erg);
                erg = 0;
                label_zahlx.Text = zahlx;
            }
            else if (calc == "-")
            {
                zahl2 = Convert.ToDouble(zahlx);
                erg = (zahl1 + zahl3) - zahl2;
                zahl3 = erg;
                box_ergebnis.Text = Convert.ToString(erg);
                label_zahl3.Text = Convert.ToString(erg);
                Convert.ToString(zahlx);
                zahlx = "0";
                Convert.ToDouble(erg);
                erg = 0;
                label_zahlx.Text = zahlx;
            }
            else if (calc == "*")
            {
                zahl2 = Convert.ToDouble(zahlx);
                erg = (zahl1 + zahl3) * zahl2;
                zahl3 = erg;
                box_ergebnis.Text = Convert.ToString(erg);
                label_zahl3.Text = Convert.ToString(erg);
                Convert.ToString(zahlx);
                zahlx = "0";
                Convert.ToDouble(erg);
                erg = 0;
                label_zahlx.Text = zahlx;
            }
            else if (calc == "/")
            {
                zahl2 = Convert.ToDouble(zahlx);
                erg = (zahl1 + zahl3) / zahl2;
                zahl3 = erg;
                box_ergebnis.Text = Convert.ToString(erg);
                label_zahl3.Text = Convert.ToString(erg);
                Convert.ToString(zahlx);
                zahlx = "0";
                Convert.ToDouble(erg);
                erg = 0;
                label_zahlx.Text = zahlx;
            }


        }
    }
}
