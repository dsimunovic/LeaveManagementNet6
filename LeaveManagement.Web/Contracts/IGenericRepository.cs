﻿namespace LeaveManagement.Web.Contracts
{
    public interface IGenericRepository<T> where T: class
    {
        Task<T> GetAsync(int? id);
        Task UpdateAsync(T entity);  
        Task<T> AddAsync(T entity);
        Task AddRangeAsync(List<T> entities);

        Task DeleteAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<bool> Exists(int id);
    }
}
