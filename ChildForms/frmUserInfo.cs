using Hospital_System_Demo.Data;
using Hospital_System_Demo.Doctors_Nurses;
using Hospital_System_Demo.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
            LockTextBoxove();
            if (_doktor != null)
            {
                txtEmail.Enabled = false;
                txtDatumRodjenja.Enabled = false;
                txtTitula.Enabled = false;
                btnCancel.Hide();
                lblCancel.Hide();
                LoadUser(_doktor);
                LockControls();
            }
        }
        //Loads user with all its data
        private void LoadUser(Doktor doktor)
        {
            tIme.Text = doktor.Ime;
            txtPrezime.Text = doktor.Prezime;
            txtEmail.Text = doktor.Email;
            if(doktor.JMBG!=null)
                txtJMBG.Text = doktor.JMBG;
            if(doktor.DatumRodjenja!=null)
                 txtDatumRodjenja.Text = doktor.DatumRodjenja;
            txtKorisnickoIme.Text = doktor.KorisnickoIme;
            txtPassword.Text = doktor.Lozinka;
            cmbGrad.SelectedItem = doktor.Grad;
            txtTitula.Text = doktor.Titula.ToString();
            if (doktor.Slika != null)
            {
                if (doktor.Slika.Length != 0)
                {
                    lblUcitajSliku.Hide();
                    pbProfilna.Image = ImageHelper.FromByteToImage(doktor.Slika);
                }
            }
            else
            {
                pbProfilna.Image = null;
                lblUcitajSliku.Show();
            }
        }





        /// <summary>
        /// Locks all textboxes and controls
        /// </summary>
        private void LockTextBoxove()
        {
            lblUcitajSliku.Enabled = false;
            txtIme.Enabled = false;
            textBox3.Enabled = false;
            textBox5.Enabled = false;
            textBox9.Enabled = false;
            textBox10.Enabled = false;
            textBox11.Enabled = false;
            textBox13.Enabled = false;
            textBox15.Enabled = false;
            textBox16.Enabled = false;
        }
        private void LockControls()
        {
            tIme.Enabled = false;
            lblUcitajSliku.Enabled = false;
            pbProfilna.Enabled = false;
            txtPrezime.Enabled = false;
            txtJMBG.Enabled = false;
            txtKorisnickoIme.Enabled = false;
            txtPassword.Enabled = false;
            cmbGrad.Enabled = false;
            txtDatumRodjenja.Enabled = false;
        }




        /// <summary>
        /// Unlocks all controls that need to be filled
        /// </summary>
        private void UnlockControls()
        {
            tIme.Enabled = true;
            lblUcitajSliku.Enabled = true;
            pbProfilna.Enabled = true;
            txtPrezime.Enabled = true;
            txtJMBG.Enabled = true;
            txtKorisnickoIme.Enabled = true;
            txtPassword.Enabled = true;
            cmbGrad.Enabled = true;
            if (txtDatumRodjenja.Text == "")
            {
                txtDatumRodjenja.ReadOnly = false;
                txtDatumRodjenja.Enabled = true;
            }
        }



        /// <summary>
        /// Allows user to add its profile picture
        /// </summary>
        private void pbProfilna_Click(object sender, EventArgs e)
        {
            if (ofdUcitaj.ShowDialog() == DialogResult.OK)
            {
                lblUcitajSliku.Hide();
                pbProfilna.Image = Image.FromFile(ofdUcitaj.FileName);
            }
        }



        /// <summary>
        /// Edit mode and canceling, also saving changes if not in edit mode
        /// </summary>
        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            if (btnEditDetails.Text == "Edit info")
            {
                UnlockControls();
                btnEditDetails.Text = "Save changes";
                btnCancel.Show();
                lblCancel.Show();
            }
            else
            {
                LockControls();
                SpasiIzmjene();
                btnCancel.Hide();
                lblCancel.Hide();
                btnEditDetails.Text = "Edit info";
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblCancel.Hide();
            btnCancel.Hide();
            btnEditDetails.Text = "Edit info";
            LoadUser(_doktor);
            LockControls();
        }
        private void SpasiIzmjene()
        {
            _doktor.Ime = tIme.Text;
            _doktor.Prezime = txtPrezime.Text;
            _doktor.KorisnickoIme = txtKorisnickoIme.Text;
            _doktor.Lozinka = txtPassword.Text;
            _doktor.Grad = cmbGrad.SelectedItem as Grad;
            _doktor.JMBG = txtJMBG.Text;
            _doktor.DatumRodjenja = txtDatumRodjenja.Text;
            if(pbProfilna.Image!=null)
               _doktor.Slika = ImageHelper.FromImageToByte(pbProfilna.Image);

            baza.Entry(_doktor).State = EntityState.Modified;
            baza.SaveChanges();
            MboxHelper.PrikaziObavjestenje("User info is up to date!");
        }
    }
}
