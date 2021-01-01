using Hospital_System_Demo.Patients;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Demo
{
    [Table("Raspored")]
    public class Raspored
    {
        public int Id { get; set; }
        public virtual List<Pregled> ListaPregleda { get; set; } = new List<Pregled>();
    }
}
