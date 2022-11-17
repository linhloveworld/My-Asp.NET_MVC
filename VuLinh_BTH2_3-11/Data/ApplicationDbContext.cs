namespace VuLinh_BTH2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOption<ApplicationDbContext> option) : base(option)
        { 
        public DbSet<Student> Students { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Customer> Customer { get; set; }
        }
    }

    public static implicit operator ApplicationDbContext(ApplicationDbContext v)
    {
        throw new NotImplementedException();
    }
}

