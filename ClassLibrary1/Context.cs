using System;
using System.Data.Entity;

namespace DataLayer
{
    public class BalansContext : DbContext
    {
        public BalansContext() : base("Boekhouden")
        {
            //Database.SetInitializer<SchoolDBContext>(new CreateDatabaseIfNotExists<SchoolDBContext>());

             Database.SetInitializer<BalansContext>(new DropCreateDatabaseIfModelChanges<BalansContext>());
            //Database.SetInitializer<SchoolDBContext>(new DropCreateDatabaseAlways<SchoolDBContext>());
            //Database.SetInitializer<SchoolDBContext>(new SchoolDBInitializer());
        }

        public DbSet<VasteActiva> VasteActiva { get; set; }
        public DbSet<VlottendeActiva> VlottendeActiva { get; set; }

        public DbSet<EigenVermogen> EigenVermogen { get; set; }
        public DbSet<KortVreemdVermogen> KortVreemdVermogen { get; set; }
        public DbSet<LangVreemdVermogen> LangVreemdVermogen { get; set; }

    }
}
