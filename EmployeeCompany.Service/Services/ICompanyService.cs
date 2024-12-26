using EmployeeCompany.Data.Entities;

namespace EmployeeCompany.Service.Services
{
    public interface ICompanyService
    {
        Task<IEnumerable<Company>> GetAllAsync();       // Retrieve all companies
        Task<Company?> GetByIdAsync(int id);            // Retrieve a company by ID
        Task AddAsync(Company company);                // Add a new company
        Task UpdateAsync(Company company);             // Update a company
        Task DeleteAsync(int id);                      // Delete a company by ID
    }
}
