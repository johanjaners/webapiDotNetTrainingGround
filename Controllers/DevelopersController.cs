using Microsoft.AspNetCore.Mvc;
using webapiDotNetTrainingGround.Models;
namespace webapiDotNetTrainingGround.Controllers;

[ApiController]
[Route("/api/[controller]")]
class DeveloperController : ControllerBase
{
    private List<Developer> _db = new();

    [HttpGet]
    public List<Developer> GetAllDevs()
    {
        return _db;
    }
}
