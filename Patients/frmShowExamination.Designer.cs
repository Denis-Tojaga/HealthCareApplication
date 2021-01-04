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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblOnDate = new System.Windows.Forms.Label();
            this.lblDiagnosis = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 23.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(187, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 63);
            this.label1.TabIndex = 38;
            this.label1.Text = "Examination Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPatient
            // 
            this.lblPatient.Font = new System.Drawing.Font("Segoe UI", 18.2F, System.Drawing.FontStyle.Bold);
            this.lblPatient.ForeColor = System.Drawing.Color.Silver;
            this.lblPatient.Location = new System.Drawing.Point(35, 114);
            this.lblPatient.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(357, 43);
            this.lblPatient.TabIndex = 39;
            this.lblPatient.Text = "Patient: ";
            this.lblPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOnDate
            // 
            this.lblOnDate.Font = new System.Drawing.Font("Segoe UI", 18.2F, System.Drawing.FontStyle.Bold);
            this.lblOnDate.ForeColor = System.Drawing.Color.Silver;
            this.lblOnDate.Location = new System.Drawing.Point(35, 157);
            this.lblOnDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOnDate.Name = "lblOnDate";
            this.lblOnDate.Size = new System.Drawing.Size(357, 43);
            this.lblOnDate.TabIndex = 40;
            this.lblOnDate.Text = "On date:";
            this.lblOnDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiagnosis
            // 
            this.lblDiagnosis.Font = new System.Drawing.Font("Segoe UI", 18.2F, System.Drawing.FontStyle.Bold);
            this.lblDiagnosis.ForeColor = System.Drawing.Color.Silver;
            this.lblDiagnosis.Location = new System.Drawing.Point(35, 200);
            this.lblDiagnosis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDiagnosis.Name = "lblDiagnosis";
            this.lblDiagnosis.Size = new System.Drawing.Size(391, 43);
            this.lblDiagnosis.TabIndex = 41;
            this.lblDiagnosis.Text = "Diagnosis:";
            this.lblDiagnosis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDoctor
            // 
            this.lblDoctor.Font = new System.Drawing.Font("Segoe UI", 18.2F, System.Drawing.FontStyle.Bold);
            this.lblDoctor.ForeColor = System.Drawing.Color.Silver;
            this.lblDoctor.Location = new System.Drawing.Point(35, 410);
            this.lblDoctor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(357, 43);
            this.lblDoctor.TabIndex = 42;
            this.lblDoctor.Text = "Doctor:";
            this.lblDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmShowExamination
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(727, 507);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lblDiagnosis);
            this.Controls.Add(this.lblOnDate);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmShowExamination";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examination Details";
            this.Load += new System.EventHandler(this.frmShowExamination_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblOnDate;
        private System.Windows.Forms.Label lblDiagnosis;
        private System.Windows.Forms.Label lblDoctor;
    }
}