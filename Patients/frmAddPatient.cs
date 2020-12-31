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
    public partial class frmAddPatient : Form
    {
        HealthCareContext baza = HealthCareDB.Base;
        private Doktor _doktor;
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
            GenerisiSifruPacijenta();
            txtTrenutniDatum.Text = DateTime.Now.ToShortDateString();
            lblAddedDoctor.Text = _doktor.ToString();
        }





        private void GenerisiSifruPacijenta()
        {
            Random random = new Random();
            string moguciZnakovi = @"1q2w3e4r5t6z7u8i9o0pasvgdfjkxlmn#k/";
            string code = "";
            for (int i = 0; i < 5; i++)
                code += moguciZnakovi[random.Next(0, moguciZnakovi.Length)];
            txtSifraPacijenta.Text = code;
        }
        private void GenerisiMail()
        {
            txtEmail.Text = txtIme.Text + "." + txtPrezime.Text + "@healthCare.com";
        }





        private void UcitajSpolove()
        {
            try
            {
                cmbSpol.DataSource = baza.Spolovi.ToList();
                cmbSpol.DisplayMember = "Naziv";
                cmbSpol.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }
        private void UcitajKrvneGrupe()
        {
            try
            {
                cmbKrvnaGrupa.DataSource = baza.KrvneGrupe.ToList();
                cmbKrvnaGrupa.DisplayMember = "Oznaka";
                cmbKrvnaGrupa.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }
        private void UcitajDijagnoze()
        {
            try
            {
                cmbDijagnoze.DataSource = baza.Dijagnoze.ToList();
                cmbDijagnoze.DisplayMember = "Naziv";
                cmbDijagnoze.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }





        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            GenerisiMail();
        }
        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            GenerisiMail();
        }
    }
}
