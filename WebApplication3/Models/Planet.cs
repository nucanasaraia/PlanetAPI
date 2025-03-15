namespace WebApplication3.Models;

public class Planet
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Sattelite { get; set; }
    public int Order { get; set; }
    public bool IsInSolarSystem { get; set; }
    public decimal Diameter { get; set; }
    public decimal Weight { get; set; }
    public string Color { get; set; }
}
