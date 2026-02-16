using Xunit;

namespace Fingerprint.ServerSdk.Test;

public class WebhookValidationTests
{
    private const string _validHeader = "v1=1b2c16b75bd2a870c114153ccda5bcfca63314bc722fa160d690de133ccbb9db";
    private const string _secret = "secret";
    private static readonly byte[] Data = "data"u8.ToArray();

    [Fact]
    public void ValidHeaderTest()
    {
        var result = WebhookValidation.IsValidSignature(_validHeader, Data, _secret);

        Assert.True(result);
    }

    [Fact]
    public void InvalidHeaderTest()
    {
        var result = WebhookValidation.IsValidSignature("v2=invalid", Data, _secret);

        Assert.False(result);
    }

    [Fact]
    public void EmptySecretTest()
    {
        var result = WebhookValidation.IsValidSignature("invalid", Data, "");

        Assert.False(result);
    }

    [Fact]
    public void EmptyDataTest()
    {
        var result = WebhookValidation.IsValidSignature(_validHeader, ""u8.ToArray(), _secret);

        Assert.False(result);
    }
}
