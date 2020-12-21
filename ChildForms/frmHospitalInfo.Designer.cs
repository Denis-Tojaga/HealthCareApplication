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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsOpenInMaps = new System.Windows.Forms.ToolStripMenuItem();
            this.wbMaps = new System.Windows.Forms.WebBrowser();
            this.lblLink = new System.Windows.Forms.LinkLabel();
            this.btnNavigate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.lblTitle.Location = new System.Drawing.Point(643, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(232, 50);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Hospital Info";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.wbMaps);
            this.panel1.Location = new System.Drawing.Point(37, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 274);
            this.panel1.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsOpenInMaps});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(149, 26);
            // 
            // cmsOpenInMaps
            // 
            this.cmsOpenInMaps.Name = "cmsOpenInMaps";
            this.cmsOpenInMaps.Size = new System.Drawing.Size(148, 22);
            this.cmsOpenInMaps.Text = "Open in Maps";
            this.cmsOpenInMaps.Click += new System.EventHandler(this.cmsOpenInMaps_Click);
            // 
            // wbMaps
            // 
            this.wbMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbMaps.Location = new System.Drawing.Point(0, 0);
            this.wbMaps.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbMaps.Name = "wbMaps";
            this.wbMaps.Size = new System.Drawing.Size(442, 274);
            this.wbMaps.TabIndex = 4;
            this.wbMaps.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.wbMaps_Navigated);
            // 
            // lblLink
            // 
            this.lblLink.AutoSize = true;
            this.lblLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblLink.LinkColor = System.Drawing.Color.White;
            this.lblLink.Location = new System.Drawing.Point(224, 289);
            this.lblLink.Name = "lblLink";
            this.lblLink.Size = new System.Drawing.Size(29, 13);
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
            this.btnNavigate.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnNavigate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(83)))), ((int)(((byte)(20)))));
            this.btnNavigate.Location = new System.Drawing.Point(151, 305);
            this.btnNavigate.Name = "btnNavigate";
            this.btnNavigate.Size = new System.Drawing.Size(175, 37);
            this.btnNavigate.TabIndex = 5;
            this.btnNavigate.Text = "Navigate";
            this.btnNavigate.UseVisualStyleBackColor = false;
            // 
            // frmHospitalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(887, 556);
            this.Controls.Add(this.btnNavigate);
            this.Controls.Add(this.lblLink);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHospitalInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Info";
            this.Load += new System.EventHandler(this.frmHospitalInfo_Load);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
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
    }
}