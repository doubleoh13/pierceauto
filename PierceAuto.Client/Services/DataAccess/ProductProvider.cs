using Microsoft.Extensions.Logging;
using PierceAuto.Client.DataAccess;
using PierceAuto.Client.Models;

namespace PierceAuto.Client.Services.DataAccess;

internal class ProductProvider(
    PierceAutoDbContextFactory contextFactory,
    ILogger<GenericDataService<Product>> logger) : GenericDataService<Product>(contextFactory, logger)
{
}