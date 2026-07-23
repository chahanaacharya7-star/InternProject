using Microsoft.AspNetCore.Mvc;
using StudentManagement.Web.Services;

namespace StudentManagement.Web.Controllers
{
    public class SchoolAdminController : Controller
    {
        private readonly IAcademicSessionService _academicSessionService;

        public SchoolAdminController(IAcademicSessionService academicSessionService)
        {
            _academicSessionService = academicSessionService;
        }

        public IActionResult AcademicSetup()
        {
            var sessions = _academicSessionService.GetAll();
            return View(sessions);
        }
    }
}