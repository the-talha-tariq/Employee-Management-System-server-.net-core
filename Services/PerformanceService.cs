using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Services
{
    public class PerformanceService : IPerformanceService
    {
        private readonly ApplicationDbContext _context;

        public PerformanceService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PerformanceReview>> GetPerformanceReviewsAsync()
        {
            return await _context.PerformanceReviews.Include(p => p.Employee).ToListAsync();
        }

        public async Task<PerformanceReview> AddPerformanceReviewAsync(PerformanceReview review)
        {
            _context.PerformanceReviews.Add(review);
            await _context.SaveChangesAsync();
            return review;
        }
    }
}
