using application.UseCases.Users;
using domain.Models;
using interfaces.Repositories;

namespace application_tests.UseCases.Users
{
    public class GetUserUseCaseTest
    {
        [Fact]
        void GetUser_GetNoRepo_Throws()
        {
            User user = new User();

            Assert.Throws<ArgumentNullException>(() =>
            {
                GetUserUseCase use1 = new(null, 0);
                GetUserUseCase useCase = new GetUserUseCase(null, 1);
            });
        }

        [Fact]
        void GetUser_GetNoUser_Throws()
        {
            IRepository<User> repo = Mock.Of<IRepository<User>>();

            Assert.Throws<ArgumentNullException>(() =>
            {
                GetUserUseCase useCase = new GetUserUseCase(repo, 0);
            });
        }

        [Fact]
        void GetUser_GetUser_ReturnsUserWithId()
        {
            int expected = 1;
            Mock<IRepository<User>> mock = new();
            mock.Setup(x => x.GetAsync(expected, default))
                .ReturnsAsync(new User{Id = expected});
            GetUserUseCase sut = new GetUserUseCase(mock.Object, expected);

            Assert.Equal(expected, sut.InvokeAsync().Id);
        }
    }
}
