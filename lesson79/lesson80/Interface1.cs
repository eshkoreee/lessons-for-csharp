using System;
using System.Collections.Generic;
using System.Text;

namespace lesson80
{
    public interface ILogger
    {
        void Log(LogLevel logLevel, string message);
        int Sum(int a,int b)
        {
            return a + b;
        }
    }
}
