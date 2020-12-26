using Hospital_System_Demo.Patients;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Demo.Doctors_Nurses
{
    [Table("Dijagnoza")]
    public class Dijagnoza
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public override string ToString() => Naziv;
    }
}
