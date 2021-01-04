namespace Hospital_System_Demo.Patients
{
    partial class frmNoviPregled
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
            this.components = new System.ComponentModel.Container();
            this.cmbDijagnoze = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbPacijenti = new System.Windows.Forms.ComboBox();
            this.lbl = new System.Windows.Forms.Label();
            this.txtDatumPregleda = new System.Windows.Forms.TextBox();
            this.txtOpisStanja = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtZapazenjeDoktora = new System.Windows.Forms.Label();
            this.btnAddExamination = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDijagnoze
            // 
            this.cmbDijagnoze.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDijagnoze.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDijagnoze.FormattingEnabled = true;
            this.cmbDijagnoze.Location = new System.Drawing.Point(145, 55);
            this.cmbDijagnoze.Name = "cmbDijagnoze";
            this.cmbDijagnoze.Size = new System.Drawing.Size(222, 39);
            this.cmbDijagnoze.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 17.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(17, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diagnosis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 17.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(421, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Patient:";
            // 
            // cmbPacijenti
            // 
            this.cmbPacijenti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPacijenti.Font = new System.Drawing.Font("Segoe UI", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPacijenti.FormattingEnabled = true;
            this.cmbPacijenti.Location = new System.Drawing.Point(528, 55);
            this.cmbPacijenti.Name = "cmbPacijenti";
            this.cmbPacijenti.Size = new System.Drawing.Size(225, 39);
            this.cmbPacijenti.TabIndex = 1;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 17.25F, System.Drawing.FontStyle.Bold);
            this.lbl.ForeColor = System.Drawing.Color.Silver;
            this.lbl.Location = new System.Drawing.Point(12, 308);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(225, 31);
            this.lbl.TabIndex = 4;
            this.lbl.Text = "Date of examination";
            // 
            // txtDatumPregleda
            // 
            this.txtDatumPregleda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.txtDatumPregleda.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatumPregleda.ForeColor = System.Drawing.Color.White;
            this.txtDatumPregleda.Location = new System.Drawing.Point(18, 342);
            this.txtDatumPregleda.Name = "txtDatumPregleda";
            this.txtDatumPregleda.ReadOnly = true;
            this.txtDatumPregleda.Size = new System.Drawing.Size(153, 35);
            this.txtDatumPregleda.TabIndex = 6;
            // 
            // txtOpisStanja
            // 
            this.txtOpisStanja.BackColor = System.Drawing.Color.Silver;
            this.txtOpisStanja.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold);
            this.txtOpisStanja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.txtOpisStanja.Location = new System.Drawing.Point(18, 170);
            this.txtOpisStanja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtOpisStanja.Name = "txtOpisStanja";
            this.txtOpisStanja.Size = new System.Drawing.Size(349, 125);
            this.txtOpisStanja.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 18.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(17, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 31);
            this.label4.TabIndex = 47;
            this.label4.Text = "Add a condition description:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(403, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 31);
            this.label3.TabIndex = 48;
            this.label3.Text = "Doctor\'s observation:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtZapazenjeDoktora
            // 
            this.txtZapazenjeDoktora.BackColor = System.Drawing.Color.Silver;
            this.txtZapazenjeDoktora.Font = new System.Drawing.Font("Segoe UI", 13.2F, System.Drawing.FontStyle.Bold);
            this.txtZapazenjeDoktora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.txtZapazenjeDoktora.Location = new System.Drawing.Point(409, 170);
            this.txtZapazenjeDoktora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtZapazenjeDoktora.Name = "txtZapazenjeDoktora";
            this.txtZapazenjeDoktora.Size = new System.Drawing.Size(345, 125);
            this.txtZapazenjeDoktora.TabIndex = 3;
            // 
            // btnAddExamination
            // 
            this.btnAddExamination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.btnAddExamination.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.btnAddExamination.FlatAppearance.BorderSize = 2;
            this.btnAddExamination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddExamination.Font = new System.Drawing.Font("Segoe UI", 18.75F, System.Drawing.FontStyle.Bold);
            this.btnAddExamination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.btnAddExamination.Location = new System.Drawing.Point(521, 329);
            this.btnAddExamination.Name = "btnAddExamination";
            this.btnAddExamination.Size = new System.Drawing.Size(233, 48);
            this.btnAddExamination.TabIndex = 4;
            this.btnAddExamination.Text = "Add Examination";
            this.btnAddExamination.UseVisualStyleBackColor = false;
            this.btnAddExamination.Click += new System.EventHandler(this.btnAddExamination_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // frmNoviPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 392);
            this.Controls.Add(this.btnAddExamination);
            this.Controls.Add(this.txtZapazenjeDoktora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOpisStanja);
            this.Controls.Add(this.txtDatumPregleda);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPacijenti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbDijagnoze);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmNoviPregled";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New examination";
            this.Load += new System.EventHandler(this.frmNoviPregled_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDijagnoze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbPacijenti;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtDatumPregleda;
        private System.Windows.Forms.Label txtOpisStanja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtZapazenjeDoktora;
        private System.Windows.Forms.Button btnAddExamination;
        private System.Windows.Forms.ErrorProvider err;
    }
}