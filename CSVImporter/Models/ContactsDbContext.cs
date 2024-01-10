using System.Data.Entity;
using CSVImporter.Model;

namespace CSVImporter.Models
{
    public class ContactsDbContext : DbContext
    {
        public ContactsDbContext() : base("ContactsDbContext")
        {
        }

        public DbSet<UserContact> Contacts { get; set; }
    }
}
