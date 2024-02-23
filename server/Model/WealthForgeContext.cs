using Microsoft.EntityFrameworkCore;

namespace WealthForgePro.Models;

public class WealthForgeContext : DbContext
{
    public WealthForgeContext(DbContextOptions<WealthForgeContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; } = null!;
    public DbSet<AssetClass> AssetClass { get; set; } = null!;
    public DbSet<MarketData> MarketData { get; set; } = null!;
    public DbSet<Portfolio> Portfolio { get; set; } = null!;
    public DbSet<Transaction> Transaction { get; set; } = null!;
}