using System.Text.Json.Serialization;

namespace domain.Models.Base;

public class NamedEntity : DescriptedEntity
{
    public string Name { get; set; }
}