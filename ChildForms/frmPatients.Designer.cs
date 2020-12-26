namespace Hospital_System_Demo.ChildForms
{
    partial class frmPatients
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewDetails = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRelease = new System.Windows.Forms.Button();
            this.panelRaspored = new System.Windows.Forms.Panel();
            this.lblTrenutniDoktor = new System.Windows.Forms.Label();
            this.dgvPacijenti = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ImePrezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KrvnaGrupa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumRodjenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Spol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelRaspored.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnAddPatient);
            this.panel2.Location = new System.Drawing.Point(580, 234);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 132);
            this.panel2.TabIndex = 31;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(211)))), ((int)(((byte)(3)))));
            this.btnAddPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddPatient.FlatAppearance.BorderSize = 0;
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatient.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold);
            this.btnAddPatient.Location = new System.Drawing.Point(0, 0);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(281, 132);
            this.btnAddPatient.TabIndex = 0;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPatient.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnViewDetails);
            this.panel1.Location = new System.Drawing.Point(580, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 132);
            this.panel1.TabIndex = 32;
            // 
            // btnViewDetails
            // 
            this.btnViewDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(211)))), ((int)(((byte)(3)))));
            this.btnViewDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnViewDetails.FlatAppearance.BorderSize = 0;
            this.btnViewDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewDetails.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold);
            this.btnViewDetails.Location = new System.Drawing.Point(0, 0);
            this.btnViewDetails.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewDetails.Name = "btnViewDetails";
            this.btnViewDetails.Size = new System.Drawing.Size(281, 132);
            this.btnViewDetails.TabIndex = 0;
            this.btnViewDetails.Text = "View Details";
            this.btnViewDetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewDetails.UseVisualStyleBackColor = false;
            this.btnViewDetails.Click += new System.EventHandler(this.btnViewDetails_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.btnRelease);
            this.panel3.Location = new System.Drawing.Point(580, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 132);
            this.panel3.TabIndex = 32;
            // 
            // btnRelease
            // 
            this.btnRelease.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(211)))), ((int)(((byte)(3)))));
            this.btnRelease.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRelease.FlatAppearance.BorderSize = 0;
            this.btnRelease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelease.Font = new System.Drawing.Font("Segoe UI Black", 25F, System.Drawing.FontStyle.Bold);
            this.btnRelease.Location = new System.Drawing.Point(0, 0);
            this.btnRelease.Margin = new System.Windows.Forms.Padding(2);
            this.btnRelease.Name = "btnRelease";
            this.btnRelease.Size = new System.Drawing.Size(281, 132);
            this.btnRelease.TabIndex = 0;
            this.btnRelease.Text = "Release";
            this.btnRelease.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelease.UseVisualStyleBackColor = false;
            // 
            // panelRaspored
            // 
            this.panelRaspored.Controls.Add(this.dgvPacijenti);
            this.panelRaspored.Location = new System.Drawing.Point(30, 80);
            this.panelRaspored.Margin = new System.Windows.Forms.Padding(2);
            this.panelRaspored.Name = "panelRaspored";
            this.panelRaspored.Size = new System.Drawing.Size(535, 443);
            this.panelRaspored.TabIndex = 33;
            // 
            // lblTrenutniDoktor
            // 
            this.lblTrenutniDoktor.Font = new System.Drawing.Font("Segoe UI", 20.2F, System.Drawing.FontStyle.Bold);
            this.lblTrenutniDoktor.ForeColor = System.Drawing.Color.Silver;
            this.lblTrenutniDoktor.Location = new System.Drawing.Point(581, 25);
            this.lblTrenutniDoktor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrenutniDoktor.Name = "lblTrenutniDoktor";
            this.lblTrenutniDoktor.Size = new System.Drawing.Size(280, 52);
            this.lblTrenutniDoktor.TabIndex = 36;
            this.lblTrenutniDoktor.Text = "prof.dr.Doktor";
            this.lblTrenutniDoktor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvPacijenti
            // 
            this.dgvPacijenti.AllowUserToDeleteRows = false;
            this.dgvPacijenti.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.dgvPacijenti.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPacijenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacijenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImePrezime,
            this.KrvnaGrupa,
            this.DatumRodjenja,
            this.JMBG,
            this.Spol});
            this.dgvPacijenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacijenti.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.dgvPacijenti.Location = new System.Drawing.Point(0, 0);
            this.dgvPacijenti.Name = "dgvPacijenti";
            this.dgvPacijenti.Size = new System.Drawing.Size(535, 443);
            this.dgvPacijenti.TabIndex = 0;
            this.dgvPacijenti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPacijenti_CellContentClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(168, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 52);
            this.label1.TabIndex = 37;
            this.label1.Text = "Current patients list";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImePrezime
            // 
            this.ImePrezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ImePrezime.DataPropertyName = "ImePrezime";
            this.ImePrezime.HeaderText = "ImePrezime";
            this.ImePrezime.Name = "ImePrezime";
            // 
            // KrvnaGrupa
            // 
            this.KrvnaGrupa.DataPropertyName = "KrvnaGrupa";
            this.KrvnaGrupa.HeaderText = "Krvna Grupa";
            this.KrvnaGrupa.Name = "KrvnaGrupa";
            // 
            // DatumRodjenja
            // 
            this.DatumRodjenja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumRodjenja.DataPropertyName = "DatumRodjenja";
            this.DatumRodjenja.HeaderText = "Datum rodjenja";
            this.DatumRodjenja.Name = "DatumRodjenja";
            // 
            // JMBG
            // 
            this.JMBG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JMBG.DataPropertyName = "JMBG";
            this.JMBG.HeaderText = "JMBG";
            this.JMBG.Name = "JMBG";
            // 
            // Spol
            // 
            this.Spol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Spol.DataPropertyName = "Spol";
            this.Spol.HeaderText = "Spol";
            this.Spol.Name = "Spol";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(211)))), ((int)(((byte)(3)))));
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = global::Hospital_System_Demo.Properties.Resources.pregled4;
            this.pictureBox3.Location = new System.Drawing.Point(201, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 132);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(211)))), ((int)(((byte)(3)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::Hospital_System_Demo.Properties.Resources.viewDetailsPatient;
            this.pictureBox2.Location = new System.Drawing.Point(201, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(8);
            this.pictureBox2.Size = new System.Drawing.Size(80, 132);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(211)))), ((int)(((byte)(3)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Hospital_System_Demo.Properties.Resources.Add_patient;
            this.pictureBox1.Location = new System.Drawing.Point(201, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(871, 552);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTrenutniDoktor);
            this.Controls.Add(this.panelRaspored);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPatients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPatients";
            this.Load += new System.EventHandler(this.frmPatients_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelRaspored.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacijenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnViewDetails;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnRelease;
        private System.Windows.Forms.Panel panelRaspored;
        private System.Windows.Forms.Label lblTrenutniDoktor;
        private System.Windows.Forms.DataGridView dgvPacijenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImePrezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn KrvnaGrupa;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumRodjenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Spol;
    }
}