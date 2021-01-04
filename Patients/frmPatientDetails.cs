using Hospital_System_Demo.Data;
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

namespace Hospital_System_Demo.Patients
{
    public partial class frmPatientDetails : Form
    {
        private HealthCareContext baza = HealthCareDB.Base;
        private Pacijent _pacijent;
        private const string Warning = "This field is required";
        public frmPatientDetails()
        {
            InitializeComponent();
            _pacijent = new Pacijent();
            dgvDijagnozePacijenta.AutoGenerateColumns = false;
            LoadGenders();
            LoadBloodType();
        }
        public frmPatientDetails(Pacijent pacijent) : this()
        {
            _pacijent = pacijent;
        }
        private void frmPatientDetails_Load(object sender, EventArgs e)
        {
            btnCancel.Hide();
            lblCancel.Hide();
            LockControls();
            LoadData(_pacijent);
            LoadDiagnosis(_pacijent.ListaDijagnoza);
        }









        /// <summary>
        /// Loads all data from database to comboboxes
        /// </summary>
        private void LoadBloodType()
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
        private void LoadGenders()
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











        /// <summary>
        /// Locks and unlock all controls whether the doctor wants to edit and save something
        /// </summary>
        private void LockControls()
        {
            txtIme.Enabled = false;
            txtPrezime.Enabled = false;
            txtJMBG.Enabled = false;
            txtEmail.Enabled = false;
            txtDatumEvidencije.Enabled = false;
            cmbKrvnaGrupa.Enabled = false;
            cmbSpol.Enabled = false;
            btnEditDetails.Text = "Edit details";
        }
        private void UnlockControls()
        {
            txtIme.Enabled = true;
            txtPrezime.Enabled = true;
            txtJMBG.Enabled = true;
            txtEmail.Enabled = true;
            txtDatumEvidencije.Enabled = true;
            cmbSpol.Enabled = true;
            cmbKrvnaGrupa.Enabled = true;
            btnEditDetails.Text = "Save";
        }








        /// <summary>
        /// Loads data about patient and his diagnosis history
        /// </summary>
        private void LoadData(Pacijent pacijent)
        {
            txtIme.Text = pacijent.Ime;
            txtPrezime.Text = pacijent.Prezime;
            cmbKrvnaGrupa.SelectedItem = pacijent.KrvnaGrupa;
            cmbSpol.SelectedItem = pacijent.Spol;
            txtEmail.Text = pacijent.Email ?? "";
            txtJMBG.Text = pacijent.JMBG ?? "";
            var indeksZadnje = pacijent.ListaDijagnoza.Count();
            txtDatumEvidencije.Text = pacijent.ListaDijagnoza[indeksZadnje - 1].DatumOdredjivanja;
            if (pacijent.ZdravstveniKartonSlika != null)
                pbHealthCard.Image = ImageHelper.FromByteToImage(pacijent.ZdravstveniKartonSlika);
            else
                pbHealthCard.Image = null;
            txtSifraPacijenta.Text = pacijent.SifraPacijenta;
        }
        private void LoadDiagnosis(List<PacijentiDijagnoze> list)
        {
            dgvDijagnozePacijenta.DataSource = null;
            dgvDijagnozePacijenta.DataSource = list ?? _pacijent.ListaDijagnoza;
        }








        /// <summary>
        /// Enables edit mode and saves the data with current inputs 
        /// </summary>
        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            if (btnEditDetails.Text == "Save")
            {
                if (SaveData())
                {
                    LockControls();
                    lblCancel.Hide();
                    btnCancel.Hide();
                }
            }
            else
            {
                UnlockControls();
                lblCancel.Show();
                btnCancel.Show();
            }
        }
        private bool SaveData()
        {
            if (ValidanUnos())
            {
                _pacijent.Ime = txtIme.Text;
                _pacijent.Prezime = txtPrezime.Text;
                _pacijent.DatumEvidencije = txtDatumEvidencije.Text;
                _pacijent.Email = txtEmail.Text;
                _pacijent.JMBG = txtJMBG.Text;
                _pacijent.Spol = cmbSpol.SelectedItem as Spol;
                _pacijent.KrvnaGrupa = cmbKrvnaGrupa.SelectedItem as KrvnaGrupa;
                _pacijent.SifraPacijenta = txtSifraPacijenta.Text;
                _pacijent.ZdravstveniKartonSlika = ImageHelper.FromImageToByte(pbHealthCard.Image);

                baza.Entry(_pacijent).State = EntityState.Modified;
                baza.SaveChanges();
                MboxHelper.PrikaziObavjestenje("Edit successfull!");
                return true;
            }
            else
                return false;
        }








        /// <summary>
        /// Validates all field if saving data, so user can't leave something empty
        /// </summary>
        private bool ValidanUnos()
        {
            return Validator.ValidirajPolje(txtIme, err, Warning) && Validator.ValidirajPolje(txtPrezime, err, Warning)
                && Validator.ValidirajPolje(txtJMBG, err, Warning) && Validator.ValidirajPolje(txtEmail, err, Warning)
                && Validator.ValidirajPolje(txtDatumEvidencije, err, Warning) &&
                Validator.ValidirajPolje(cmbSpol, err, Warning) && Validator.ValidirajPolje(cmbKrvnaGrupa, err, Warning)
                && Validator.ValidirajPolje(pbHealthCard, err, Warning);
        }








        /// <summary>
        /// Cancels editing mode and loads default data about patient
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnEditDetails.Text == "Save")
            {
                btnEditDetails.Text = "Edit details";
                LoadData(_pacijent);
                LockControls();
                btnCancel.Hide();
                lblCancel.Hide();
            }
        }
    }
}
