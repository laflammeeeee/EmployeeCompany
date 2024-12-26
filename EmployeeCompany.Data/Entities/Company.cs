namespace EmployeeCompany.Data.Entities
{
    public class Company
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Owner { get; set; } = string.Empty;
        public int Year { get; set; }
        public int NumberOfEmployees { get; set; }
        public ICollection<Employee> Employees { get; set; } = new List<Employee>(); // Navigation Property
    }
}
