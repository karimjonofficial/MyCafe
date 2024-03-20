using System.Text.Json.Serialization;

namespace domain.Models.Base;

public class Person : NamedEntity
{
    public string Surname { get; set; }
    public string Patronymic { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
}