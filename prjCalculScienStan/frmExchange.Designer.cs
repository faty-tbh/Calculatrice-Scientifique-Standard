namespace prjCalculScienStan
{
    partial class frmExchange
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtMontant = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblConver = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radDeux = new System.Windows.Forms.RadioButton();
            this.radUn = new System.Windows.Forms.RadioButton();
            this.lblXtodollar = new System.Windows.Forms.Label();
            this.lblDollarto = new System.Windows.Forms.Label();
            this.cmbPays = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnQuitter.Location = new System.Drawing.Point(821, 573);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(129, 54);
            this.btnQuitter.TabIndex = 22;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEffacer.Location = new System.Drawing.Point(821, 484);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(129, 54);
            this.btnEffacer.TabIndex = 21;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvert.Location = new System.Drawing.Point(821, 397);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(129, 54);
            this.btnConvert.TabIndex = 20;
            this.btnConvert.Text = "Convertir";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtMontant
            // 
            this.txtMontant.Location = new System.Drawing.Point(467, 431);
            this.txtMontant.Multiline = true;
            this.txtMontant.Name = "txtMontant";
            this.txtMontant.Size = new System.Drawing.Size(223, 63);
            this.txtMontant.TabIndex = 19;
            this.txtMontant.TextChanged += new System.EventHandler(this.txtMontant_TextChanged);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(4, 560);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(418, 67);
            this.lblResult.TabIndex = 18;
            // 
            // lblConver
            // 
            this.lblConver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblConver.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblConver.Location = new System.Drawing.Point(467, 330);
            this.lblConver.Name = "lblConver";
            this.lblConver.Size = new System.Drawing.Size(223, 70);
            this.lblConver.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radDeux);
            this.groupBox1.Controls.Add(this.radUn);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(4, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 184);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type De Conversion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radDeux
            // 
            this.radDeux.AutoSize = true;
            this.radDeux.Location = new System.Drawing.Point(24, 121);
            this.radDeux.Name = "radDeux";
            this.radDeux.Size = new System.Drawing.Size(21, 20);
            this.radDeux.TabIndex = 1;
            this.radDeux.TabStop = true;
            this.radDeux.UseVisualStyleBackColor = true;
            this.radDeux.CheckedChanged += new System.EventHandler(this.radDeux_CheckedChanged);
            // 
            // radUn
            // 
            this.radUn.AutoSize = true;
            this.radUn.Location = new System.Drawing.Point(24, 46);
            this.radUn.Name = "radUn";
            this.radUn.Size = new System.Drawing.Size(21, 20);
            this.radUn.TabIndex = 0;
            this.radUn.TabStop = true;
            this.radUn.UseVisualStyleBackColor = true;
            this.radUn.CheckedChanged += new System.EventHandler(this.radUn_CheckedChanged);
            // 
            // lblXtodollar
            // 
            this.lblXtodollar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblXtodollar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblXtodollar.Location = new System.Drawing.Point(467, 188);
            this.lblXtodollar.Name = "lblXtodollar";
            this.lblXtodollar.Size = new System.Drawing.Size(473, 56);
            this.lblXtodollar.TabIndex = 15;
            // 
            // lblDollarto
            // 
            this.lblDollarto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDollarto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDollarto.Location = new System.Drawing.Point(467, 110);
            this.lblDollarto.Name = "lblDollarto";
            this.lblDollarto.Size = new System.Drawing.Size(473, 56);
            this.lblDollarto.TabIndex = 14;
            // 
            // cmbPays
            // 
            this.cmbPays.FormattingEnabled = true;
            this.cmbPays.Location = new System.Drawing.Point(4, 111);
            this.cmbPays.Name = "cmbPays";
            this.cmbPays.Size = new System.Drawing.Size(299, 33);
            this.cmbPays.TabIndex = 13;
            this.cmbPays.SelectedIndexChanged += new System.EventHandler(this.cmbPays_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(216, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 60);
            this.label1.TabIndex = 12;
            this.label1.Text = "BUREAUX- EXCHANGES";
            // 
            // frmExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 699);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtMontant);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblConver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblXtodollar);
            this.Controls.Add(this.lblDollarto);
            this.Controls.Add(this.cmbPays);
            this.Controls.Add(this.label1);
            this.Name = "frmExchange";
            this.Text = "frmExchange";
            this.Load += new System.EventHandler(this.frmExchange_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnQuitter;
        private Button btnEffacer;
        private Button btnConvert;
        private TextBox txtMontant;
        private Label lblResult;
        private Label lblConver;
        private GroupBox groupBox1;
        private RadioButton radDeux;
        private RadioButton radUn;
        private Label lblXtodollar;
        private Label lblDollarto;
        private ComboBox cmbPays;
        private Label label1;
    }
}