using Microsoft.EntityFrameworkCore;

namespace PierceAuto.Client.DataAccess;

internal class PierceAutoDbContext(DbContextOptions<PierceAutoDbContext> options): DbContext(options)
{
    
}