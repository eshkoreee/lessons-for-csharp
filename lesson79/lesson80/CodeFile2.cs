namespace lesson80
{
    public class ConsoleLogger : ILogger
    {
        public void Log(LogLevel logLevel, string message)
        {
            switch (logLevel)
            {
                case LogLevel.Debug: Console.ForegroundColor = ConsoleColor.Green; break;

                case LogLevel.Info: Console.ForegroundColor = ConsoleColor.White; break;

                case LogLevel.Warning: Console.ForegroundColor = ConsoleColor.Yellow; break;

                case LogLevel.Error: case LogLevel.Fatal: Console.ForegroundColor = ConsoleColor.Red; break;
                default:
                    break;
            }
            Console.WriteLine($"{DateTime.Now}: {message}");
            Console.ResetColor();
        }
    }
}