using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Procedures.Model;

namespace Procedures.Services;

public class AppDbContext : DbContext
{
    private IConfiguration _configuration;

    public AppDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
        
        // Database.EnsureDeleted();
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration["ConnectionString"]);
        base.OnConfiguring(optionsBuilder);
    }
    
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<Game> Games { get; set; }
 
}