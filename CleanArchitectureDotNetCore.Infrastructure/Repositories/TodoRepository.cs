using CleanArchitectureDotNetCore.Domain.Entities;
using CleanArchitectureDotNetCore.Domain.Interfaces;
using CleanArchitectureDotNetCore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitectureDotNetCore.Infrastructure.Repositories;

public class TodoRepository : ITodoRepository
{
    private readonly TodoDbContext _context;

    public TodoRepository(TodoDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Todo todo)
    {
        _context.Todos.Add(todo);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<Todo>> GetAllAsync() =>
        await _context.Todos.ToListAsync();

    public async Task<Todo?> GetByIdAsync(Guid id) =>
        await _context.Todos.FindAsync(id);
}
