using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PierceAuto.Client.DataAccess;
using PierceAuto.Client.Models;

namespace PierceAuto.Client.Services.DataAccess;

internal class GenericDataService<T>(PierceAutoDbContextFactory contextFactory, ILogger<GenericDataService<T>> logger)
    where T : class, IDomainModel
{
    public async Task<T> Create(T entity)
    {
        await using var context = contextFactory.CreateDbContext();
        context.Set<T>().Add(entity);
        await context.SaveChangesAsync();
        return entity;
    }

    public async Task<T> Update(T entity)
    {
        await using var context = contextFactory.CreateDbContext();
        context.Set<T>().Update(entity);
        await context.SaveChangesAsync();
        return entity;
    }

    public async Task<bool> Delete(T entity)
    {
        try
        {
            await using var context = contextFactory.CreateDbContext();
            context.Set<T>().Remove(entity);
            await context.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, ex.Message);
            return false;
        }
    }

    public async Task<T?> GetById(int id)
    {
        await using var context = contextFactory.CreateDbContext();
        return await context.Set<T>().FirstOrDefaultAsync(e => e.Id == id);
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        
        await using var context = contextFactory.CreateDbContext();
        return await context.Set<T>().ToListAsync();
    }
}