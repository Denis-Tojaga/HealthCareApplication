using Hospital_System_Demo.Doctors_Nurses;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Demo.Patients
{
    [Table("Pregled")]
    public class Pregled
    {
        public int Id { get; set; }
        public virtual Pacijent Pacijent { get; set; }
        public virtual Dijagnoza Dijagnoza { get; set; }
        public virtual Raspored Raspored { get; set; }
        public string DatumPregleda { get; set; }
        public string OpisStanja { get; set; }
        public bool AktivanPregled { get; set; }
        public string ZakljucakDoktora { get; set; }

    }
}
