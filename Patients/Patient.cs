﻿using Hospital_System_Demo.Doctors_Nurses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Demo.Patients
{
    public class Pacijent
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string DatumRodjenja { get; set; }
        public string DatumEvidencije { get; set; }
        public string JMBG { get; set; }
        public virtual KrvnaGrupa KrvnaGrupa { get; set; }
        public virtual Spol Spol { get; set; }
        public virtual List<PacijentiDijagnoze> ListaDijagnoza { get; set; } = new List<PacijentiDijagnoze>();
        public string SifraPacijenta { get; set; }
        public byte[] ZdravstveniKartonSlika { get; set; }
        public string ImePrezime { get { return Ime + " " + Prezime; } }

        public override string ToString() => ImePrezime;
    }
}
