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

namespace Hospital_System_Demo
{
    public partial class frmAppMain : Form
    {
        Doktor _doctor;
        MedicinskaSestra _nurse;
        public frmAppMain()
        {
            InitializeComponent();
            _nurse = new MedicinskaSestra();
            _doctor = new Doktor();
        }

        public frmAppMain(object User) : this()
        {
            if (User is Doktor)
                _doctor = User as Doktor;
            else
                _nurse = User as MedicinskaSestra;
        }

        private void frmAppMain_Load(object sender, EventArgs e)
        {
            //this is something
        }
    }
}
