namespace Logger;

public class ExternalLogger
{
    public void LogMessage(string message)
    {
        Console.WriteLine($"ExternalLogger - Logged Message: {message}");
    }
}
