using Microsoft.Extensions.Logging;
// ReSharper disable TemplateIsNotCompileTimeConstantProblem
namespace Simple_Logger
{
    public interface ILoggerAdapter<T>
    {
        void LogDebug(string msg);
        void LogDebug<T0>(string msg,T0 arg0);
        void LogDebug<T0, T1>(string msg,T0 arg0, T1 arg1);
        void LogDebug<T0, T1, T2>(string msg,T0 arg0, T1 arg1, T2 arg2);
        void LogDebug<T0, T1, T2, T3>(string msg,T0 arg0, T1 arg1, T2 arg2, T3 arg3);
        void LogInformation(string msg);
        void LogInformation<T0>(string msg,T0 arg0);
        void LogInformation<T0, T1>(string msg,T0 arg0, T1 arg1);
        void LogInformation<T0, T1, T2>(string msg,T0 arg0, T1 arg1, T2 arg2);
        void LogInformation<T0, T1, T2, T3>(string msg,T0 arg0, T1 arg1, T2 arg2, T3 arg3);
        void LogWarning(string msg);
        void LogWarning<T0>(string msg,T0 arg0);
        void LogWarning<T0, T1>(string msg,T0 arg0, T1 arg1);
        void LogWarning<T0, T1, T2>(string msg,T0 arg0, T1 arg1, T2 arg2);
        void LogWarning<T0, T1, T2, T3>(string msg,T0 arg0, T1 arg1, T2 arg2, T3 arg3);
        void LogError(string msg);
        void LogError<T0>(string msg,T0 arg0);
        void LogError<T0, T1>(string msg,T0 arg0, T1 arg1);
        void LogError<T0, T1, T2>(string msg,T0 arg0, T1 arg1, T2 arg2);
        void LogError<T0, T1, T2, T3>(string msg,T0 arg0, T1 arg1, T2 arg2, T3 arg3);
    }

    public class LoggerAdapter<T>: ILoggerAdapter<T>
    {
        private readonly ILogger<T> _logger;
       
        public LoggerAdapter(ILogger<T> logger)
        {
            _logger = logger;
        }

        public void LogDebug(string msg)
        {
            if(_logger.IsEnabled(LogLevel.Debug))
                _logger.LogDebug(msg);
        }

        public void LogDebug<T0>(string msg,T0 arg0)
        {
            if(_logger.IsEnabled(LogLevel.Debug))
                _logger.LogDebug(msg,arg0);
        }

        public void LogDebug<T0, T1>(string msg,T0 arg0, T1 arg1)
        {
            if(_logger.IsEnabled(LogLevel.Debug))
                _logger.LogDebug(msg,arg0, arg1);
        }

        public void LogDebug<T0, T1, T2>(string msg,T0 arg0, T1 arg1, T2 arg2)
        {
            if(_logger.IsEnabled(LogLevel.Debug))
                _logger.LogDebug(msg,arg0, arg1, arg2);
        }

        public void LogDebug<T0, T1, T2, T3>(string msg,T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            if(_logger.IsEnabled(LogLevel.Debug))
                _logger.LogDebug(msg,arg0, arg1, arg2, arg3);
        }

        public void LogInformation(string msg)
        {
            if(_logger.IsEnabled(LogLevel.Information))
                _logger.LogInformation(msg);
        }

        public void LogInformation<T0>(string msg,T0 arg0)
        {
            if(_logger.IsEnabled(LogLevel.Information))
                _logger.LogInformation(msg,arg0);
        }

        public void LogInformation<T0, T1>(string msg,T0 arg0, T1 arg1)
        {
            if(_logger.IsEnabled(LogLevel.Information))
                _logger.LogInformation(msg,arg0, arg1);
        }

        public void LogInformation<T0, T1, T2>(string msg,T0 arg0, T1 arg1, T2 arg2)
        {
            if(_logger.IsEnabled(LogLevel.Information))
                _logger.LogInformation(msg,arg0, arg1, arg2);
        }

        public void LogInformation<T0, T1, T2, T3>(string msg,T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            if(_logger.IsEnabled(LogLevel.Information))
                _logger.LogInformation(msg,arg0, arg1, arg2, arg3);
        }

        public void LogWarning(string msg)
        {
            if(_logger.IsEnabled(LogLevel.Warning))
                _logger.LogWarning(msg);
        }

        public void LogWarning<T0>(string msg,T0 arg0)
        {
            if(_logger.IsEnabled(LogLevel.Warning))
                _logger.LogWarning(msg,arg0);
        }

        public void LogWarning<T0, T1>(string msg,T0 arg0, T1 arg1)
        {
            if(_logger.IsEnabled(LogLevel.Warning))
                _logger.LogWarning(msg,arg0, arg1);
        }

        public void LogWarning<T0, T1, T2>(string msg,T0 arg0, T1 arg1, T2 arg2)
        {
            if(_logger.IsEnabled(LogLevel.Warning))
                _logger.LogWarning(msg,arg0, arg1, arg2);
        }

        public void LogWarning<T0, T1, T2, T3>(string msg,T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            if(_logger.IsEnabled(LogLevel.Warning))
                _logger.LogWarning(msg,arg0, arg1, arg2, arg3);
        }

        public void LogError(string msg)
        {
            if(_logger.IsEnabled(LogLevel.Error))
                _logger.LogError(msg);
        }

        public void LogError<T0>(string msg,T0 arg0)
        {
            if(_logger.IsEnabled(LogLevel.Error))
                _logger.LogError(msg,arg0);
        }

        public void LogError<T0, T1>(string msg,T0 arg0, T1 arg1)
        {
            if(_logger.IsEnabled(LogLevel.Error))
                _logger.LogError(msg,arg0, arg1);
        }

        public void LogError<T0, T1, T2>(string msg,T0 arg0, T1 arg1, T2 arg2)
        {
            if(_logger.IsEnabled(LogLevel.Error))
                _logger.LogError(msg,arg0, arg1, arg2);
        }

        public void LogError<T0, T1, T2, T3>(string msg,T0 arg0, T1 arg1, T2 arg2, T3 arg3)
        {
            if(_logger.IsEnabled(LogLevel.Error))
                _logger.LogError(msg,arg0, arg1, arg2, arg3);
        }
    }

}