using Riok.Mapperly.Abstractions;

namespace TestMapperly
{
    public partial class MapperlyMapper
    {
        [MapPropertyFromSource(nameof(EmployeeDto.Name), Use = nameof(MapName))]
        public partial EmployeeDto Map(Employee employee);

        private string MapName(Employee employee)
            => $"{employee.FirstName} {employee.LastName}";
    }
}
