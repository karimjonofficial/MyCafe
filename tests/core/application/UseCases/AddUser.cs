using System.Collections.ObjectModel;
using domain.Models;

namespace application.UseCases;

public class AddUser
{
    ObservableCollection<User> collection = new ObservableCollection<User>();
    
    
    [Fact]
    void AddUserTest()
    {
        
    }
}