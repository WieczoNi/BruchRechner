using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public struct Fraction
{
    public Fraction(int n, int d)
    {
        N = n;
        D = d;
    }

    public int N { get; private set; }
    public int D { get; private set; }
}
namespace BruchRechner
{
    public partial class BruchRechner : Form
    {

        public BruchRechner()
        {
            InitializeComponent();
        }
        float dezimal1;
        float dezimal2;
        double ergebnis;
        int nE;
        int zE;
        int gZ;
        void dezimalrechner()
        {
            dezimal1 = float.Parse(zähler1.Text) / float.Parse(nenner1.Text);
            dezimal2 = float.Parse(zähler2.Text) / float.Parse(nenner2.Text);
        }
        public Fraction RealToFraction(double value, double accuracy)
        {
            if (accuracy <= 0.0 || accuracy >= 1.0)
            {
                throw new ArgumentOutOfRangeException("accuracy", "Must be > 0 and < 1.");
            }

            int sign = Math.Sign(value);

            if (sign == -1)
            {
                value = Math.Abs(value);
            }

            
            double maxError = sign == 0 ? accuracy : value * accuracy;

            int n = (int)Math.Floor(value);
            value -= n;

            if (value < maxError)
            {
                return new Fraction(sign * n, 1);
            }

            if (1 - maxError < value)
            {
                return new Fraction(sign * (n + 1), 1);
            }

            double z = value;
            int previousDenominator = 0;
            int denominator = 1;
            int numerator;

            do
            {
                z = 1.0 / (z - (int)z);
                int temp = denominator;
                denominator = denominator * (int)z + previousDenominator;
                previousDenominator = temp;
                numerator = Convert.ToInt32(value * denominator);
            }
            while (Math.Abs(value - (double)numerator / denominator) > maxError && z != (int)z);



            return new Fraction((n * denominator + numerator) * sign, denominator);
        }
        private void zähler1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nenner1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nenner2_TextChanged(object sender, EventArgs e)
        {

        }

        private void zähler2_TextChanged(object sender, EventArgs e)
        {

        }

        private void zählerErgebnis_Click(object sender, EventArgs e)
        {

        }

        private void nennerErgebnis_Click(object sender, EventArgs e)
        {

        }

        private void optionen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void confirm_Click(object sender, EventArgs e)
        {
            if (optionen.SelectedItem.ToString() == "+")
            {
                dezimalrechner();
                ergebnis = dezimal1 + dezimal2;
                nE = RealToFraction(ergebnis, 0.00001).D;
                zE = RealToFraction(ergebnis, 0.00001).N;
                //In Rücksicht hätte ich diese while Schleifen zu ermittlung der Ganzen Zahlen auch in eine Funktion schreiben können
                while (nE <= zE)
                {
                    zE = zE - nE;
                    gZ = gZ + 1;
                }
                while ((nE - (2 * nE)) >= zE)
                {
                    zE = zE + nE;
                    gZ = gZ - 1;
                }
                nennerErgebnis.Text = nE.ToString();
                zählerErgebnis.Text = zE.ToString();
                GanzZahl.Text = gZ.ToString();
                if(gZ == 0)
                {
                    GanzZahl.Visible = false;
                }
                else
                {
                    GanzZahl.Visible = true;
                }
                gZ = 0;
            }
            else if (optionen.SelectedItem.ToString() == "-")
            {
                dezimalrechner();
                ergebnis = dezimal1 - dezimal2;
                nE = RealToFraction(ergebnis, 0.00001).D;
                zE = RealToFraction(ergebnis, 0.00001).N;
                while (nE <= zE)
                {
                    zE = zE - nE;
                    gZ = gZ + 1;
                }
                while ((nE - (2 * nE)) >= zE)
                {
                    zE = zE + nE;
                    gZ = gZ - 1;
                }
                nennerErgebnis.Text = nE.ToString();
                zählerErgebnis.Text = zE.ToString();
                GanzZahl.Text = gZ.ToString();
                if (gZ == 0)
                {
                    GanzZahl.Visible = false;
                }
                else
                {
                    GanzZahl.Visible = true;
                }
                gZ = 0;

            }
            else if (optionen.SelectedItem.ToString() == "x")
            {
                dezimalrechner();
                ergebnis = dezimal1 * dezimal2;
                nE = RealToFraction(ergebnis, 0.00001).D;
                zE = RealToFraction(ergebnis, 0.00001).N;
                while (nE <= zE)
                {
                    zE = zE - nE;
                    gZ = gZ + 1;
                }
                while ((nE - (2 * nE)) >= zE)
                {
                    zE = zE + nE;
                    gZ = gZ - 1;
                }
                nennerErgebnis.Text = nE.ToString();
                zählerErgebnis.Text = zE.ToString();
                GanzZahl.Text = gZ.ToString();
                if (gZ == 0)
                {
                    GanzZahl.Visible = false;
                }
                else
                {
                    GanzZahl.Visible = true;
                }
                gZ = 0;
            }
            else
            {
                dezimalrechner();
                ergebnis = dezimal1 / dezimal2;
                nE = RealToFraction(ergebnis, 0.00001).D;
                zE = RealToFraction(ergebnis, 0.00001).N;
                while (nE <= zE)
                {
                    zE = zE - nE;
                    gZ = gZ + 1;
                }
                while ((nE - (2 * nE)) >= zE)
                {
                    zE = zE + nE;
                    gZ = gZ - 1;
                }
                nennerErgebnis.Text = nE.ToString();
                zählerErgebnis.Text = zE.ToString();
                GanzZahl.Text = gZ.ToString();
                if (gZ == 0)
                {
                    GanzZahl.Visible = false;
                }
                else
                {
                    GanzZahl.Visible = true;
                }
                gZ = 0;
            }
        }

        private void optionen_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (optionen.SelectedItem.ToString() == "+")
            {
                dezimalrechner();
                ergebnis = dezimal1 + dezimal2;
                nE = RealToFraction(ergebnis, 0.00001).D;
                zE = RealToFraction(ergebnis, 0.00001).N;
                while (nE <= zE)
                {
                    zE = zE - nE;
                    gZ = gZ + 1;
                }
                while ((nE - (2 * nE)) >= zE)
                {
                    zE = zE + nE;
                    gZ = gZ - 1;
                }
                nennerErgebnis.Text = nE.ToString();
                zählerErgebnis.Text = zE.ToString();
                GanzZahl.Text = gZ.ToString();
                if (gZ == 0)
                {
                    GanzZahl.Visible = false;
                }
                else
                {
                    GanzZahl.Visible = true;
                }
                gZ = 0;
            }
            else if (optionen.SelectedItem.ToString() == "-")
            {
                dezimalrechner();
                ergebnis = dezimal1 - dezimal2;
                nE = RealToFraction(ergebnis, 0.00001).D;
                zE = RealToFraction(ergebnis, 0.00001).N;
                while (nE <= zE)
                {
                    zE = zE - nE;
                    gZ = gZ + 1;
                }
                while ((nE - (2 * nE)) >= zE)
                {
                    zE = zE + nE;
                    gZ = gZ - 1;
                }
                nennerErgebnis.Text = nE.ToString();
                zählerErgebnis.Text = zE.ToString();
                GanzZahl.Text = gZ.ToString();
                if (gZ == 0)
                {
                    GanzZahl.Visible = false;
                }
                else
                {
                    GanzZahl.Visible = true;
                }
                gZ = 0;

            }
            else if (optionen.SelectedItem.ToString() == "x")
            {
                dezimalrechner();
                ergebnis = dezimal1 * dezimal2;
                nE = RealToFraction(ergebnis, 0.00001).D;
                zE = RealToFraction(ergebnis, 0.00001).N;
                while (nE <= zE)
                {
                    zE = zE - nE;
                    gZ = gZ + 1;
                }
                while ((nE - (2 * nE)) >= zE)
                {
                    zE = zE + nE;
                    gZ = gZ - 1;
                }
                nennerErgebnis.Text = nE.ToString();
                zählerErgebnis.Text = zE.ToString();
                GanzZahl.Text = gZ.ToString();
                if (gZ == 0)
                {
                    GanzZahl.Visible = false;
                }
                else
                {
                    GanzZahl.Visible = true;
                }
                gZ = 0;
            }
            else
            {
                dezimalrechner();
                ergebnis = dezimal1 / dezimal2;
                nE = RealToFraction(ergebnis, 0.00001).D;
                zE = RealToFraction(ergebnis, 0.00001).N;
                while (nE <= zE)
                {
                    zE = zE - nE;
                    gZ = gZ + 1;
                }
                while ((nE - (2 * nE)) >= zE)
                {
                    zE = zE + nE;
                    gZ = gZ - 1;
                }
                nennerErgebnis.Text = nE.ToString();
                zählerErgebnis.Text = zE.ToString();
                GanzZahl.Text = gZ.ToString();
                if (gZ == 0)
                {
                    GanzZahl.Visible = false;
                }
                else
                {
                    GanzZahl.Visible = true;
                }
                gZ = 0;
            }
        }
    }
}
