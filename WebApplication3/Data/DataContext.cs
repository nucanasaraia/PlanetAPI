using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Data;

public class DataContext :DbContext
{
    public DbSet<Planet> Planets { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Cagareli;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
}
