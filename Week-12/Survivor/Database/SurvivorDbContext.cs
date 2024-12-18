using System;
using Microsoft.EntityFrameworkCore;
using Survivor.Models;

namespace Survivor.Database;

public class SurvivorDbContext : DbContext
{
  private readonly IConfiguration _configuration;
  public DbSet<Models.Competitor> Competitors { get; set; }
  public DbSet<Models.Category> Categories { get; set; }
  public SurvivorDbContext(IConfiguration configuration)
  {
    _configuration = configuration;
  }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlite(_configuration.GetConnectionString("DefaultConnection"));
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<Competitor>()
      .HasOne(c => c.Category)
      .WithMany(c => c.Competitors)
      .HasForeignKey(c => c.CategoryId);
  }
}
