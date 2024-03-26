using domain.Models;
using interfaces.Repositories;

namespace application.UseCases.Users
{
    public class GetUserUseCase
    {
        private readonly IRepository<User> _repository;
        private readonly int _id;

        public GetUserUseCase(IRepository<User> repository, int id)
        {
            _id = id > 0 ? id : throw new ArgumentNullException(nameof(id));
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public Task<User> InvokeAsync()
        {
            return _repository.GetAsync(_id);
        }
    }
}

/**public class GetUserUseCase(IRepository<User> repository, int id)
    {
        private readonly IRepository<User> _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        private readonly int _id = id > 0 ? id : throw new ArgumentNullException(nameof(id));

        public Task<User> InvokeAsync()
        {
            return _repository.GetAsync(_id);
        }
    }**/
