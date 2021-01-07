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

namespace Hospital_System_Demo.ChildForms
{
    public partial class frmUserInfo : Form
    {
        private Doktor _doktor;
        private MedicinskaSestra _nurse;
        private HealthCareContext baza = HealthCareDB.Base;
        public frmUserInfo()
        {
            InitializeComponent();
            UcitajGradove();
        }

        private void UcitajGradove()
        {
            try
            {
                cmbGrad.DataSource = baza.Gradovi.ToList();
                cmbGrad.DisplayMember = "Naziv";
                cmbGrad.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        public frmUserInfo(object objekat) :this()
        {
            if (objekat is Doktor)
                _doktor = objekat as Doktor;
            else
                _nurse = objekat as MedicinskaSestra;
        }

        

        private void frmUserInfo_Load(object sender, EventArgs e)
        {
            if (_doktor != null)
                LoadUser(_doktor);
        }

        private void LoadUser(Doktor doktor)
        {
            tIme.Text = doktor.Ime;
            txtPrezime.Text = doktor.Prezime;
            txtDatumRodjenja.Text = doktor.DatumRodjenja;
            txtEmail.Text = doktor.Email;
            txtJMBG.Text = doktor.JMBG;
            txtKorisnickoIme.Text = doktor.KorisnickoIme;
            txtPassword.Text = doktor.Lozinka;
            cmbGrad.SelectedItem = doktor.Grad;
            txtTitula.Text = doktor.Titula.ToString();
        }

        
    }
}
