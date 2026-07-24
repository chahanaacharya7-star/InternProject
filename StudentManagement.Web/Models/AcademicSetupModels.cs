namespace StudentManagement.Web.Models
{
    public class ExamYear
    {
        public int Id { get; set; }
        public string DisplayName { get; set; } = string.Empty;
        public int Year { get; set; }
    }

    public class AcademicProgram
    {
        public int Id { get; set; }
        public string ProgramName { get; set; } = string.Empty;
        public string ProgramCode { get; set; } = string.Empty;
        public int? StudentLimit { get; set; }
        public string ProgramType { get; set; } = string.Empty;
        public string DataAccessGroup { get; set; } = string.Empty;
        public string Level { get; set; } = string.Empty;
        public string Faculty { get; set; } = string.Empty;
        public string AcademicIncharge { get; set; } = string.Empty;
        public string Status { get; set; } = "ACTIVE";
        public int DisplayOrder { get; set; }
    }

    public class Batch
    {
        public int Id { get; set; }
        public string ProgramName { get; set; } = string.Empty;
        public string BatchName { get; set; } = string.Empty;
        public string AcademicSession { get; set; } = string.Empty;
        public string GradingSystem { get; set; } = string.Empty;
        public string Status { get; set; } = "ACTIVE";
        public bool HiddenFromTeacher { get; set; }
    }

    public class Level
    {
        public int Id { get; set; }
        public string LevelName { get; set; } = string.Empty;
        public int LevelOrder { get; set; }
        public string Remarks { get; set; } = string.Empty;
        public string Status { get; set; } = "ACTIVE";
    }

    public class Faculty
    {
        public int Id { get; set; }
        public string FacultyName { get; set; } = string.Empty;
        public string Remarks { get; set; } = string.Empty;
        public string Status { get; set; } = "ACTIVE";
    }

    public class Section
    {
        public int Id { get; set; }
        public string SectionName { get; set; } = string.Empty;
        public string Remarks { get; set; } = string.Empty;
        public string Status { get; set; } = "ACTIVE";
    }

    public class Semester
    {
        public int Id { get; set; }
        public string SemesterName { get; set; } = string.Empty;
        public string Remarks { get; set; } = string.Empty;
        public string Status { get; set; } = "ACTIVE";
        public string ProgramType { get; set; } = string.Empty;
    }
}