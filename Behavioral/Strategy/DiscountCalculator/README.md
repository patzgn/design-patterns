**Task:** Extract the discount logic into a Strategy pattern. Each discount type should be a separate class. Add a new "seasonal" type with a 10% discount — without modifying the `OrderProcessor` class.

```csharp
public class OrderProcessor
{
    private string _customerType; // "regular", "vip", "employee"

    public OrderProcessor(string customerType)
    {
        _customerType = customerType;
    }

    public double CalculateFinalPrice(double price)
    {
        if (_customerType == "vip")
            return price * 0.80;
        else if (_customerType == "employee")
            return price * 0.60;
        else
            return price;
    }
}
```
