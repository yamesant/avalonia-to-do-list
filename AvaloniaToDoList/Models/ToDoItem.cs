using System;

namespace AvaloniaToDoList.Models;

/// <summary>
/// This is our Model for a simple ToDoItem. 
/// </summary>
public class ToDoItem
{
    public string? Content { get; set; }
    public DateTime? CompletionDateTime { get; set; }
    public ToDoItemStatus Status { get; set; }
}

public enum ToDoItemStatus
{
    New,
    Completed,
}