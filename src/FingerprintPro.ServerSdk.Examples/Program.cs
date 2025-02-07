// See https://aka.ms/new-console-template for more information

using System;
using FingerprintPro.ServerSdk.Api;
using FingerprintPro.ServerSdk.Client;
using FingerprintPro.ServerSdk.Model;


var example = new FingerprintExample();
example.GetVisitsExample();
example.GetEventExample();
example.SearchEventsExample();

// Uncomment following line to test update event method
// example.UpdateEventExample()

// Uncomment following line to test delete visitor data
// example.DeleteVisitorDataExample()

internal class FingerprintExample
{
    private readonly Configuration _configuration = new(Environment.GetEnvironmentVariable("API_KEY")!);
    private readonly string _visitorId = Environment.GetEnvironmentVariable("VISITOR_ID")!;
    private readonly string _requestId = Environment.GetEnvironmentVariable("REQUEST_ID")!;
    private readonly FingerprintApi _api;

    public FingerprintExample()
    {
        // Change region if needed
        var region = Environment.GetEnvironmentVariable("REGION")!;
        _configuration.Region = region switch
        {
            "eu" => Region.Eu,
            "ap" => Region.Asia,
            _ => _configuration.Region
        };

        _api = new FingerprintApi(_configuration);
    }


    public void GetVisitsExample()
    {
        var visits = _api.GetVisits(_visitorId);
        Console.WriteLine("GetVisits() result:");
        Console.WriteLine(visits);
    }

    public void GetEventExample()
    {
        var events = _api.GetEvent(_requestId);
        Console.WriteLine("GetEvent() result:");
        Console.WriteLine(events);
    }

    public void SearchEventsExample()
    {
        var events = _api.SearchEvents(2, bot: "bad");
        Console.WriteLine("SearchEvents() result:");
        Console.WriteLine(events);
    }

    public void UpdateEventExample()
    {
        var tag = new Tag
        {
            ["sdk"] = "dotnet"
        };

        var body = new EventsUpdateRequest()
        {
            Suspect = false,
            Tag = tag,
            LinkedId = "<linked_id>"
        };
        _api.UpdateEvent(body, _requestId);
        Console.WriteLine("Event updated");
    }

    public void DeleteVisitorDataExample()
    {
        _api.DeleteVisitorData(_visitorId);
        Console.WriteLine("Scheduled visitor data removal");
    }
}