namespace ConfigurationManager;

public class ConfigurationManager
{
    private static ConfigurationManager? _instance;

    private static readonly object Lock = new();

    private readonly Dictionary<string, string> _settings;

    private ConfigurationManager()
    {
        _settings = new Dictionary<string, string>();
    }

    public static ConfigurationManager Instance
    {
        get
        {
            lock (Lock)
            {
                if (_instance is null)
                {
                    _instance = new ConfigurationManager();
                }

                return _instance;
            }
        }
    }

    public void Set(string key, string value)
    {
        _settings.TryAdd(key, value);
    }

    public string Get(string key)
    {
        return _settings.GetValueOrDefault(key, "There is no configuration settings for this key.");
    }

    public void PrintAll()
    {
        Console.WriteLine("Current configuration:");
        foreach (var setting in _settings)
        {
            Console.WriteLine($"{setting.Key}: {setting.Value}");
        }
    }
}
