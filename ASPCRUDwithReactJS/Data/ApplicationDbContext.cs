using ASPCRUDwithReactJS.Model;
using Microsoft.EntityFrameworkCore;

namespace ASPCRUDwithReactJS.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "Sunil",
                    Age = 50,
                    IsActive = true
                },
                new Employee
                {
                    Id = 2,
                    Name = "Amal",
                    Age = 55,
                    IsActive = false
                },
                new Employee
                {
                    Id = 3,
                    Name = "Kamal",
                    Age = 65,
                    IsActive = true
                }
            );
        }
    }
}
