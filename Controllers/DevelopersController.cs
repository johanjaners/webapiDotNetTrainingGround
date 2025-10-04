using Microsoft.AspNetCore.Mvc;
using webapiDotNetTrainingGround.Models;
namespace webapiDotNetTrainingGround.Controllers;

class DeveloperController : ControllerBase
{
    private List<Developer> _db = new();
}
