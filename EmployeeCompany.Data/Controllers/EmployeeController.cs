// CompanyEmployee.API/Controllers/EmployeeController.cs
using CompanyEmployee.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployee.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        // ... (Implement controller actions)
    }
}