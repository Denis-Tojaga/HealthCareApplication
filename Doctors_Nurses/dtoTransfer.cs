﻿using Hospital_System_Demo.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Demo.Doctors_Nurses
{
    public class dtoTransfer
    {
        public string ImePrezime { get; set; }
        public int BrojPacijenata { get; set; }
        public int BrojOsobljaNaSmjeni { get; set; }
        public List<Pregled> ListaPregledaZaDanas { get; set; } = new List<Pregled>();
    }
}
