using EmployeeCompany.Data.Entities;

namespace EmployeeCompany.Service.Services
{
    public interface IEmployeeService
    {
        Task<IEnumerable<Employee>> GetAllAsync();       // Retrieve all employees
        Task<Employee?> GetByIdAsync(int id);            // Retrieve an employee by ID
        Task AddAsync(Employee employee);               // Add a new employee
        Task UpdateAsync(Employee employee);            // Update an employee
        Task DeleteAsync(int id);                       // Delete an employee by ID
    }
}
