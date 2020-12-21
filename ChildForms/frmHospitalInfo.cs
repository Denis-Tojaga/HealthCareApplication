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
    public partial class frmHospitalInfo : Form
    {
        private const string Link = "https://www.google.com/maps/@43.3249463,17.8197502,16.12z?hl=hr";
        public frmHospitalInfo()
        {
            InitializeComponent();
        }


        // Navigates to the URL in the address box when 
        // the Go button is clicked.
        private void cmsOpenInMaps_Click(object sender, EventArgs e)
        {
            Navigate(Link);
        }

        private void frmHospitalInfo_Load(object sender, EventArgs e)
        {

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

    }
}
