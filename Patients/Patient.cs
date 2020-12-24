using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Demo.Patients
{
    public class Pacijent
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string JMBG { get; set; }
        public virtual KrvnaGrupa KrvnaGrupa { get; set; }
        public virtual Spol Spol { get; set; }
        public string SifraPacijenta { get; set; }
        public byte[] ZdravstveniKartonSlika { get; set; }

    }
}
