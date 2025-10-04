using Microsoft.AspNetCore.Mvc;
using webapiDotNetTrainingGround.Models;
namespace webapiDotNetTrainingGround.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class DeveloperController : ControllerBase
{
    private List<Developer> _db = new();

    [HttpGet]
    public List<Developer> GetAllDevs() => _db;
}
