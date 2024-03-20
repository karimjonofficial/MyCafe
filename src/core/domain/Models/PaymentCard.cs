namespace domain.Models;

public class PaymentCard
{
    public User User { get; set; }
    public IEnumerable<Product> Products { get; set; }
    public IEnumerable<int> Amounts { get; set; }
    public decimal Price { get; set; }
    public decimal Gratuity { get; set; }
    public decimal GratuityPercent { get; set; }
    public decimal EndPrice { get; set; }
}