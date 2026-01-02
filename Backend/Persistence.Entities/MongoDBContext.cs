using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MongoDB.EntityFrameworkCore.Extensions;

namespace Persistence.Entities;

public class MongoDBContext : DbContext
{


    public DbSet<Audit> Audits { get; set; }


    public MongoDBContext(DbContextOptions<MongoDBContext> options) : base(options)
    {

    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Audit>().ToCollection("EventPlanner");
    }
}
