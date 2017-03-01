using System;
using Common.Logger.Interface;
using log4net;

namespace Common.Logger
{
    public class LoggerWrapper : ILoggerWrapper
    {
        private readonly ILog log4NetAdapter;

        public LoggerWrapper(Type type)
        {
            log4NetAdapter = LogManager.GetLogger(type);
        }

        public void LogInfo(string message)
        {
            log4NetAdapter.Info(message);
        }

        public void LogInfo(string message, Exception exception)
        {
            log4NetAdapter.Info(message, exception);
        }

        public void LogError(string message)
        {
            log4NetAdapter.Error(message);
        }

        public void LogError(string error, Exception exception)
        {
            log4NetAdapter.Error(error, exception);
        }
    }
}
