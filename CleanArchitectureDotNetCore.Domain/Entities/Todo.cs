﻿namespace CleanArchitectureDotNetCore.Domain.Entities;

public class Todo
{
    public Guid Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
}
