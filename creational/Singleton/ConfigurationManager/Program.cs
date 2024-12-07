// See https://aka.ms/new-console-template for more information

var config1 = ConfigurationManager.ConfigurationManager.Instance;
var config2 = ConfigurationManager.ConfigurationManager.Instance;

config1.Set("AppName", "My Application");
config1.Set("Version", "1.0.0");
config1.Set("Theme", "Light");

Console.WriteLine($"AppName: {config2.Get("AppName")}");
config2.PrintAll();

Console.WriteLine("\nTesting with multiple threads...");
Parallel.Invoke(
    () => config1.Set("Database", "SQL Server"),
    () => config2.Set("Cache", "Enabled"),
    () => config1.PrintAll()
);
