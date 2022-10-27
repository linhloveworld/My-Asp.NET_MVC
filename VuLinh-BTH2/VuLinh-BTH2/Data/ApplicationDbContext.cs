using Microsoft.EntityFrameworkCore;
using VuLinh_BTH2.Models;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace VuLinh_BTH2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public static implicit operator ApplicationDbContext(ApplicationBuilder v)
        {
            throw new NotImplementedException();
        }
    }
}
