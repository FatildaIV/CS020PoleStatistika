using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS020PoleStatistika
{
    public partial class PoleStatistikaForm : Form
    {
        public PoleStatistikaForm()
        {
            InitializeComponent();
        }

        private void cislaTextBox_TextChanged(object sender, EventArgs e)
        {
            string[] cisla = cislaTextBox.Text.Split(';');

            if (cisla.Length > 0)
            {
                soucetLabel.Text = string.Format("Součet: {0}", Soucet(cisla));
                prumerLabel.Text = string.Format("Průměr: {0}", AritmetickyPrumer(cisla));
                minimumLabel.Text = string.Format("Minimum: {0}", Minimum(cisla));
                maximumLabel.Text = string.Format("Maximum: {0}", Maximum(cisla));
            }
        }
        private static double AritmetickyPrumer(string[] cisla)
        {
            return Soucet(cisla) / cisla.Length;
        }
        private static double Soucet(string[] cisla)
        {
            double cislo, soucet = 0;
            for (int i = 0; i < cisla.Length; i++)
            {
                if (double.TryParse(cisla[i], out cislo))
                    soucet += cislo;
            }
            return soucet;
        }
        private static double Minimum(string[] cisla)
        {
            if (cisla.Length == 0) return double.NaN;
            double cislo, minimum = double.Parse(cisla[0]);

            for (int i = 0; i < cisla.Length; i++)
            {
                if (double.TryParse(cisla[i], out cislo))
                    if (cislo < minimum) 
                        minimum = cislo;
            }
            return minimum;
        }
        private static double Maximum(string[] cisla)
        {
            if (cisla.Length == 0) return double.NaN;
            double cislo, maximum = double.Parse(cisla[0]);

            for (int i = 0; i < cisla.Length; i++)
            {
                if (double.TryParse(cisla[i], out cislo))
                    if (cislo > maximum)
                        maximum = cislo;
            }
            return maximum;
        }
    }
}
