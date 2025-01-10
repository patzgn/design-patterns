using Ducks.Models.Ducks;
using Ducks.Models.Turkeys;

namespace Ducks.Adapters;

public class DuckAdapter(IDuck duck) : ITurkey
{
    private readonly Random _random = new();

    public void Fly()
    {
        if (_random.Next(5) == 0)
        {
            duck.Fly();
        }
    }

    public void Gobble() =>
        duck.Quack();
}
