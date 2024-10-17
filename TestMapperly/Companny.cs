using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMapperly
{
    public class Company
    {
        public Guid Id { get; init; } = Guid.NewGuid();
        public string Name { get; set; }
        public IList<Employee> Employees { get; } = new List<Employee>();

        public Company(string name)
        {
            Name = name;
        }

        public Employee CreateEmployee(string first, string last)
        {
            var employee = new Employee(Guid.NewGuid(), this, first, last);
            Employees.Add(employee);

            return employee;
        }
    }

    public record CompanyDto(Guid Id, string Name, EmployeeDto[] Employees)
    {
        ///// <inheritdoc />
        //public virtual bool Equals(CompanyDto? other)
        //{
        //    if (ReferenceEquals(null, other)) return false;
        //    if (ReferenceEquals(this, other)) return true;

        //    return Id.Equals(other.Id)
        //        && string.Equals(Name, other.Name, StringComparison.InvariantCulture)
        //        && Employees.SequenceEqual(other.Employees); // <-- this is the only reason to re-implement Equals method
        //}

        ///// <inheritdoc />
        //public override int GetHashCode()
        //{
        //    var hashCode = new HashCode();
        //    hashCode.Add(Id);
        //    hashCode.Add(Name, StringComparer.InvariantCulture);
        //    hashCode.Add(Employees);
        //    return hashCode.ToHashCode();
        //}
    }
}
