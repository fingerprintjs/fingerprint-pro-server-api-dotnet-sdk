// See https://aka.ms/new-console-template for more information

using System;
using FingerprintPro.ServerSdk.Api;
using FingerprintPro.ServerSdk.Client;


var configuration = new Configuration(Environment.GetEnvironmentVariable("API_KEY")!);

// Change region if needed
var region = Environment.GetEnvironmentVariable("REGION")!;
if (region == "eu")
{
    configuration.Region = Region.Eu;
}
else if (region == "ap")
{
    configuration.Region = Region.Asia;
}

var api = new FingerprintApi(
    configuration
);

var requestId = Environment.GetEnvironmentVariable("REQUEST_ID")!;
var visitorId = Environment.GetEnvironmentVariable("VISITOR_ID")!;

var visits = api.GetVisits(visitorId);
var events = api.GetEvent(requestId);

Console.WriteLine(visits.ToJson());
Console.WriteLine(events.ToJson());