using System;
using System.Windows.Forms;

namespace Geometric_Figures
{
    public partial class FormGeometric : Form
    {
        public FormGeometric()
        {
            InitializeComponent();
        }

        private void btnRechthoek_Click(object sender, EventArgs e)
        {
            GeometricFigure temp = new Rechthoek() { Hoogte = Convert.ToInt32(numHoogte.Value), Breedte = Convert.ToInt32(numBreedte.Value) };
            listBox1.Items.Add(temp);
        }

        private void btnVierkant_Click(object sender, EventArgs e)
        {
            GeometricFigure temp = new Vierkant(Convert.ToInt32(numHoogte.Value), Convert.ToInt32(numBreedte.Value));
            listBox1.Items.Add(temp);
        }

        private void btnDriehoek_Click(object sender, EventArgs e)
        {
            GeometricFigure temp = new Driehoek() { Hoogte = Convert.ToInt32(numHoogte.Value), Breedte = Convert.ToInt32(numBreedte.Value) };
            listBox1.Items.Add(temp);
        }
    }
}