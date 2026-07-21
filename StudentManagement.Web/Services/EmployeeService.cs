using System.Text.Json;
using StudentManagement.Web.Models;

namespace StudentManagement.Web.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly List<Employee> _employees;

        public EmployeeService(IWebHostEnvironment env)
        {
            var path = Path.Combine(env.ContentRootPath, "Data", "employees.json");

            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                _employees = JsonSerializer.Deserialize<List<Employee>>(json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new List<Employee>();
            }
            else
            {
                _employees = new List<Employee>();
            }
        }

        public List<Employee> GetAll() => _employees;

        public int GetTotalCount() => _employees.Count;

        public int GetMaleCount() => _employees.Count(e => e.Gender.Equals("Male", StringComparison.OrdinalIgnoreCase));

        public int GetFemaleCount() => _employees.Count(e => e.Gender.Equals("Female", StringComparison.OrdinalIgnoreCase));

        public int GetActiveCount() => _employees.Count(e => e.IsActive);
    }
}