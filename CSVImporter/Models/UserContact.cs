using System.ComponentModel.DataAnnotations;

namespace CSVImporter.Models
{
    public class UserContact
    {
        [Key]
        public int ContactId { get; set; }

        [MaxLength(20)]
        public string m_name {  get; set; }

        [MaxLength(20)]
        public string m_surname { get; set; }

        [MaxLength(10)]
        [MinLength(10)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Pouze čísla jsou povolena.")]
        public string m_privateIdNumber { get; set; }

        [MaxLength(50)]
        public string m_address { get; set; }

        [MaxLength(9)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Pouze čísla jsou povolena.")]
        public string m_phoneNumber1 { get; set; }

        [MaxLength(9)]
        [RegularExpression("^[0-9]+$", ErrorMessage = "Pouze čísla jsou povolena.")]
        public string m_phoneNumber2 { get; set; }
    }
}
