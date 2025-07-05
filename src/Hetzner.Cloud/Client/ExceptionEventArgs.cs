using System;

namespace Hetzner.Cloud.Client
{
    /// <summary>
    /// Useful for tracking server health
    /// </summary>
    internal class ExceptionEventArgs : EventArgs
    {
        /// <summary>
        /// The ApiResponse
        /// </summary>
        public Exception Exception { get; }

        /// <summary>
        /// The ExceptionEventArgs
        /// </summary>
        /// <param name="exception"></param>
        public ExceptionEventArgs(Exception exception)
        {
            Exception = exception;
        }
    }
}
