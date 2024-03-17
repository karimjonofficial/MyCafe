using interfaces.Pages;

namespace interfaces.Repositories;

public interface IRepository<T>
{
    Task<T> PostAsync(T model, CancellationToken token = default);
    Task<T> PostAsync(IEnumerable<T> models, CancellationToken token = default);
    
    Task<T> DeleteAsync(T model, CancellationToken token = default);
    Task<T> DeleteAsync(int id, CancellationToken token = default);
    Task<T> DeleteAsync(IEnumerable<int> ids, CancellationToken token = default);
    
    Task<T> PatchAsync(int id, T model, CancellationToken token = default);
    Task<T> PutAsync(int id, T model, CancellationToken token = default);
    
    Task<T> GetAsync(int id, CancellationToken token = default);
    Task<IEnumerable<T>> GetAsync(CancellationToken token = default);
    
    Task<IPage<T>> GetAscAsync(int index, int count, string sortBy, string filter, CancellationToken token = default);
    Task<IPage<T>> GetDescAsync(int index, int count, string sortBy, string filter, CancellationToken token = default);

    Task<bool> Exists(int id, CancellationToken token);
}