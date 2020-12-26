using Hospital_System_Demo.Patients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Demo
{
    public class Raspored
    {
        public int Id { get; set; }
        public string Datum { get; set; }
        public virtual List<Pregled> ListaPregleda { get; set; }
    }
}
