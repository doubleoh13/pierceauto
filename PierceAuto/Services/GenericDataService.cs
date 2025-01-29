using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PierceAuto.Models;

namespace PierceAuto.Services;

internal class GenericDataService<T>(DbContextFactory contextFactory) : IDataService<T> where T : class, IHasID
{
    public async Task<IEnumerable<T>> GetAllAsync()
    {
        await using DbContext context = contextFactory.CreateDbContext();

        return await context.Set<T>().ToListAsync();
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        await using DbContext context = contextFactory.CreateDbContext();

        return await context.Set<T>().Where(e => e.ID == id).FirstOrDefaultAsync();
    }

    public async Task<T> AddAsync(T entity)
    {
        await using DbContext context = contextFactory.CreateDbContext();

        EntityEntry<T> createdEntity = await context.Set<T>().AddAsync(entity);
        await context.SaveChangesAsync();

        return createdEntity.Entity;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<T> UpdateAsync(T entity)
    {
        throw new NotImplementedException();
    }

    public async Task<T?> GetFirstRecord()
    {
        await using DbContext context = contextFactory.CreateDbContext();
        T? entity = await context.Set<T>().OrderBy(e => e.ID).FirstOrDefaultAsync();

        return entity;
    }

    public async Task<T?> GetLastRecord()
    {
        await using DbContext context = contextFactory.CreateDbContext();
        T? entity = await context.Set<T>().OrderByDescending(e => e.ID).FirstOrDefaultAsync();

        return entity;
    }

    public Task<T?> FindRecord(T searchParams)
    {
        throw new NotImplementedException();
    }

    public async Task<T?> GetPreviousRecord(int currentId)
    {
        await using DbContext context = contextFactory.CreateDbContext();
        T? entity = await context.Set<T>()
            .Where(e => e.ID < currentId)
            .OrderByDescending(e => e.ID)
            .FirstOrDefaultAsync();

        return entity;
    }

    public async Task<T?> GetNextRecord(int currentId)
    {
        await using DbContext context = contextFactory.CreateDbContext();
        T? entity = await context.Set<T>()
            .Where(e => e.ID > currentId)
            .OrderBy(e => e.ID)
            .FirstOrDefaultAsync();

        return entity;
    }
}