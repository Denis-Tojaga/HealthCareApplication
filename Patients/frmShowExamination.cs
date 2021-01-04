using Hospital_System_Demo.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System_Demo.Patients
{
    public partial class frmShowExamination : Form
    {
        private Pregled _pregled;
        private HealthCareContext baza = HealthCareDB.Base;
        public frmShowExamination()
        {
            InitializeComponent();
        }

        public frmShowExamination(Pregled objekat) : this()
        {
            _pregled = objekat;
        }

        private void frmShowExamination_Load(object sender, EventArgs e)
        {
            UcitajPregled();
        }

        private void UcitajPregled()
        {
            try
            {

            }
            catch (Exception ex)
            {

            }
        }
    }
}
