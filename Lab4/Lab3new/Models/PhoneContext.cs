using System.Data.Entity;


namespace Lab3new.Models
{
    public class PhoneContext: DbContext
    {
        public PhoneContext() : base("DBConnection") { }
        public DbSet<Telephone> Telephone { get; set; }
    }
}