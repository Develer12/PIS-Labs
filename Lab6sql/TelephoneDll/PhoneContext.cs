using System.Data.Entity;


namespace TelephoneDll
{
    public class PhoneContext : DbContext
    {
        public PhoneContext() : base("DBConnection") { }
        public DbSet<Telephone> Telephone { get; set; }
    }
}