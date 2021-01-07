using Hospital_System_Demo.ChildForms;
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

namespace Hospital_System_Demo
{
    public partial class frmAppMain : Form
    {
        Doktor _doctor;
        MedicinskaSestra _nurse;
        bool doctorMode = false;
        Form _aktivnaForma = null;
        Button kliknutiTrenutno;
        public frmAppMain()
        {
            InitializeComponent();
            _nurse = new MedicinskaSestra();
            _doctor = new Doktor();
        }
        private void frmAppMain_Load(object sender, EventArgs e)
        {
        }



        /// <summary>
        /// Constructors for logged user, either doctor or nurse 
        /// </summary>
        public frmAppMain(Doktor User) : this()
        {
            _doctor = User;
            doctorMode = true;
        }
        public frmAppMain(MedicinskaSestra User) : this()
        {
            _nurse = User;
        }



        /// <summary>
        /// Disables and enables button on click for the current form
        /// </summary>
        private void AktivirajButton(object btnKliknuti)
        {
            if (btnKliknuti != null && kliknutiTrenutno != (Button)btnKliknuti)
            {
                if (kliknutiTrenutno != null)
                {
                    kliknutiTrenutno.Enabled = true;
                    kliknutiTrenutno.ForeColor = Color.White;
                }

                kliknutiTrenutno = (Button)btnKliknuti;
                kliknutiTrenutno.Enabled = false;
                kliknutiTrenutno.ForeColor = Color.Silver;
            }
        }






        ///Method which opens up a child forms on button click
        private void OpenChildForm(Form childForma, object btnKliknuti)
        {
            _aktivnaForma?.Close();
            AktivirajButton(btnKliknuti);
            
            _aktivnaForma = childForma;
            childForma.TopLevel = false;
            childForma.FormBorderStyle = FormBorderStyle.None;
            childForma.Dock = DockStyle.Fill;
            panelChildForms.Controls.Add(childForma);
            panelChildForms.Tag = childForma;
            childForma.BringToFront();
            childForma.Show();
        }




        /// <summary>
        /// Closes the current form
        /// </summary>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }







        /// <summary>
        /// Determines if the logged user is doctor or nurse, depending on that it opens up a new form with collection of their data
        /// </summary>
        private void btnHospitalInfo_Click(object sender, EventArgs e)
        {
            if(doctorMode)
                OpenChildForm(new frmHospitalInfo(_doctor), sender);
            else
                OpenChildForm(new frmHospitalInfo(_nurse), sender);
        }
        private void btnPatients_Click(object sender, EventArgs e)
        {
            if (doctorMode)
                OpenChildForm(new frmPatients(_doctor), sender);
            else                 
                OpenChildForm(new frmPatients(_nurse), sender);
        }
        private void btnExaminations_Click(object sender, EventArgs e)
        {
            if (doctorMode)
                OpenChildForm(new frmSchedule(_doctor), sender);
            else
                OpenChildForm(new frmSchedule(_nurse), sender);
        }
        private void btnMedicineOrders_Click(object sender, EventArgs e)
        {
            if (doctorMode)
                OpenChildForm(new frmEquipment(_doctor),sender);
            else
                MboxHelper.PrikaziObavjestenje($"You have to be in doctor mode to view this!");

        }
        private void btnUserInfo_Click(object sender, EventArgs e)
        {
            object objekat;
            if (_doctor != null)
                objekat = _doctor;
            else
                objekat = _nurse;
            OpenChildForm(new frmUserInfo(objekat),sender);
        }
    }
}
