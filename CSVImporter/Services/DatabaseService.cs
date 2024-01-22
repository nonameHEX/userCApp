using CSVImporter.Database;
using CSVImporter.Models;
using System.Text.RegularExpressions;

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

        public List<UserContact> ParseUserInput(string name, string surname, string privateIdNumber, string address, string phoneNumber1, string phoneNumber2)
        {
            if (string.IsNullOrEmpty(name) || !name.All(char.IsLetter))
                throw new ArgumentException("Chybně zadané jméno.");

            if (string.IsNullOrEmpty(surname) || !surname.All(char.IsLetter))
                throw new ArgumentException("Chybně zadané přijmení.");

            if (string.IsNullOrEmpty(privateIdNumber) || privateIdNumber.Length != 10 || !Regex.IsMatch(privateIdNumber, "^[0-9]+$"))
                throw new ArgumentException("Chybně zadané RČ.");

            if (string.IsNullOrEmpty(address))
                throw new ArgumentException("Chybně zadaná adresa.");

            if (string.IsNullOrEmpty(phoneNumber1) || phoneNumber1.Length != 9 || !Regex.IsMatch(phoneNumber1, "^[0-9]+$"))
                throw new ArgumentException("Chybně zadaný Telefon 1.");

            if (string.IsNullOrEmpty(phoneNumber2) || phoneNumber2.Length != 9 || !Regex.IsMatch(phoneNumber2, "^[0-9]+$"))
                throw new ArgumentException("Chybně zadaný Telefon 2.");

            UserContact newContact = new UserContact
            {
                m_name = name,
                m_surname = surname,
                m_privateIdNumber = privateIdNumber,
                m_address = address,
                m_phoneNumber1 = phoneNumber1,
                m_phoneNumber2 = phoneNumber2
            };
            return new List<UserContact> { newContact };
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
