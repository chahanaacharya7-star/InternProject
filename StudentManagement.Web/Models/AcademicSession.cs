namespace StudentManagement.Web.Models
{
    public class AcademicSession
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int DisplayOrder { get; set; }
        public string Status { get; set; } = "ACTIVE";
        public bool IsRunning { get; set; }
    }
}