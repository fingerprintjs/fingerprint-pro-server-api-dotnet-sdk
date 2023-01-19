using FingerprintPro.ServerSdk.Api;
using FingerprintPro.ServerSdk.Client;
using FingerprintPro.ServerSdk.Model;

namespace FingerprintPro.ServerSdk.FunctionalTest;

public class ApiTests
{
    private FingerprintApi _api;

    [SetUp]
    public void Setup()
    {
        var configuration = new Configuration("D0sjRtV8i0obVPaWoxsY")
        {
            Region = Region.Eu
        };

        _api = new FingerprintApi(
            configuration
        );
    }

    [Test]
    public void GetEventsTest()
    {
        var requestId = "1673533359077.QYeH4K";

        var events = _api.GetEvent(requestId);

        var task = () =>
        {
            try
            {
                var response = _api.GetEvent(requestId);

                Console.WriteLine("Got response");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(e);
            }
        };
        
        var tasks = new Task[25];
        for (var i = 0; i < tasks.Length; i++)
        {
            tasks[i] = Task.Run(task);
        }

        Task.WaitAll(tasks);
    }

    [Test]
    public void GetEvents404Test()
    {
        var getEvents = () => _api.GetEventAsync("1662542583652.pLBzes");

        Assert.That(getEvents,
            Throws.TypeOf<ApiException>().With.Message.Contains("request id is not found").And
                .Property(nameof(ApiException.ErrorCode)).EqualTo(404));
    }

    [Test]
    public void GetVisitsWithoutRequestIdTest()
    {
        var visitorId = Environment.GetEnvironmentVariable("VISITOR_ID")!;

        var response = _api.GetVisits(visitorId);

        Assert.Multiple(() =>
        {
            Assert.That(response, Is.InstanceOf<Response>());
            Assert.That(response.Visits, Has.Count.AtLeast(4));
            Assert.That(response.Visits, Is.All.InstanceOf<ResponseVisits>());
            Assert.That(response.VisitorId, Is.EqualTo(visitorId));
        });
    }

    [Test]
    public void GetVisitsWithRequestIdTest()
    {
        var visitorId = Environment.GetEnvironmentVariable("VISITOR_ID")!;
        var allVisits = _api.GetVisits(visitorId);

        var requestId = allVisits.Visits[0].RequestId;

        var response = _api.GetVisits(visitorId, requestId);

        Assert.Multiple(() =>
        {
            Assert.That(response, Is.InstanceOf<Response>());
            Assert.That(response.Visits, Has.Count.EqualTo(1));
            Assert.That(response.Visits[0].RequestId, Is.EqualTo(requestId));
            Assert.That(response.VisitorId, Is.EqualTo(visitorId));
        });
    }

    [Test]
    public void GetVisitsWithLinkedId()
    {
        var visitorId = Environment.GetEnvironmentVariable("VISITOR_ID")!;
        var allVisits = _api.GetVisits(visitorId);

        var linkedId = allVisits.Visits[0].LinkedId;

        var response = _api.GetVisits(visitorId, null, linkedId);

        Assert.Multiple(() =>
        {
            Assert.That(response, Is.InstanceOf<Response>());
            Assert.That(response.Visits, Has.Count.EqualTo(2));
            Assert.That(response.Visits, Is.All.Property("LinkedId").EqualTo(linkedId));
            Assert.That(response.VisitorId, Is.EqualTo(visitorId));
        });
    }
}