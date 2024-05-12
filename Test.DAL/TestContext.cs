using Microsoft.EntityFrameworkCore;
using Test.DAL.Entities;

namespace Test.DAL
{
    public class TestContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Invasion> Invasions { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }

        public TestContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Database=TestInvasionDB;Trusted_Connection=True;Trust Server Certificate=True;");
        }
    }
}