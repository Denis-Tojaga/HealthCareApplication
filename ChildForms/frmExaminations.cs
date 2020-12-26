using Hospital_System_Demo.Doctors_Nurses;
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
    }
}
