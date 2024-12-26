using EmployeeCompany.Data.Entities;
using EmployeeCompany.Data.Repositories;

namespace EmployeeCompany.Service.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;

        public CompanyService(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task<IEnumerable<Company>> GetAllAsync()
        {
            return await _companyRepository.GetAllAsync();
        }

        public async Task<Company?> GetByIdAsync(int id)
        {
            return await _companyRepository.GetByIdAsync(id);
        }

        public async Task AddAsync(Company company)
        {
            await _companyRepository.AddAsync(company);
        }

        public async Task UpdateAsync(Company company)
        {
            await _companyRepository.UpdateAsync(company);
        }

        public async Task DeleteAsync(int id)
        {
            await _companyRepository.DeleteAsync(id);
        }
    }
}
