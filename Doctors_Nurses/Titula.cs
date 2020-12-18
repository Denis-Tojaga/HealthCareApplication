using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Demo.Doctors_Nurses
{
    [Table("Titula")]
    public class Titula
    {
        public int ID { get; set; }
        public string TipTitule { get; set; }
        public override string ToString()
        {
            return TipTitule;
        }
    }
}
