using CleanArchitectureDotNetCore.Application.DTOs;
using CleanArchitectureDotNetCore.Application.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitectureDotNetCore.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TodoController : ControllerBase
{
    private readonly TodoService _service;

    public TodoController(TodoService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get() =>
        Ok(await _service.GetAllAsync());

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] TodoDto dto)
    {
        await _service.AddAsync(dto);
        return Ok();
    }
}