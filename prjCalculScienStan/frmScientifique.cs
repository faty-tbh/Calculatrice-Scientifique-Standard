using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjCalculScienStan
{
    public partial class frmScientifique : Form
    {
        Double results = 0;
        string operation = "";
        bool value = false;
        public frmScientifique()
        {
            InitializeComponent();
        }

        private void frmScientifique_Load(object sender, EventArgs e)
        {
            btnRien.Enabled = btnMC.Enabled = btnMR.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.141592653589976323";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            double log = Double.Parse(txtResult.Text);
            log = Math.Log10(log);
            txtResult.Text = System.Convert.ToString(log);
        }

        private void btnPuiss2_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = System.Convert.ToString(x);
        }

        private void btn1x_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(1.0 / Convert.ToDouble(txtResult.Text));
            txtResult.Text = System.Convert.ToString(x);
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            double log = Double.Parse(txtResult.Text);
            log = Math.Log(log);
            txtResult.Text = System.Convert.ToString(log);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }

            if (txtResult.Text.Length == 0)
            {
                txtResult.Text = "0";
            }
        }

        private void btnpare2_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "(";
            }
            else
            {
                txtResult.Text = txtResult.Text + "(";
            }
        }

        private void btnpare_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = ")";
            }
            else
            {
                txtResult.Text = txtResult.Text + ")";
            }
        }

        private void btnDix_Click(object sender, EventArgs e)
        {
            double y;
            y= 10 * (1 / results);
            
            txtResult.Text = txtResult.Text = System.Convert.ToString(y);
        }
    

        private void btnmiddle_Click(object sender, EventArgs e)
        {
            double x;
           
            x = Convert.ToDouble(1.0 /2);
            txtResult.Text = System.Convert.ToString(x);
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            btnM.Enabled = btnMC.Enabled = btnMplus.Enabled = btnMmoins.Enabled = btnMR.Enabled = true;
        }

        private void btnMdo_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtResult.Text) / Convert.ToDouble(100);
            txtResult.Text = System.Convert.ToString(x);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btnPuiss2.Text = "x^​3";
            button3.Text = "^3√x";
            button4.Text = "^y√x";
            btnDix.Text = "2^x";
            btnLog.Text = "logyx";
            btnLn.Text = "e^x";
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            btnM.Enabled = btnMC.Enabled = btnMR.Enabled = false;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            btnM.Enabled = btnMC.Enabled = btnMplus.Enabled = btnMmoins.Enabled = btnMR.Enabled = true;
        }

        private void btnMplus_Click(object sender, EventArgs e)
        {
            btnM.Enabled = btnMC.Enabled = btnMplus.Enabled = btnMmoins.Enabled = btnMR.Enabled = true;
        }

        private void btnMmoins_Click(object sender, EventArgs e)
        {
            btnM.Enabled = btnMC.Enabled = btnMplus.Enabled = btnMmoins.Enabled = btnMR.Enabled = true;
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            double x;
            x=Math.Exp(results);
            txtResult.Text= txtResult.Text = System.Convert.ToString(x);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "2.7182818284590452353602874713527";
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (value))
                txtResult.Text = "";
            value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtResult.Text.Contains("."))
                    txtResult.Text = txtResult.Text + num.Text;

            }
            else
                txtResult.Text = txtResult.Text + num.Text;
        }

        private void Aritmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(txtResult.Text);
            txtResult.Text = "";
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            if (results == 1)
            {
                txtResult.Text = "1";
            }
            else
            {
                while (results != 1)
                {
                    results = results - 1;
                }
            }
        }

        private void btnEgal_Click(object sender, EventArgs e)
        {
            
            switch (operation)
            {
                case "+":
                    txtResult.Text = (results + (Double.Parse(txtResult.Text).ToString()));
                    break;

                case "-":
                    txtResult.Text = (results - Double.Parse(txtResult.Text)).ToString();
                    break;

                case "x":
                    txtResult.Text = (results * Double.Parse(txtResult.Text)).ToString();
                    break;

                case "/":
                    txtResult.Text = (results / Double.Parse(txtResult.Text)).ToString();
                    break;

                default:
                    break;
            }
        }

        private void btnValabso_Click(object sender, EventArgs e)
        {

            results= Double.Parse(txtResult.Text);
            if(results < 0)
            {
                results = results * (-1);
                txtResult.Text = results.ToString();
            }

            else
                txtResult.Text = results.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResult.Text = Convert.ToString(Math.Pow(results, 1 / 3));
        }
    }
}
