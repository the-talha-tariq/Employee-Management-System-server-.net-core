using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class PerformanceReview
    {
        [Key]
        public int ReviewId { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        public int Rating { get; set; }
        public string Feedback { get; set; }
    }
}
