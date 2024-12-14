using System;
using CodeFirstBasic.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasic.Database;

public class PatikaFirstDbContext : DbContext
{
  public DbSet<Movie> Movies { get; set; }
  public DbSet<Game> Games { get; set; }

  public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> options) : base(options)
  {
  }
}
