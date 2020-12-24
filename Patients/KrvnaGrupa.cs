using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Demo.Patients
{
    public class KrvnaGrupa
    {
        public int Id { get; set; }
        public string Tip { get; set; }
        public string Oznaka { get; set; }
        public override string ToString() => Oznaka;
    }
}
