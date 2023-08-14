using System.Linq.Expressions;

namespace CasgemMicroservice.Services.Order.Core.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
        Task<List<T>> GetOrderesById(Expression<Func<T,bool>> filter=null);
    }
}
