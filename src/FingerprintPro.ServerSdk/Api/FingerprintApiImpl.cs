using FingerprintPro.ServerSdk.Client;
using FingerprintPro.ServerSdk.Model;

namespace FingerprintPro.ServerSdk.Api;

public class FingerprintApi : IFingerprintApi
{
    // TODO Should come from swagger
    public const string Version = "5.0.0";

    private readonly ApiClient _apiClient;

    private ExceptionFactory _exceptionFactory = (name, response) => null;

    /// <summary>
    /// Gets or sets the configuration object
    /// </summary>
    /// <value>An instance of the Configuration</value>
    public Configuration Configuration { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="FingerprintApi"/> class
    /// using Configuration object
    /// </summary>
    /// <param name="configuration">An instance of Configuration</param>
    /// <returns></returns>
    public FingerprintApi(Configuration configuration)
    {
        Configuration = configuration;
        _apiClient = new ApiClient(configuration);

        ExceptionFactory = Configuration.DefaultExceptionFactory!;
    }

    /// <summary>
    /// Gets the base path of the API client.
    /// </summary>
    /// <value>The base path</value>
    public string GetBasePath()
    {
        return this._apiClient.RestClient.Options.BaseUrl!.ToString();
    }

    /// <summary>
    /// Provides a factory method hook for the creation of exceptions.
    /// </summary>
    public ExceptionFactory ExceptionFactory
    {
        get
        {
            if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
            {
                throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
            }
            return _exceptionFactory;
        }
        set { _exceptionFactory = value; }
    }

    public EventResponse GetEvent(string requestId)
    {
        throw new NotImplementedException();
    }

    public ApiResponse<EventResponse> GetEventWithHttpInfo(string requestId)
    {
        throw new NotImplementedException();
    }

    public Response GetVisits(string visitorId, string requestId = null, string linkedId = null, int? limit = null,
        string paginationKey = null, long? before = null)
    {
        throw new NotImplementedException();
    }

    public ApiResponse<Response> GetVisitsWithHttpInfo(string visitorId, string requestId = null, string linkedId = null, int? limit = null,
        string paginationKey = null, long? before = null)
    {
        throw new NotImplementedException();
    }

    public Task<EventResponse> GetEventAsync(string requestId)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<EventResponse>> GetEventAsyncWithHttpInfo(string requestId)
    {
        throw new NotImplementedException();
    }

    public Task<Response> GetVisitsAsync(string visitorId, string requestId = null, string linkedId = null, int? limit = null,
        string paginationKey = null, long? before = null)
    {
        throw new NotImplementedException();
    }

    public Task<ApiResponse<Response>> GetVisitsAsyncWithHttpInfo(string visitorId, string requestId = null, string linkedId = null, int? limit = null,
        string paginationKey = null, long? before = null)
    {
        throw new NotImplementedException();
    }
}