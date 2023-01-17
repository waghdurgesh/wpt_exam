using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Log.Models;
using Logmeth.Models;
namespace Registration_MVC.Controllers;

public class AuthController : Controller
{
    private readonly ILogger<AuthController> _logger;
    public AuthController(ILogger<AuthController> logger)
    {
        Console.WriteLine("Auth Controller instance initialized......");
        _logger = logger;
    }
    public IActionResult Validate(string email, string pass)
    {
        string login_file = @"F:\Module\MS Dotnet\git_repo_dotnet\ms_dotnet\Registration_MVC\wwwroot\json\Login.json";
        string login_data = System.IO.File.ReadAllText(login_file);
        List<Login>? login_list = JsonSerializer.Deserialize<List<Login>>(login_data);
        Console.WriteLine("login list");
        foreach (Login data in login_list)
        {
            if (data.Email == email && data.Password == pass)
            {
                return Redirect("/home/Index");
            }
            else
            {
                return Redirect("/auth/failed");
            }
        }
        return View();
    }
    public IActionResult Signup()
    {
        Console.WriteLine("In Sign Up");
        return View();
    }
    public IActionResult Signupupload(string First, string Last, string Email, string Password)
    {
        Login loglist = new Login(First, Last, Email, Password);
        LoginMethods signup = new LoginMethods();
        signup.SerializeSignUp(loglist);
        return Redirect("/Auth/login");
    }
    public IActionResult Login()
    {
        Console.WriteLine("In Login Action");
        return View();
    }
    public IActionResult Failed()
    {
        Console.WriteLine("In Login failed");
        return View();
    }
    public IActionResult ForgotPassword()
    {
        return View();
    }

}
