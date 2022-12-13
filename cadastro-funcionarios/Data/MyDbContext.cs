using cadastro_funcionarios.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace cadastro_funcionarios.Data
{
    public class MyDbContext : DbContext
    {

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) { 
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Employee>()
           .HasOne(b => b.Address)
           .WithOne(i => i.Employee)
           .HasForeignKey<Address>(b => b.EmployeeForeignKey);
        }


        public DbSet<cadastro_funcionarios.Models.Employee> Employee { get; set; }

        public DbSet<cadastro_funcionarios.Models.Address> Address { get; set; } 

        public DbSet<cadastro_funcionarios.Models.User> User { get; set; }

    }
}
