using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace SoftwareCompany.Models
{
    public class Contact_Us
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        [Display(Name = "DOB")]
        public DateTime DOB { get; set; }
    }
}
