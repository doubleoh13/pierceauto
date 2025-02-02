using Microsoft.EntityFrameworkCore;
using PierceAuto.Client.Models;

namespace PierceAuto.Client.DataAccess;

internal class PierceAutoDbContext(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Supplier> Suppliers { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }
}