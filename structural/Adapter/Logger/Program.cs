using Logger;

var externalLogger = new ExternalLogger();

var logger = new LoggerAdapter(externalLogger);

logger.Log("Logging Using the Adapter Pattern");
