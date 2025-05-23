using CleanArchitectureDotNetCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureDotNetCore.Infrastructure.Data;

public class TodoDbContext : DbContext
{
    public TodoDbContext(DbContextOptions<TodoDbContext> options) : base(options) { }

    public DbSet<Todo> Todos => Set<Todo>();
}
