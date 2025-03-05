using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementSystem.Models
{
    public class Leave
    {
        [Key]
        public int LeaveId { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
