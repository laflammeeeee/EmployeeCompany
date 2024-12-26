namespace EmployeeCompany.Data.Entities
{
    public class Employee
    {
        public int Id { get; set; } // Primary Key
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DOB { get; set; }
        public string Address { get; set; } = string.Empty;
        public DateTime EmploymentStartDate { get; set; }
        public decimal TotalCompensation { get; set; }
        public int NoticePeriod { get; set; }
        public int CompanyId { get; set; } // Foreign Key
        public Company? Company { get; set; } // Navigation Property
    }
}
