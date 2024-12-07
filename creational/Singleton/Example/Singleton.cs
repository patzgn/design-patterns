namespace Example;

public class Singleton
{
    private static Singleton? _instance;
    private static readonly object Lock = new();

    private Singleton()
    {
    }

    public static Singleton Instance
    {
        get
        {
            lock (Lock)
            {
                if (_instance is null)
                {
                    _instance = new Singleton();
                }

                return _instance;
            }
        }
    }
}
