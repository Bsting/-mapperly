using TestMapperly;
using System.Text.Json;
using System.Text.Json.Serialization;


JsonSerializerOptions options = new()
{
    ReferenceHandler = ReferenceHandler.IgnoreCycles,
    WriteIndented = true
};

var company = new Company("Company 1");

company.CreateEmployee("abc", "one");
company.CreateEmployee("def", "two");

var mapperlyMapper = new MapperlyMapper();

var companyDtoFromMapperly = mapperlyMapper.Map<CompanyDto>(company);

Console.WriteLine("Success!");
Console.WriteLine(JsonSerializer.Serialize(company, options));
Console.WriteLine(JsonSerializer.Serialize(companyDtoFromMapperly, options));
