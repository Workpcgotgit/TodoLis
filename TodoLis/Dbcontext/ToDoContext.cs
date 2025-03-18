using Microsoft.EntityFrameworkCore;

public class ToDoDbContext : DbContext
{
	public DbSet<ToDoItem> ToDoItems { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		optionsBuilder.UseSqlServer("Server=SITERO-PF3N194A;Database=ToDoListDb;Trusted_Connection=True;TrustServerCertificate=True;");
	}
}
