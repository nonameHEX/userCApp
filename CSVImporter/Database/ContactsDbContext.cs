using System.Data.Entity;
using CSVImporter.Models;

namespace CSVImporter.Database
{
    public class ContactsDbContext : DbContext
    {
        public ContactsDbContext() : base("ContactsDbContext")
        {
        }

        public DbSet<UserContact> Contacts { get; set; }
    }
}
