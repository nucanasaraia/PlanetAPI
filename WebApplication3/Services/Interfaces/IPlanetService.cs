using WebApplication3.Models;
using WebApplication3.Requests;

namespace WebApplication3.Services.Interfaces;


public interface IPlanetService
{
    Planet AddPlanet(AddPlanet request);
    List<Planet> GetAllPlanets();
    List<Planet> GetAllPlanetsSorted();
    Planet GetNearestPlanet();
    Planet DeletePlanet(int id);
}
