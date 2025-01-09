namespace Logger;

public class LoggerAdapter(ExternalLogger logger) : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine("LoggerAdapter: I translate the call to the ExternalLogger.");
        logger.LogMessage(message);
    }
}
