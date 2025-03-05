using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Services
{
    public interface ILeaveService
    {
        Task<IEnumerable<Leave>> GetLeavesAsync();
        Task<Leave> ApplyLeaveAsync(Leave leave);
    }
}
