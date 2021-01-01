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
    public partial class frmExaminations : Form
    {
        private Doktor _loggedDoctor;
        private MedicinskaSestra _loggedNurse;
        private HealthCareContext baza = HealthCareDB.Base;

        public frmExaminations()
        {
            InitializeComponent();
        }
        public frmExaminations(Doktor doktor) :this()
        {
            _loggedDoctor = doktor;
        }
        public frmExaminations(MedicinskaSestra sestra) : this()
        {
            _loggedNurse = sestra;
        }

        private void frmExaminations_Load(object sender, EventArgs e)
        {
            try
            {
                var odabraniRaspored = _loggedDoctor.RasporediDoktora.Where(raspored => raspored.DatumRasporeda == lblTrenutniDatum.Text).FirstOrDefault();
                if (odabraniRaspored.Raspored.ListaPregleda.Count() != 0)
                {
                    lblPregled1.Text +=" "+ odabraniRaspored.Raspored.ListaPregleda[0].Pacijent.ToString();
                    lblPregled2.Text += " " + odabraniRaspored.Raspored.ListaPregleda[1].Pacijent.ToString();
                    lblPregled3.Text += " " + odabraniRaspored.Raspored.ListaPregleda[2].Pacijent.ToString();
                    lblPregled4.Text += " " + odabraniRaspored.Raspored.ListaPregleda[3].Pacijent.ToString();
                }
            }
            catch (Exception ex)
            {
                MboxHelper.PrikaziGresku(ex);
            }
        }

        private void btnPreviousDate_Click(object sender, EventArgs e)
        {
            int trenutniDan = int.Parse(DateTime.Now.Day.ToString());
            int trenutniMjesec = int.Parse(DateTime.Now.Month.ToString());
            int trenutnaGodina = int.Parse(DateTime.Now.Year.ToString());

            trenutniDan--;
            if(trenutniDan == 0)
            {
                if(trenutniMjesec==1 || trenutniMjesec==3 || trenutniMjesec==5 || trenutniMjesec==7 || trenutniMjesec == 8 || trenutniMjesec == 10 || trenutniMjesec == 12)
                {
                    trenutniDan = 31;
                    trenutniMjesec--;
                    if(trenutniMjesec==0)
                    {
                        trenutniMjesec = 12;
                        trenutnaGodina--;
                    }
                }else if(trenutniMjesec == 4 || trenutniMjesec == 6 || trenutniMjesec == 9 || trenutniMjesec == 11)
                {
                    trenutniDan = 30;
                    trenutniMjesec--;
                    if(trenutniMjesec==0)
                    {
                        trenutniMjesec = 12;
                        trenutnaGodina--;
                    }
                }else if(trenutniMjesec==2)
                {
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
                }
            }



            lblTrenutniDatum.Text = trenutniDan.ToString() + "." + trenutniMjesec.ToString() + "."  + trenutnaGodina.ToString();
        }
    }
}
