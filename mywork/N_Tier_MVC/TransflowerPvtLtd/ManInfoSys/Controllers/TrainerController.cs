using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ManInfoSys.Models;
using BOL;
using BLL;
// using DAL;
using DAL.Connected;

namespace ManInfoSys.Controllers;

public class TrainerController : Controller
{
    private readonly ILogger<TrainerController> _logger;

    public TrainerController(ILogger<TrainerController> logger)
    {
        _logger = logger;
    }
//display list using json
    // public IActionResult List()
    // {
    //     Coordinator Head = new Coordinator();
    //     List<Trainer> AllTrainers = Head.GetAllTrainer();
    //     this.ViewData["TrainersList"] = AllTrainers;
    //     return View();
    // }
//details by id using json
    // public IActionResult Details(int id)
    // {
    //     Coordinator Head = new Coordinator();
    //     Trainer? AllTrainers = Head.GetTrainerDetails(id);
    //     this.ViewData["TrainersDetails"] = AllTrainers;
    //     return View();
    // }
//display list using sql
    public IActionResult List()
    {
        Coordinator sqlHead = new Coordinator();
        List<Trainer> allTrainersSQL = sqlHead.GetTrainersSQLData();
        this.ViewData["TrainersSQLList"]=allTrainersSQL;
        return View();
    }
//details by using sql
    public IActionResult Details(int id){
        Coordinator head = new Coordinator();
        Trainer allDetails = head.GetTrainerDetailsSQL(id);
        this.ViewData["TrainersSQLDetails"]=allDetails;
        return View();
    }

    // [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    // public IActionResult Error()
    // {
    //     return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    // }
}
