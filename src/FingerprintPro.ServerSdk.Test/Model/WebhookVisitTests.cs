using System.Text;
using FingerprintPro.ServerSdk.Json;
using FingerprintPro.ServerSdk.Model;
using FingerprintPro.ServerSdk.Test.Utils;

namespace FingerprintPro.ServerSdk.Test.Model;

[TestFixture]
public class WebhookVisitTests
{
    [Test]
    public void FromBytesTest()
    {
        var bytes = MockLoader.Load("webhook.json");
        var json = Encoding.UTF8.GetString(bytes);
        var webhook = JsonUtils.Deserialize<WebhookVisit>(json);

        Assert.That(webhook, Is.InstanceOf<WebhookVisit>());
    }
}
