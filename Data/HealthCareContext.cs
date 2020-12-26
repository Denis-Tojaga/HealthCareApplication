using Hospital_System_Demo.Doctors_Nurses;
using Hospital_System_Demo.Patients;
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
        public DbSet<Spol> Spolovi { get; set; }
        public DbSet<Titula> Titule { get; set; }
        public DbSet<KrvnaGrupa> KrvneGrupe { get; set; }
        public DbSet<Doktor> Doktori { get; set; }
        public DbSet<MedicinskaSestra> MedicinskeSestre { get; set; }
        public DbSet<Pacijent> Pacijenti { get; set; }
        public DbSet<Pregled> Pregledi { get; set; }
        public DbSet<Dijagnoza> Dijagnoze { get; set; }
        public DbSet<Raspored> Rasporedi { get; set; }
        public DbSet<PacijentiDijagnoze> PacijentiDijagnoze { get; set; }

        public HealthCareContext() : base("PutanjaDoBaze")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
