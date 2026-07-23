using StudentManagement.Web.Models;

namespace StudentManagement.Web.Services
{
    public interface IAcademicSessionService
    {
        List<AcademicSession> GetAll();
    }
}