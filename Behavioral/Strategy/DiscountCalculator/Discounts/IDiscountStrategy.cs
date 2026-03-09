namespace DiscountCalculator.Discounts;

public interface IDiscountStrategy
{
    double ApplyDiscount(double price);
}
