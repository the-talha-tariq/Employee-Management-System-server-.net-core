using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class Salary
    {
        [Key]
        public int SalaryId { get; set; }

        public decimal Amount { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
