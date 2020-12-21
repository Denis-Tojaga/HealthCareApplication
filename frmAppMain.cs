using Hospital_System_Demo.ChildForms;
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
        Form _aktivnaForma = null;
        Button kliknutiTrenutno;
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


        /// <summary>
        /// Disables and enables button on click for the current form
        /// </summary>
        private void DisableButton()
        {
            foreach (Control prosliButton in panelMeniButtons.Controls)
                if (prosliButton.GetType() == typeof(Button))
                    prosliButton.BackColor = Color.FromArgb(51, 51, 76);
        }
        private void AktivirajButton(object btnKliknuti)
        {
            if (btnKliknuti != null)
                if (kliknutiTrenutno != (Button)btnKliknuti)
                {
                    DisableButton();
                    kliknutiTrenutno = (Button)btnKliknuti;
                }
        }


        ///Method which opens up a child forms on button click
        private void OpenChildForm(Form childForma, object btnKliknuti)
        {
            _aktivnaForma?.Close();
            AktivirajButton(btnKliknuti);
            (btnKliknuti as Button).BackColor = Color.FromArgb(30, 115, 172);
            _aktivnaForma = childForma;
            childForma.TopLevel = false;
            childForma.FormBorderStyle = FormBorderStyle.None;
            childForma.Dock = DockStyle.Fill;
            panelChildForms.Controls.Add(childForma);
            panelChildForms.Tag = childForma;
            childForma.BringToFront();
            childForma.Show();
        }

        private void btnHospitalInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHospitalInfo(), sender);
        }
    }
}
