using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Requests;
using WebApplication3.Services.Interfaces;

namespace WebApplication3.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PlanetsController : ControllerBase
{
    private readonly IPlanetService _service;

    public PlanetsController(IPlanetService service)
    {
        _service = service;
    }

    [HttpPost("add-planet")]
    public Planet AddPlanet(AddPlanet request)
    {
        return _service.AddPlanet(request);
    }

    [HttpGet("get-all-planets")]
    public List<Planet> GetPlanets()
    {
        return _service.GetAllPlanets();
    }
}
