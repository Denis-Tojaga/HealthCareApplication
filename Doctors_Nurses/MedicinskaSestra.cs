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
        public string KorisnickoIme { get; set; }
        public string Lozinka { get; set; }
        public string Email { get; set; }
        public byte[] Slika { get; set; }
        public string DatumRodjenja { get; set; }
        public string DatumZaposlenja { get; set; }
        public virtual Grad Grad { get; set; }
        public MedicinskaSestra()
        {
           
        }

        public override string ToString() => Ime + " " + Prezime;
    }
}
