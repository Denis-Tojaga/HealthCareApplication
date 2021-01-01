using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Demo.Doctors_Nurses
{
    [Table("Doktor")]
    public class Doktor
    {
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public string Email { get; set; }
        public string SifraLicence { get; set; }
        public string KorisnickoIme { get; set; }
        public string DatumRodjenja { get; set; }
        public string DatumZaposlenja { get; set; }
        public string Lozinka { get; set; }
        public byte[] Slika { get; set; }
        public virtual Titula Titula { get; set; }
        public virtual Grad Grad { get; set; }
        public virtual List<RasporediDoktori> RasporediDoktora { get; set; } = new List<RasporediDoktori>();

        public Doktor()
        {
        }

        public override string ToString()=>Titula.ToString() + Ime + " " + Prezime;
    }
}
