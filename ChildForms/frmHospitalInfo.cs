using Hospital_System_Demo.Data;
using Hospital_System_Demo.Doctors_Nurses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_System_Demo.ChildForms
{
    public partial class frmHospitalInfo : Form
    {
        private const string Link = "https://www.google.com/maps/@43.3249463,17.8197502,16.12z?hl=hr";
        private HealthCareContext baza = HealthCareDB.Base;
        private Doktor _loggedDoctor;
        private MedicinskaSestra _loggedNurse;
        public frmHospitalInfo()
        {
            InitializeComponent();
            _loggedDoctor = new Doktor();
            _loggedNurse = new MedicinskaSestra();
        }
        public frmHospitalInfo(Doktor doktor): this()
        {
            _loggedDoctor = doktor;
        }
        public frmHospitalInfo(MedicinskaSestra sestra) : this()
        {
            _loggedNurse = sestra;
        }



        private void frmHospitalInfo_Load(object sender, EventArgs e)
        {
            lblLink.Hide();
            Navigate(Link);
            UcitajPodatkeOPanelima();
        }

      

        private void UcitajPodatkeOPanelima()
        {
            lblDoctorNumber.Text = baza.Doktori.Count().ToString();
            lblNurseNumber.Text = baza.MedicinskeSestre.Count().ToString();
            lblPatientNumber.Text = baza.Pacijenti.Count().ToString();
        }





        // Navigates to the given URL if it is valid, if its not in valid format it corrects it
        private void Navigate(string address)
        {
            if (string.IsNullOrEmpty(address)) return;
            if (address.Equals("about:blank")) return;
            if (!address.StartsWith("http://") &&
                !address.StartsWith("https://"))
            {
                address = "http://" + address;
            }
            try
            {
                wbMaps.Navigate(new Uri(address));
            }
            catch (System.UriFormatException ex)
            {
                MessageBox.Show($"{ex.Message} {ex.InnerException?.Message}");
            }
        }





        // Updates the URL in TextBoxAddress upon navigation.
        private void wbMaps_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            lblLink.Text = wbMaps.Url.ToString();
        }







        // Opens the URL in the browser 
        // the Navigate button is clicked.
        private void btnNavigate_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo(lblLink.Text);
            Process.Start(sInfo);
        }







        /// <summary>
        /// Changes the color of button on mouseHover and mouseLeave
        /// </summary>
        private void btnNavigate_MouseHover(object sender, EventArgs e)
        {
            btnNavigate.BackColor = Color.FromArgb(245, 83, 20);
            btnNavigate.ForeColor = Color.FromArgb(5, 25, 30);
        }
        private void btnNavigate_MouseLeave(object sender, EventArgs e)
        {
            btnNavigate.BackColor = Color.FromArgb(5,25,30);
            btnNavigate.ForeColor = Color.FromArgb(245, 83, 20);
        }
    }
}
