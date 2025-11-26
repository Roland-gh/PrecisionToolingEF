using System.ComponentModel.DataAnnotations;

namespace PrecisionToolingEF.Models
{
    public class Job
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Jobs must have a job number.")]
        public int JobNumber { get; set; }

        public string PurchaseOrder { get; set; } = string.Empty;

        public Customer Customer { get; set; } = new();

        public string? Description { get; set; }

        [Required(ErrorMessage = "Job must have a start date.")]
        [Display(Name = "Start Date")]
        public DateOnly StartDate { get; set; }

        [Display(Name = "Finish Date")]
        public DateOnly? FinishDate { get; set; }

        [StringLength(300)]
        public string? Notes { get; set; }

        
        [Display(Name = "Material Cost")]
        [DataType(DataType.Currency)]
        public decimal? MaterialCost { get; set; }

        [Display(Name = "Labor Cost")]
        [DataType(DataType.Currency)]
        public decimal? LaborCost { get; set; }
    }
}
