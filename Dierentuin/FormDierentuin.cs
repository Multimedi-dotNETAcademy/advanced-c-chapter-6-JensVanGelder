using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Dierentuin
{
    public partial class FormDierentuin : Form
    {
        private List<Dier> dierentuin = new List<Dier>();
        private Dier temp;

        public FormDierentuin()
        {
            InitializeComponent();
        }

        private void btnAap_Click(object sender, EventArgs e)
        {
            AddAnimal("aap");
        }

        private void btnPin_Click(object sender, EventArgs e)
        {
            AddAnimal("pinguïn");
        }

        private void btnTijger_Click(object sender, EventArgs e)
        {
            AddAnimal("tijger");
        }

        private void btnUil_Click(object sender, EventArgs e)
        {
            AddAnimal("uil");
        }

        private void btnPraat_Click(object sender, EventArgs e)
        {
            var temp = dierentuin[listBox1.SelectedIndex];
            MessageBox.Show(temp.Zegt(), $"{temp.GetType().Name} zegt:");
        }

        public void AddAnimal(string dier)
        {
            switch (dier)
            {
                case "uil":
                    temp = new Uil();
                    break;

                case "tijger":
                    temp = new Tijger();
                    break;

                case "pinguïn":
                    temp = new Pinguïn();
                    break;

                case "aap":
                    temp = new Aap();
                    break;

                default:
                    break;
            }
            dierentuin.Add(temp);
            listBox1.Items.Add(temp);
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            dierentuin.RemoveAt(listBox1.SelectedIndex);
            UpdateList();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dierentuin.Clear();
            UpdateList();
            lblGewicht.Text = "Gemiddelde Gewicht:";
        }

        private void UpdateList()
        {
            listBox1.Items.Clear();
            foreach (Dier dier in dierentuin)
            {
                listBox1.Items.Add(dier);
            }
        }

        private void btnGewicht_Click(object sender, EventArgs e)
        {
            double gewichtUil = 0;
            double gewichtPing = 0;
            double gewichtAap = 0;
            double gewichtTijg = 0;

            foreach (Dier dier in dierentuin)
            {
                if (dier.GetType().Name == "Uil")
                {
                    gewichtUil += dier.GewichtInKG;
                }
                else if (dier.GetType().Name == "Aap")
                {
                    gewichtAap += dier.GewichtInKG;
                }
                else if (dier.GetType().Name == "Tijger")
                {
                    gewichtTijg += dier.GewichtInKG;
                }
                else if (dier.GetType().Name == "Pinguïn")
                {
                    gewichtPing += dier.GewichtInKG;
                }
            }
            UpdateGewicht(gewichtUil, "Uil", lblUilen);
            UpdateGewicht(gewichtAap, "Aap", lblApen);
            UpdateGewicht(gewichtPing, "Pinguïn", lblPins);
            UpdateGewicht(gewichtTijg, "Tijger", lblTijgers);
        }
        public void UpdateGewicht(double gewicht, string dier,Label lbl)
        {
            gewicht = Math.Round(gewicht / dierentuin.Count(d => d.GetType().Name == dier), 2);
            lbl.Text = $"{gewicht}KG";
        }
    }
}