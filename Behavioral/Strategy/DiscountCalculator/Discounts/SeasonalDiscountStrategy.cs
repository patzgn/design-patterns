namespace DiscountCalculator.Discounts;

public class SeasonalDiscountStrategy : IDiscountStrategy
{
    public double ApplyDiscount(double price)
    {
        return price * 0.90;
    }
}
