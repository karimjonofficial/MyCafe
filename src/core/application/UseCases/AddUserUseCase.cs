using System.Collections.ObjectModel;
using domain.Models;
using interfaces.Repositories;

namespace application.UseCases;

public class AddUserUseCase(IRepository<User> repository, User model)
{
    public async Task<User> Invoke()
    {
        return await repository.PostAsync(model);
    }
}