using System;
using JwtExample.Models;
using Microsoft.EntityFrameworkCore;

namespace JwtExample.Database;

public class ApplicationDbContext : DbContext
{
  public ApplicationDbContext(DbContextOptions options) : base(options)
  {
  }

  public DbSet<User> Users { get; set; }
}
