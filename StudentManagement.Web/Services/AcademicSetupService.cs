using System.Text.Json;
using StudentManagement.Web.Models;

namespace StudentManagement.Web.Services
{
    public class AcademicSetupService : IAcademicSetupService
    {
        private readonly string _dataPath;
        private readonly JsonSerializerOptions _options = new() { PropertyNameCaseInsensitive = true };

        public AcademicSetupService(IWebHostEnvironment env)
        {
            _dataPath = Path.Combine(env.ContentRootPath, "Data");
        }

        private List<T> Load<T>(string fileName)
        {
            var path = Path.Combine(_dataPath, fileName);
            if (!File.Exists(path)) return new List<T>();
            var json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<T>>(json, _options) ?? new List<T>();
        }

        public List<ExamYear> GetExamYears() => Load<ExamYear>("examYears.json");
        public List<AcademicProgram> GetPrograms() => Load<AcademicProgram>("programs.json");
        public List<Batch> GetBatches() => Load<Batch>("batches.json");
        public List<Level> GetLevels() => Load<Level>("levels.json");
        public List<Faculty> GetFaculties() => Load<Faculty>("faculties.json");
        public List<Section> GetSections() => Load<Section>("sections.json");
        public List<Semester> GetSemesters() => Load<Semester>("semesters.json");
    }
}