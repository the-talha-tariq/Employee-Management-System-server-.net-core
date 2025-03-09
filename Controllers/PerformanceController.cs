using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Controllers
{
    [Route("api/performance")]
    [ApiController]
    public class PerformanceController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public PerformanceController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<PerformanceReview>>> GetPerformanceReview()
        {
            return await _context.PerformanceReviews.Include(e => e.ReviewId).ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<PerformanceReview>> CreatePerformanceReview(PerformanceReview performanceReview)
        {
            _context.PerformanceReviews.Add(performanceReview);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPerformanceReview), new { id = performanceReview.ReviewId}, performanceReview);
        }
    }
}
