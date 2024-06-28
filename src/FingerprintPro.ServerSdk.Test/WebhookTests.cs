using System.Text;

namespace FingerprintPro.ServerSdk.Test;

[TestFixture]
public class WebhookTests
{
    private const string _validHeader = "v1=1b2c16b75bd2a870c114153ccda5bcfca63314bc722fa160d690de133ccbb9db";
    private const string _secret = "secret";
    private static readonly byte[] Data = "data"u8.ToArray();

    [Test]
    public void ValidHeaderTest()
    {
        var result = Webhook.IsValidWebhookSignature(_validHeader, Data, _secret);

        Assert.That(result, Is.True);
    }

    [Test]
    public void InvalidHeaderTest()
    {
        var result = Webhook.IsValidWebhookSignature("v2=invalid", Data, _secret);

        Assert.That(result, Is.False);
    }


    [Test]
    public void HeaderWithoutVersionTest()
    {
        var result = Webhook.IsValidWebhookSignature("invalid", Data, _secret);

        Assert.That(result, Is.False);
    }

    [Test]
    public void EmptyHeaderTest()
    {
        var result = Webhook.IsValidWebhookSignature("invalid", Data, _secret);

        Assert.That(result, Is.False);
    }

    [Test]
    public void EmptySecretTest()
    {
        var result = Webhook.IsValidWebhookSignature("invalid", Data, "");

        Assert.That(result, Is.False);
    }

    [Test]
    public void EmptyDataTest()
    {
        var result = Webhook.IsValidWebhookSignature(_validHeader, ""u8.ToArray(), _secret);

        Assert.That(result, Is.False);
    }
}
