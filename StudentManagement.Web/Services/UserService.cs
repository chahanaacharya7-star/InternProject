using System.Text.Json;

namespace StudentManagement.Web.Services
{
    public interface IUserService
    {
        bool Authenticate(string email, string password, string role);
        bool CreateUser(string email, string password, string role, out string errorMessage);
    }

    public class UserService : IUserService
    {
        private readonly string _filePath;
        private readonly object _lock = new();

        public UserService(IWebHostEnvironment env)
        {
            _filePath = Path.Combine(env.ContentRootPath, "users.json");
            InitializeDefaultUsers();
        }

        private void InitializeDefaultUsers()
        {
            if (!File.Exists(_filePath))
            {
                var defaultUsers = new List<UserDto>
                {
                    new() { Email = "admin@school.com", Password = "Admin@123", Role = "Admin" },
                    new() { Email = "teacher@school.com", Password = "Teacher@123", Role = "Teacher" },
                    new() { Email = "student@school.com", Password = "Student@123", Role = "Student" }
                };
                SaveUsers(defaultUsers);
            }
        }

        private List<UserDto> LoadUsers()
        {
            lock (_lock)
            {
                if (!File.Exists(_filePath)) return new List<UserDto>();
                try
                {
                    var json = File.ReadAllText(_filePath);
                    return JsonSerializer.Deserialize<List<UserDto>>(json) ?? new List<UserDto>();
                }
                catch
                {
                    return new List<UserDto>();
                }
            }
        }

        private void SaveUsers(List<UserDto> users)
        {
            lock (_lock)
            {
                var json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(_filePath, json);
            }
        }

        public bool Authenticate(string email, string password, string role)
        {
            var users = LoadUsers();
            var normalizedEmail = email.Trim().ToLower();
            var user = users.FirstOrDefault(u => u.Email.Trim().ToLower() == normalizedEmail && u.Role == role);
            
            return user != null && user.Password == password;
        }

        public bool CreateUser(string email, string password, string role, out string errorMessage)
        {
            errorMessage = string.Empty;
            var normalizedEmail = email.Trim().ToLower();
            
            lock (_lock)
            {
                var users = LoadUsers();
                if (users.Any(u => u.Email.Trim().ToLower() == normalizedEmail))
                {
                    errorMessage = "A user with this email/username already exists.";
                    return false;
                }

                users.Add(new UserDto { Email = email, Password = password, Role = role });
                SaveUsers(users);
                return true;
            }
        }
    }

    public class UserDto
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
