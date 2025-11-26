using System.ComponentModel.DataAnnotations;

namespace PrecisionToolingEF.Models
{
    public class Customer
    {
        public int Id
        {
            get; set;
        }

        [Display(Name = "Company Name")]
        [Required(ErrorMessage = "You cannot leave the Company name blank.")]
        [StringLength(100)]
        public string Name
        {
            get; set;
        } = "";



        [Required(ErrorMessage = "You cannot leave the Address1 blank.")]
        public string Address1
        {
            get; set;
        } = "";

        public string? Address2
        {
            get; set;
        }


        [Required(ErrorMessage = "You cannot leave the City blank.")]
        public string City
        {
            get; set;
        } = "";


        [Required(ErrorMessage = "You cannot leave the State blank.")]
        public string State
        {
            get; set;
        } = "";

        [Display(Name = "Zip Code")]
        public string? ZipCode { get; set; }

        [StringLength(350)]
        public string? Notes {get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^[2-9]\d{2}[2-9]\d{6}$", ErrorMessage = "Enter a valid 10-digit phone number.")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        public string? Phone { get; set; }

        [StringLength(255)]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        
        [RegularExpression(@"^[2-9]\d{2}[2-9]\d{6}$", ErrorMessage = "Enter a valid 10-digit fax number.")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(10)]
        public string? FaxNumber { get; set; }


        public string? Contact { get; set; }

    }
}
