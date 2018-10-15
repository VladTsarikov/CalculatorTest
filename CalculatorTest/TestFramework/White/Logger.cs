using System;
using NLog;

namespace TestFramework.white
{
    public class Logger
    {
        public static NLog.Logger Log = LogManager.GetCurrentClassLogger();
        private static Logger _instance;

        private Logger()
        {
        }

        public static Logger GetInstance()
        {
            return _instance ?? (_instance = new Logger());
        }

        public static void LogStep(LogLevel logLevel,string message)
        {
           Log.
        }

        public void Info(string message)
        {
            Log.Info(message);
        }

        public void Debug(string message)
        {
            Log.Debug(message);
        }

        public void Error(string message)
        {
            Log.Error(message);
        }

        public void Fatal(string message)
        {
            Log.Fatal(message);
        }

        public void Step(int step)
        {
            Log.Info($"----------=[{step}]=----------");
        }
    }
}
