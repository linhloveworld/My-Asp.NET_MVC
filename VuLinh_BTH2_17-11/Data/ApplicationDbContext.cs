using System;
using System.Data.Entity;
using VuLinh_BTH2.Data;
using VuLinh_BTH2_17_11.Models;
using VuLinh_BTH2_3_11.Models;

namespace VuLinh_BTH2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOption<ApplicationDbContext> option) : base(option)
        {
            
        }
        public DbSet<Students> Students { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Faculty> Faculty { get; set; } = default;

        internal void Update(Students std)
        {
            throw new NotImplementedException();
        }
        internal void Add(Students std)
        {
            throw new NotImplementedException();
        }
    }
    public class DbContextOption<T>
    {

    }
}

