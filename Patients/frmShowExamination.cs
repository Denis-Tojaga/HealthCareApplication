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
    public partial class frmShowExamination : Form
    {
        private Pregled _pregled;
        private Doktor _doktor;
        private HealthCareContext baza = HealthCareDB.Base;
        string navodnik = "";
        public frmShowExamination()
        {
            InitializeComponent();
        }
        public frmShowExamination(Pregled objekat,Doktor doktor) : this()
        {
            _pregled = objekat;
            _doktor = doktor;
        }
        private void frmShowExamination_Load(object sender, EventArgs e)
        {
            UcitajPregled();
        }




        /// <summary>
        /// Loads the current examination and its data
        /// </summary>
        private void UcitajPregled()
        {
            try
            {
                lblPatient.Text += "  " + _pregled.Pacijent.ToString();
                lblOnDate.Text += "  " + _pregled.DatumPregleda;
                lblDiagnosis.Text += "  " + _pregled.Dijagnoza.ToString();
                lblDoctor.Text += "  " + _doktor.ToString();
                lblOpisStanja.Text +=_pregled.OpisStanja + "...";
                lblZapazanjeDoktora.Text = _pregled.ZakljucakDoktora + "...";
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

       
    }
}
