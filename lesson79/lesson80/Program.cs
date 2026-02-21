namespace lesson80
{
    /*
     * реализация интерфейсов по умолчанию в С# 8.0+
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger consoleLogger = new ConsoleLogger();
            consoleLogger.Foo();
             consoleLogger.Log(LogLevel.Debug, "some event");
             consoleLogger.Log(LogLevel.Warning, "some warning");
             consoleLogger.Log(LogLevel.Fatal, "some fatal error");
            
        }
    }
}
