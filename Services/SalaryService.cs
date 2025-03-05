using EmployeeManagementSystem.Data;
using EmployeeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Services
{
    public class SalaryService : ISalaryService
    {
        private readonly ApplicationDbContext _context;

        public SalaryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Salary>> GetSalariesAsync()
        {
            return await _context.Salaries.Include(s => s.Employee).ToListAsync();
        }

        public async Task<Salary> AddSalaryAsync(Salary salary)
        {
            _context.Salaries.Add(salary);
            await _context.SaveChangesAsync();
            return salary;
        }
    }
}
