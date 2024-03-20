using domain.Models.Base;
using interfaces.Pages;
using interfaces.Repositories;

namespace data.Repositories.Base;

public class Repository<T> : IRepository<T> where T : Entity, new()
{
    public Repository()
    {
        
    }
    
    public Task<T> PostAsync(T model, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public Task<T> PostAsync(IEnumerable<T> models, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public Task<T> DeleteAsync(T model, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public Task<T> DeleteAsync(int id, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public Task<T> DeleteAsync(IEnumerable<int> ids, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public Task<T> PatchAsync(int id, T model, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public Task<T> PutAsync(int id, T model, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetAsync(int id, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> GetAsync(CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public Task<IPage<T>> GetAscAsync(int index, int count, string sortBy, string filter, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public Task<IPage<T>> GetDescAsync(int index, int count, string sortBy, string filter, CancellationToken token = default)
    {
        throw new NotImplementedException();
    }

    public Task<bool> Exists(int id, CancellationToken token)
    {
        throw new NotImplementedException();
    }
}