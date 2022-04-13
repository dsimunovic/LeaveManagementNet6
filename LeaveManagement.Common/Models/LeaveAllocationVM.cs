using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.Common.Models
{
    public class LeaveAllocationVM
    {
        [Required]
        public int Id { get; set; }
        [Display(Name="Number of days")]
        [Required]
        [Range(1,50, ErrorMessage = "Number must be between 1 and 50")]
        public int NumberOfDays { get; set; }
        [Display(Name = "Allocation period")]
        [Required]
        public int Period { get; set; }
        public LeaveTypeVM? LeaveType { get; set; }

    }
}