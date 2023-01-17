// See https://aka.ms/new-console-template for more information

using System;
using Fingerprint.ServerSdk.Api;
using Fingerprint.ServerSdk.Client;

var configuration = new Configuration(Environment.GetEnvironmentVariable("API_KEY")!);
//configuration.Region = Region.Eu;

var api = new FingerprintApi(
    configuration
);

var requestId = Environment.GetEnvironmentVariable("REQUEST_ID")!;
var visitorId = Environment.GetEnvironmentVariable("VISITOR_ID")!;

var visits = api.GetVisits(visitorId);
var events = api.GetEvent(requestId);

Console.WriteLine(visits);
Console.WriteLine(events);