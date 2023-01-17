using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Registration_MVC.Models;
using System.Text.Json;
namespace Registration_MVC.Controllers;
using ProfMeth.Models;
using Prof.Models;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult ProfileList()
    {
        string profilelist_file = @"F:\Module\MS Dotnet\git_repo_dotnet\ms_dotnet\Registration_MVC\wwwroot\json\List.json";
        string profile_data = System.IO.File.ReadAllText(profilelist_file);
        List<Profile> profile_list = JsonSerializer.Deserialize<List<Profile>>(profile_data);
        Console.WriteLine(profile_list);
        ViewData["profilelist"] = profile_list;
        return View();
    }

    public IActionResult Privacy()
    {   
        Console.WriteLine("In Privacy");
        return View();
    }

    public IActionResult Index()
    {
        Console.WriteLine("In Index");
        return View();
    }
   public IActionResult ForgotPassword()
    {   
        Console.WriteLine("In Forgot Password");
        return View();
    }
    public IActionResult Registration()
    {   
        Console.WriteLine("In Registration");
        return View();
    }

    public IActionResult About()
    {
         Console.WriteLine("In About");
        return View();
    }
    public IActionResult Uploadprofile(string firstname, string lastname, string username, string email, string profileurl)
    {
        Profile profilelist = new Profile(firstname, lastname, username, email, profileurl);
        ProfileMethods profileobj = new ProfileMethods();
        profileobj.SerializeProfile(profilelist);
        return Redirect("/home/ProfileList");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
