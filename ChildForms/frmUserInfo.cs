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
    public partial class frmUserInfo : Form
    {
        private Doktor _doktor;
        private MedicinskaSestra _nurse;
        public frmUserInfo()
        {
            InitializeComponent();
        }
        public frmUserInfo(object objekat) :this()
        {
            if (objekat is Doktor)
                _doktor = objekat as Doktor;
            else
                _nurse = objekat as MedicinskaSestra;
        }

        

        private void frmUserInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
