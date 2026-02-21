 namespace lesson80
{
    /*
     * реальзация интерфейса по умолчанию с# 8.0+
     */
     class Program
    {
        static void Main(string[] args)
        {
            ILogger consoleLogger = new ConsoleLogger();
            consoleLogger.Log(LogLevel.Debug, "Some event");
            consoleLogger.Log(LogLevel.Warning, "Some warning");
            consoleLogger.Log(LogLevel.Fatal, "Some event");
        }
    }
}
