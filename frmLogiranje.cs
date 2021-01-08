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
                e.SuppressKeyPress = true;
                var pretragaDoktora = PretragaDoktora() as Doktor;
                var pretragaSestre = PretragaMedSestre() as MedicinskaSestra;
                if (pretragaDoktora != null)
                {
                    OpenMainForm(pretragaDoktora);
                    //doesn't produce beep sound after main form opens up
                    e.SuppressKeyPress = true;
                }
                else if(pretragaSestre !=null)
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
        private object PretragaDoktora() => data.Doktori.Where(x => x.KorisnickoIme == txtUsername.Text && x.Lozinka == txtPassword.Text).FirstOrDefault();
        private object PretragaMedSestre() => data.MedicinskeSestre.Where(x => x.KorisnickoIme == txtUsername.Text && x.Lozinka == txtPassword.Text).FirstOrDefault();









        /// <summary>
        /// Searches for doctor or nurse with those credentials in database, if it finds them opens up a new app form
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                var pretragaDoktora = PretragaDoktora() as Doktor;
                var pretragaSestre = PretragaMedSestre() as MedicinskaSestra;
                if ((pretragaDoktora as Doktor)!=null)
                {
                    OpenMainForm(pretragaDoktora);
                    this.Close();
                }
                else if (pretragaSestre!= null)
                {
                    OpenMainForm(pretragaSestre);
                    this.Close();
                }
                else
                    MessageBox.Show($"User not found!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        /// <summary>
        /// Opens up main form in logged user mod
        /// </summary>
        private void OpenMainForm(Doktor User)
        {
            frmAppMain mainForm = new frmAppMain(User);
            mainForm.ShowDialog();
        }


        private void OpenMainForm(MedicinskaSestra User)
        {
            frmAppMain mainForm = new frmAppMain(User);
            mainForm.ShowDialog();
        }


        //Validates the user inputs if something is missing or isn't valid
        private bool ValidirajUnos() => Validator.ValidirajPolje(txtUsername, err, Warning) && Validator.ValidirajPolje(txtPassword, err, Warning);














        /// <summary>
        /// Panel part of code
        /// </summary>






        //Enables the sign in button, otherwise user can't sign in
        private void cbTermsAndConditions_CheckedChanged(object sender, EventArgs e)
        {
            if(cbTermsAndConditions.Checked)
                btnSign.Enabled = true;
            else
                btnSign.Enabled = false;
        }
        //makes form bigger and shows up panel for signing in
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Size = novaVelicina;
        }




        /// <summary>
        /// Tells the user if the passwords are matching, comparing the everytime he enters something new 
        /// </summary>
        private void txtLozinka_TextChanged(object sender, EventArgs e)
        {
            txtPotvrdaLozinke.Enabled = true;
            lblMatchingMessage.Show();
            char passcode = new char();
            if (txtLozinka.PasswordChar == passcode)
                txtLozinka.PasswordChar = '*';
        }
        private void txtPotvrdaLozinke_TextChanged(object sender, EventArgs e)
        {
            char passcode = new char();
            if (txtPotvrdaLozinke.PasswordChar == passcode)
                txtPotvrdaLozinke.PasswordChar = '*';
            if (txtLozinka.Text == txtPotvrdaLozinke.Text && !PrazanTekst(txtLozinka,txtPotvrdaLozinke))
            {
                lblMatchingMessage.Text = "Passwords are matching!";
                lblMatchingMessage.ForeColor = Color.FromArgb(4,145,7);
            }
            else
            {
                lblMatchingMessage.Text = "Passwords aren't matching!";
                lblMatchingMessage.ForeColor = Color.Moccasin;
            }
        }
        private bool PrazanTekst(TextBox txtLozinka, TextBox txtPotvrdaLozinke)=> txtLozinka.Text == "" && txtPotvrdaLozinke.Text == "";







        /// <summary>
        /// Mouse click all text in textbox clears and user is ready to write, if its password textbox it sets the password char to "*"
        /// </summary>
        private void txtIme_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtIme.Text == "First Name")
                txtIme.Text = "";
        }
        private void txtPrezime_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPrezime.Text == "Last Name")
                txtPrezime.Text = "";
        }
        private void txtEmail_MouseClick(object sender, MouseEventArgs e)
        {
            if(txtEmail.Text=="Email")
                txtEmail.Text = "";
        }
        private void txtLozinka_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtLozinka.Text == "Password")
                txtLozinka.Text = "";
        }
        private void txtPotvrdaLozinke_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtPotvrdaLozinke.Text == "Re-Enter Password")
                txtPotvrdaLozinke.Text = "";
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
            ResetForm();
        }



        //Resets the form to the start type
        private void ResetForm()
        {
            panel1.Visible = false;
            Size = pocetnaVelicina;
            txtUsername.Text = "Username";
            txtPassword.Text = "Password";
            txtPassword.PasswordChar = new char();
        }





        /// <summary>
        /// Validates all input fields and makes a new Doctor or a Nurse in database with that data, if user selected doctor or nurse the app makes one and 
        ///adds it to database
        /// Resets the form to the beginning format
        /// </summary>
        private void btnSign_Click(object sender, EventArgs e)
        {
            if (ValidirajPolja())
            {
                if (cbDoctorChecked.Checked)
                {
                    var doctorUser = new Doktor();
                    doctorUser.Ime = txtIme.Text;
                    doctorUser.Prezime = txtPrezime.Text;
                    doctorUser.DatumZaposlenja = DateTime.Now.ToShortDateString();
                    doctorUser.KorisnickoIme = txtIme.Text.ToLower();
                    doctorUser.Lozinka = txtLozinka.Text;
                    doctorUser.Email = txtEmail.Text;
                    var grad = data.Gradovi.Find(1);
                    var titula = data.Titule.Find(1);
                    doctorUser.Grad = grad;
                    doctorUser.Titula = titula;
                    data.Doktori.Add(doctorUser);
                    data.SaveChanges();
                    MessageBox.Show($"Your signing successfully done!","Sign up result",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ResetForm();
                }
                else
                {
                    var nurseUser = new MedicinskaSestra();
                    nurseUser.Ime = txtIme.Text;
                    nurseUser.Prezime = txtPrezime.Text;
                    nurseUser.DatumZaposlenja = DateTime.Now.ToShortDateString();
                    nurseUser.KorisnickoIme = txtIme.Text.ToLower();
                    nurseUser.Lozinka = txtLozinka.Text;
                    nurseUser.Email = txtEmail.Text;
                    data.MedicinskeSestre.Add(nurseUser);
                    data.SaveChanges();
                    MessageBox.Show($"Your signing in successfully done!", "Sign up result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                }
            }else
                MessageBox.Show($"Please check your input fields!");
        }
        
        
        
        
        
        
        //Validates all input fields
        //Checks if passwords are the same
        private bool ValidirajPolja()
        {
            return lblMatchingMessage.Text == "Passwords are matching!" && Validator.ValidirajPolje(txtIme, err2, Warning)
                && Validator.ValidirajPolje(txtPrezime, err2, Warning) && Validator.ValidirajPolje(txtEmail, err2, Warning)
                && Validator.ValidirajPolje(txtLozinka, err2, Warning) && Validator.ValidirajPolje(txtPotvrdaLozinke, err2, Warning)
                && (cbDoctorChecked.Checked || cbNurseChecked.Checked);
        }
    }
}
