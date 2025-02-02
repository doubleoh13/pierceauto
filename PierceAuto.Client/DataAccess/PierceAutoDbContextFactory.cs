using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace PierceAuto.Client.DataAccess;

internal class PierceAutoDbContextFactory(IConfiguration config)
{
    public PierceAutoDbContext CreateDbContext(string[]? args = null)
    {
        var options = new DbContextOptionsBuilder<PierceAutoDbContext>();
        options.UseSqlServer(config.GetConnectionString("Default"));
        return new PierceAutoDbContext(options.Options);
    }
}