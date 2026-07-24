using StudentManagement.Web.Models;

namespace StudentManagement.Web.Services
{
    public interface IAcademicSetupService
    {
        List<ExamYear> GetExamYears();
        List<AcademicProgram> GetPrograms();
        List<Batch> GetBatches();
        List<Level> GetLevels();
        List<Faculty> GetFaculties();
        List<Section> GetSections();
        List<Semester> GetSemesters();
    }
}