using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Web
{
    public class SetupController : Controller
    {
        // Route: /Setup/UserList
        public IActionResult UserList()
        {
            // Points to Views/Setup/Users.cshtml
            return View("Users");
        }
    }
}