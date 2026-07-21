using StudentManagement.Web.Models;

namespace StudentManagement.Web.Services
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        int GetTotalCount();
        int GetMaleCount();
        int GetFemaleCount();
        int GetActiveCount();
    }
}