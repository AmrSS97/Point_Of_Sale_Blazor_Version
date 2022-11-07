using System;

namespace Loggers
{
    public interface ILogger
    {
        /// <summary>
        /// Log the specified message as Informations .
        /// </summary>
        /// <param name="message">The message.</param>
        void Info(string message);

        /// <summary>
        /// Log the specified message as Debug.
        /// </summary>
        /// <param name="message">The message.</param>
        void Debug(string message);

        /// <summary>
        /// Log the specified message as Error.
        /// </summary>
        /// <param name="message">The message.</param>
        void Error(string message);

        /// <summary>
        /// Log the specified exception as Error.
        /// </summary>
        /// <param name="exception">The exception.</param>
        /// <param name="arguments">The arguments.</param>
        void Error(Exception exception);


        /// <summary>
        /// Log the specified message and exception.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="exception">The exception.</param>
        void Error(string message, Exception exception);
    }
}
