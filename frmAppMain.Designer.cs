namespace Hospital_System_Demo
{
    partial class frmAppMain
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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHospitalInfo = new System.Windows.Forms.Button();
            this.panelMeniButtons = new System.Windows.Forms.Panel();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.btnMedicineOrders = new System.Windows.Forms.Button();
            this.btnExaminations = new System.Windows.Forms.Button();
            this.btnPatients = new System.Windows.Forms.Button();
            this.panelChildForms = new System.Windows.Forms.Panel();
            this.panelTitle.SuspendLayout();
            this.panelMeniButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1076, 110);
            this.panelTitle.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 2;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1023, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.lblTitle.Location = new System.Drawing.Point(200, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(642, 67);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HEALTH CARE APP";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHospitalInfo
            // 
            this.btnHospitalInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.btnHospitalInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHospitalInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.btnHospitalInfo.FlatAppearance.BorderSize = 6;
            this.btnHospitalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHospitalInfo.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHospitalInfo.ForeColor = System.Drawing.Color.White;
            this.btnHospitalInfo.Location = new System.Drawing.Point(0, 0);
            this.btnHospitalInfo.Name = "btnHospitalInfo";
            this.btnHospitalInfo.Size = new System.Drawing.Size(189, 112);
            this.btnHospitalInfo.TabIndex = 0;
            this.btnHospitalInfo.Text = "Hospital info";
            this.btnHospitalInfo.UseVisualStyleBackColor = false;
            this.btnHospitalInfo.Click += new System.EventHandler(this.btnHospitalInfo_Click);
            // 
            // panelMeniButtons
            // 
            this.panelMeniButtons.Controls.Add(this.btnUserInfo);
            this.panelMeniButtons.Controls.Add(this.btnMedicineOrders);
            this.panelMeniButtons.Controls.Add(this.btnExaminations);
            this.panelMeniButtons.Controls.Add(this.btnPatients);
            this.panelMeniButtons.Controls.Add(this.btnHospitalInfo);
            this.panelMeniButtons.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMeniButtons.Location = new System.Drawing.Point(0, 110);
            this.panelMeniButtons.Name = "panelMeniButtons";
            this.panelMeniButtons.Size = new System.Drawing.Size(189, 556);
            this.panelMeniButtons.TabIndex = 2;
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.btnUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.btnUserInfo.FlatAppearance.BorderSize = 6;
            this.btnUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnUserInfo.ForeColor = System.Drawing.Color.White;
            this.btnUserInfo.Location = new System.Drawing.Point(0, 447);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(189, 109);
            this.btnUserInfo.TabIndex = 4;
            this.btnUserInfo.Text = "User info";
            this.btnUserInfo.UseVisualStyleBackColor = false;
            // 
            // btnMedicineOrders
            // 
            this.btnMedicineOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.btnMedicineOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedicineOrders.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.btnMedicineOrders.FlatAppearance.BorderSize = 6;
            this.btnMedicineOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedicineOrders.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicineOrders.ForeColor = System.Drawing.Color.White;
            this.btnMedicineOrders.Location = new System.Drawing.Point(0, 331);
            this.btnMedicineOrders.Name = "btnMedicineOrders";
            this.btnMedicineOrders.Size = new System.Drawing.Size(189, 116);
            this.btnMedicineOrders.TabIndex = 3;
            this.btnMedicineOrders.Text = "Medicine orders";
            this.btnMedicineOrders.UseVisualStyleBackColor = false;
            // 
            // btnExaminations
            // 
            this.btnExaminations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.btnExaminations.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExaminations.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.btnExaminations.FlatAppearance.BorderSize = 6;
            this.btnExaminations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExaminations.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnExaminations.ForeColor = System.Drawing.Color.White;
            this.btnExaminations.Location = new System.Drawing.Point(0, 219);
            this.btnExaminations.Name = "btnExaminations";
            this.btnExaminations.Size = new System.Drawing.Size(189, 112);
            this.btnExaminations.TabIndex = 2;
            this.btnExaminations.Text = "Examinations";
            this.btnExaminations.UseVisualStyleBackColor = false;
            // 
            // btnPatients
            // 
            this.btnPatients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.btnPatients.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPatients.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.btnPatients.FlatAppearance.BorderSize = 6;
            this.btnPatients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatients.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatients.ForeColor = System.Drawing.Color.White;
            this.btnPatients.Location = new System.Drawing.Point(0, 112);
            this.btnPatients.Name = "btnPatients";
            this.btnPatients.Size = new System.Drawing.Size(189, 107);
            this.btnPatients.TabIndex = 1;
            this.btnPatients.Text = "Patients";
            this.btnPatients.UseVisualStyleBackColor = false;
            // 
            // panelChildForms
            // 
            this.panelChildForms.Location = new System.Drawing.Point(189, 110);
            this.panelChildForms.Name = "panelChildForms";
            this.panelChildForms.Size = new System.Drawing.Size(887, 556);
            this.panelChildForms.TabIndex = 3;
            // 
            // frmAppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 666);
            this.Controls.Add(this.panelChildForms);
            this.Controls.Add(this.panelMeniButtons);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAppMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAppMain";
            this.Load += new System.EventHandler(this.frmAppMain_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelMeniButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnHospitalInfo;
        private System.Windows.Forms.Panel panelMeniButtons;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Button btnMedicineOrders;
        private System.Windows.Forms.Button btnExaminations;
        private System.Windows.Forms.Button btnPatients;
        private System.Windows.Forms.Panel panelChildForms;
    }
}