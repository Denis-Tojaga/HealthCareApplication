namespace Hospital_System_Demo.ChildForms
{
    partial class frmHospitalInfo
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wbMaps = new System.Windows.Forms.WebBrowser();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsOpenInMaps = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.btnNavigate = new System.Windows.Forms.Button();
            this.txtIme = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDoctorNumber = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lblNurseNumber = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPatientNumber = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.lblTitle.Location = new System.Drawing.Point(979, 64);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 62);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Info";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wbMaps);
            this.panel1.Location = new System.Drawing.Point(52, 61);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 337);
            this.panel1.TabIndex = 2;
            // 
            // wbMaps
            // 
            this.wbMaps.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.wbMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbMaps.Location = new System.Drawing.Point(0, 0);
            this.wbMaps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wbMaps.MinimumSize = new System.Drawing.Size(27, 25);
            this.wbMaps.Name = "wbMaps";
            this.wbMaps.ScriptErrorsSuppressed = true;
            this.wbMaps.Size = new System.Drawing.Size(589, 337);
            this.wbMaps.TabIndex = 4;
            this.wbMaps.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wbMaps_Navigated);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsOpenInMaps});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(171, 28);
            // 
            // cmsOpenInMaps
            // 
            this.cmsOpenInMaps.Name = "cmsOpenInMaps";
            this.cmsOpenInMaps.Size = new System.Drawing.Size(170, 24);
            this.cmsOpenInMaps.Text = "Open in Maps";
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblLink.LinkColor = System.Drawing.Color.White;
            this.lblLink.Location = new System.Drawing.Point(660, 15);
            this.lblLink.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(36, 17);
            this.lblLink.TabIndex = 4;
            this.lblLink.TabStop = true;
            this.lblLink.Text = "URL";
            // 
            // btnNavigate
            // 
            this.btnNavigate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.btnNavigate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.btnNavigate.FlatAppearance.BorderSize = 2;
            this.btnNavigate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavigate.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnNavigate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.btnNavigate.Location = new System.Drawing.Point(242, 406);
            this.btnNavigate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNavigate.Name = "btnNavigate";
            this.btnNavigate.Size = new System.Drawing.Size(213, 39);
            this.btnNavigate.TabIndex = 5;
            this.btnNavigate.Text = "Open in browser";
            this.btnNavigate.UseVisualStyleBackColor = false;
            this.btnNavigate.Click += new System.EventHandler(this.btnNavigate_Click);
            this.btnNavigate.MouseLeave += new System.EventHandler(this.btnNavigate_MouseLeave);
            this.btnNavigate.MouseHover += new System.EventHandler(this.btnNavigate_MouseHover);
            // 
            // txtIme
            // 
            this.txtIme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.txtIme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIme.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIme.ForeColor = System.Drawing.Color.White;
            this.txtIme.Location = new System.Drawing.Point(843, 162);
            this.txtIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIme.Name = "txtIme";
            this.txtIme.Size = new System.Drawing.Size(319, 32);
            this.txtIme.TabIndex = 17;
            this.txtIme.Text = "Dom Zdravlja Mostar";
            this.txtIme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGray;
            this.label4.Location = new System.Drawing.Point(841, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(317, 2);
            this.label4.TabIndex = 18;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(843, 290);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(316, 45);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "124";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(843, 337);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 2);
            this.label1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(843, 230);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(316, 32);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "domzdravlja@health.com";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(843, 265);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(316, 2);
            this.label2.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.label3.Location = new System.Drawing.Point(724, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 42);
            this.label3.TabIndex = 23;
            this.label3.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18.25F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.label5.Location = new System.Drawing.Point(732, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 42);
            this.label5.TabIndex = 24;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 18.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.label6.Location = new System.Drawing.Point(691, 303);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 42);
            this.label6.TabIndex = 25;
            this.label6.Text = "Number";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(211)))), ((int)(((byte)(3)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.lblDoctorNumber);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(37, 471);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(345, 127);
            this.panel3.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 62);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 48);
            this.label7.TabIndex = 4;
            this.label7.Text = "Doctors";
            // 
            // lblDoctorNumber
            // 
            this.lblDoctorNumber.AutoSize = true;
            this.lblDoctorNumber.Font = new System.Drawing.Font("Comic Sans MS", 23.25F, System.Drawing.FontStyle.Bold);
            this.lblDoctorNumber.ForeColor = System.Drawing.Color.Black;
            this.lblDoctorNumber.Location = new System.Drawing.Point(5, 5);
            this.lblDoctorNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDoctorNumber.Name = "lblDoctorNumber";
            this.lblDoctorNumber.Size = new System.Drawing.Size(48, 55);
            this.lblDoctorNumber.TabIndex = 3;
            this.lblDoctorNumber.Text = "5";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(211)))), ((int)(((byte)(3)))));
            this.panel8.Controls.Add(this.label11);
            this.panel8.Controls.Add(this.lblNurseNumber);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(431, 471);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(336, 129);
            this.panel8.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(7, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(135, 48);
            this.label11.TabIndex = 7;
            this.label11.Text = "Nurses";
            // 
            // lblNurseNumber
            // 
            this.lblNurseNumber.AutoSize = true;
            this.lblNurseNumber.Font = new System.Drawing.Font("Comic Sans MS", 23.25F, System.Drawing.FontStyle.Bold);
            this.lblNurseNumber.ForeColor = System.Drawing.Color.Black;
            this.lblNurseNumber.Location = new System.Drawing.Point(5, 5);
            this.lblNurseNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNurseNumber.Name = "lblNurseNumber";
            this.lblNurseNumber.Size = new System.Drawing.Size(48, 55);
            this.lblNurseNumber.TabIndex = 6;
            this.lblNurseNumber.Text = "5";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(211)))), ((int)(((byte)(3)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblPatientNumber);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Location = new System.Drawing.Point(808, 471);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(336, 129);
            this.panel2.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(7, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 48);
            this.label8.TabIndex = 7;
            this.label8.Text = "Patients";
            // 
            // lblPatientNumber
            // 
            this.lblPatientNumber.AutoSize = true;
            this.lblPatientNumber.Font = new System.Drawing.Font("Comic Sans MS", 23.25F, System.Drawing.FontStyle.Bold);
            this.lblPatientNumber.ForeColor = System.Drawing.Color.Black;
            this.lblPatientNumber.Location = new System.Drawing.Point(5, 5);
            this.lblPatientNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPatientNumber.Name = "lblPatientNumber";
            this.lblPatientNumber.Size = new System.Drawing.Size(48, 55);
            this.lblPatientNumber.TabIndex = 6;
            this.lblPatientNumber.Text = "5";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::Hospital_System_Demo.Properties.Resources.patient_icon_9244;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(195, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(141, 129);
            this.panel5.TabIndex = 2;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Transparent;
            this.panel9.BackgroundImage = global::Hospital_System_Demo.Properties.Resources.nurseLogo2;
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(195, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(4);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(141, 129);
            this.panel9.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::Hospital_System_Demo.Properties.Resources.doktor;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(205, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(140, 127);
            this.panel4.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 18.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(235, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(241, 42);
            this.label9.TabIndex = 31;
            this.label9.Text = "How to find us?";
            // 
            // frmHospitalInfo
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1183, 684);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnNavigate);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmHospitalInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Info";
            this.Load += new System.EventHandler(this.frmHospitalInfo_Load);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsOpenInMaps;
        private System.Windows.Forms.WebBrowser wbMaps;
        private System.Windows.Forms.LinkLabel lblLink;
        private System.Windows.Forms.Button btnNavigate;
        private System.Windows.Forms.TextBox txtIme;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDoctorNumber;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNurseNumber;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPatientNumber;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label9;
    }
}