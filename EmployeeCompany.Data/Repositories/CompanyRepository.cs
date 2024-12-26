using EmployeeCompany.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeCompany.Data.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly AppDbContext _context;

        public CompanyRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Company>> GetAllAsync()
        {
            // Includes the Employees for each Company
            return await _context.Companies.Include(c => c.Employees).ToListAsync();
        }

        public async Task<Company?> GetByIdAsync(int id)
        {
            // Includes the Employees for the specific Company
            return await _context.Companies.Include(c => c.Employees).FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task AddAsync(Company company)
        {
            await _context.Companies.AddAsync(company);  // Add the Company
            await _context.SaveChangesAsync();          // Commit changes
        }

        public async Task UpdateAsync(Company company)
        {
            _context.Companies.Update(company);         // Update the Company
            await _context.SaveChangesAsync();          // Commit changes
        }

        public async Task DeleteAsync(int id)
        {
            var company = await GetByIdAsync(id);
            if (company != null)
            {
                _context.Companies.Remove(company);      // Remove the Company
                await _context.SaveChangesAsync();      // Commit changes
            }
        }
    }
}
