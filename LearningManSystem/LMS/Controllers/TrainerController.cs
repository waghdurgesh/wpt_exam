using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LMS.Models;
using BOL;
using BLL;
using DAL.Connected;

namespace LMS.Controllers;

public class TrainerController : Controller
{
    private readonly ILogger<TrainerController> _logger;

    public TrainerController(ILogger<TrainerController> logger)
    {
        _logger = logger;
    }
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

}
