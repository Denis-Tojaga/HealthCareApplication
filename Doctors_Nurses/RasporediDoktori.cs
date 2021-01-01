using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Demo.Doctors_Nurses
{
    [Table("RasporediDoktori")]
    public class RasporediDoktori
    {
        public int Id { get; set; }
        public string DatumRasporeda { get; set; }
        public virtual Raspored Raspored { get; set; }
        public virtual Doktor Doktor { get; set; }
    }
}
