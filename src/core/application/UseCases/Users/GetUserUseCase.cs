using domain.Models;
using interfaces.Repositories;

namespace application.UseCases.Users
{
    public class GetUserUseCase(IRepository<User> repository, int id)
    {
        private readonly IRepository<User> _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        private readonly int _id = id > 0 ? id : throw new ArgumentNullException(nameof(id));

        public Task<User> InvokeAsync()
        {
            return _repository.GetAsync(_id);
        }
    }
}
