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
        }

        public frmPatientDetails(Pacijent pacijent) : this()
        {
            _pacijent = pacijent;
        }


        private void frmPatientDetails_Load(object sender, EventArgs e)
        {
            LoadData(_pacijent);
            LoadDiagnosis(_pacijent);
        }

        private void LoadData(Pacijent pacijent)
        {
            txtIme.Text = pacijent.Ime;
            txtPrezime.Text = pacijent.Prezime;
            cmbSpol.SelectedItem = pacijent.KrvnaGrupa;
            cmbSpol.SelectedItem = pacijent.Spol;
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
    }
}
