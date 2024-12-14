using CodeFirstRelations.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstRelations.Database;

public class PatikaSecondDbContext : DbContext
{
  private readonly IConfiguration _configuration;
  public DbSet<User> Users { get; set; }
  public DbSet<Post> Posts { get; set; }

  public PatikaSecondDbContext(IConfiguration configuration)
  {
    _configuration = configuration;
  }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    optionsBuilder.UseSqlite(_configuration.GetConnectionString("DefaultConnection"));
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.Entity<User>()
      .HasMany(u => u.Posts)
      .WithOne(p => p.User)
      .HasForeignKey(p => p.UserId);
  }
}
