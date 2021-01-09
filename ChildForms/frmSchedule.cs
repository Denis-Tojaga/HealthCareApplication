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
    public partial class frmSchedule : Form
    {
        private List<Label> ListaBoxovaExamination = new List<Label>();
        private Doktor _loggedDoctor;
        private MedicinskaSestra _loggedNurse;
        private HealthCareContext baza = HealthCareDB.Base;
        private List<Pregled> ListaPregledaDanas;
        public frmSchedule()
        {
            InitializeComponent();
            DodajBoxoveUListu();
            FormatDate(DateTime.Now.ToShortDateString());
        }
        public frmSchedule(Doktor doktor) :this()
        {
            _loggedDoctor = doktor;
        }
        public frmSchedule(MedicinskaSestra sestra) : this()
        {
            _loggedNurse = sestra;
        }








        /// <summary>
        /// Adding labels to a list and load of all examination for current date 
        /// </summary>
        private void DodajBoxoveUListu()
        {
            ListaBoxovaExamination.Add(lblPregled1);
            ListaBoxovaExamination.Add(lblPregled2);
            ListaBoxovaExamination.Add(lblPregled3);
            ListaBoxovaExamination.Add(lblPregled4);
        }
        private void frmExaminations_Load(object sender, EventArgs e)
        {
            try
            {
                button1.Enabled = false;
                LoadSchedules(lblTrenutniDatum.Text);
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }











        /// <summary>
        /// Formatting current date to valid string and then calculating spaces for the valid set of date
        /// </summary>
        private void FormatDate(string datumUFormatu)
        {
            string praviDatum = "";
            for (int i = 0; i < datumUFormatu.Length; i++)
                if (datumUFormatu[i] != ' ')
                    praviDatum += datumUFormatu[i];
            lblTrenutniDatum.Text = praviDatum;
        }









        /// <summary>
        /// Calculating date format to an integers and loading schedule on the same date, previous and next button
        /// </summary>
        private void btnPreviousDate_Click(object sender, EventArgs e)
        {
            //Four possible casses
            //22.12.2000.
            //4.-4.-2012.
            //-4.12.2000.
            //12.-4.2000.


            string dan = "";
            string mjesec = "";
            string godina = "";

            if (lblTrenutniDatum.Text[1] == '.' && lblTrenutniDatum.Text[3]=='.')
            {
                dan += lblTrenutniDatum.Text[0];
                mjesec += lblTrenutniDatum.Text[2];
                for (int i = 4; i < 8; i++)
                    godina += lblTrenutniDatum.Text[i];
            }
            else if(lblTrenutniDatum.Text[1] == '.' && lblTrenutniDatum.Text[3] != '.')
            {
                dan += lblTrenutniDatum.Text[0];
                for (int i = 2; i < 4; i++)
                    mjesec += lblTrenutniDatum.Text[i];
                for (int i = 5; i < 9; i++)
                    godina += lblTrenutniDatum.Text[i];
            }
            else if(lblTrenutniDatum.Text[1] != '.' && lblTrenutniDatum.Text[4] == '.')
            {
                for (int i = 0; i < 2; i++)
                    dan += lblTrenutniDatum.Text[i];
                mjesec += lblTrenutniDatum.Text[3];
                for (int i = 5; i < 9; i++)
                    godina += lblTrenutniDatum.Text[i];
            }
            else if(lblTrenutniDatum.Text[1] != '.' && lblTrenutniDatum.Text[3] != '.')
            {
                for (int i = 0; i < 2; i++)
                    dan += lblTrenutniDatum.Text[i];
                for (int i = 3; i < 5; i++)
                    mjesec += lblTrenutniDatum.Text[i];
                for (int i = 6; i < 10; i++)
                    godina += lblTrenutniDatum.Text[i];
            }
           
            int trenutniDan = int.Parse(dan);
            int trenutniMjesec = int.Parse(mjesec);
            int trenutnaGodina = int.Parse(godina);


            trenutniDan--;
            if(trenutniDan == 0)
                if(trenutniMjesec==1 || trenutniMjesec==5 || trenutniMjesec==7 || trenutniMjesec == 8 || trenutniMjesec == 10 || trenutniMjesec == 12)
                {
                    trenutniDan = 30;
                    trenutniMjesec--;
                    if(trenutniMjesec==0)
                    {
                        trenutniMjesec = 12;
                        trenutnaGodina--;
                    }
                }else if(trenutniMjesec == 2 || trenutniMjesec == 4 || trenutniMjesec == 6 || trenutniMjesec == 9 || trenutniMjesec == 11)
                {
                    trenutniDan = 31;
                    trenutniMjesec--;
                    if(trenutniMjesec==0)
                    {
                        trenutniMjesec = 12;
                        trenutnaGodina--;
                    }
                }else if(trenutniMjesec==3)
                    if(trenutnaGodina%4==0)
                    {
                        trenutniDan = 29;
                        trenutniMjesec--;
                        if(trenutniMjesec==0)
                        {
                            trenutniMjesec = 12;
                            trenutnaGodina--;
                        }
                    }
                    else
                    {
                        trenutniDan = 28;
                        trenutniMjesec--;
                        if (trenutniMjesec == 0)
                        {
                            trenutniMjesec = 12;
                            trenutnaGodina--;
                        }
                    }
            lblTrenutniDatum.Text = trenutniDan.ToString() + "." + trenutniMjesec.ToString() + "."  + trenutnaGodina.ToString()  + ".";
            LoadSchedules(lblTrenutniDatum.Text);
        }
        private void btnNextDate_Click(object sender, EventArgs e)
        {
            //Four possible casses
            //22.12.2000.
            //3.-1.-2021.
            //-4.12.2000.
            //12.-4.2000.

            


            string dan = "";
            string mjesec = "";
            string godina = "";

            if (lblTrenutniDatum.Text[1] == '.' && lblTrenutniDatum.Text[3] == '.')
            {
                dan += lblTrenutniDatum.Text[0];
                mjesec += lblTrenutniDatum.Text[2];
                for (int i = 4; i < 8; i++)
                    godina += lblTrenutniDatum.Text[i];
            }
            else if (lblTrenutniDatum.Text[1] == '.' && lblTrenutniDatum.Text[3] != '.')
            {
                dan += lblTrenutniDatum.Text[0];
                for (int i = 2; i < 4; i++)
                    mjesec += lblTrenutniDatum.Text[i];
                for (int i = 5; i < 9; i++)
                    godina += lblTrenutniDatum.Text[i];
            }
            else if (lblTrenutniDatum.Text[1] != '.' && lblTrenutniDatum.Text[4] == '.')
            {
                for (int i = 0; i < 2; i++)
                    dan += lblTrenutniDatum.Text[i];
                mjesec += lblTrenutniDatum.Text[3];
                for (int i = 5; i < 9; i++)
                    godina += lblTrenutniDatum.Text[i];
            }
            else if (lblTrenutniDatum.Text[1] != '.' && lblTrenutniDatum.Text[3] != '.')
            {
                for (int i = 0; i < 2; i++)
                    dan += lblTrenutniDatum.Text[i];
                for (int i = 3; i < 5; i++)
                    mjesec += lblTrenutniDatum.Text[i];
                for (int i = 6; i < 10; i++)
                    godina += lblTrenutniDatum.Text[i];
            }

            int trenutniDan = int.Parse(dan);
            int trenutniMjesec = int.Parse(mjesec);
            int trenutnaGodina = int.Parse(godina);


            trenutniDan++;
            if ((trenutniMjesec == 1 || trenutniMjesec == 3 || trenutniMjesec == 5 || trenutniMjesec == 7 || trenutniMjesec == 8 || trenutniMjesec == 10 || trenutniMjesec == 12) && trenutniDan > 31)
            {
                trenutniDan = 1;
                trenutniMjesec++;
                if (trenutniMjesec > 12)
                {
                    trenutniMjesec = 1;
                    trenutnaGodina++;
                }
            }
            else if (trenutniMjesec == 4 || trenutniMjesec == 6 || trenutniMjesec == 9 || trenutniMjesec == 11 && trenutniDan>30)
            {
                trenutniDan = 1;
                trenutniMjesec++;
                if (trenutniMjesec > 12)
                {
                    trenutniMjesec = 1;
                    trenutnaGodina++;
                }
            }
            else if (trenutniMjesec == 2 && trenutniDan>28)
                if (trenutnaGodina % 4 == 0)
                {
                    trenutniDan = 29;
                }
                else
                {
                    trenutniDan = 1;
                    trenutniMjesec++;
                    if (trenutniMjesec >12)
                    {
                        trenutniMjesec = 1;
                        trenutnaGodina++;
                    }
                }
            lblTrenutniDatum.Text = trenutniDan.ToString() + "." + trenutniMjesec.ToString() + "." + trenutnaGodina.ToString() + ".";
            LoadSchedules(lblTrenutniDatum.Text);
        }











        /// <summary>
        /// Loads all examinations to labels and valid schedule for current date  
        /// </summary>
        private void LoadSchedules(string text)
        {

            var rezultat = _loggedDoctor.RasporediDoktora.Where(raspored => raspored.DatumRasporeda == text).FirstOrDefault();
            if (rezultat!=null)
            {
                if (rezultat.Raspored.ListaPregleda.Count() != 0)
                {
                    var ListaPregledaDanas = new List<Pregled>();
                    ListaPregledaDanas = rezultat.Raspored.ListaPregleda;
                    button1.Enabled = true;
                    if (ListaPregledaDanas.Count() > 0)
                    {
                        OcistiLabels();
                        if (ListaPregledaDanas.Count() > 4)
                        {
                            for (int i = 0; i < 4; i++)
                                ListaBoxovaExamination[i].Text += " of " + ListaPregledaDanas[i].Pacijent.ToString();
                        }else
                        {
                            for (int i = 0; i < ListaPregledaDanas.Count()-1; i++)
                                ListaBoxovaExamination[i].Text += " of " + ListaPregledaDanas[i].Pacijent.ToString();
                        }
                    }
                }
            }else
                OcistiLabels();
        }
        













        /// <summary>
        /// Cleas all labels if there are no any examinations on that day
        /// </summary>
        private void OcistiLabels()
        {
            lblPregled1.Text = "Examination";
            lblPregled2.Text = "Examination";
            lblPregled3.Text = "Examination";
            lblPregled4.Text = "Examination";
        }







        /// <summary>
        /// Shows or adds an examination in case there is nobody in label
        /// </summary>
        private void ShowORAddExamination(Label kliknutaLabela)
        {
            if(kliknutaLabela.Text=="Examination")
            {
                var objekat = baza.RasporediDoktori.Where(x => x.DatumRasporeda == lblTrenutniDatum.Text && x.Doktor.ID == _loggedDoctor.ID).FirstOrDefault();
                if (objekat == null)
                {
                    var rasporedObj = new Raspored();
                    var noviRaspored = new RasporediDoktori();
                    noviRaspored.DatumRasporeda = lblTrenutniDatum.Text;
                    noviRaspored.Raspored = rasporedObj;
                    _loggedDoctor.RasporediDoktora.Add(noviRaspored);
                    baza.SaveChanges();
                    frmNoviPregled noviPregled = new frmNoviPregled(noviRaspored);
                    if (noviPregled.ShowDialog() == DialogResult.OK)
                        LoadSchedules(lblTrenutniDatum.Text);
                }
                else
                {
                    frmNoviPregled pronadjen = new frmNoviPregled(objekat);
                    if (pronadjen.ShowDialog() == DialogResult.OK)
                        LoadSchedules(lblTrenutniDatum.Text);
                }
                
            }else
            {
                string Ime = IzdvojiIme(kliknutaLabela.Text);
                string Prezime = IzdvojiPrezime(kliknutaLabela.Text);
                RasporediDoktori trenutni = _loggedDoctor.RasporediDoktora.Where(x => x.DatumRasporeda == lblTrenutniDatum.Text).FirstOrDefault();
                var pregledSend = baza.Pregledi.Where(pregled => pregled.Pacijent.Ime == Ime && pregled.Pacijent.Prezime == Prezime && pregled.Raspored.Id == trenutni.Raspored.Id).FirstOrDefault();
                frmShowExamination prikaziPregled = new frmShowExamination(pregledSend,_loggedDoctor);
                prikaziPregled.ShowDialog();
            }
        }








        /// <summary>
        /// Manipulates with text in label, takes the name and surname of the patient from the string
        /// </summary>
        private string IzdvojiPrezime(string citavNiz)
        {
            string prezime = "";
            for (int i = citavNiz.Length-1; i > 0; i--)
                if (citavNiz[i] != ' ')
                    prezime += citavNiz[i];
                else
                    return OkrenutoPrezime(prezime);
            return "";
        }
        private string OkrenutoPrezime(string prezime)
        {
            string novoPrezime = "";
            for (int i = prezime.Length-1; i >= 0; i--)
                novoPrezime += prezime[i];
            return novoPrezime;
        }
        private string IzdvojiIme(string text)
        {
            string ime="";
            for (int i = 15; i < text.Length-1; i++)
                if (text[i] != ' ')
                    ime += text[i];
                else
                    return ime;
            return "";
        }












        /// <summary>
        /// What happens when user clicks on examination label
        /// </summary>
        private void lblPregled1_Click(object sender, EventArgs e)
        {
            ShowORAddExamination(sender as Label);
        }
        private void lblPregled2_Click(object sender, EventArgs e)
        {
            ShowORAddExamination(sender as Label);
        }
        private void lblPregled3_Click(object sender, EventArgs e)
        {
            ShowORAddExamination(sender as Label);
        }
        private void lblPregled4_Click(object sender, EventArgs e)
        {
            ShowORAddExamination(sender as Label);
        }










        /// <summary>
        /// Shows a daily report for a doctor, which he is able to print out
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            var rezultat = _loggedDoctor.RasporediDoktora.Where(raspored => raspored.DatumRasporeda == lblTrenutniDatum.Text).FirstOrDefault();
            var listaPregleda = rezultat.Raspored.ListaPregleda;
            dtoTransfer transferObjekat = new dtoTransfer();
            transferObjekat.ListaPregledaZaDanas = listaPregleda;
            frmDailyReview izvjestaj = new frmDailyReview(transferObjekat);
            izvjestaj.Show();
        }
    }
}
