using CsvHelper;
using CsvHelper.Configuration;
using CSVImporter.Models;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;

namespace CSVImporter.Services
{
    public class CsvParserService
    {
        private string m_csvFilePath;

        public CsvParserService(string filePath)
        {
            m_csvFilePath = filePath;
        }

        public List<UserContact> ReadContacts()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                Delimiter = ";",
                HasHeaderRecord = true,
            };

            using (var reader = new StreamReader(m_csvFilePath))
            using (var csv = new CsvReader(reader, config))
            {
                csv.Context.RegisterClassMap<UserContactMap>();
                return csv.GetRecords<UserContact>().ToList();
            }
        }
    }
    public class UserContactMap : ClassMap<UserContact>
    {
        public UserContactMap()
        {
            Map(m => m.m_name).Name("Jméno");
            Map(m => m.m_surname).Name("Příjmení");
            Map(m => m.m_privateIdNumber).Name("RČ");
            Map(m => m.m_address).Name("Adresa");
            Map(m => m.m_phoneNumber1).Name("Telefon 1");
            Map(m => m.m_phoneNumber2).Name("Telefon 2");
        }
    }
}
