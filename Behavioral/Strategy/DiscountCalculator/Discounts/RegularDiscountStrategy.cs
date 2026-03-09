namespace DiscountCalculator.Discounts;

public class RegularDiscountStrategy : IDiscountStrategy
{
    public double ApplyDiscount(double price)
    {
        return price;
    }
}
