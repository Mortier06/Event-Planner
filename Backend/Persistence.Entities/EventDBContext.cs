using System;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Entities;

public class EventDBContext : DbContext
{
    public DbSet<Locatie> Locaties { get; set; }
    public DbSet<Evenement> Evenementen { get; set; }
    public DbSet<Taak> Taken { get; set; }
    private string connectionString = "Server=127.0.0.1;Port=8555;Database=EventPlanner;User=eventplanner;Password=eventplanner123;SslMode=Preferred;";


    public EventDBContext(DbContextOptions<EventDBContext> options) : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseMySql(
             connectionString,
             new MySqlServerVersion(ServerVersion.AutoDetect(connectionString))
         );
    }
}
