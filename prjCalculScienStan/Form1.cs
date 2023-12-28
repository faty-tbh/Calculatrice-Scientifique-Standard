namespace prjCalculScienStan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuQuitter_Click(object sender, EventArgs e)
        {
            String msg = "Etes-Vous sure de vouloire quitter ce programme ?";
            string titre = "Fermeture de l Application";
            if (MessageBox.Show(msg, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) ;
            {
                Application.Exit();
            }
        }

        private void mnuStandard_Click(object sender, EventArgs e)
        {
            frmStandard fs = new frmStandard();
            fs.IsMdiContainer = true;
            fs.Show();
        }

        private void mnuScientifique_Click(object sender, EventArgs e)
        {
            frmScientifique fs = new frmScientifique();
            fs.IsMdiContainer = true;
            fs.Show();
        }

        private void mnuApropos_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void versionLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExchange fs = new frmExchange();
            fs.IsMdiContainer = true;
            fs.Show();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmExchange fs = new frmExchange();
            fs.IsMdiContainer = true;
            fs.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmStandard fs = new frmStandard();
            fs.IsMdiContainer = true;
            fs.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmScientifique fs = new frmScientifique();
            fs.IsMdiContainer = true;
            fs.Show();
        }
    }
    }
