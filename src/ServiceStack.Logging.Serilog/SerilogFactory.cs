using System;
using Serilog;

namespace ServiceStack.Logging.Serilog
{
    /// <summary>
    /// ILogFactory that creates an Serilog ILog logger
    /// </summary>
    public class SerilogFactory : ILogFactory
    {
        private readonly ILogger _log;

        /// <summary>
        /// Initializes a new instance of the <see cref="SerilogFactory"/> class.
        /// </summary>
        public SerilogFactory(ILogger log)
        {
            _log = log;
        }

        /// <summary>
        /// Gets the logger.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public ILog GetLogger(Type type)
        {
            return new SerilogLogger(_log.ForContext(type));
        }

        /// <summary>
        /// Gets the logger.
        /// </summary>
        /// <param name="typeName">Name of the type.</param>
        /// <returns></returns>
        public ILog GetLogger(string typeName)
        {
            try
            {
                var type = Type.GetType(typeName);
                return new SerilogLogger(_log.ForContext(type));
            }
            catch (Exception)
            {
                // if the type is not valid, just return a non-context logger
                return new SerilogLogger(_log); 
            }
        }
    }
}
