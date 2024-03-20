using domain.Models.Base;

namespace domain.Models;

public class PaymentCheck : DescriptedEntity
{
    public User User { get; set; }
    public IEnumerable<Product> Products { get; set; }
    public IEnumerable<int> Amounts { get; set; }
    public decimal Price { get; set; }
    public DateTimeOffset DateTime { get; set; }
    public decimal Gratuity { get; set; }
    public decimal GratuityPercent { get; set; }
    public decimal EndPrice { get; set; }
}