using System.Text.Json;
using Fingerprint.ServerSdk.Api;
using Fingerprint.ServerSdk.Client;
using Fingerprint.ServerSdk.Extensions;
using Fingerprint.ServerSdk.Model;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Fingerprint.ServerSdk.Examples;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();
        var api = host.Services.GetRequiredService<IFingerprintApi>();

        await SearchEventsExample(api);

        var eventId = Environment.GetEnvironmentVariable("EVENT_ID");
        if (!string.IsNullOrWhiteSpace(eventId))
        {
            await GetEventExample(api, eventId);
        }

        var updateEventId = Environment.GetEnvironmentVariable("UPDATE_EVENT_ID");
        if (!string.IsNullOrWhiteSpace(updateEventId))
        {
            await UpdateEventExample(api, updateEventId);
        }

        var visitorId = Environment.GetEnvironmentVariable("VISITOR_ID");
        if (!string.IsNullOrWhiteSpace(visitorId))
        {
            await DeleteVisitorDataExample(api, visitorId);
        }
    }

    private static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
        .ConfigureApi((_, _, options) =>
        {
            var token = Environment.GetEnvironmentVariable("SECRET_API_KEY");
            if (string.IsNullOrWhiteSpace(token))
            {
                throw new InvalidOperationException("SECRET_API_KEY is missing");
            }

            var region = Environment.GetEnvironmentVariable("REGION");
            if (!string.IsNullOrWhiteSpace(region))
            {
                options.Region = Regions.Parse(region);
            }

            var bearerToken = new BearerToken(token);
            options.AddTokens(bearerToken);
        });

    private static async Task SearchEventsExample(IFingerprintApi api)
    {
        var events = await api.SearchEventsAsync(new SearchEventsRequest()
            .WithLimit(2)
            .WithBot("bad"));

        if (! events.IsOk)
        {
            throw new ExampleException("SearchEventsAsync failed", events);
        }

        Console.WriteLine("SearchEventsAsync result:");
        Console.WriteLine(JsonSerializer.Serialize(events.Ok()));
    }

    private static async Task GetEventExample(IFingerprintApi api, string eventId)
    {
        var model = await api.GetEventAsync(eventId: eventId);

        if (!model.IsOk)
        {
            throw new ExampleException("GetEventAsync failed", model);
        }

        Console.WriteLine("GetEventAsync result:");
        Console.WriteLine(JsonSerializer.Serialize(model.Ok()));
    }

    private static async Task UpdateEventExample(IFingerprintApi api, string eventId)
    {
        var tags = new Dictionary<string, object>
        {
            { "sdk", "dotnet" }
        };

        var body = new EventUpdate(linkedId: "<linked_id>", tags: tags, suspect: false);
        var updateEvent = await api.UpdateEventAsync(eventId: eventId, eventUpdate: body);

        if (! updateEvent.IsOk)
        {
            throw new ExampleException("UpdateEventAsync failed", updateEvent);
        }

        Console.WriteLine("Event updated");
    }

    private static async Task DeleteVisitorDataExample(IFingerprintApi api, string visitorId)
    {
        var deleteVisitorData = await api.DeleteVisitorDataAsync(visitorId: visitorId);

        if (! deleteVisitorData.IsOk)
        {
            throw new ExampleException("DeleteVisitorDataAsync failed", deleteVisitorData);
        }

        Console.WriteLine("Scheduled visitor data removal");
    }
}