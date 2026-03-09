using DiscountCalculator.Discounts;

namespace DiscountCalculator;

public class OrderProcessor
{
    private IDiscountStrategy _discountStrategy;

    public OrderProcessor(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public double CalculateFinalPrice(double price)
    {
        return _discountStrategy.ApplyDiscount(price);
    }
}
