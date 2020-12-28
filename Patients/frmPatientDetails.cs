using Hospital_System_Demo.Data;
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
    public partial class frmPatientDetails : Form
    {
        private HealthCareContext baza = HealthCareDB.Base;
        private Pacijent _pacijent;
        public frmPatientDetails()
        {
            InitializeComponent();
            _pacijent = new Pacijent();
            dgvDijagnozePacijenta.AutoGenerateColumns = false;
            LoadGenders();
            LoadBloodType();
        }

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

        public frmPatientDetails(Pacijent pacijent) : this()
        {
            _pacijent = pacijent;
        }


        private void frmPatientDetails_Load(object sender, EventArgs e)
        {
            LockControls();
            LoadData(_pacijent);
            LoadDiagnosis(_pacijent);
        }

        private void LockControls()
        {
            txtIme.Enabled = false;
            txtPrezime.Enabled = false;
            txtJMBG.Enabled = false;
            txtEmail.Enabled = false;
            btnAddHC.Enabled = false;
            btnEditDetails.Text = "Edit details";
        }

        private void LoadData(Pacijent pacijent)
        {
            txtIme.Text = pacijent.Ime;
            txtPrezime.Text = pacijent.Prezime;
            cmbKrvnaGrupa.SelectedItem = pacijent.KrvnaGrupa;
            cmbKrvnaGrupa.SelectedItem = pacijent.Spol;
            var indeksZadnje = pacijent.ListaDijagnoza.Count();
            txtDatumEvidencije.Text = pacijent.ListaDijagnoza[indeksZadnje - 1].DatumOdredjivanja;
            if (pacijent.ZdravstveniKartonSlika != null)
                pbHealthCard.Image = ImageHelper.FromByteToImage(pacijent.ZdravstveniKartonSlika);
            else
                pbHealthCard.Image = null;
            txtSifraPacijenta.Text = pacijent.SifraPacijenta;
        }

        private void LoadDiagnosis(Pacijent pacijent)
        {
            dgvDijagnozePacijenta.DataSource = null;
            dgvDijagnozePacijenta.DataSource = pacijent.ListaDijagnoza;
        }

        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            if (btnEditDetails.Text == "Save")
                LockControls();
            else
                UnlockControls();
        }

        private void UnlockControls()
        {
            txtIme.Enabled = true;
            txtPrezime.Enabled = true;
            txtJMBG.Enabled = true;
            txtEmail.Enabled = true;
            btnAddHC.Enabled = true;
            txtDatumEvidencije.Enabled = true;
            btnEditDetails.Text = "Save";
        }
    }
}
