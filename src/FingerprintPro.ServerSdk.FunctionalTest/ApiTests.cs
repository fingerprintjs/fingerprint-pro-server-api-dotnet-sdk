using FingerprintPro.ServerSdk.Api;
using FingerprintPro.ServerSdk.Client;
using FingerprintPro.ServerSdk.Model;

namespace FingerprintPro.ServerSdk.FunctionalTest;

public class ApiTests
{
    private FingerprintApi _api;
    private String requestId;
    private String visitorId;
    private long start;
    private long end;
    private String searchEventsPaginationKey;

    [OneTimeSetUp]
    public void Setup()
    {
        var configuration = new Configuration(Environment.GetEnvironmentVariable("SECRET_API_KEY")!);

        _api = new FingerprintApi(
            configuration
        );

        var now = DateTimeOffset.UtcNow;
        end = now.ToUnixTimeMilliseconds();
        start = now.AddDays(-90).ToUnixTimeMilliseconds();

        var events = _api.SearchEvents(2, start: start, end: end);
        Assert.That(events.Events, Is.Not.Empty);
        var firstEventIdentificationData = events.Events[0].Products.Identification.Data;
        requestId = firstEventIdentificationData.RequestId;
        visitorId = firstEventIdentificationData.VisitorId;
    }

    [Test]
    public void GetEventsTest()
    {
        var events = _api.GetEvent(requestId);

        Assert.Multiple(() =>
        {
            Assert.That(events, Is.InstanceOf<EventsGetResponse>());
            Assert.That(events.Products, Is.InstanceOf<Products>());
            Assert.That(events.Products.Botd, Is.InstanceOf<ProductBotd>());
            Assert.That(events.Products.Identification, Is.InstanceOf<ProductIdentification>());
            Assert.That(events.Products.Identification.Data.RequestId, Is.EqualTo(requestId));
        });
    }

    [Test]
    public void GetEvents404Test()
    {
        var getEvents = () => _api.GetEventAsync("1662542583652.pLBzes");

        Assert.That(getEvents,
            Throws.TypeOf<ApiException>().With.Message.Contains("request id not found")
                .And.Property(nameof(ApiException.HttpCode)).EqualTo(404)
                .And.Property(nameof(ApiException.ErrorCode)).EqualTo(ErrorCode.RequestNotFound)
                .And.Property(nameof(ApiException.ErrorContent)).InstanceOf(typeof(ErrorResponse)));
    }

    [Test]
    public void GetVisitsWithoutRequestIdTest()
    {
        var response = _api.GetVisits(visitorId);

        Assert.Multiple(() =>
        {
            Assert.That(response, Is.InstanceOf<VisitorsGetResponse>());
            Assert.That(response.Visits, Is.All.InstanceOf<Visit>());
            Assert.That(response.VisitorId, Is.EqualTo(visitorId));
        });
    }

    [Test]
    public void GetVisitsWithRequestIdTest()
    {
        var allVisits = _api.GetVisits(visitorId);

        var requestId = allVisits.Visits[0].RequestId;

        var response = _api.GetVisits(visitorId, requestId);

        Assert.Multiple(() =>
        {
            Assert.That(response, Is.InstanceOf<VisitorsGetResponse>());
            Assert.That(response.Visits, Has.Count.EqualTo(1));
            Assert.That(response.Visits[0].RequestId, Is.EqualTo(requestId));
            Assert.That(response.VisitorId, Is.EqualTo(visitorId));
        });
    }

    [Test]
    public void SearchEvents()
    {
        var limit = 2;
        var start = DateTime.UtcNow.Subtract(TimeSpan.FromDays(365));
        var end = DateTime.UtcNow.Add(TimeSpan.FromDays(365));

        var response = _api.SearchEvents(limit, start: ((DateTimeOffset)start).ToUnixTimeMilliseconds(),
            end: ((DateTimeOffset)end).ToUnixTimeMilliseconds());

        Assert.That(response.Events.Count, Is.GreaterThanOrEqualTo(1));
    }

    [Test]
    public void SearchEventsPagination()
    {
        var response = _api.SearchEvents(2, start: start, end: end, paginationKey: searchEventsPaginationKey);
        Assert.That(response.Events.Count, Is.GreaterThanOrEqualTo(1));
    }

    [Test]
    public void SearchOldEvents()
    {
        var response = _api.SearchEvents(limit: 2, start: start, end: end, reverse: true);

        Assert.That(response.Events.Count, Is.GreaterThanOrEqualTo(1));
        var oldEventIdentificationData = response.Events[0].Products.Identification.Data;

        Assert.That(oldEventIdentificationData.RequestId, Is.Not.EqualTo(requestId));

        // Try to request old events to check if they still could be deserialized
        _api.GetVisits(oldEventIdentificationData.VisitorId);
        _api.GetEvent(oldEventIdentificationData.RequestId);
    }
}