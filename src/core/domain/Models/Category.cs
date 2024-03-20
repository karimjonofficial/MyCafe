using System.Text.Json.Serialization;
using domain.Models.Base;

namespace domain.Models;

public class Category : NamedEntity
{
    public IEnumerable<Product> Products { get; set; }
}