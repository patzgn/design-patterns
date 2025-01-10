using Ducks.Models.Ducks;
using Ducks.Models.Turkeys;

namespace Ducks.Adapters;

public class TurkeyAdapter(ITurkey turkey) : IDuck
{
    public void Fly()
    {
        for (int i = 0; i < 5; i++)
        {
            turkey.Fly();
        }
    }

    public void Quack() =>
        turkey.Gobble();
}
