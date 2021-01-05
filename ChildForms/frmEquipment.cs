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

namespace Hospital_System_Demo.ChildForms
{
    public partial class frmEquipment : Form
    {
        private Doktor _doktor;
        private List<ProgressBar> ListaBarova = new List<ProgressBar>();
        private HealthCareContext baza = HealthCareDB.Base;
        public frmEquipment()
        {
            InitializeComponent();
            AddBars();
        }

        private void AddBars()
        {
            ListaBarova.Add(pb1);
            ListaBarova.Add(pb2);
            ListaBarova.Add(pb3);
            ListaBarova.Add(pb4);
            ListaBarova.Add(pb5);
            ListaBarova.Add(pb6);
            ListaBarova.Add(pb7);
            ListaBarova.Add(pb8);
        }

        public frmEquipment(Doktor doktor):this()
        {
            _doktor = doktor;
        }

        private void frmEquipment_Load(object sender, EventArgs e)
        {
            LoadQuantity();
        }

        private void LoadQuantity()
        {
            try
            {
                var svaOprema = baza.PopisOpreme.ToList();
                for (int i = 0; i < svaOprema.Count(); i++)
                    ListaBarova[i].Value = int.Parse(svaOprema[i].KolicinaNaStanju);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unsuccessful load!");
                throw;
            }
        }
    }
}
