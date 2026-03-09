namespace DiscountCalculator.Discounts;

public class EmployeeDiscountStrategy : IDiscountStrategy
{
    public double ApplyDiscount(double price)
    {
        return price * 0.60;
    }
}
