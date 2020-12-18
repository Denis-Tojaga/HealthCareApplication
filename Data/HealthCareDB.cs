using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Demo.Data
{
    public class HealthCareDB
    {
        public static HealthCareContext Base { get; set; } = new HealthCareContext();
    }
}
