using System;
using Serilog;

namespace ServiceStack.Logging.Serilog
{
    /// <summary>
    /// Wrapper over the Serilog 1.0 and above logger 
    /// </summary>
    public class SerilogLogger : ILog
    {
        private readonly ILogger _seriLogger;

        public SerilogLogger(ILogger seriLogger)
        {
            if (seriLogger == null) throw new ArgumentNullException("seriLogger");
            _seriLogger = seriLogger;
        }

        public void Debug(object message)
        {
            _seriLogger.Debug(string.Empty, message);
        }

        public void Debug(object message, Exception exception)
        {
            _seriLogger.Debug(exception, string.Empty, message);
        }

        public void DebugFormat(string format, params object[] args)
        {
            _seriLogger.Debug(format, args);
        }

        public void Error(object message)
        {
            _seriLogger.Error(string.Empty, message);
        }

        public void Error(object message, Exception exception)
        {
            _seriLogger.Error(exception, string.Empty, message);
        }

        public void ErrorFormat(string format, params object[] args)
        {
            _seriLogger.Error(format, args);
        }

        public void Fatal(object message)
        {
            _seriLogger.Fatal(string.Empty, message);
        }

        public void Fatal(object message, Exception exception)
        {
            _seriLogger.Fatal(exception, string.Empty, message);
        }

        public void FatalFormat(string format, params object[] args)
        {
            _seriLogger.Fatal(format, args);
        }

        public void Info(object message)
        {
            _seriLogger.Information(string.Empty, message);
        }

        public void Info(object message, Exception exception)
        {
            _seriLogger.Information(exception, string.Empty, message);
        }

        public void InfoFormat(string format, params object[] args)
        {
            _seriLogger.Information(format, args);
        }

        public void Warn(object message)
        {
            _seriLogger.Warning(string.Empty, message);
        }

        public void Warn(object message, Exception exception)
        {
            _seriLogger.Warning(exception, string.Empty, message);
        }

        public void WarnFormat(string format, params object[] args)
        {
            _seriLogger.Warning(format, args);
        }

        public bool IsDebugEnabled { get; private set; }
    }
}
