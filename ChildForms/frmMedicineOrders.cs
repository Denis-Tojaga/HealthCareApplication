﻿using Hospital_System_Demo.Doctors_Nurses;
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
    public partial class frmMedicineOrders : Form
    {
        private Doktor _doktor;
        public frmMedicineOrders()
        {
            InitializeComponent();
        }
        public frmMedicineOrders(Doktor doktor):this()
        {
            _doktor = doktor;
        }



    }
}
