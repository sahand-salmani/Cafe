using Domain.Models;
using Domain.Users;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Database
{
    public class DatabaseContext : 
        IdentityDbContext<ApplicationUser,ApplicationRole, string, IdentityUserClaim<string>, ApplicationUserRole, IdentityUserLogin<string>, IdentityRoleClaim<string>, IdentityUserToken<string>>
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ContractProduct> ContractProducts { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeePayment> EmployeePayments { get; set; }
        public DbSet<Intern> Interns { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Spend> Spends { get; set; }
        public DbSet<Stant> Stants { get; set; }
        public DbSet<Fail> Fails { get; set; }
        public DbSet<PrePayment> PrePayments { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ContractProduct>().HasKey(e => new { e.ContractId, e.ProductId });
            builder.Entity<ContractProduct>().HasOne(e => e.Contract).WithMany(e => e.ContractProducts)
                .HasForeignKey(e => e.ContractId);
            builder.Entity<ContractProduct>().HasOne(e => e.Product).WithMany(e => e.Contracts)
                .HasForeignKey(e => e.ProductId);

            builder.Entity<Restaurant>().HasIndex(e => e.Name).IsUnique();
            builder.Entity<Position>().HasIndex(e => e.Name).IsUnique();

            builder.AddSeedUser();
        }
    }
}
