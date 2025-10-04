using Microsoft.AspNetCore.Mvc;
using webapiDotNetTrainingGround.Models;
namespace webapiDotNetTrainingGround.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class DevelopersController : ControllerBase
{
    private List<Developer> _db = [];

    [HttpGet]
    public List<Developer> GetAllDevelopers() => _db;

    [HttpGet]
    public Developer? GetDeveloperById(int id) => _db.Find(d => d.Id == id);
}