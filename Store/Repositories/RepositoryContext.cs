using Microsoft.EntityFrameworkCore;
using Entities.Models;
namespace Repositories;

public class RepositoryContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>().HasData(
            new Product() { ProductId=1, ProductName="Laptop", Price=40_000},
            new Product() { ProductId=2, ProductName="Monitor", Price=12_000},
            new Product() { ProductId=3, ProductName="Keyboard", Price=1_000},
            new Product() { ProductId=4, ProductName="Mouse", Price=500},
            new Product() { ProductId=5, ProductName="Headphone", Price=2_000}
        );
        
        modelBuilder.Entity<Category>().HasData(
            new Category() { CategoryId=1, CategoryName="Books"},
            new Category() { CategoryId=2, CategoryName="Electronics"}
        );
    }
}