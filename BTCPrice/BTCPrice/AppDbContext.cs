using Microsoft.EntityFrameworkCore;
using BTCPrice.Model;

public class AppDbContext : DbContext
{
    public DbSet<PriceDetail> Prices { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Use the in-memory database provider
        optionsBuilder.UseInMemoryDatabase("InMemoryDatabase");
    }
}