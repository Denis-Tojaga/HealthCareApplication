using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Demo.Doctors_Nurses
{
    [Table("MedicinskaSestra")]
    public class MedicinskaSestra
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string ImePrezime { get; set; }
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public byte[] Slika { get; set; }

        public MedicinskaSestra()
        {
            ImePrezime = Ime + " " + Prezime;
        }

        public override string ToString() => ImePrezime;
    }
}
