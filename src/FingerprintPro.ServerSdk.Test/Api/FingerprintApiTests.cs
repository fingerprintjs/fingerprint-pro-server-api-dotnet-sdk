/* 
 * Fingerprint Pro Server API
 *
 * Fingerprint Pro Server API allows you to get information about visitors and about individual events in a server environment. This API can be used for data exports, decision-making, and data analysis scenarios.
 *
 * OpenAPI spec version: 3
 * Contact: support@fingerprint.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Net;
using System.Text;
using FingerprintPro.ServerSdk.Api;
using FingerprintPro.ServerSdk.Client;
using FingerprintPro.ServerSdk.Model;
using FingerprintPro.ServerSdk.Test.Utils;

namespace FingerprintPro.ServerSdk.Test.Api
{
    /// <summary>
    ///  Class for testing FingerprintApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FingerprintApiTests
    {
        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            Console.WriteLine("Starting server...");

            // Start simple HTTP server
            _mockServer = new HttpListener();
            _mockServer.Prefixes.Add(_serverUrl);
            _mockServer.Start();

            _mockResponseHeaders = new WebHeaderCollection();
            _mockResponseStatusCode = (int)HttpStatusCode.OK;

            HandleConnection().GetAwaiter();

            Console.WriteLine("Started server");

            var config = new Configuration("123")
            {
                BasePath = _serverUrl
            };

            _instance = new FingerprintApi(config);
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {
            Console.WriteLine("Closing server.");

            _requests.Clear();
            _mockServer!.Close();
        }

        private const string _serverUrl = "http://127.0.0.1:8080/";

        private FingerprintApi? _instance;

        private HttpListener? _mockServer;

        private readonly List<HttpListenerRequest> _requests = new List<HttpListenerRequest>();

        private byte[]? _mockResponseBytes;

        private WebHeaderCollection? _mockResponseHeaders;

        private int? _mockResponseStatusCode;

        private void SetupMockResponse(string fileName)
        {
            _mockResponseBytes = MockLoader.Load(fileName);
        }

        private async Task HandleConnection()
        {
            while (_mockServer != null)
            {
                var ctx = await _mockServer.GetContextAsync();

                // Peel out the requests and response objects
                var req = ctx.Request;
                var resp = ctx.Response;

                _requests.Add(req);

                // Print out some info about the request
                Console.WriteLine(req.Url?.ToString());
                Console.WriteLine(req.HttpMethod);
                Console.WriteLine(req.UserHostName);
                Console.WriteLine(req.UserAgent);
                Console.WriteLine();

                if (_mockResponseBytes != null)
                {
                    resp.ContentType = "application/json";
                    resp.ContentEncoding = Encoding.UTF8;
                    resp.ContentLength64 = _mockResponseBytes.LongLength;
                    resp.StatusCode = _mockResponseStatusCode ?? (int)HttpStatusCode.OK;

                    foreach (var key in _mockResponseHeaders.AllKeys)
                    {
                        resp.AddHeader(key, _mockResponseHeaders[key]);
                    }

                    await resp.OutputStream.WriteAsync(_mockResponseBytes);
                }

                resp.Close();
            }
        }

        /// <summary>
        /// Test an instance of FingerprintApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.That(_instance, Is.InstanceOf(typeof(FingerprintApi)), "instance is a FingerprintApi");
        }

        /// <summary>
        /// Test GetEvent
        /// </summary>
        [Test]
        public void GetEventTest()
        {
            SetupMockResponse("get_event.json");

            const string requestId = "0KSh65EnVoB85JBmloQK";
            var response = _instance!.GetEvent(requestId);

            Assert.Multiple(() =>
            {
                Assert.That(_requests, Has.Count.EqualTo(1));
                Assert.That(response, Is.InstanceOf<EventResponse>(), "response is EventResponse");

                var request = _requests[0];

                Assert.That(request.Headers.Get("User-Agent"),
                    Is.EqualTo($"Swagger-Codegen/{FingerprintApi.Version}/csharp"));
                Assert.That(request.Url?.ToString(),
                    Is.EqualTo(
                        $"http://127.0.0.1:8080/events/{requestId}?ii=fingerprint-pro-server-api-dotnet-sdk%2f{FingerprintApi.Version}&api_key=123"));
                Assert.That(request.HttpMethod, Is.EqualTo("GET"));
                Assert.That(response.Products.Identification.Data.RequestId, Is.EqualTo(requestId));
            });
        }

        [Test]
        public void GetEventBotdTooManyRequestsErrorTest()
        {
            SetupMockResponse("get_event_botd_too_many_requests_error.json");

            const string requestId = "0KSh65EnVoB85JBmloQK";
            var response = _instance!.GetEvent(requestId);

            Assert.Multiple(() =>
            {
                Assert.That(_requests, Has.Count.EqualTo(1));
                Assert.That(response, Is.InstanceOf<EventResponse>(), "response is EventResponse");
                Assert.That(response.Products.Botd.Error.Code, Is.EqualTo(BotdError.CodeEnum.TooManyRequests));
            });
        }

        [Test]
        public void GetEventBotdFailedErorTest()
        {
            SetupMockResponse("get_event_botd_failed_error.json");

            const string requestId = "0KSh65EnVoB85JBmloQK";
            var response = _instance!.GetEvent(requestId);

            Assert.Multiple(() =>
            {
                Assert.That(_requests, Has.Count.EqualTo(1));
                Assert.That(response, Is.InstanceOf<EventResponse>(), "response is EventResponse");
                Assert.That(response.Products.Botd.Error.Code, Is.EqualTo(BotdError.CodeEnum.Failed));
            });
        }

        [Test]
        public void GetEventIdentificationTooManyRequestsErrorTest()
        {
            SetupMockResponse("get_event_identification_too_many_requests_error.json");

            const string requestId = "0KSh65EnVoB85JBmloQK";
            var response = _instance!.GetEvent(requestId);

            Assert.Multiple(() =>
            {
                Assert.That(_requests, Has.Count.EqualTo(1));
                Assert.That(response, Is.InstanceOf<EventResponse>(), "response is EventResponse");
                Assert.That(response.Products.Identification.Error.Code, Is.EqualTo(IdentificationError.CodeEnum._429TooManyRequests));
            });
        }

        [Test]
        public void GetEventIdentificationFailedErrorTest()
        {
            SetupMockResponse("get_event_identification_failed_error.json");

            const string requestId = "0KSh65EnVoB85JBmloQK";
            var response = _instance!.GetEvent(requestId);

            Assert.Multiple(() =>
            {
                Assert.That(_requests, Has.Count.EqualTo(1));
                Assert.That(response, Is.InstanceOf<EventResponse>(), "response is EventResponse");
                Assert.That(response.Products.Identification.Error.Code, Is.EqualTo(IdentificationError.CodeEnum.Failed));
            });
        }

        /// <summary>
        /// Test GetVisits
        /// </summary>
        [Test]
        public void GetVisitsLimit1Test()
        {
            SetupMockResponse("visits_limit_1.json");

            const string visitorId = "AcxioeQKffpXF8iGQK3P";
            const string requestId = "1655373953086.DDlfmP";
            const string? linkedId = null;
            int? limit = 1;
            long? before = null;

            var response = _instance!.GetVisits(visitorId, requestId, linkedId, limit, before);

            Assert.Multiple(() =>
            {
                Assert.That(_requests, Has.Count.EqualTo(1));
                Assert.That(response, Is.InstanceOf<Response>(), "response is Response");
                Assert.That(response.VisitorId, Is.EqualTo(visitorId));
                Assert.That(response.Visits, Has.Count.EqualTo(1));

                var request = _requests[0];

                Assert.That(request.Headers.Get("User-Agent"),
                    Is.EqualTo($"Swagger-Codegen/{FingerprintApi.Version}/csharp"));
                Assert.That(request.Url?.ToString(),
                    Is.EqualTo(
                        $"http://127.0.0.1:8080/visitors/{visitorId}?ii=fingerprint-pro-server-api-dotnet-sdk%2f{FingerprintApi.Version}&request_id={requestId}&limit={limit}&api_key=123"));
                Assert.That(request.HttpMethod, Is.EqualTo("GET"));
            });
        }

        [Test]
        public void GetVisitsTooManyRequestsErrorTest()
        {
            SetupMockResponse("visits_too_many_requests_error.json");

            _mockResponseHeaders?.Add("Retry-After", "10");
            _mockResponseStatusCode = TooManyRequestsException.TooManyRequestsCode;

            const string visitorId = "AcxioeQKffpXF8iGQK3P";

            var getResponse = () => _instance!.GetVisits(visitorId);

            Assert.That(getResponse,
                Throws.TypeOf<TooManyRequestsException>().With.Property(nameof(TooManyRequestsException.ErrorCode))
                    .EqualTo(TooManyRequestsException.TooManyRequestsCode));
        }
    }
}