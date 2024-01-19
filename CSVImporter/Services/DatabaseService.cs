using CSVImporter.Database;
using CSVImporter.Models;

namespace CSVImporter.Services
{
    public class DatabaseService
    {
        public void ImportContacts(List<UserContact> contacts)
        {
            using (var dbContext = new ContactsDbContext())
            {
                foreach (var contact in contacts)
                {
                    var existingContact = dbContext.Contacts.FirstOrDefault(c => c.m_privateIdNumber == contact.m_privateIdNumber);
                    if (existingContact != null)
                    {
                        existingContact.m_name = contact.m_name;
                        existingContact.m_surname = contact.m_surname;
                        existingContact.m_address = contact.m_address;
                        existingContact.m_phoneNumber1 = contact.m_phoneNumber1;
                        existingContact.m_phoneNumber2 = contact.m_phoneNumber2;
                    }
                    else
                    {
                        dbContext.Contacts.Add(contact);
                    }
                }
                dbContext.SaveChanges();
            }
        }
        public List<UserContact> GetAllContacts()
        {
            using (var dbContext = new ContactsDbContext())
            {
                return dbContext.Contacts.ToList();
            }
        }
    }
}
