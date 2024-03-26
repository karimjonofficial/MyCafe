using application.UseCases.Users;
using domain.Models;
using interfaces.Repositories;

namespace application_tests.UseCases.Users
{
    public class PatchUserUseCaseTest
    {
        [Fact]
        void PatchUser_PatchNoRepoAndNoUser_Throws()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                PatchUserUseCase useCase = new PatchUserUseCase(null, null);
            });
        }

        [Fact]
        void PatchUser_PatchNoRepo_Throws()
        {
            User user = new User();

            Assert.Throws<ArgumentNullException>(() =>
            {
                PatchUserUseCase useCase = new PatchUserUseCase(null, user);
            });
        }

        [Fact]
        void PatchUser_PatchNoUser_Throws()
        {
            IRepository<User> repo = Mock.Of<IRepository<User>>();

            Assert.Throws<ArgumentNullException>(() =>
            {
                PatchUserUseCase useCase = new PatchUserUseCase(repo, null);
            });
        }

        [Fact]
        void PatchUser_PatchUser_ReturnsUserWithId()
        {
            int expected = 1;
            User user = new User()
            {
                Id = expected
            };
            Mock<IRepository<User>> mock = new();
            mock.Setup(x => x.PatchAsync(user, default))
                .ReturnsAsync(user);
            PatchUserUseCase sut = new PatchUserUseCase(mock.Object, user);

            Assert.Equal(expected, sut.InvokeAsync().Id);

        }
    }
}
