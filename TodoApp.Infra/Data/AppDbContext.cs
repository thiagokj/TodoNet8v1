using Microsoft.EntityFrameworkCore;
using TodoApp.Core.Contexts.TodoContext.Entities;
using TodoApp.Infra.Contexts.TodoContext.Mappings;

namespace TodoApp.Infra.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
  public DbSet<Todo> Todos { get; set; } = null!;

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    modelBuilder.ApplyConfiguration(new TodoMap());
  }
}