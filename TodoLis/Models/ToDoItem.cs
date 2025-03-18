using System;
using System.ComponentModel.DataAnnotations;

public class ToDoItem
{
	public int Id { get; set; }

	[Required]
	[MaxLength(255)]
	public string Title { get; set; } = string.Empty;

	public bool IsCompleted { get; set; }

	public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
