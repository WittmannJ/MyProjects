using Microsoft.EntityFrameworkCore;

public class CuratorContext : DbContext
{
    public virtual DbSet<Item> Items {get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=./curator.db");
    }
}