using EmployeeManagement.Models;

namespace EmployeeManagement.Repositories
{
    public interface InterfaceRepository<T>
    {
        Task<IEnumerable<T>> getAllAsync();
        Task<T?> getByIdAsync(int id);
        Task AddAsync(T t);
        Task UpdateAsync(T t);
        Task DeleteAsync(int id);
    }
}
