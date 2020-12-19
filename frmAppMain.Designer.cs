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
            this.tcHome = new System.Windows.Forms.TabControl();
            this.tPHome = new System.Windows.Forms.TabPage();
            this.tpNext = new System.Windows.Forms.TabPage();
            this.tcHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcHome
            // 
            this.tcHome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcHome.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tcHome.Controls.Add(this.tPHome);
            this.tcHome.Controls.Add(this.tpNext);
            this.tcHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tcHome.Font = new System.Drawing.Font("Segoe UI Semibold", 22.75F, System.Drawing.FontStyle.Bold);
            this.tcHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tcHome.Location = new System.Drawing.Point(12, 39);
            this.tcHome.Name = "tcHome";
            this.tcHome.SelectedIndex = 0;
            this.tcHome.Size = new System.Drawing.Size(1070, 530);
            this.tcHome.TabIndex = 0;
            this.tcHome.Tag = "";
            // 
            // tPHome
            // 
            this.tPHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.tPHome.Font = new System.Drawing.Font("Segoe UI Semibold", 22.75F, System.Drawing.FontStyle.Bold);
            this.tPHome.Location = new System.Drawing.Point(4, 53);
            this.tPHome.Name = "tPHome";
            this.tPHome.Padding = new System.Windows.Forms.Padding(3);
            this.tPHome.Size = new System.Drawing.Size(1062, 473);
            this.tPHome.TabIndex = 0;
            this.tPHome.Text = "Home";
            // 
            // tpNext
            // 
            this.tpNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.tpNext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpNext.Location = new System.Drawing.Point(4, 53);
            this.tpNext.Name = "tpNext";
            this.tpNext.Padding = new System.Windows.Forms.Padding(3);
            this.tpNext.Size = new System.Drawing.Size(1062, 473);
            this.tpNext.TabIndex = 1;
            this.tpNext.Text = "Next";
            // 
            // frmAppMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 581);
            this.Controls.Add(this.tcHome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAppMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAppMain";
            this.tcHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcHome;
        private System.Windows.Forms.TabPage tPHome;
        private System.Windows.Forms.TabPage tpNext;
    }
}