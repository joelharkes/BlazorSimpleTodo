using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

public class TodoContext : DbContext
{
    public const string DbName = "database.db";
    public DbSet<TodoList> TodoLists { get; set; }
    public DbSet<TodoItem> TodoItems { get; set; }

    public string DbPath { get; }

    public TodoContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, DbName);
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}

public class TodoList
{
    public int TodoListId { get; set; }
    public required string Name { get; set; }

    public DateTime? CheckedAt {get; set;}

    public List<TodoItem> Posts { get; } = new();
}

public class TodoItem
{
    public int TodoItemId { get; set; }
    public required string Title { get; set; }
    public required string Content { get; set; }

    public int TodoListId { get; set; }
    public required TodoList TodoList { get; set; }
}