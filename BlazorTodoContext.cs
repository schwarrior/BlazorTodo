using Microsoft.EntityFrameworkCore;

public class BlazorTodoContext(DbContextOptions<BlazorTodoContext> options) : DbContext(options)
{
    public DbSet<BlazorTodo.Models.Movie> Movie { get; set; } = default!;
}
