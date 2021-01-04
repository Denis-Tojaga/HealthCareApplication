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
        private RasporediDoktori _raspored;
        public frmNoviPregled()
        {
            InitializeComponent();
        }
        public frmNoviPregled(RasporediDoktori objekat):this()
        {
            _doktor = baza.Doktori.Where(x=>x.ID == objekat.Doktor.ID).FirstOrDefault();
            _raspored = objekat;
            try
            {
                UcitajDijagnoze();
                UcitajPacijente();
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }



        /// <summary>
        /// Loads patients and diagnosis in comboboxes
        /// </summary>
        private void UcitajPacijente()
        {
            cmbPacijenti.DataSource = baza.Pacijenti.ToList();
            cmbPacijenti.DisplayMember = "ImePrezime";
            cmbPacijenti.ValueMember = "Id";
        }
        private void UcitajDijagnoze()
        {
            cmbDijagnoze.DataSource = baza.Dijagnoze.ToList();
            cmbDijagnoze.DisplayMember = "Naziv";
            cmbDijagnoze.ValueMember = "Id";
        }
        private void frmNoviPregled_Load(object sender, EventArgs e)
        {
            txtDatumPregleda.Text = DateTime.Now.ToShortDateString();
        }











        /// <summary>
        /// Adds new examination to the list of examinations in the correct schedule
        /// </summary>
        private void btnAddExamination_Click(object sender, EventArgs e)
        {
            if(ValidanUnos())
            {
                Pregled noviPregled = new Pregled();
                noviPregled.DatumPregleda = txtDatumPregleda.Text;
                noviPregled.Pacijent = cmbPacijenti.SelectedItem as Pacijent;
                noviPregled.Dijagnoza = cmbDijagnoze.SelectedItem as Dijagnoza;
                noviPregled.OpisStanja = txtOpisStanja.Text;
                noviPregled.ZakljucakDoktora = txtZapazanjeDoktora.Text;
                noviPregled.AktivanPregled = cbAktivan.Checked;
                if (_raspored.Raspored.ListaPregleda.Count() < 4)
                {
                    _raspored.Raspored.ListaPregleda.Add(noviPregled);
                    baza.SaveChanges();
                    MessageBox.Show($"Examination added!");
                    DialogResult=DialogResult.OK;
                }else
                    MessageBox.Show($"Doctor already has 4 examinations on that day!");
            }
        }









        /// <summary>
        /// Validates the input of the user
        /// </summary>
        private bool ValidanUnos() => Validator.ValidirajPolje(txtOpisStanja, err, Validator.Warning) && Validator.ValidirajPolje(txtZapazanjeDoktora, err, Validator.Warning);
    }
}
