using EmployeeManagementSystem.Models;

namespace EmployeeManagementSystem.Services
{
    public interface IPerformanceService
    {
        Task<IEnumerable<PerformanceReview>> GetPerformanceReviewsAsync();
        Task<PerformanceReview> AddPerformanceReviewAsync(PerformanceReview review);
    }
}
