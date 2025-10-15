using System.Text;

namespace Fingerprint.ServerSdk.Test;

[TestFixture]
public class WebhookValidationTests
{
    private const string _validHeader = "v1=1b2c16b75bd2a870c114153ccda5bcfca63314bc722fa160d690de133ccbb9db";
    private const string _secret = "secret";
    private static readonly byte[] Data = "data"u8.ToArray();

    [Test]
    public void ValidHeaderTest()
    {
        var result = WebhookValidation.IsValidSignature(_validHeader, Data, _secret);

        Assert.That(result, Is.True);
    }

    [Test]
    public void InvalidHeaderTest()
    {
        var result = WebhookValidation.IsValidSignature("v2=invalid", Data, _secret);

        Assert.That(result, Is.False);
    }


    [Test]
    public void HeaderWithoutVersionTest()
    {
        var result = WebhookValidation.IsValidSignature("invalid", Data, _secret);

        Assert.That(result, Is.False);
    }

    [Test]
    public void EmptyHeaderTest()
    {
        var result = WebhookValidation.IsValidSignature("invalid", Data, _secret);

        Assert.That(result, Is.False);
    }

    [Test]
    public void EmptySecretTest()
    {
        var result = WebhookValidation.IsValidSignature("invalid", Data, "");

        Assert.That(result, Is.False);
    }

    [Test]
    public void EmptyDataTest()
    {
        var result = WebhookValidation.IsValidSignature(_validHeader, ""u8.ToArray(), _secret);

        Assert.That(result, Is.False);
    }
}
