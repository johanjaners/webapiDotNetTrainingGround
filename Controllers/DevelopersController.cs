using Microsoft.AspNetCore.Mvc;
using webapiDotNetTrainingGround.Models;
namespace webapiDotNetTrainingGround.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class DevelopersController : ControllerBase
{
    private readonly Db _db;

    public DevelopersController()
    {
        _db = new Db();
    }

    [HttpGet]
    public List<Developer> GetAllDevelopers() => _db.Developers;

    [HttpGet("{id}")]
    public Developer? GetDeveloperById(int id) => _db.Developers.Find(d => d.Id == id);

    [HttpPost]
    public IActionResult CreateNewDeveloper(Developer developerToAdd)
    {
        var nextId = _db.Developers.Count + 1;
        developerToAdd.Id = nextId;
        _db.Developers.Add(developerToAdd);

        return CreatedAtAction(nameof(GetDeveloperById), new { id = nextId }, developerToAdd);
    }
}