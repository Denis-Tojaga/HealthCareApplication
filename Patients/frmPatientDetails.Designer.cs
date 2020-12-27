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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDijagnozePacijenta = new System.Windows.Forms.DataGridView();
            this.Dijagnoza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatumOdredjivanja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijagnozePacijenta)).BeginInit();
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
            // frmPatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 517);
            this.Controls.Add(this.dgvDijagnozePacijenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPatientDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Details";
            this.Load += new System.EventHandler(this.frmPatientDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDijagnozePacijenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDijagnozePacijenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dijagnoza;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatumOdredjivanja;
    }
}