using application.UseCases.Users;
using domain.Models;
using interfaces.Repositories;

namespace application_tests.UseCases.Users
{
    public class PutUserUseCaseTest
    {
        [Fact]
        void PutUser_PutNoRepoAndNoUser_Throws()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                PutUserUseCase useCase = new PutUserUseCase(null, null);
            });
        }

        [Fact]
        void PutUser_PutNoRepo_Throws()
        {
            User user = new User();

            Assert.Throws<ArgumentNullException>(() =>
            {
                PutUserUseCase useCase = new PutUserUseCase(null, user);
            });
        }

        [Fact]
        void PutUser_PutNoUser_Throws()
        {
            IRepository<User> repo = Mock.Of<IRepository<User>>();

            Assert.Throws<ArgumentNullException>(() =>
            {
                PutUserUseCase useCase = new PutUserUseCase(repo, null);
            });
        }

        [Fact]
        void PutUser_PutUser_ReturnsUserWithId()
        {
            int expected = 1;
            User user = new User() { Id = expected };
            Mock<IRepository<User>> mock = new();
            mock.Setup(x => x.PutAsync(user, default))
                .ReturnsAsync(new User
                {
                    Id = expected
                });
            PutUserUseCase sut = new PutUserUseCase(mock.Object, user);

            Assert.Equal(expected, sut.InvokeAsync().Id);
        }
    }
}
