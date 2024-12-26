using EmployeeCompany.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCompany.Data.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;

        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Employee>> GetAllAsync()
        {
            // Includes the related Company for each Employee
            return await _context.Employees.Include(e => e.Company).ToListAsync();
        }

        public async Task<Employee?> GetByIdAsync(int id)
        {
            // Includes the related Company for the specific Employee
            return await _context.Employees.Include(e => e.Company).FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task AddAsync(Employee employee)
        {
            await _context.Employees.AddAsync(employee);  // Add the Employee
            await _context.SaveChangesAsync();           // Commit changes
        }

        public async Task UpdateAsync(Employee employee)
        {
            _context.Employees.Update(employee);         // Update the Employee
            await _context.SaveChangesAsync();           // Commit changes
        }

        public async Task DeleteAsync(int id)
        {
            var employee = await GetByIdAsync(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);      // Remove the Employee
                await _context.SaveChangesAsync();       // Commit changes
            }
        }
    }
}
