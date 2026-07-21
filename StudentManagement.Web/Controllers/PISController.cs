using Microsoft.AspNetCore.Mvc;
using StudentManagement.Web.Services;

namespace StudentManagement.Web.Controllers
{
    public class PISController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public PISController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult EmployeeList()
        {
            ViewBag.TotalEmployee = _employeeService.GetTotalCount();
            ViewBag.MaleEmployee = _employeeService.GetMaleCount();
            ViewBag.FemaleEmployee = _employeeService.GetFemaleCount();
            ViewBag.ActiveEmployee = _employeeService.GetActiveCount();

            var employees = _employeeService.GetAll();
            return View(employees);
        }
    }
}