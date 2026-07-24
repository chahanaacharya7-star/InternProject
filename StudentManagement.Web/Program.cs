using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<StudentManagement.Web.Services.IUserService, StudentManagement.Web.Services.UserService>();
builder.Services.AddSingleton<StudentManagement.Web.Services.IEmployeeService, StudentManagement.Web.Services.EmployeeService>();
builder.Services.AddSingleton<StudentManagement.Web.Services.IAcademicSessionService, StudentManagement.Web.Services.AcademicSessionService>();
builder.Services.AddSingleton<StudentManagement.Web.Services.IAcademicSetupService, StudentManagement.Web.Services.AcademicSetupService>();

// Register Cookie Authentication services
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Account/Login";
        options.ExpireTimeSpan = TimeSpan.FromMinutes(20);
        options.SlidingExpiration = true;
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}")
    .WithStaticAssets();


app.Run();
