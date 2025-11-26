using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PrecisionToolingEF.Models
{
    public class Employee
    {

        // This will act as employee number
        public int Id { get; set; }

        [Required(ErrorMessage = "Employee First Name is mandatory.")]
        [DisplayName("First Name")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Employee First Name is mandatory.")]
        [DisplayName("Last Name")]
        public string? LastName { get; set; }

        [DisplayName("Middle Name")]
        public string? MiddleName { get; set; }

        public string? Address1 { get; set; }

        public string? Address2 { get; set; }

        public string? City { get; set; }

        public string? State { get;set; }

        public string? PostalCode { get; set; }

        public string? SSN { get; set; }

        public decimal? Rate { get; set; }

        public string? Notes { get; set; }


    }
}
