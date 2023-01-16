using Fingerprint.Sdk.Client;

namespace Fingerprint.Sdk.Test.Client;

[TestFixture]
public class ConfigurationTests
{
    [Test]
    public void EuRegionTest()
    {
        var config = new Configuration("123")
        {
            Region = Region.Eu
        };

        Assert.Multiple(() =>
        {
            Assert.That(config.BasePath, Is.EqualTo("https://eu.api.fpjs.io"));
            Assert.That(config.Region, Is.EqualTo(Region.Eu));
        });
    }

    [Test]
    public void AsiaRegionTest()
    {
        var config = new Configuration("123")
        {
            Region = Region.Asia
        };

        Assert.Multiple(() =>
        {
            Assert.That(config.BasePath, Is.EqualTo("https://ap.api.fpjs.io"));
            Assert.That(config.Region, Is.EqualTo(Region.Asia));
        });
    }

    [Test]
    public void UsRegionTest()
    {
        var config = new Configuration("123");

        Assert.Multiple(() =>
        {
            Assert.That(config.BasePath, Is.EqualTo("https://api.fpjs.io"));
            Assert.That(config.Region, Is.EqualTo(Region.Us));
        });
    }
}