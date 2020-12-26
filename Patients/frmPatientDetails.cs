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
    public partial class frmPatientDetails : Form
    {
        private HealthCareContext baza = HealthCareDB.Base;
        private Pacijent _pacijent;
        public frmPatientDetails()
        {
            InitializeComponent();
            _pacijent = new Pacijent();
        }

        public frmPatientDetails(Pacijent pacijent) : this()
        {
            _pacijent = pacijent;
        }

        private void frmPatientDetails_Load(object sender, EventArgs e)
        {
            LoadDiagnosis(_pacijent);
        }

        private void LoadDiagnosis(Pacijent pacijent)
        {
            dataGridView1.DataSource = null;
            var listaDijagnoza = baza.PacijentiDijagnoze.ToList();
            dataGridView1.DataSource = listaDijagnoza;
        }
    }
}
