using System.Text;
using Fingerprint.Sdk.Model;
using Fingerprint.Sdk.Test.Utils;
using Newtonsoft.Json;

namespace Fingerprint.Sdk.Test.Model;

[TestFixture]
public class WebhookVisitTests
{
    [Test]
    public void FromBytesTest()
    {
        var bytes = MockLoader.Load("webhook.json");
        var json = Encoding.UTF8.GetString(bytes);
        var webhook = JsonConvert.DeserializeObject<WebhookVisit>(json);

        Assert.That(webhook, Is.InstanceOf<WebhookVisit>());
    }
}