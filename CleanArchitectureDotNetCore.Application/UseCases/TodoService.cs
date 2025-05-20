using CleanArchitectureDotNetCore.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDotNetCore.Application.UseCases;

internal class TodoService
{
    private readonly ITodoRepository _repository;

    public TodoService(ITodoRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<TodoDto>> GetAllAsync()
    {
        var todos = await _repository.GetAllAsync();
        return todos.Select(t => new TodoDto
        {
            Id = t.Id,
            Title = t.Title,
            IsCompleted = t.IsCompleted
        });
    }

    public async Task AddAsync(TodoDto dto)
    {
        var todo = new Todo
        {
            Id = Guid.NewGuid(),
            Title = dto.Title,
            IsCompleted = dto.IsCompleted
        };
        await _repository.AddAsync(todo);
    }
}
