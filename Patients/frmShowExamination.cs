using Hospital_System_Demo.Data;
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
    public partial class frmShowExamination : Form
    {
        private Pacijent _pacijent;
        private List<Pregled> _listaPregleda;
        private HealthCareContext baza = HealthCareDB.Base;
        public frmShowExamination()
        {
            InitializeComponent();
        }

        public frmShowExamination(string imeP,string prezimeP,int raspored) : this()
        {
            _pacijent = baza.Pacijenti.Where(pacijent => pacijent.Ime == imeP && pacijent.Prezime == prezimeP).FirstOrDefault();
            _listaPregleda = baza.Pregledi.Where(pregled => pregled.Pacijent.Ime == imeP && pregled.Pacijent.Prezime == prezimeP && pregled.Raspored.Id == raspored).ToList();
        }

        private void frmShowExamination_Load(object sender, EventArgs e)
        {
            
        }
    }
}
