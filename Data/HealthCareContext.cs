using Hospital_System_Demo.Doctors_Nurses;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System_Demo
{
    public class HealthCareContext : DbContext
    {
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<Doktor> Doktori { get; set; }
        public DbSet<Titula> Titule { get; set; }
        public DbSet<MedicinskaSestra> MedicinskeSestre { get; set; }

        public HealthCareContext() : base("DatabasePath")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
