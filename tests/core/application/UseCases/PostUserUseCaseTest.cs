using application.UseCases;
using domain.Models;
using interfaces.Repositories;

namespace application_tests.UseCases;

public class PostUserUseCaseTest
{
    [Fact]
    void PostUser_PostNoRepoAndNoUser_Throws()
    {
        Assert.Throws<ArgumentNullException>(() =>
        {
            PostUserUseCase useCase = new PostUserUseCase(null, null);
        });
    }

    [Fact]
    void PostUser_PostNoRepo_Throws()
    {
        User user = new User();

        Assert.Throws<ArgumentNullException>(() =>
        {
            PostUserUseCase useCase = new PostUserUseCase(null, user);
        });
    }

    [Fact]
    void PostUser_PostNoUser_Throws()
    {
        IRepository<User> repo = Mock.Of<IRepository<User>>();

        Assert.Throws<ArgumentNullException>(() =>
        {
            PostUserUseCase useCase = new PostUserUseCase(repo, null);
        });
    }

    [Fact]
    public async void PostUser_PostUser_ReturnsUserWithId()
    {
        int expected = 1;
        User user = new User();
        Mock<IRepository<User>> mock = new();
        mock.Setup(x => x.PostAsync(user, default))
            .ReturnsAsync(value: new User
            {
                Id = expected
            });
        PostUserUseCase sut = new PostUserUseCase(repository: mock.Object, user: user);

        User user1 = await sut.InvokeAsync();
        Assert.Equal(expected, user1.Id);
    }
}
