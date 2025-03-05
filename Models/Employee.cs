using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public virtual Salary Salary { get; set; }

        public virtual ICollection<Leave> Leaves { get; set; }
        public virtual ICollection<PerformanceReview> PerformanceReviews { get; set; }
    }
}
