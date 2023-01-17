using Microsoft.AspNetCore.Mvc;
using crud_basic.Models;
namespace crud_basic.Controllers;

[ApiController]
[Route("api/[controller]")]
public class QualificationController : ControllerBase
{
    // private readonly transflower_misContext _logger;

    // public QualificationController(transflower_misContext logger)
    // {
    //     _logger = logger;
    // }

    // [Route("GetQual")]
    // [HttpGet]
    // public IActionResult GetQual()
    // {
    //     List<Qualification> list = _logger.Qualifications.ToList();
    //     return StatusCode(StatusCodes.Status200OK, list);
    // }
    QualificationDAL objQual = new QualificationDAL();

    [HttpGet]
    [Route("GetQual")]
    public IEnumerable<Qualification> GetQual()
    {
        return objQual.GetAllQualifiactions();
    }

    [HttpDelete]
    [Route("DelQual/{id}")]
    public int Delete(int id)
    {
        return objQual.DeleteQualifications(id);
    }

}
