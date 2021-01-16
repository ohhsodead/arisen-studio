using System;

namespace ModioX.Net
{
    public class FtpException : Exception
    {
        public FtpException(int error, string message)
            : base(message)
        {
            _error = error;
        }

        private readonly int _error;

        public int ErrorCode
        {
            get { return _error; }
        }
    }
}
