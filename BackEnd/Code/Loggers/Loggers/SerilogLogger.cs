using Serilog;
using Serilog.Core;
using System;
using System.IO;

namespace Loggers
{
    public class SerilogLogger : ILogger
    {
        private readonly Logger _logger;
        private readonly string _fileName;

        public SerilogLogger(string filename)
        {
            _fileName = filename;
            _logger = CreateLogger();          
        }
        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Error(string message)
        {
            _logger.Error(message);
        }

        public void Error(Exception exception)
        {
            _logger.Error(exception, string.Empty);
        }

        public void Error(string message, Exception exception)
        {
            _logger.Error(exception, message);
        }

        public void Info(string message)
        {
            _logger.Information(message);
        }


        private Logger CreateLogger()
        {
            string folderName = "Logs";
            string fileName = $"{folderName}{Path.DirectorySeparatorChar}{_fileName}-{Guid.NewGuid()}-.log";
            Logger logger = new LoggerConfiguration()
                                     .WriteTo.File(fileName, rollingInterval: RollingInterval.Day)
                                     .CreateLogger();
            return logger;
        }
    }
}
