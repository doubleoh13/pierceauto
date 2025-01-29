﻿namespace PierceAuto.Services;

internal interface IDataService<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<bool> DeleteAsync(int id);
    Task<T?> GetFirstRecord();
    Task<T?> GetPreviousRecord(int currentId);
    Task<T?> GetNextRecord(int currentId);
    Task<T?> GetLastRecord();
    Task<T?> FindRecord(T searchParams);
}