namespace StudentManagement.Web.Models
{
    public class AcademicSetupViewModel
    {
        public List<AcademicSession> AcademicSessions { get; set; } = new();
        public List<ExamYear> ExamYears { get; set; } = new();
        public List<AcademicProgram> Programs { get; set; } = new();
        public List<Batch> Batches { get; set; } = new();
        public List<Level> Levels { get; set; } = new();
        public List<Faculty> Faculties { get; set; } = new();
        public List<Section> Sections { get; set; } = new();
        public List<Semester> Semesters { get; set; } = new();
    }
}