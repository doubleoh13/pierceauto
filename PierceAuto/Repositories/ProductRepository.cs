using PierceAuto.Models;
using PierceAuto.Services;

namespace PierceAuto.Repositories;

internal class ProductRepository(DbContextFactory contextFactory)
    : GenericDataService<Product>(contextFactory), IProductRepository
{
}