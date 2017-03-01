using System;

namespace Common.Logger.Interface
{
    public interface ILoggerWrapper
    {
        void LogInfo(string message);

        void LogInfo(string message, Exception exception);

        void LogError(string message);

        void LogError(string error, Exception exception);
    }
}