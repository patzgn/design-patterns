namespace DiscountCalculator.Discounts;

public class VipDiscountStrategy : IDiscountStrategy
{
    public double ApplyDiscount(double price)
    {
        return price * 0.80;
    }
}
