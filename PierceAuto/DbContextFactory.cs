using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PierceAuto;
internal class DbContextFactory(string connectionString) : IDesignTimeDbContextFactory<DbContext>
{
    private readonly string _connectionString = connectionString;

    public DbContext CreateDbContext(string[]? args = null)
    {
        var optionsBuilder = new DbContextOptionsBuilder<DbContext>();
        optionsBuilder.UseSqlServer(_connectionString);
        return new DbContext(optionsBuilder.Options);
    }
}
