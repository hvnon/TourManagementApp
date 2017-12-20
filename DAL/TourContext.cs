using DAL.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace DAL
{
    public class TourContext : DbContext
    {
        public TourContext() : base("TourManagement")
        {
            //Database.SetInitializer(new BookInitializer());
            this.Configuration.LazyLoadingEnabled = false;
        }


        public DbSet<TourType> TourTypes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Tour> Tours { get; set; }
        public DbSet<TourPriceHistory> TourPriceHistories { get; set; }
        public DbSet<TourLocation> TourLocations { get; set; }
        public DbSet<FeeType> FeeTypes { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupFee> GroupFees { get; set; }
        public DbSet<CustomerGroup> CustomerGroups { get; set; }
        public DbSet<Role> Roles { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<OneToOneConstraintIntroductionConvention>();
        }
    }
}
