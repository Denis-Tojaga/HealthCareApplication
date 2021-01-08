using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_System_Demo.Data;
using Microsoft.Reporting.WinForms;

namespace Hospital_System_Demo.Doctors_Nurses
{
    public partial class frmDailyReview : Form
    {
        private dtoTransfer objekat;
        public frmDailyReview()
        {
            InitializeComponent();
        }

        public frmDailyReview(dtoTransfer transfer) :this()
        {
            objekat = transfer;
        }

        private string PostaviSatnicu(int i)
        {
            if (i == 0)
                return "08:30";
            else if (i == 1)
                return "09:30";
            else if (i == 2)
                return "13:30";
            else if (i == 3)
                return "14:30";
            else if (i == 4)
                return "15:30";
            return "";
        }

        private void frmDailyReview_Load(object sender, EventArgs e)
        {
            dsStanje.tblDanasnjeStanjeDataTable tbl = new dsStanje.tblDanasnjeStanjeDataTable();
            for (int i = 0; i < objekat.ListaPregledaZaDanas.Count(); i++)
            {
                dsStanje.tblDanasnjeStanjeRow noviRed = tbl.NewtblDanasnjeStanjeRow();
                noviRed.Satnica = PostaviSatnicu(i);
                noviRed.Soba = "Soba10" + i;
                noviRed.Pacijent = objekat.ListaPregledaZaDanas[i].Pacijent.ToString();
                tbl.Rows.Add(noviRed);
            }

            ReportDataSource izvor = new ReportDataSource();
            izvor.Name = "dsIzvor";
            izvor.Value = tbl;

            rptViewer.LocalReport.DataSources.Add(izvor);
            this.rptViewer.RefreshReport();
        }
    }
}
