using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSVImporter.Model
{
    public class UserContact
    {
        private string m_name {  get; set; }
        private string m_surname { get; set; }
        private int m_privateIdNumber { get; set; }
        private string m_adress { get; set; }
        private List<int> m_phoneNumber { get; set; }

        public UserContact(string name, string surname, int privateIdNumber, string adress, List<int> phoneNumber)
        {
            m_name = name;
            m_surname = surname;
            m_privateIdNumber = privateIdNumber;
            m_adress = adress;
            m_phoneNumber = phoneNumber;
        }
    }
}
