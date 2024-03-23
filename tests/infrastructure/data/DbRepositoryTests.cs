using System.Collections.ObjectModel;
using data.Repositories.Base;
using domain.Models;

namespace data_tests;

public class DbRepositoryTests
{
    private readonly ObservableCollection<User> _db;
    private DbRepository<User> _repository;

    private User user1 = new User() { Id = 1 };

    public DbRepositoryTests()
    {
        _db =  new ObservableCollection<User>();
        _repository = new DbRepository<User>(_db);
    }
    
    [Fact]
    private void CreateNewRepo()
    {
        _repository = new DbRepository<User>(_db);
        Assert.NotNull(_repository);
    }

    [Fact]
    private void PostNewUser()
    {
        _repository.PostAsync(user1);
    }
}