using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Demo
{
    [Table("Grad")]
    public class Grad
    {
        public int ID { get; set; }
        public string Naziv { get; set; }
        public override string ToString() => Naziv;
    }
}
