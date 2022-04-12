using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Web.Models
{
    public class LeaveRequestCreateVM: IValidatableObject
    {
        [Display(Name="Start date")]
        [Required]
        public DateTime? StartDate { get; set; }

        [Display(Name = "End date")]
        [Required]
        public DateTime? EndDate { get; set; }

        public SelectList? LeaveTypes { get; set; }
        [Display(Name = "Leave type")]

        [Required]
        public int LeaveTypeId { get; set; }
        [Display(Name = "Request comments")]

        public string? RequestComments { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (StartDate > EndDate)
            {
                yield return new ValidationResult("The start date must be before end date", new[] { nameof(StartDate), nameof(EndDate) });
            }

            if (RequestComments?.Length > 500)
            {
                yield return new ValidationResult("The comment is too long", new[] { nameof(RequestComments)});
            }
        }
    }
}
