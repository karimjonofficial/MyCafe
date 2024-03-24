using domain.Models;
using interfaces.Repositories;

namespace application.UseCases;

public class PostUserUseCase(IRepository<User> repository, User user)
{   
    private readonly IRepository<User> _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    private readonly User _user = user ?? throw new ArgumentNullException(nameof(user));

    public Task<User> InvokeAsync()
    {
        return _repository.PostAsync(_user);
    }
}