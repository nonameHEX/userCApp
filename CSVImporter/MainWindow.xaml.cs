using CSVImporter.Models;
using CSVImporter.Services;
using Microsoft.Win32;
using System.Diagnostics;
using System.Text;
using System.Windows;


namespace CSVImporter
{
    public partial class MainWindow : Window
    {
        private string csvFilePath = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Browse_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.csv)|*.csv";
            if (openFileDialog.ShowDialog() == true) {
                csvFilePath = openFileDialog.FileName;
                csvFilePathText.Content = csvFilePath;
            }
        }

        private void Import_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(csvFilePath))
            {
                try
                {
                    var csvReader = new CsvParserService(csvFilePath);
                    var contacts = csvReader.ReadContacts();
                    var dbService = new DatabaseService();
                    dbService.ImportContacts(contacts);
                    MessageBox.Show("Data úspěšně importována");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Chyba při čtení souboru: {ex.Message}");
                    Debug.WriteLine(ex.InnerException?.Message);
                }
            }
            else
            {
                MessageBox.Show("Vyberte prosím CSV soubor.");
            }
        }

        private void ShowData_Click(object sender, RoutedEventArgs e)
        {
            var dbService = new DatabaseService();
            if (dbService != null)
            {
                var allContacts = dbService.GetAllContacts();
                if (allContacts != null)
                {
                    DisplayContacts(allContacts);
                }else
                {
                    MessageBox.Show("Nejsou žádná data v DB");
                }
            }
        }

        private void DisplayContacts(List<UserContact> contacts)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"ID: Jméno Přijmení, RČ, Adresa, Telefon 1");

            foreach (var contact in contacts)
            {
                stringBuilder.AppendLine($"{contact.ContactId}: {contact.m_name} {contact.m_surname}, " +
                    $"{contact.m_privateIdNumber}, {contact.m_address}, {contact.m_phoneNumber1}");
            }

            csvDataText.Text = stringBuilder.ToString();
        }

        private void AddContact_Click(object sender, RoutedEventArgs e)
        {
            //TODO Add contact to DB and maybe to csv file
        }
    }
}