using Hospital_System_Demo.Data;
using Hospital_System_Demo.Doctors_Nurses;
using Hospital_System_Demo.Helpers;
using Hospital_System_Demo.Patients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System_Demo.ChildForms
{
    public partial class frmPatients : Form
    {
        private HealthCareContext baza = HealthCareDB.Base;
        private Doktor _loggedDoctor;
        private MedicinskaSestra _loggedNurse;
        private Pacijent selected;
        private bool DoktorMode = false;
        public frmPatients()
        {
            InitializeComponent();
            _loggedNurse = new MedicinskaSestra();
            _loggedDoctor = new Doktor();
            dgvPacijenti.AutoGenerateColumns = false;
        }
        public frmPatients(Doktor doktor):this()
        {
            _loggedDoctor = doktor;
            DoktorMode = true;
        }
        public frmPatients(MedicinskaSestra sestra):this()
        {
            _loggedNurse = sestra;
        }
        private void frmPatients_Load(object sender, EventArgs e)
        {
            if (DoktorMode)
                UcitajPodatkeODoktoru(_loggedDoctor);
            LoadPatients();
        }







        /// <summary>
        /// Loads the data about currently logged doctor and all patient in database 
        /// </summary>
        private void LoadPatients(List<Pacijent> listaPacijenata = null)
        {
            dgvPacijenti.DataSource = null;
            dgvPacijenti.DataSource = listaPacijenata ?? baza.Pacijenti.ToList();
        }
        private void UcitajPodatkeODoktoru(Doktor loggedDoctor)
        {
            try
            {
                lblTrenutniDoktor.Text = loggedDoctor.ToString();
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }









        /// <summary>
        /// Selects the patient by clicking on the datagridview row
        /// </summary>
        private void dgvPacijenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = dgvPacijenti.SelectedRows[0].DataBoundItem as Pacijent;
        }











        /// <summary>
        /// Shows all patient details in the new form, so the doctor can have a clear view
        /// </summary>
        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (selected != null)
                new frmPatientDetails(selected).ShowDialog();
            else
                MboxHelper.PrikaziObavjestenje("You must first click on any patient from the list!");
        }   











        /// <summary>
        /// Adds new patient with the data entered in the frmAddPatient form
        /// </summary>
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            frmAddPatient noviPacijent = new frmAddPatient(_loggedDoctor);
            if (noviPacijent.ShowDialog() == DialogResult.OK)
                LoadPatients();
        }







        /// <summary>
        /// Releases the selected patient from the hospital, and deletes its record
        /// </summary>
        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("By clicking OK, You are releasing this patient from the hospital.","Release of patient",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var selectedPatient = dgvPacijenti.SelectedRows[0].DataBoundItem as Pacijent;
                baza.Pacijenti.Remove(selectedPatient);
                baza.SaveChanges();
                LoadPatients();
            }
        }

      

        /// <summary>
        /// Finds all patients whose name or surname contains filter
        /// </summary>
        private void txtPretraga_TextChanged(object sender, EventArgs e)
        {
            var filter = txtPretraga.Text.ToLower();
            if (filter == "")
            {
                LoadPatients();
                return;
            }
            else
            {
                var rezultat = baza.Pacijenti.Where(pacijent => pacijent.Ime.ToLower().Contains(filter) || pacijent.Prezime.ToLower().Contains(filter)).ToList();
                LoadPatients(rezultat);
            }
        }
    }
}
