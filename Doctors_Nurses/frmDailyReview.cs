using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void frmDailyReview_Load(object sender, EventArgs e)
        {

            this.rptViewer.RefreshReport();
        }
    }
}
