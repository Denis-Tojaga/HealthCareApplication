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





        /// <summary>
        /// Loads default data when creating a new user 
        /// </summary>
        private void UcitajDefaultPodatke()
        {
            UcitajDijagnoze();
            UcitajKrvneGrupe();
            UcitajSpolove();
            GenerisiSifruPacijenta();
            txtTrenutniDatum.Text = DateTime.Now.ToShortDateString();
            lblAddedDoctor.Text = _doktor.ToString();
        }







        /// <summary>
        /// Generates an email and radnom patient code 
        /// </summary>
        private void GenerisiSifruPacijenta()
        {
            Random random = new Random();
            string moguciZnakovi = @"1q2w3e4r5t6z7u8i9o0pasvgdfjkxlmn#k/";
            string code = "";
            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                    code += "-";
                else
                    code += moguciZnakovi[random.Next(0, moguciZnakovi.Length)];
            }
            txtSifraPacijenta.Text = code;
        }
        private void GenerisiMail()
        {
            txtEmail.Text = txtIme.Text + "." + txtPrezime.Text + "@healthCare.com";
        }






        /// <summary>
        /// Loads gender,blood type,diagnosis in comboboxex
        /// </summary>
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






        /// <summary>
        /// Generates a new default email with users credentials
        /// </summary>
        private void txtIme_TextChanged(object sender, EventArgs e)
        {
            GenerisiMail();
        }
        private void txtPrezime_TextChanged(object sender, EventArgs e)
        {
            GenerisiMail();
        }







        /// <summary>
        /// Adding a new healthCard from user's files
        /// </summary>
        private void pbHealthCard_Click(object sender, EventArgs e)
        {
            if (ofdAddHealthCard.ShowDialog() == DialogResult.OK)
            {
                pbHealthCard.Image = Image.FromFile(ofdAddHealthCard.FileName);
                lblAddingHC.Hide();
            }
        }







        /// <summary>
        /// Makes new patient with all entered data 
        /// </summary>
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            if(ValidirajPolja())
            {
                Pacijent noviPacijent = new Pacijent();
                noviPacijent.Ime = txtIme.Text;
                noviPacijent.Prezime = txtPrezime.Text;
                noviPacijent.Email = txtEmail.Text;
                noviPacijent.JMBG = txtJMBG.Text;
                noviPacijent.SifraPacijenta = txtSifraPacijenta.Text;
                noviPacijent.DatumEvidencije = txtTrenutniDatum.Text;
                noviPacijent.DatumRodjenja = dtmDatumRodjenja.Value.ToString();
                noviPacijent.Spol = cmbSpol.SelectedItem as Spol;
                noviPacijent.KrvnaGrupa = cmbKrvnaGrupa.SelectedItem as KrvnaGrupa;
                noviPacijent.ListaDijagnoza.Add(new PacijentiDijagnoze()
                {
                    Dijagnoza = cmbDijagnoze.SelectedItem as Dijagnoza,
                    DatumOdredjivanja = txtTrenutniDatum.Text
                });
                noviPacijent.ZdravstveniKartonSlika = ImageHelper.FromImageToByte(pbHealthCard.Image);
                baza.Pacijenti.Add(noviPacijent);
                baza.SaveChanges();
                MessageBox.Show($"Patient successfully added!");
                DialogResult = DialogResult.OK;
                Close();
            }
        }


        private bool ValidirajPolja() => Validator.ValidirajPolje(txtIme, err, Validator.Warning) && Validator.ValidirajPolje(txtPrezime, err, Validator.Warning)
            && Validator.ValidirajPolje(txtJMBG, err, Validator.Warning) && Validator.ValidirajPolje(txtEmail, err, Validator.Warning)
            && Validator.ValidirajPolje(pbHealthCard, err, Validator.Warning);
    }
}
