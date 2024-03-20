using domain.Models.Base;

namespace domain.Models;

public class User : Person
{
    public DateTime BirtDate { get; set; }
}