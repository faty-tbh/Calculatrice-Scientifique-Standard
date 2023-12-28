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
    public partial class frmExchange : Form
    {

        public frmExchange()
        {
            InitializeComponent();
        }

        private void frmExchange_Load(object sender, EventArgs e)
        {
            StreamReader monfichier = new StreamReader("TextFile1.txt");
            cmbPays.Text = "Select Country";

            while (monfichier.EndOfStream == false)
            {

                string pays = monfichier.ReadLine();
                string devise = monfichier.ReadLine();
                Single val = Convert.ToSingle(monfichier.ReadLine());
                cmbPays.Items.Add(pays);


            }
        }



        private void cmbPays_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblConver.Text = txtMontant.Text =lblResult.Text= "";
            StreamReader monfichier = new StreamReader("TextFile1.txt");
            cmbPays.Text = "Select Country";


            while (monfichier.EndOfStream == false)
            {
                Single result = 0;


                string pays = monfichier.ReadLine();
                string devise = monfichier.ReadLine();
                Single val = Convert.ToSingle(monfichier.ReadLine());

                cmbPays.Items.Add(pays);
                

                if (pays == cmbPays.SelectedItem.ToString())
                {
                    
                    lblDollarto.Text = "1 usa dollar = " + val + " " + devise;
                    lblXtodollar.Text = "1 " + devise + " = " + 1/val + " usa dollar ";
                    radUn.Text = "from american dollar to " + devise;
                    radDeux.Text = "from " + devise + " to american dollar";
                    
                }
                
            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            String msg = "Etes-Vous sure de vouloire quitter ce programme ?";
            string titre = "Fermeture de l Application";
            if (MessageBox.Show(msg, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) ;
            {
                Application.Exit();
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)

        {
            StreamReader monfichier = new StreamReader("TextFile1.txt");
            cmbPays.Text = "Select Country";


            while (monfichier.EndOfStream == false)
            {
                Single result ;


                string pays = monfichier.ReadLine();
                string devise = monfichier.ReadLine();
                Single val = Convert.ToSingle(monfichier.ReadLine());

                cmbPays.Items.Add(pays);
                Single Mont = Convert.ToSingle(txtMontant.Text);
                if (txtMontant.Text.Length==0)
                {
                    
                    MessageBox.Show("Veuillez entrer un montant");
                }


                if (radUn.Checked == true)
                {

                    result = Mont * val;

                    lblResult.Text = "Le montant est : " + result + " ";
                }
                else if(radDeux.Checked==true)
                {
                    result = Mont /val;
                    lblResult.Text = "Le montant est : " + result + " $";
                    
                }
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            lblDollarto.Text = lblXtodollar.Text = radDeux.Text = radUn.Text = lblResult.Text =lblConver.Text=lblConver.Text=txtMontant.Text= "";
            cmbPays.Text = "select country";
        }

        private void radUn_CheckedChanged(object sender, EventArgs e)
        {
            if (radUn.Checked == true)
            {
                lblConver.Text = " US Dollar";

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
    }

        private void radDeux_CheckedChanged(object sender, EventArgs e)
        {
            
            StreamReader monfichier = new StreamReader("TextFile1.txt");
            while (monfichier.EndOfStream == false)
            {
                


                string pays = monfichier.ReadLine();
                string devise = monfichier.ReadLine();
                Single val = Convert.ToSingle(monfichier.ReadLine());
                if (pays == cmbPays.SelectedItem.ToString())
                {
                    if (radDeux.Checked == true)
                    {
                        lblConver.Text = " A " + devise;
                    }


                }
            }
        }

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

