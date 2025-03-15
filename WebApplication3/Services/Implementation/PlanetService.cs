using Azure.Core;
using WebApplication3.Data;
using WebApplication3.Models;
using WebApplication3.Requests;
using WebApplication3.Services.Interfaces;

namespace WebApplication3.Services.Implementation;

public class PlanetService : IPlanetService
{
    private readonly DataContext _context;

    public PlanetService(DataContext context)
    {
        _context = context;
    }

    public Planet AddPlanet(AddPlanet request)
    {
        var planet = new Planet()
        {
            Color = request.Color,
            Diameter = request.Diameter,
            Name = request.Name,
            IsInSolarSystem = request.IsInSolarSystem,
            Weight = request.Weight,
            Sattelite = request.Sattelite,
            Order = request.Order,
        };

        _context.Planets.Add(planet);
        _context.SaveChanges();

        return planet;
    }

 

    public List<Planet> GetAllPlanets()
    {
        return _context.Planets.ToList();
    }

    public Planet DeletePlanet(int id)
    {
        var planetToDelete =
            _context.Planets.FirstOrDefault(x => x.Id == id);

        if(planetToDelete == null)
        {
            return null;
        }
        else
        {
            _context.Planets.Remove(planetToDelete);
            _context.SaveChanges();
            return planetToDelete;
        }
    }

    public List<Planet> GetAllPlanetsSorted()
    {
        return _context.Planets.OrderBy(x => x.Order).ToList();
    }

    public Planet GetNearestPlanet()
    {
        var allPlanets = (Planet)_context.Planets.OrderBy(x => x.Order).Take(1);



        return allPlanets;
    }
}
