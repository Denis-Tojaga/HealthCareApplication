namespace Hospital_System_Demo.Patients
{
    partial class frmPatientDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDijagnozePacijenta = new System.Windows.Forms.DataGridView();
            this.Dijagnoza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumOdredjivanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrezime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtJMBG = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifraPacijenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pbHealthCard = new System.Windows.Forms.PictureBox();
            this.Gender = new System.Windows.Forms.Label();
            this.cmbSpol = new System.Windows.Forms.ComboBox();
            this.cmbKrvnaGrupa = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDatumEvidencije = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnEditDetails = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblCancel = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.ofdAddCard = new System.Windows.Forms.OpenFileDialog();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijagnozePacijenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHealthCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDijagnozePacijenta
            // 
            this.dgvDijagnozePacijenta.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.dgvDijagnozePacijenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDijagnozePacijenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.dgvDijagnozePacijenta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDijagnozePacijenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvDijagnozePacijenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDijagnozePacijenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDijagnozePacijenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDijagnozePacijenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dijagnoza,
            this.DatumOdredjivanja});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDijagnozePacijenta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDijagnozePacijenta.EnableHeadersVisualStyles = false;
            this.dgvDijagnozePacijenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.dgvDijagnozePacijenta.Location = new System.Drawing.Point(586, 62);
            this.dgvDijagnozePacijenta.Name = "dgvDijagnozePacijenta";
            this.dgvDijagnozePacijenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDijagnozePacijenta.RowHeadersVisible = false;
            this.dgvDijagnozePacijenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvDijagnozePacijenta.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDijagnozePacijenta.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.dgvDijagnozePacijenta.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDijagnozePacijenta.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvDijagnozePacijenta.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.dgvDijagnozePacijenta.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.dgvDijagnozePacijenta.RowTemplate.Height = 43;
            this.dgvDijagnozePacijenta.RowTemplate.ReadOnly = true;
            this.dgvDijagnozePacijenta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDijagnozePacijenta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDijagnozePacijenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDijagnozePacijenta.Size = new System.Drawing.Size(273, 443);
            this.dgvDijagnozePacijenta.TabIndex = 1;
            // 
            // Dijagnoza
            // 
            this.Dijagnoza.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dijagnoza.DataPropertyName = "Dijagnoza";
            this.Dijagnoza.HeaderText = "Diagnosis";
            this.Dijagnoza.Name = "Dijagnoza";
            // 
            // DatumOdredjivanja
            // 
            this.DatumOdredjivanja.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DatumOdredjivanja.DataPropertyName = "DatumOdredjivanja";
            this.DatumOdredjivanja.HeaderText = "Date of record";
            this.DatumOdredjivanja.Name = "DatumOdredjivanja";
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.txtIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIme.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.txtIme.ForeColor = System.Drawing.Color.DarkGray;
            this.txtIme.Location = new System.Drawing.Point(32, 58);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(136, 25);
            this.txtIme.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(32, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 2);
            this.label4.TabIndex = 18;
            // 
            // txtPrezime
            // 
            this.txtPrezime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.txtPrezime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrezime.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.txtPrezime.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPrezime.Location = new System.Drawing.Point(215, 59);
            this.txtPrezime.Name = "txtPrezime";
            this.txtPrezime.Size = new System.Drawing.Size(136, 25);
            this.txtPrezime.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(215, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 2);
            this.label1.TabIndex = 20;
            // 
            // txtJMBG
            // 
            this.txtJMBG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.txtJMBG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJMBG.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.txtJMBG.ForeColor = System.Drawing.Color.DarkGray;
            this.txtJMBG.Location = new System.Drawing.Point(405, 60);
            this.txtJMBG.Name = "txtJMBG";
            this.txtJMBG.Size = new System.Drawing.Size(136, 25);
            this.txtJMBG.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(405, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 2);
            this.label2.TabIndex = 22;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.txtEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.txtEmail.Location = new System.Drawing.Point(32, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(218, 25);
            this.txtEmail.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkGray;
            this.label3.Location = new System.Drawing.Point(32, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 2);
            this.label3.TabIndex = 24;
            // 
            // txtSifraPacijenta
            // 
            this.txtSifraPacijenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.txtSifraPacijenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSifraPacijenta.Enabled = false;
            this.txtSifraPacijenta.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.txtSifraPacijenta.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSifraPacijenta.Location = new System.Drawing.Point(312, 136);
            this.txtSifraPacijenta.Name = "txtSifraPacijenta";
            this.txtSifraPacijenta.Size = new System.Drawing.Size(229, 25);
            this.txtSifraPacijenta.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(312, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 2);
            this.label5.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(27, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 30);
            this.label6.TabIndex = 27;
            this.label6.Text = "First Name";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(210, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 30);
            this.label7.TabIndex = 28;
            this.label7.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(400, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 30);
            this.label8.TabIndex = 29;
            this.label8.Text = "JMBG";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(27, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 30);
            this.label9.TabIndex = 30;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(307, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 30);
            this.label10.TabIndex = 31;
            this.label10.Text = "Patient code";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Silver;
            this.label11.Location = new System.Drawing.Point(581, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(278, 30);
            this.label11.TabIndex = 32;
            this.label11.Text = "All previous diagnosis";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbHealthCard
            // 
            this.pbHealthCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbHealthCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbHealthCard.Location = new System.Drawing.Point(32, 185);
            this.pbHealthCard.Name = "pbHealthCard";
            this.pbHealthCard.Size = new System.Drawing.Size(218, 280);
            this.pbHealthCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHealthCard.TabIndex = 33;
            this.pbHealthCard.TabStop = false;
            // 
            // Gender
            // 
            this.Gender.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.Gender.ForeColor = System.Drawing.Color.Silver;
            this.Gender.Location = new System.Drawing.Point(307, 210);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(97, 30);
            this.Gender.TabIndex = 37;
            this.Gender.Text = "Gender";
            // 
            // cmbSpol
            // 
            this.cmbSpol.BackColor = System.Drawing.Color.Silver;
            this.cmbSpol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpol.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSpol.ForeColor = System.Drawing.Color.Black;
            this.cmbSpol.FormattingEnabled = true;
            this.cmbSpol.Location = new System.Drawing.Point(454, 210);
            this.cmbSpol.Name = "cmbSpol";
            this.cmbSpol.Size = new System.Drawing.Size(121, 29);
            this.cmbSpol.TabIndex = 38;
            // 
            // cmbKrvnaGrupa
            // 
            this.cmbKrvnaGrupa.BackColor = System.Drawing.Color.Silver;
            this.cmbKrvnaGrupa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKrvnaGrupa.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKrvnaGrupa.ForeColor = System.Drawing.Color.Black;
            this.cmbKrvnaGrupa.FormattingEnabled = true;
            this.cmbKrvnaGrupa.Location = new System.Drawing.Point(454, 262);
            this.cmbKrvnaGrupa.Name = "cmbKrvnaGrupa";
            this.cmbKrvnaGrupa.Size = new System.Drawing.Size(121, 29);
            this.cmbKrvnaGrupa.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(307, 262);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 30);
            this.label12.TabIndex = 39;
            this.label12.Text = "Blood type";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Silver;
            this.label13.Location = new System.Drawing.Point(307, 302);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(150, 30);
            this.label13.TabIndex = 43;
            this.label13.Text = "Last record date";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDatumEvidencije
            // 
            this.txtDatumEvidencije.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.txtDatumEvidencije.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDatumEvidencije.Enabled = false;
            this.txtDatumEvidencije.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.txtDatumEvidencije.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDatumEvidencije.Location = new System.Drawing.Point(454, 302);
            this.txtDatumEvidencije.Name = "txtDatumEvidencije";
            this.txtDatumEvidencije.Size = new System.Drawing.Size(121, 25);
            this.txtDatumEvidencije.TabIndex = 41;
            this.txtDatumEvidencije.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkGray;
            this.label14.Location = new System.Drawing.Point(454, 330);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 2);
            this.label14.TabIndex = 42;
            // 
            // btnEditDetails
            // 
            this.btnEditDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.btnEditDetails.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEditDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnEditDetails.Location = new System.Drawing.Point(414, 471);
            this.btnEditDetails.Name = "btnEditDetails";
            this.btnEditDetails.Size = new System.Drawing.Size(161, 32);
            this.btnEditDetails.TabIndex = 44;
            this.btnEditDetails.Text = "Edit Details";
            this.btnEditDetails.UseVisualStyleBackColor = false;
            this.btnEditDetails.Click += new System.EventHandler(this.btnEditDetails_Click);
            // 
            // err
            // 
            this.err.BlinkRate = 150;
            this.err.ContainerControl = this;
            // 
            // lblCancel
            // 
            this.lblCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.lblCancel.ForeColor = System.Drawing.Color.Silver;
            this.lblCancel.Location = new System.Drawing.Point(409, 438);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(143, 30);
            this.lblCancel.TabIndex = 45;
            this.lblCancel.Text = "Cancel editing";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(541, 431);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(34, 34);
            this.btnCancel.TabIndex = 46;
            this.btnCancel.Text = "X";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ofdAddCard
            // 
            this.ofdAddCard.FileName = "openFileDialog1";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 13.75F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Silver;
            this.label15.Location = new System.Drawing.Point(79, 471);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 30);
            this.label15.TabIndex = 47;
            this.label15.Text = "Health Card";
            // 
            // frmPatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(871, 517);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.btnEditDetails);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDatumEvidencije);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cmbKrvnaGrupa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbSpol);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.pbHealthCard);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSifraPacijenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtJMBG);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrezime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvDijagnozePacijenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPatientDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Details";
            this.Load += new System.EventHandler(this.frmPatientDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijagnozePacijenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHealthCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDijagnozePacijenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dijagnoza;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOdredjivanja;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrezime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJMBG;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSifraPacijenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pbHealthCard;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.ComboBox cmbSpol;
        private System.Windows.Forms.ComboBox cmbKrvnaGrupa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDatumEvidencije;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnEditDetails;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.OpenFileDialog ofdAddCard;
        private System.Windows.Forms.Label label15;
    }
}