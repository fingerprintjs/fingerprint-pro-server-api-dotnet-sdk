// See https://aka.ms/new-console-template for more information

using Fingerprint.Sdk.Api;
using Fingerprint.Sdk.Client;

var configuration = new Configuration();
configuration.AddApiKey("api_key", Environment.GetEnvironmentVariable("API_KEY")!);

var api = new FingerprintApi(
    configuration
);

var requestId = Environment.GetEnvironmentVariable("REQUEST_ID")!;

var visits = api.GetVisits(Environment.GetEnvironmentVariable("VISITOR_ID")!);
var events = api.GetEvent(requestId);

Console.WriteLine(visits);
Console.WriteLine(events);