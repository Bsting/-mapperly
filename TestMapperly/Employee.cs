using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMapperly
{
    public class Employee
    {
        public Guid Id { get; init; }
        public Guid CompanyId { get; init; }
        public Company Company { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(Guid id, Company company, string firstName, string lastName)
        {
            Id = id;
            CompanyId = company.Id;
            Company = company;
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public record EmployeeDto(Guid Id, Guid CompanyId, string Name);
}
