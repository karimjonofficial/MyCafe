using domain.Models.Base;

namespace domain.Models;

public class Table : NamedEntity
{
    public User Servant { get; set; }
    public bool IsAvailable { get; set; }
}