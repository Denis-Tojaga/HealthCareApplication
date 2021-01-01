﻿using Hospital_System_Demo.Data;
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

        private void LoadPatients(List<Pacijent> listaPacijenata = null)
        {
            dgvPacijenti.DataSource = null;
            dgvPacijenti.DataSource = listaPacijenata ?? baza.Pacijenti.ToList();
        }

        private void UcitajPodatkeODoktoru(Doktor loggedDoctor)
        {
            try
            {
                lblTrenutniDoktor.Text = loggedDoctor.Titula.TipTitule + loggedDoctor.Ime + " " + loggedDoctor.Prezime;
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private void btnViewDetails_Click(object sender, EventArgs e)
        {
            if (selected != null)
                new frmPatientDetails(selected).ShowDialog();
            else
                MboxHelper.PrikaziObavjestenje("You must first click on any patient from the list!");
        }   

        private void dgvPacijenti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = dgvPacijenti.SelectedRows[0].DataBoundItem as Pacijent;
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            frmAddPatient noviPacijent = new frmAddPatient(_loggedDoctor);
            if (noviPacijent.ShowDialog() == DialogResult.OK)
                LoadPatients();
        }

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
    }
}
