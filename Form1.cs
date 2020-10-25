using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void btnBerekenen_Click(object sender, EventArgs e)
        {
            if (txtGewicht.Text.Trim() == string.Empty)
            {
                lblEror.Visible = true;
                lblEror.Text = "Controleer of alles goed is ingevuld";
                return;
            }
            float gewicht = float.Parse(txtGewicht.Text);
            
            if (txtLengte.Text.Trim() == string.Empty)
            {
                lblEror.Visible = true;
                lblEror.Text = "Controleer of alles goed is ingevuld";
                return;
            }
            float lengte = float.Parse(txtLengte.Text);
            
            if (txtLengte.Text.Trim() == string.Empty)
            {
                lblEror.Visible = true;
                lblEror.Text = "Controleer of alles goed is ingevuld";
                return;
            }
            float leeftijd = float.Parse(txtLeeftijd.Text);

            float lengtemeter = ((lengte / 100) * (lengte / 100));
            float BMI = (gewicht / lengtemeter);


            if (BMI <= 18.5)
            {
                lblAdvies.Text = ("onder gewicht, u moet met spoet naar de huisarts ");

            }
            else if (BMI > 18.5 && BMI <= 24.9)
            {
                lblAdvies.Text = ("gezond gewicht");

            }
            else if (BMI <= 25 && BMI <= 29.9)
            {
                lblAdvies.Text = ("overgewicht, u moet met spoet naar de huisarts ");

            }


            lblBMI.Text = BMI.ToString();

            btnBerekenen.Enabled = false;
        }

        private void lblAdvies_Click(object sender, EventArgs e)
        {
            lblAdvies.Text = "";
        }

        private void lblBMI_Click(object sender, EventArgs e)
        {
            lblBMI.Text = "";
        }

        private void radioButtonV_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonV.Checked == true)
            {
                lblVrouw.Text = ("u bent te dik, dat komt doordat u meer vet heeft");

            }


        }

        private void txtGewicht_TextChanged(object sender, EventArgs e)
        {
            if (txtGewicht.Text.Trim() == string.Empty)
            {
                txtGewicht.Visible = true;
                txtGewicht.Text = "Controleer of alles goed is ingevuld";
                return;
            }
            float gewicht = float.Parse(txtGewicht.Text);
        }

        private void txtLengte_TextChanged(object sender, EventArgs e)
        {
            if (txtLengte.Text.Trim() == string.Empty)
            {
                txtLengte.Visible = true;
                txtLengte.Text = "Controleer of alles goed is ingevuld";
                return;
            }
            float lengte = float.Parse(txtLengte.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}



