using System.Text.Json;
using StudentManagement.Web.Models;

namespace StudentManagement.Web.Services
{
    public class AcademicSessionService : IAcademicSessionService
    {
        private readonly List<AcademicSession> _sessions;

        public AcademicSessionService(IWebHostEnvironment env)
        {
            var path = Path.Combine(env.ContentRootPath, "Data", "academicSessions.json");

            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);
                _sessions = JsonSerializer.Deserialize<List<AcademicSession>>(json,
                    new JsonSerializerOptions { PropertyNameCaseInsensitive = true }) ?? new List<AcademicSession>();
            }
            else
            {
                _sessions = new List<AcademicSession>();
            }
        }

        public List<AcademicSession> GetAll() => _sessions;
    }
}