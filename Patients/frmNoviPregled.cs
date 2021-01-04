using Hospital_System_Demo.Data;
using Hospital_System_Demo.Doctors_Nurses;
using Hospital_System_Demo.Helpers;
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
    public partial class frmNoviPregled : Form
    {
        private Doktor _doktor;
        private HealthCareContext baza = HealthCareDB.Base;
        public frmNoviPregled()
        {
            InitializeComponent();
        }

        public frmNoviPregled(Doktor doktor):this()
        {
            _doktor = doktor;
            try
            {
                UcitajDijagnoze();
                UcitajPacijente();
                txtDatumPregleda.Text = DateTime.Now.ToShortDateString();
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private void UcitajPacijente()
        {
            throw new NotImplementedException();
        }

       
        private void UcitajDijagnoze()
        {
            cmbDijagnoze.DataSource = baza.Dijagnoze.ToList();
            cmbDijagnoze.DisplayMember = "Naziv";
            cmbDijagnoze.ValueMember = "Id";
        }

        private void frmNoviPregled_Load(object sender, EventArgs e)
        {

        }
    }
}
