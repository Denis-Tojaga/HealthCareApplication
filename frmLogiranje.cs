using Hospital_System_Demo.Data;
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
    public partial class frmLogiranje : Form
    {
        private const string Warning = "This field is required!";
        HealthCareContext data = HealthCareDB.Base;
        private Size pocetnaVelicina = new Size(372, 542);
        private Size novaVelicina = new Size(718, 542);
        public frmLogiranje()
        {
            InitializeComponent();
        }
        private void frmLogiranje_Load(object sender, EventArgs e)
        {
            HidePanelChildControls();
            txtPotvrdaLozinke.Enabled = false;
            btnSign.Enabled = false;
            panel1.Visible=false;
            Size = pocetnaVelicina;
            lblMatchingMessage.Hide();
        }




        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }










        /// <summary>
        /// Placeholder logic at both textboxes and key down method
        /// </summary>
        private void txtUsername_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (txtUsername.Text == "Username")
                txtUsername.Text = "";
        }
        private void txtPassword_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (txtPassword.Text == "Password")
                txtPassword.Text = "";
        }
        private void txtPassword_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var pretragaDoktora = PretragaDoktora();
                var pretragaSestre = PretragaMedSestre();
                if ((pretragaDoktora as Doktor) != null)
                {
                    OpenMainForm(pretragaDoktora);
                    //doesn't produce beep sound after main form opens up
                    e.SuppressKeyPress = true;
                }
                else if((pretragaSestre as MedicinskaSestra)!=null)
                {
                    OpenMainForm(pretragaSestre);
                    e.SuppressKeyPress = true;
                }else
                    MessageBox.Show($"User not found!","Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void txtPassword_TextChanged_1(object sender, EventArgs e)
        {
            char passcode = new char();
            if (txtPassword.PasswordChar == passcode)
                txtPassword.PasswordChar = '*';
        }












        /// <summary>
        /// Search implemented by user credentials
        /// </summary>
        private object PretragaDoktora() => data.Doktori.Where(x => x.KorisnickoIme == txtUsername.Text && x.Lozinka == txtPassword.Text).ToList();
        private object PretragaMedSestre() => data.MedicinskeSestre.Where(x => x.KorisnickoIme == txtUsername.Text && x.Lozinka == txtPassword.Text).ToList();









        /// <summary>
        /// Searches for doctor or nurse with those credentials in database, if it finds them opens up a new app form
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                var pretragaDoktora = PretragaDoktora();
                var pretragaSestre = PretragaMedSestre();
                if (pretragaDoktora != null)
                    OpenMainForm(pretragaDoktora);
                else if (pretragaSestre != null)
                    OpenMainForm(pretragaSestre);
                else
                    MessageBox.Show($"User not found!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }







        /// <summary>
        /// Opens up main form in logged user mod
        /// </summary>
        private void OpenMainForm(object User)
        {
            frmAppMain mainForm = new frmAppMain(User);
            mainForm.ShowDialog();
        }







        //Validates the user inputs if something is missing or isn't valid
        private bool ValidirajUnos() => Validator.ValidirajPolje(txtUsername, err, Warning) && Validator.ValidirajPolje(txtPassword, err, Warning);

        private void cbTermsAndConditions_CheckedChanged(object sender, EventArgs e)
        {
            if(cbTermsAndConditions.Checked)
                btnSign.Enabled = true;
            else
                btnSign.Enabled = false;
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Size = novaVelicina;
        }
        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {
            txtPotvrdaLozinke.Enabled = true;
            lblMatchingMessage.Show();
        }
        private void txtPotvrdaLozinke_TextChanged(object sender, EventArgs e)
        {
            if(txtLozinka.Text == txtPotvrdaLozinke.Text)
            {
                lblMatchingMessage.Text = "Passwords are matching!";
                lblMatchingMessage.ForeColor = Color.FromArgb(4,145,7);
            }
        }









        /// <summary>
        /// Hides panel and all its controls
        /// </summary>
        private void HidePanelChildControls()
        {
            txtPotvrdaLozinke.Enabled = false;
            btnSign.Enabled = false;
            panel1.Hide();
            lblMatchingMessage.Hide();
        }

        private void btnColapse_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            Size = pocetnaVelicina;
        }
    }
}
