using EFCoreTutorial.Models.ModelsUsingConvention.FullyDefinedNavigationProperty;
using EFCoreTutorial.Models.ModelsUsingConvention.NoNavigationPropertyWithFK;
using EFCoreTutorial.Models.ModelsUsingConvention.SingleCollectionNavigationProperty;
using EFCoreTutorial.Models.ModelsUsingConvention.SingleCollectionNavigationPropertyWithFK;
using EFCoreTutorial.Models.ModelsUsingConvention.SingleReferenceNavigationProperty;
using EFCoreTutorial.Models.ModelsUsingConvention.SingleReferenceNavigationPropertyWithFK;
using Microsoft.EntityFrameworkCore;

namespace EFCoreTutorial
{
    public class EFCoreTutorialContext : DbContext
    {
        public DbSet<FDNP_Process_CC> FDNP_Process_CC { get; set; }
        public DbSet<FDNP_Group_CC> FDNP_Group_CC { get; set; }
        public DbSet<FDNP_Point_CC> FDNP_Point_CC { get; set; }

        public DbSet<NNPFK_Process_CC> NNPFK_Process_CC { get; set; }
        public DbSet<NNPFK_Group_CC> NNPFK_Group_CC { get; set; }
        public DbSet<NNPFK_Point_CC> NNPFK_Point_CC { get; set; }

        public DbSet<SCNP_Process_CC> SCNP_Process_CC { get; set; }
        public DbSet<SCNP_Group_CC> SCNP_Group_CC { get; set; }
        public DbSet<SCNP_Point_CC> SCNP_Point_CC { get; set; }

        public DbSet<SCNPFK_Process_CC> SCNPFK_Process_CC { get; set; }
        public DbSet<SCNPFK_Group_CC> SCNPFK_Group_CC { get; set; }
        public DbSet<SCNPFK_Point_CC> SCNPFK_Point_CC { get; set; }

        public DbSet<SRNP_Process_CC> SRNP_Process_CC { get; set; }
        public DbSet<SRNP_Group_CC> SRNP_Group_CC { get; set; }
        public DbSet<SRNP_Point_CC> SRNP_Point_CC { get; set; }

        public DbSet<SRNPFK_Process_CC> SRNPFK_Process_CC { get; set; }
        public DbSet<SRNPFK_Group_CC> SRNPFK_Group_CC { get; set; }
        public DbSet<SRNPFK_Point_CC> SRNPFK_Point_CC { get; set; }


        public EFCoreTutorialContext()
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=ABIDMAHMOOD\AMSQLSERVER;Database=EFCoreTutorialDB;Trusted_Connection=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

    }
}
