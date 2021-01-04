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

namespace Hospital_System_Demo.Patients
{
    public partial class frmNoviPregled : Form
    {
        private Doktor _doktor;
        public frmNoviPregled()
        {
            InitializeComponent();
        }

        public frmNoviPregled(Doktor doktor):this()
        {

        }


    }
}
