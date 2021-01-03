namespace Hospital_System_Demo.Patients
{
    partial class frmShowExamination
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
            this.lblImePacijenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblImePacijenta
            // 
            this.lblImePacijenta.AutoSize = true;
            this.lblImePacijenta.Location = new System.Drawing.Point(229, 133);
            this.lblImePacijenta.Name = "lblImePacijenta";
            this.lblImePacijenta.Size = new System.Drawing.Size(35, 13);
            this.lblImePacijenta.TabIndex = 0;
            this.lblImePacijenta.Text = "label1";
            // 
            // frmShowExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblImePacijenta);
            this.Name = "frmShowExamination";
            this.Text = "frmPrikaziPregled";
            this.Load += new System.EventHandler(this.frmShowExamination_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImePacijenta;
    }
}