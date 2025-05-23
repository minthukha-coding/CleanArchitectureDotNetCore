using CleanArchitectureDotNetCore.Domain.Entities;

namespace CleanArchitectureDotNetCore.Domain.Interfaces;

public interface ITodoRepository
{
    Task<IEnumerable<Todo>> GetAllAsync();
    Task<Todo?> GetByIdAsync(Guid id);
    Task AddAsync(Todo todo);
}