using Caliburn.Micro;
using Microsoft.Extensions.Logging;

namespace PierceAuto.Client.Utils;

internal class LoggingAdapter<T>(ILogger<T> logger) : ILog
{
    public void Info(string format, params object[] args)
    {
        logger.LogInformation(format, args);
    }

    public void Warn(string format, params object[] args)
    {
        logger.LogWarning(format, args);
    }

    public void Error(Exception exception)
    {
        logger.LogError(exception, exception.Message);
    }
}