using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Services
{
    public interface ISalaryService
    {
        Task<IEnumerable<Salary>> GetSalariesAsync();
        Task<Salary> AddSalaryAsync(Salary salary);
    }
}
