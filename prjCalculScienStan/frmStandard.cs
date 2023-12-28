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
    public partial class frmStandard : Form
    {
        Double results = 0;
        string operation = "";
        bool enter_value = false;
        public frmStandard()
        {
            InitializeComponent();
        }

        private void Arithmetic_Operator(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            operation = num.Text;
            results = Double.Parse(txtResult.Text);
            txtResult.Text = "";
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((txtResult.Text == "0") || (enter_value))
                txtResult.Text = "";
            enter_value = false;
            Button num = (Button)sender;
            if (num.Text == ".")
            {
                if (!txtResult.Text.Contains("."))
                    txtResult.Text = txtResult.Text + num.Text;

            }
            else
                txtResult.Text = txtResult.Text + num.Text;
        }

        private void btnEgal_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    txtResult.Text = results + Double.Parse(txtResult.Text).ToString();
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

        private void btnModulo_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtResult.Text) / Convert.ToDouble(100);
            txtResult.Text = System.Convert.ToString(x);
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            string f, s;
            f = Convert.ToString(results);
            s = Convert.ToString(txtResult.Text);

            f = "";
            s = "";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
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

        private void btn1x_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(1.0 / Convert.ToDouble(txtResult.Text));
            txtResult.Text = System.Convert.ToString(x);
        }

        private void btnPuiss2_Click(object sender, EventArgs e)
        {
            double x;
            x = Convert.ToDouble(txtResult.Text) * Convert.ToDouble(txtResult.Text);
            txtResult.Text = System.Convert.ToString(x);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text = Convert.ToString(Math.Pow(results, 1 / 3));
        }

        private void btnmiddle_Click(object sender, EventArgs e)
        {
            double hi = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * hi);
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            btnM.Enabled = btnMC.Enabled = btnMplus.Enabled = btnMmoins.Enabled = btnMR.Enabled = true;
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
    }
}
