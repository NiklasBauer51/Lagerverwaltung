using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lagerverwaltung
{
    public partial class FormLagerverwaltung : Form
    {
        public FormLagerverwaltung()
        {
            InitializeComponent();
        }

        private void buttonKaufen_Click(object sender, EventArgs e)
        {
            int kaufen = Convert.ToInt32(textBoxKaufen.Text);

            Lager Lagersicht4 = new Lager();
            Lagersicht4.Kaufen(kaufen, 500);


            int BestandKoeln = 500 - kaufen;
            labelKoelnMenge.Text = Convert.ToString(BestandKoeln);

            //if (kaufen < 0)   vorher throwt er die ArgumentOutOfRangeException
            //{
            //    MessageBox.Show("Ungültiger Wert");
            //}

        }

        private void buttonUmlagern_Click(object sender, EventArgs e)
        {
            int umlagern = Convert.ToInt32(textBoxUmlagern.Text);

            Lager Lagersicht2 = new Lager();
            Lagersicht2.Umlagern(8000, 6000);

            int BestandBonn = 8000;
            int BestandKoeln = 6000;

            BestandBonn = BestandBonn + umlagern;
            BestandKoeln = BestandKoeln - umlagern;

            if (BestandBonn > 10000)
            {
                MessageBox.Show("Maximaler Lagerplatz(10000) überschritten");
            }

            labelKoelnMenge2.Text = Convert.ToString(BestandKoeln);
            labelBonnMenge.Text = Convert.ToString(BestandBonn);

        }

        private void buttonAuslagern_Click(object sender, EventArgs e)
        {
            Lager Lagersicht3 = new Lager();
            int Gesamtlagerbestand = Lagersicht3.Auslagern(200, 500);

            int BestandLeverkusen = 200;
            int BestandKoeln = 500;

            int auslagern = Convert.ToInt32(textBoxAuslagern.Text);

            BestandKoeln = BestandKoeln + auslagern;
            BestandLeverkusen = BestandLeverkusen - auslagern;

            labelLeverkusenMenge.Text = Convert.ToString(BestandLeverkusen);
            labelKoelnMenge3.Text = Convert.ToString(BestandKoeln);

        }

        private void buttonBuchen_Click(object sender, EventArgs e)
        {
            Lager Lagersicht1 = new Lager();
            int GesamtLagerbestand = Lagersicht1.Buchen(200, 301);

            labelGesamtmenge2.Text = Convert.ToString(GesamtLagerbestand);
       
        }
    }
}
