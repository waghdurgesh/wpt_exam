using Microsoft.AspNetCore.Mvc;
using LearningManSys.Models;
using Microsoft.AspNetCore.Cors;

namespace LearningManSys.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TrainingController : ControllerBase
{

    private readonly ILogger<TrainingController> _logger;

    public TrainingController(ILogger<TrainingController> logger)
    {
        _logger = logger;
    }
    TrainingDAL dl = new TrainingDAL();

    [EnableCors()]
    [HttpGet]
    [Route("getlist")]
    public IEnumerable<Training> Get()
    {
        List<Training> list = new List<Training>();
        return dl.GetAll();
    }

    [EnableCors()]
    [HttpDelete]
    [Route("{id}")]
    public void Delete([FromRoute] int id)
    {
        {
            TrainingDAL data = new TrainingDAL();
            data.Delete(id);
        }
    }
    [EnableCors()]
    [HttpGet]
    [Route("{id}")]
    public Training GetbyId([FromRoute] int id)
    {
        TrainingDAL data = new TrainingDAL();
        Training obj = data.GetById(id);
        return obj;
    }

    [EnableCors()]
    [HttpPost]
    public void Insert(Training element)
    {
        TrainingDAL data = new TrainingDAL();
        data.Insert(element);
    }
    
    [EnableCors()]
    [HttpPut]
    [Route("{id}")]
    public void Put([FromRoute] int id, Training obj)
    {
        TrainingDAL data = new TrainingDAL();
        data.Update(obj);
    }

}
