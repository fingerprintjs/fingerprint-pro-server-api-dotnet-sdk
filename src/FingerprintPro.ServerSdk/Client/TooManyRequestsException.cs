namespace FingerprintPro.ServerSdk.Client
{
    /// <summary>
    /// API Exception thrown in case of TooManyRequests error.
    /// Contains useful details about the error.
    /// </summary>
    public class TooManyRequestsException : ApiException
    {
        // TooManyRequests code is not available in HttpStatusCode enum in some .NET versions
        public const int TooManyRequestsCode = 429;

        /// <summary>
        /// Time in seconds to wait before next request.
        /// </summary>
        public int? RetryAfter { get; private set; }

        public TooManyRequestsException(string message, int? retryAfter) : base(TooManyRequestsCode, message)
        {
            this.RetryAfter = retryAfter;
        }
    }
}