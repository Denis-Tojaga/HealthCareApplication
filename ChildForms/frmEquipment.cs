using Hospital_System_Demo.Data;
using Hospital_System_Demo.Doctors_Nurses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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
        private List<Oprema> SvaOprema;
        private List<Label> LabelKolicineLista = new List<Label>();
        private List<ProgressBar> ListaBarova = new List<ProgressBar>();
        private HealthCareContext baza = HealthCareDB.Base;
        public frmEquipment()
        {
            InitializeComponent();
            AddBars();
            AddQuantity();
        }
        public frmEquipment(Doktor doktor):this()
        {
            _doktor = doktor;
        }



        /// <summary>
        /// Adds list of progres bard and labels to private lists
        /// </summary>
        private void AddQuantity()
        {
            LabelKolicineLista.Add(lblKol1);
            LabelKolicineLista.Add(lblKol2);
            LabelKolicineLista.Add(lblKol3);
            LabelKolicineLista.Add(lblKol4);
            LabelKolicineLista.Add(lblKol5);
            LabelKolicineLista.Add(lblKol6);
            LabelKolicineLista.Add(lblKol7);
            LabelKolicineLista.Add(lblKol8);
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


        private void frmEquipment_Load(object sender, EventArgs e)
        {
            LoadQuantity();
        }







        /// <summary>
        /// Loads equipment and its quantity in stock to the correct labels
        /// </summary>
        private void LoadQuantity()
        {
            try
            {
                SvaOprema = baza.PopisOpreme.ToList();
                for (int i = 0; i < SvaOprema.Count(); i++)
                {
                    ListaBarova[i].Value = int.Parse(SvaOprema[i].KolicinaNaStanju);
                    LabelKolicineLista[i].Text = ListaBarova[i].Value.ToString() + "/100";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unsuccessful load!");
                throw;
            }
        }







        /// <summary>
        /// Logic for reducing quantity number
        /// </summary>
        private void SmanjiKolicinu(int redniBrojbara)
        {
            ListaBarova[redniBrojbara].Value -= 1;
            SvaOprema[redniBrojbara].KolicinaNaStanju = ListaBarova[redniBrojbara].Value.ToString();
            LabelKolicineLista[redniBrojbara].Text = ListaBarova[redniBrojbara].Value.ToString() + "/100";
            baza.Entry(SvaOprema[redniBrojbara]).State = EntityState.Modified;
            baza.SaveChanges();
        }








        /// <summary>
        /// Logic for ordering certain product
        /// </summary>
        private void NapraviOrder(int redniBroj)
        {
            if (MessageBox.Show($"Please confirm doing this order {_doktor}","User action",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                if (ListaBarova[redniBroj].Value + 20 < 100)
                {
                    ListaBarova[redniBroj].Value += 20;
                    SvaOprema[redniBroj].KolicinaNaStanju = ListaBarova[redniBroj].Value.ToString();
                    LabelKolicineLista[redniBroj].Text = ListaBarova[redniBroj].Value.ToString() + "/100";
                    baza.Entry(SvaOprema[redniBroj]).State = EntityState.Modified;
                    baza.SaveChanges();
                }else
                    MessageBox.Show($"You already have enough in stock!");
            }
        }










        /// <summary>
        /// Lowers the quantity of the selected equipment and saves that immediately to database
        /// </summary>
        private void btnAdd1_Click(object sender, EventArgs e)
        {
            SmanjiKolicinu(0);
        }
        private void btnAdd2_Click(object sender, EventArgs e)
        {
            SmanjiKolicinu(1);
        }
        private void btnAdd3_Click(object sender, EventArgs e)
        {
            SmanjiKolicinu(2);
        }
        private void btnAdd4_Click(object sender, EventArgs e)
        {
            SmanjiKolicinu(3);
        }
        private void btnAdd5_Click(object sender, EventArgs e)
        {
            SmanjiKolicinu(4);
        }
        private void btnAdd6_Click(object sender, EventArgs e)
        {
            SmanjiKolicinu(5);
        }
        private void btnAdd7_Click(object sender, EventArgs e)
        {
            SmanjiKolicinu(6);
        }
        private void btnAdd8_Click(object sender, EventArgs e)
        {
            SmanjiKolicinu(7);
        }









        /// <summary>
        /// Call of ordering method for every button 
        /// </summary>
        private void btnO1_Click(object sender, EventArgs e)
        {
            NapraviOrder(0);
        }
        private void btnO2_Click(object sender, EventArgs e)
        {
            NapraviOrder(1);
        }
        private void btnO3_Click(object sender, EventArgs e)
        {
            NapraviOrder(2);
        }
        private void btnO4_Click(object sender, EventArgs e)
        {
            NapraviOrder(3);
        }
        private void btnO5_Click(object sender, EventArgs e)
        {
            NapraviOrder(4);
        }
        private void btnO6_Click(object sender, EventArgs e)
        {
            NapraviOrder(5);
        }
        private void btnO7_Click(object sender, EventArgs e)
        {
            NapraviOrder(6);
        }
        private void btnO8_Click(object sender, EventArgs e)
        {
            NapraviOrder(7);
        }
    }
}
