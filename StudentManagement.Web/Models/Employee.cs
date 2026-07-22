namespace StudentManagement.Web.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public string Designation { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public bool IsActive { get; set; }

        public string Code { get; set; } = string.Empty;
        public string LegalEntity { get; set; } = string.Empty;
        public string Branch { get; set; } = string.Empty;
        public string BusinessUnit { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string DefaultPassword { get; set; } = string.Empty;
        public string CreatedDate { get; set; } = string.Empty;
        public string LastLoginDate { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}