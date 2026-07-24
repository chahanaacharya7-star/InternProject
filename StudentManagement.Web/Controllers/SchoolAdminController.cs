using Microsoft.AspNetCore.Mvc;
using StudentManagement.Web.Models;
using StudentManagement.Web.Services;

namespace StudentManagement.Web.Controllers
{
    public class SchoolAdminController : Controller
    {
        private readonly IAcademicSessionService _academicSessionService;
        private readonly IAcademicSetupService _academicSetupService;

        public SchoolAdminController(IAcademicSessionService academicSessionService, IAcademicSetupService academicSetupService)
        {
            _academicSessionService = academicSessionService;
            _academicSetupService = academicSetupService;
        }

        public IActionResult AcademicSetup()
        {
            var vm = new AcademicSetupViewModel
            {
                AcademicSessions = _academicSessionService.GetAll(),
                ExamYears = _academicSetupService.GetExamYears(),
                Programs = _academicSetupService.GetPrograms(),
                Batches = _academicSetupService.GetBatches(),
                Levels = _academicSetupService.GetLevels(),
                Faculties = _academicSetupService.GetFaculties(),
                Sections = _academicSetupService.GetSections(),
                Semesters = _academicSetupService.GetSemesters()
            };
            return View(vm);
        }
    }
}