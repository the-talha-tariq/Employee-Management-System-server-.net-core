using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Services
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department>> GetDepartmentsAsync();
        Task<Department> AddDepartmentAsync(Department department);
    }
}
