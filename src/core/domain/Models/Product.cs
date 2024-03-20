using System.Text.Json.Serialization;
using domain.Models.Base;

namespace domain.Models;

public class Product : NamedEntity
{
    public decimal Price { get; set; }
}