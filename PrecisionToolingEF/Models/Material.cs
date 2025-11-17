using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PrecisionToolingEF.Models
{
    public class Material
    {
        public int Id { get; set; }

        
        [Display(Name = "Material Name")]
        [Required(ErrorMessage = "You must supply a material name.")]
        public string Name { get; set; } = "";

        [Required(ErrorMessage = "You must supply a material description.")]
        [StringLength(150)]
        public string Description { get; set; } = "";

        [Required(ErrorMessage = "You must supply a quantity.")]
        public double Quantity { get; set; }

        [Required(ErrorMessage = "You must supply a material price")]
        public decimal Price { get; set; }

        public string Vendor { get; set; } = "";

        public int JobId { get; set; }

    }
}
