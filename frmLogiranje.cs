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
        public frmLogiranje()
        {
            InitializeComponent();
        }

        private void frmLogiranje_Load(object sender, EventArgs e)
        {

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

        private object PretragaDoktora() => data.Doktori.Where(x => x.KorisnickoIme == txtUsername.Text && x.Lozinka == txtPassword.Text).ToList();
        private object PretragaMedSestre() => data.MedicinskeSestre.Where(x => x.KorisnickoIme == txtUsername.Text && x.Lozinka == txtPassword.Text).ToList();




        /// <summary>
        /// Opens up main form in logged user mod
        /// </summary>
        private void OpenMainForm(object User)
        {
            frmAppMain mainForm = new frmAppMain(User);
            mainForm.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (ValidirajUnos())
            {
                var pretragaDoktora = PretragaDoktora();
                var pretragaSestre = PretragaMedSestre();
                if ((pretragaDoktora as Doktor) != null)
                    OpenMainForm(pretragaDoktora);
                else if ((pretragaSestre as MedicinskaSestra) != null)
                    OpenMainForm(pretragaSestre);
                else
                    MessageBox.Show($"User not found!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidirajUnos()
        {
            return Validator.ValidirajPolje(txtUsername, err, Warning) && Validator.ValidirajPolje(txtPassword, err, Warning);
        }
    }
}
