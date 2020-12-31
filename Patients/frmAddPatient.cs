using Hospital_System_Demo.Doctors_Nurses;
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
    public partial class frmAddPatient : Form
    {
        private Doktor _doktor
        public frmAddPatient()
        {
            InitializeComponent();
            _doktor = new Doktor();
        }

        public frmAddPatient(Doktor doktor):this()
        {
            _doktor = doktor;
        }

        private void frmAddPatient_Load(object sender, EventArgs e)
        {
            UcitajDefaultPodatke();
        }

        private void UcitajDefaultPodatke()
        {
            UcitajDijagnoze();
            UcitajKrvneGrupe();
            UcitajSpolove();
            GenerisiMail();
            GenerisiSifruPacijenta();
            txtTrenutniDatum.Text = DateTime.Now.ToShortDateString();
            lblAddedDoctor.Text = _doktor.ToString();

        }
    }
}
