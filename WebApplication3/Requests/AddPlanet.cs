namespace WebApplication3.Requests;

public class AddPlanet
{
    public string Name { get; set; }
    public string Sattelite { get; set; }
    public int Order { get; set; }
    public bool IsInSolarSystem { get; set; }
    public decimal Diameter { get; set; }
    public decimal Weight { get; set; }
    public string Color { get; set; }
}
