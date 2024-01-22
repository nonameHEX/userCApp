using CSVImporter.Models;
using CSVImporter.Services;
using System.Windows;
using System.Windows.Controls;

namespace CSVImporter
{
    public partial class ContactInputElement : UserControl
    {
        public ContactInputElement()
        {
            InitializeComponent();
        }

        private void AddContact_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var dbService = new DatabaseService();
                var contact = dbService.ParseUserInput(inName.Text, inSurname.Text, inPrivateIdNum.Text, inAddress.Text, inPhone1.Text, inPhone2.Text);
                dbService.ImportContacts(contact);
                MessageBox.Show("Kontakt úspěšně přidán.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Chyba");
            }
        }
    }
}
