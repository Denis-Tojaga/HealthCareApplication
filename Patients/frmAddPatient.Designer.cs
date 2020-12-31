namespace Hospital_System_Demo.Patients
{
    partial class frmAddPatient
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
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.cmbKrvnaGrupa = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbSpol = new System.Windows.Forms.ComboBox();
            this.Gender = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSifraPacijenta = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDijagnoze = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTrenutniDatum = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblAddingHC = new System.Windows.Forms.Label();
            this.lblAddedDoctor = new System.Windows.Forms.Label();
            this.pbHealthCard = new System.Windows.Forms.PictureBox();
            this.ofdAddHealthCard = new System.Windows.Forms.OpenFileDialog();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dtmDatumRodjenja = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pbHealthCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.btnAddPatient.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold);
            this.btnAddPatient.Location = new System.Drawing.Point(682, 370);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(177, 40);
            this.btnAddPatient.TabIndex = 9;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // cmbKrvnaGrupa
            // 
            this.cmbKrvnaGrupa.BackColor = System.Drawing.Color.Silver;
            this.cmbKrvnaGrupa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKrvnaGrupa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKrvnaGrupa.ForeColor = System.Drawing.Color.Black;
            this.cmbKrvnaGrupa.FormattingEnabled = true;
            this.cmbKrvnaGrupa.Location = new System.Drawing.Point(733, 207);
            this.cmbKrvnaGrupa.Name = "cmbKrvnaGrupa";
            this.cmbKrvnaGrupa.Size = new System.Drawing.Size(123, 29);
            this.cmbKrvnaGrupa.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(629, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 30);
            this.label12.TabIndex = 66;
            this.label12.Text = "Blood type:";
            // 
            // cmbSpol
            // 
            this.cmbSpol.BackColor = System.Drawing.Color.Silver;
            this.cmbSpol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpol.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSpol.ForeColor = System.Drawing.Color.Black;
            this.cmbSpol.FormattingEnabled = true;
            this.cmbSpol.Location = new System.Drawing.Point(733, 148);
            this.cmbSpol.Name = "cmbSpol";
            this.cmbSpol.Size = new System.Drawing.Size(123, 29);
            this.cmbSpol.TabIndex = 7;
            // 
            // Gender
            // 
            this.Gender.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.Gender.ForeColor = System.Drawing.Color.Silver;
            this.Gender.Location = new System.Drawing.Point(632, 148);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(81, 30);
            this.Gender.TabIndex = 64;
            this.Gender.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(25, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 30);
            this.label6.TabIndex = 57;
            this.label6.Text = "First Name:";
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.txtIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIme.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.txtIme.ForeColor = System.Drawing.Color.DarkGray;
            this.txtIme.Location = new System.Drawing.Point(146, 43);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(167, 25);
            this.txtIme.TabIndex = 0;
            this.txtIme.TextChanged += new System.EventHandler(this.txtIme_TextChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(146, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 2);
            this.label4.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(25, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 30);
            this.label1.TabIndex = 74;
            this.label1.Text = "Last Name:";
            // 
            // txtPrezime
            // 
            this.txtPrezime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.txtPrezime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrezime.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.txtPrezime.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPrezime.Location = new System.Drawing.Point(146, 102);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(167, 25);
            this.txtPrezime.TabIndex = 1;
            this.txtPrezime.TextChanged += new System.EventHandler(this.txtPrezime_TextChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGray;
            this.label7.Location = new System.Drawing.Point(146, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 2);
            this.label7.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(70, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 30);
            this.label11.TabIndex = 77;
            this.label11.Text = "JMBG:";
            // 
            // txtJMBG
            // 
            this.txtJMBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.txtJMBG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJMBG.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.txtJMBG.ForeColor = System.Drawing.Color.DarkGray;
            this.txtJMBG.Location = new System.Drawing.Point(146, 161);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(167, 25);
            this.txtJMBG.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkGray;
            this.label15.Location = new System.Drawing.Point(146, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 2);
            this.label15.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(25, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 30);
            this.label5.TabIndex = 80;
            this.label5.Text = "Patient Code:";
            // 
            // txtSifraPacijenta
            // 
            this.txtSifraPacijenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.txtSifraPacijenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifraPacijenta.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.txtSifraPacijenta.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSifraPacijenta.Location = new System.Drawing.Point(182, 220);
            this.txtSifraPacijenta.Name = "txtSifraPacijenta";
            this.txtSifraPacijenta.ReadOnly = true;
            this.txtSifraPacijenta.Size = new System.Drawing.Size(131, 25);
            this.txtSifraPacijenta.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DarkGray;
            this.label10.Location = new System.Drawing.Point(182, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 2);
            this.label10.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(25, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 30);
            this.label2.TabIndex = 83;
            this.label2.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.Location = new System.Drawing.Point(96, 289);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(217, 20);
            this.txtEmail.TabIndex = 81;
            this.txtEmail.Text = "@healthCare.com";
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(96, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 2);
            this.label3.TabIndex = 82;
            // 
            // cmbDijagnoze
            // 
            this.cmbDijagnoze.BackColor = System.Drawing.Color.Silver;
            this.cmbDijagnoze.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDijagnoze.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDijagnoze.ForeColor = System.Drawing.Color.Black;
            this.cmbDijagnoze.FormattingEnabled = true;
            this.cmbDijagnoze.Location = new System.Drawing.Point(436, 38);
            this.cmbDijagnoze.Name = "cmbDijagnoze";
            this.cmbDijagnoze.Size = new System.Drawing.Size(190, 29);
            this.cmbDijagnoze.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(333, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 30);
            this.label8.TabIndex = 85;
            this.label8.Text = "Diagnosis:";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(644, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 30);
            this.label9.TabIndex = 88;
            this.label9.Text = "Date:";
            // 
            // txtTrenutniDatum
            // 
            this.txtTrenutniDatum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.txtTrenutniDatum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTrenutniDatum.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.txtTrenutniDatum.ForeColor = System.Drawing.Color.DarkGray;
            this.txtTrenutniDatum.Location = new System.Drawing.Point(736, 86);
            this.txtTrenutniDatum.Name = "txtTrenutniDatum";
            this.txtTrenutniDatum.ReadOnly = true;
            this.txtTrenutniDatum.Size = new System.Drawing.Size(120, 25);
            this.txtTrenutniDatum.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DarkGray;
            this.label13.Location = new System.Drawing.Point(736, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 2);
            this.label13.TabIndex = 87;
            // 
            // lblAddingHC
            // 
            this.lblAddingHC.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.lblAddingHC.ForeColor = System.Drawing.Color.Silver;
            this.lblAddingHC.Location = new System.Drawing.Point(381, 370);
            this.lblAddingHC.Name = "lblAddingHC";
            this.lblAddingHC.Size = new System.Drawing.Size(216, 30);
            this.lblAddingHC.TabIndex = 90;
            this.lblAddingHC.Text = "Click to add HealthCard";
            // 
            // lblAddedDoctor
            // 
            this.lblAddedDoctor.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.lblAddedDoctor.ForeColor = System.Drawing.Color.Silver;
            this.lblAddedDoctor.Location = new System.Drawing.Point(677, 413);
            this.lblAddedDoctor.Name = "lblAddedDoctor";
            this.lblAddedDoctor.Size = new System.Drawing.Size(182, 30);
            this.lblAddedDoctor.TabIndex = 93;
            this.lblAddedDoctor.Text = "Current Doctor";
            this.lblAddedDoctor.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pbHealthCard
            // 
            this.pbHealthCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHealthCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbHealthCard.Location = new System.Drawing.Point(338, 87);
            this.pbHealthCard.Name = "pbHealthCard";
            this.pbHealthCard.Size = new System.Drawing.Size(288, 280);
            this.pbHealthCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHealthCard.TabIndex = 89;
            this.pbHealthCard.TabStop = false;
            this.pbHealthCard.Click += new System.EventHandler(this.pbHealthCard_Click);
            // 
            // ofdAddHealthCard
            // 
            this.ofdAddHealthCard.FileName = "openFileDialog1";
            // 
            // err
            // 
            this.err.BlinkRate = 200;
            this.err.ContainerControl = this;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Silver;
            this.label14.Location = new System.Drawing.Point(25, 342);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 30);
            this.label14.TabIndex = 96;
            this.label14.Text = "Date of birth:";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkGray;
            this.label16.Location = new System.Drawing.Point(161, 370);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 2);
            this.label16.TabIndex = 95;
            // 
            // dtmDatumRodjenja
            // 
            this.dtmDatumRodjenja.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.dtmDatumRodjenja.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dtmDatumRodjenja.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtmDatumRodjenja.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDatumRodjenja.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDatumRodjenja.Location = new System.Drawing.Point(161, 342);
            this.dtmDatumRodjenja.Name = "dtmDatumRodjenja";
            this.dtmDatumRodjenja.Size = new System.Drawing.Size(152, 25);
            this.dtmDatumRodjenja.TabIndex = 4;
            // 
            // frmAddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.dtmDatumRodjenja);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblAddedDoctor);
            this.Controls.Add(this.lblAddingHC);
            this.Controls.Add(this.pbHealthCard);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTrenutniDatum);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbDijagnoze);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSifraPacijenta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.cmbKrvnaGrupa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbSpol);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label4);
            this.Name = "frmAddPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddPatient";
            this.Load += new System.EventHandler(this.frmAddPatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHealthCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.ComboBox cmbKrvnaGrupa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbSpol;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSifraPacijenta;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDijagnoze;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTrenutniDatum;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pbHealthCard;
        private System.Windows.Forms.Label lblAddingHC;
        private System.Windows.Forms.Label lblAddedDoctor;
        private System.Windows.Forms.OpenFileDialog ofdAddHealthCard;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.DateTimePicker dtmDatumRodjenja;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
    }
}