using System.Text.Json;
using FingerprintPro.ServerSdk.Json;
using FingerprintPro.ServerSdk.Model;
using Org.BouncyCastle.Crypto;

namespace FingerprintPro.ServerSdk.Test;

[TestFixture]
public class SealedTest
{
    [Test]
    public void UnsealEventResponseTest()
    {
        var sealedResult = Convert.FromBase64String(
            "noXc7SZeaIKHXyFfzrvEXBCbQ3FPxHL7VpxiMX78XcFXPbEcgS2GRor0g27N3LLvHCWvvvhrdwkeDhKjrSC4bQfpR1OoImxLUgY4/lg7C7JZh1hlhsj9JWR3nWVo8t5oKvaDcwx/DXnyM659S5Bh9RJrP47koPwTHYsd2+N6KAXX5iuDQj4Fonhp4A3/rEmVn83mRVUSgAvyM2yRq3bww6unERvsUmVrSv/IcMw6LBIvjsKkcAj5vnFgyr0K41ITtNIaiYDMCjR3KOzvZkSstv2eWOXopEPPn9C9wHYpHEDSzEODVB9lRMB6YbcgS0vOsFD5KLHiiE/luKZl28Z3vlQNWx21ASpJdi1J2s8cEWsmEHwMoqLhnkpqHEn21wQZgMjLDvIGZ+QRJo0KnCCY4TP1cB3/TQxvzTslBpBoUqXcuC+VCLRZPXARiq6nx7SvJ2wRttQq+QFbpbjj5sXkE3HMNsb2P4r7yrMxS8WIUBlVKlxj8foqgKTTyp05AQvCxHOWc2suzDBdxEhwGlaM4vpHuzBoJIAd1c+al+mNlO+XSnJ6xPwQ37WRwHheBq/8/RNh42FQpZZh7VcXcXRvtpR9HHr8kUegzZaFQJqtZAlMUfTF9tGE7gWEWWeLAdkhEDg/NNGu+HoCIJkPt03P2gZKtnx22aUG1mlS/VEWjwtEy8u8j1q9rWpTPCPkVZR07Zflvq/rjr/4W/UdQdS5X2slz3e0Ak9rRFtZVljB3PLfVbQDZiome3FE3JojguqSraRhmMlTl0fj09mkhcze8vi4rtAWogy3iundYNLhxfNG/xAl5h3Cyrxcg2NbrZhkuLDdKoS86Ka0jGbSqLLsk1RpYx51Ljdlft0dw1viz4JNU8xReelISsfo3hsJTVaqe29Gw+IsdFq+ojlC5/YajG6SXCRGNw==");
        var key = Convert.FromBase64String("p2PA7MGy5tx56cnyJaFZMr96BCFwZeHjZV2EqMvTq53=");

        var expectedResponse = JsonUtils.Deserialize<EventsGetResponse>(
                "{\"products\":{\"identification\":{\"data\":{\"visitorId\":\"2ZEDCZEfOfXjEmMuE3tq\",\"requestId\":\"1703067132750.Z5hutJ\",\"replayed\":false,\"browserDetails\":{\"browserName\":\"Safari\",\"browserMajorVersion\":\"17\",\"browserFullVersion\":\"17.3\",\"os\":\"Mac OS X\",\"osVersion\":\"10.15.7\",\"device\":\"Other\",\"userAgent\":\"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/17.3 Safari/605.1.15\"},\"incognito\":false,\"ip\":\"::1\",\"ipLocation\":{\"accuracyRadius\":1000,\"latitude\":59.3241,\"longitude\":18.0517,\"postalCode\":\"100 05\",\"timezone\":\"Europe/Stockholm\",\"city\":{\"name\":\"Stockholm\"},\"country\":{\"code\":\"SE\",\"name\":\"Sweden\"},\"continent\":{\"code\":\"EU\",\"name\":\"Europe\"},\"subdivisions\":[{\"isoCode\":\"AB\",\"name\":\"Stockholm County\"}]},\"timestamp\":1703067136286,\"time\":\"2023-12-20T10:12:16Z\",\"url\":\"http://localhost:8080/\",\"tag\":{\"foo\":\"bar\"},\"confidence\":{\"score\":1},\"visitorFound\":true,\"firstSeenAt\":{\"global\":\"2023-12-15T12:13:55.103Z\",\"subscription\":\"2023-12-15T12:13:55.103Z\"},\"lastSeenAt\":{\"global\":\"2023-12-19T11:39:51.52Z\",\"subscription\":\"2023-12-19T11:39:51.52Z\"}}},\"botd\":{\"data\":{\"bot\":{\"result\":\"notDetected\"},\"meta\":{\"foo\":\"bar\"},\"url\":\"http://localhost:8080/\",\"ip\":\"::1\",\"time\":\"2023-12-20T10:12:13.894Z\",\"userAgent\":\"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_15_7) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/17.3 Safari/605.1.15\",\"requestId\":\"1703067132750.Z5hutJ\"}}}}")
            !;

        var actualResponse = Sealed.UnsealEventResponse(
            sealedResult,
            new Sealed.DecryptionKey[]
            {
                // Invalid key
                new(Convert.FromBase64String("p2PA7MGy5tx56cnyJaFZMr96BCFwZeHjZV2EqMvTq54="),
                    Sealed.DecryptionAlgorithm.Aes256Gcm),
                new(key, Sealed.DecryptionAlgorithm.Aes256Gcm)
            });

        Assert.That(actualResponse.ToString(), Is.EqualTo(expectedResponse.ToString()));
    }

    [Test]
    public void UnsealEventResponseWithInvalidSealedResultTest()
    {
        // "{\"invalid\":true}"
        var sealedResult =
            Convert.FromBase64String("noXc7VOpBstjjcavDKSKr4HTavt4mdq8h6NC32T0hUtw9S0jXT8lPjZiWL8SyHxmrF3uTGqO+g==");
        var key = Convert.FromBase64String("p2PA7MGy5tx56cnyJaFZMr96BCFwZeHjZV2EqMvTq53=");

        Assert.Throws<InvalidDataException>(() =>
            Sealed.UnsealEventResponse(
                sealedResult,
                new Sealed.DecryptionKey[]
                {
                    new(Convert.FromBase64String("aW52YWxpZA=="), Sealed.DecryptionAlgorithm.Aes256Gcm),
                    new(key, Sealed.DecryptionAlgorithm.Aes256Gcm)
                }));
    }

    [Test]
    public void UnsealEventResponseWithInvalidJsonSealedResultTest()
    {
        var sealedResult = Convert.FromBase64String(
            "noXc7VE/iOGp4qw5etO5BigT7Gq3Grr3vFf4O+kB+JGQFDBDPAy7afWfhz/AhDRiY86mH7GSfOhBbNL4Q/xAvJPLepFFFs2YKYKGH5KLLvTfTX9/MPR4xACLJTbBRk1oLrz7KvyUh8wJzRH15MFryFIgTprKQEAURxSxVfkwKFc/lQvth9A/VD+qfrfQPPfOevGydBSuwhInuOWXsrtT+Oy036o+sf3uR2sGSAVwqMkORNu1s4jvCvT+v5fQH0SVHp2E24tscteOEUNhYcfsWInoDKl2vFR04YX8TSXqC9/YWJDRv4rSV2H806HvKJguElS7Bk4PVGELNg6bYKTV+QVq70UM/X9aABbOy/maYVE1Cv2fV7lOsKj58i4XXMnBoHf6HSrdLBMuelcEbqmILlnouZr9EusGJw9s3bVFihC1ZJMBVkwuUn93eicqg2YjTN+pUevEyQuSYJ9UZ6sRPOGp8OwQNBEYJiMN7M5/5cO4jAB5W7Sgsn+tN5khUDevrXaAdj/q/a6Sq9sGTImySH6IWm8LY+TA13JRTztQne3aD0XmWT2QkTHZ9MP67zaRl5wcJaKWHMYuDcRXu8DJNHQS3IC7RMOKboJPSTrIgmCEeNP4ctdqV+piBC0AEX1zEO/tms3XmoLqGtflHxP/h20XVRlX5YAPyRWJju5gFdXNyLRU6IS2/crJiPocgyTJXtS8/Ffg6ksyg7NSO0Z3232cv1uAszeBsQmBxz6/kwpq5fiNDGTsQouS5g8GqePB34Dduasi/Hn9oHKnDOOpYUnCkIUSJrwJSwqh6Z6kWbZywdqhS6paGeYW+bcVo/zdBhIdS6OH8AAf+5NaZpqmUweTpRcI3/2BYRMhn5KNbVJMG0Egq986V9G0g2o3+7pkpFyHMBuMN4txwLmonU5Thgg=");
        var key = Convert.FromBase64String("p2PA7MGy5tx56cnyJaFZMr96BCFwZeHjZV2EqMvTq53=");

        Assert.Throws<JsonException>(() =>
            Sealed.UnsealEventResponse(
                sealedResult,
                new Sealed.DecryptionKey[]
                {
                    new(Convert.FromBase64String("aW52YWxpZA=="), Sealed.DecryptionAlgorithm.Aes256Gcm),
                    new(key, Sealed.DecryptionAlgorithm.Aes256Gcm)
                }));
    }

    [Test]
    public void UnsealEventResponseWithNotCompressedSealedResultTest()
    {
        var sealedResult = Convert.FromBase64String(
            "noXc7dtuk0smGE+ZbaoXzrp6Rq8ySxLepejTsu7+jUXlPhV1w+WuHx9gbPhaENJnOQo8BcGmsaRhL5k2NVj+DRNzYO9cQD7wHxmXKCyTbl/dvSYOMoHziUZ2VbQ7tmaorFny26v8jROr/UBGfvPE0dLKC36IN9ZlJ3X0NZJO8SY+8bCr4mTrkVZsv/hpvZp+OjC4h7e5vxcpmnBWXzxfaO79Lq3aMRIEf9XfK7/bVIptHaEqtPKCTwl9rz1KUpUUNQSHTPM0NlqJe9bjYf5mr1uYvWHhcJoXSyRyVMxIv/quRiw3SKJzAMOTBiAvFICpWuRFa+T/xIMHK0g96w/IMQo0jdY1E067ZEvBUOBmsJnGJg1LllS3rbJVe+E2ClFNL8SzFphyvtlcfvYB+SVSD4bzI0w/YCldv5Sq42BFt5bn4n4aE5A6658DYsfSRYWqP6OpqPJx96cY34W7H1t/ZG0ulez6zF5NvWhc1HDQ1gMtXd+K/ogt1n+FyFtn8xzvtSGkmrc2jJgYNI5Pd0Z0ent73z0MKbJx9v2ta/emPEzPr3cndN5amdr6TmRkDU4bq0vyhAh87DJrAnJQLdrvYLddnrr8xTdeXxj1i1Yug6SGncPh9sbTYkdOfuamPAYOuiJVBAMcfYsYEiQndZe8mOQ4bpCr+hxAAqixhZ16pQ8CeUwa247+D2scRymLB8qJXlaERuFZtWGVAZ8VP/GS/9EXjrzpjGX9vlrIPeJP8fh2S5QPzw55cGNJ7JfAdOyManXnoEw2/QzDhSZQARVl+akFgSO0Y13YmbiL7H6HcKWGcJ2ipDKIaj2fJ7GE0Vzyt+CBEezSQR99Igd8x3p2JtvsVKp35iLPksjS1VqtSCTbuIRUlINlfQHNjeQiE/B/61jo3Mf7SmjYjqtvXt5e9RKb+CQku2qH4ZU8xN3DSg+4mLom3BgKBkm/MoyGBpMK41c96d2tRp3tp4hV0F6ac02Crg7P2lw8IUct+i2VJ8VUjcbRfTIPQs0HjNjM6/gLfLCkWOHYrlFjwusXWQCJz91Kq+hVxj7M9LtplPO4AUq6RUMNhlPGUmyOI2tcUMrjq9vMLXGlfdkH185zM4Mk+O7DRLC8683lXZFZvcBEmxr855PqLLH/9SpYKHBoGRatDRdQe3oRp6gHS0jpQ1SW/si4kvLKiUNjiBExvbQVOUV7/VFXvG1RpM9wbzSoOd40gg7ZzD/72QshUC/25DkM/Pm7RBzwtjgmnRKjT+mROeC/7VQLoz3amv09O8Mvbt+h/lX5+51Q834F7NgIGagbB20WtWcMtrmKrvCEZlaoiZrmYVSbi1RfknRK7CTPJkopw9IjO7Ut2EhKZ+jL4rwk6TlVm6EC6Kuj7KNqp6wB/UNe9eM2Eym/aiHAcja8XN4YQhSIuJD2Wxb0n3LkKnAjK1/GY65c8K6rZsVYQ0MQL1j4lMl0UZPjG/vzKyetIsVDyXc4J9ZhOEMYnt/LaxEeSt4EMJGBA9wpTmz33X4h3ij0Y3DY/rH7lrEScUknw20swTZRm5T6q1bnimj7M1OiOkebdI09MZ0nyaTWRHdB7B52C/moh89Q7qa2Fulp5h8Us1FYRkWBLt37a5rGI1IfVeP38KaPbagND+XzWpNqX4HVrAVPLQVK5EwUvGamED3ooJ0FMieTc0IH0N+IeUYG7Q8XmrRVBcw32W8pEfYLO9L71An/J0jQZCIP8DuQnUG0mOvunOuloBGvP/9LvkBlkamh68F0a5f5ny1jloyIFJhRh5dt2SBlbsXS9AKqUwARYSSsA9Ao4WJWOZMyjp8A+qIBAfW65MdhhUDKYMBgIAbMCc3uiptzElQQopE5TT5xIhwfYxa503jVzQbz1Q==");
        var key = Convert.FromBase64String("p2PA7MGy5tx56cnyJaFZMr96BCFwZeHjZV2EqMvTq53=");

        var ex = Assert.Throws<Sealed.UnsealAggregateException>(() =>
            Sealed.UnsealEventResponse(
                sealedResult,
                new Sealed.DecryptionKey[]
                {
                    new(Convert.FromBase64String("aW52YWxpZA=="), Sealed.DecryptionAlgorithm.Aes256Gcm),
                    new(key, Sealed.DecryptionAlgorithm.Aes256Gcm)
                }));

        var lastError = ex!.UnsealExceptions.Last();

        Assert.That(lastError.InnerException, Is.InstanceOf(typeof(InvalidDataException)));
    }

    [Test]
    public void UnsealEventResponseWithInvalidHeaderTest()
    {
        var sealedResult = Convert.FromBase64String(
            "noXc7xXO+mqeAGrvBMgObi/S0fXTpP3zupk8qFqsO/1zdtWCD169iLA3VkkZh9ICHpZ0oWRzqG0M9/TnCeKFohgBLqDp6O0zEfXOv6i5q++aucItznQdLwrKLP+O0blfb4dWVI8/aSbd4ELAZuJJxj9bCoVZ1vk+ShbUXCRZTD30OIEAr3eiG9aw00y1UZIqMgX6CkFlU9L9OnKLsNsyomPIaRHTmgVTI5kNhrnVNyNsnzt9rY7fUD52DQxJILVPrUJ1Q+qW7VyNslzGYBPG0DyYlKbRAomKJDQIkdj/Uwa6bhSTq4XYNVvbk5AJ/dGwvsVdOnkMT2Ipd67KwbKfw5bqQj/cw6bj8Cp2FD4Dy4Ud4daBpPRsCyxBM2jOjVz1B/lAyrOp8BweXOXYugwdPyEn38MBZ5oL4D38jIwR/QiVnMHpERh93jtgwh9Abza6i4/zZaDAbPhtZLXSM5ztdctv8bAb63CppLU541Kf4OaLO3QLvfLRXK2n8bwEwzVAqQ22dyzt6/vPiRbZ5akh8JB6QFXG0QJF9DejsIspKF3JvOKjG2edmC9o+GfL3hwDBiihYXCGY9lElZICAdt+7rZm5UxMx7STrVKy81xcvfaIp1BwGh/HyMsJnkE8IczzRFpLlHGYuNDxdLoBjiifrmHvOCUDcV8UvhSV+UAZtAVejdNGo5G/bz0NF21HUO4pVRPu6RqZIs/aX4hlm6iO/0Ru00ct8pfadUIgRcephTuFC2fHyZxNBC6NApRtLSNLfzYTTo/uSjgcu6rLWiNo5G7yfrM45RXjalFEFzk75Z/fu9lCJJa5uLFgDNxlU+IaFjArfXJCll3apbZp4/LNKiU35ZlB7ZmjDTrji1wLep8iRVVEGht/DW00MTok7Zn7Fv+MlxgWmbZB3BuezwTmXb/fNw==");
        var key = Convert.FromBase64String("p2PA7MGy5tx56cnyJaFZMr96BCFwZeHjZV2EqMvTq53=");

        Assert.Throws<Sealed.InvalidSealedDataHeaderException>(() =>
            Sealed.UnsealEventResponse(
                sealedResult,
                new Sealed.DecryptionKey[]
                {
                    new(Convert.FromBase64String("aW52YWxpZA=="), Sealed.DecryptionAlgorithm.Aes256Gcm),
                    new(key, Sealed.DecryptionAlgorithm.Aes256Gcm)
                }));
    }

    [Test]
    public void UnsealEventResponseWithEmptyData()
    {
        var sealedResult = Array.Empty<byte>();
        var key = Convert.FromBase64String("p2PA7MGy5tx56cnyJaFZMr96BCFwZeHjZV2EqMvTq53=");

        Assert.Throws<Sealed.InvalidSealedDataHeaderException>(() =>
            Sealed.UnsealEventResponse(
                sealedResult,
                new Sealed.DecryptionKey[]
                {
                    new(Convert.FromBase64String("aW52YWxpZA=="), Sealed.DecryptionAlgorithm.Aes256Gcm),
                    new(key, Sealed.DecryptionAlgorithm.Aes256Gcm)
                }));
    }

    [Test]
    public void UnsealEventResponseWithInvalidKeys()
    {
        var sealedResult = Convert.FromBase64String(
            "noXc7SXO+mqeAGrvBMgObi/S0fXTpP3zupk8qFqsO/1zdtWCD169iLA3VkkZh9ICHpZ0oWRzqG0M9/TnCeKFohgBLqDp6O0zEfXOv6i5q++aucItznQdLwrKLP+O0blfb4dWVI8/aSbd4ELAZuJJxj9bCoVZ1vk+ShbUXCRZTD30OIEAr3eiG9aw00y1UZIqMgX6CkFlU9L9OnKLsNsyomPIaRHTmgVTI5kNhrnVNyNsnzt9rY7fUD52DQxJILVPrUJ1Q+qW7VyNslzGYBPG0DyYlKbRAomKJDQIkdj/Uwa6bhSTq4XYNVvbk5AJ/dGwvsVdOnkMT2Ipd67KwbKfw5bqQj/cw6bj8Cp2FD4Dy4Ud4daBpPRsCyxBM2jOjVz1B/lAyrOp8BweXOXYugwdPyEn38MBZ5oL4D38jIwR/QiVnMHpERh93jtgwh9Abza6i4/zZaDAbPhtZLXSM5ztdctv8bAb63CppLU541Kf4OaLO3QLvfLRXK2n8bwEwzVAqQ22dyzt6/vPiRbZ5akh8JB6QFXG0QJF9DejsIspKF3JvOKjG2edmC9o+GfL3hwDBiihYXCGY9lElZICAdt+7rZm5UxMx7STrVKy81xcvfaIp1BwGh/HyMsJnkE8IczzRFpLlHGYuNDxdLoBjiifrmHvOCUDcV8UvhSV+UAZtAVejdNGo5G/bz0NF21HUO4pVRPu6RqZIs/aX4hlm6iO/0Ru00ct8pfadUIgRcephTuFC2fHyZxNBC6NApRtLSNLfzYTTo/uSjgcu6rLWiNo5G7yfrM45RXjalFEFzk75Z/fu9lCJJa5uLFgDNKlU+IaFjArfXJCll3apbZp4/LNKiU35ZlB7ZmjDTrji1wLep8iRVVEGht/DW00MTok7Zn7Fv+MlxgWmbZB3BuezwTmXb/fNw==");

        Assert.Throws<Sealed.UnsealAggregateException>(() =>
            Sealed.UnsealEventResponse(
                sealedResult,
                new Sealed.DecryptionKey[]
                {
                    new(Convert.FromBase64String("aW52YWxpZA=="), Sealed.DecryptionAlgorithm.Aes256Gcm),
                    new(Convert.FromBase64String("p2PA7MGy5tx56cnyJaFZMr96BCFwZeHjZV2EqMvTq54="),
                        Sealed.DecryptionAlgorithm.Aes256Gcm)
                }));
    }

    [Test]
    public void UnsealEventResponseWithInvalidNonce()
    {
        byte[] sealedResult = { 0x9E, 0x85, 0xDC, 0xED, 0xAA, 0xBB, 0xCC };

        var ex = Assert.Throws<Sealed.UnsealAggregateException>(() =>
            Sealed.UnsealEventResponse(
                sealedResult,
                new Sealed.DecryptionKey[]
                {
                    new(Convert.FromBase64String("aW52YWxpZA=="), Sealed.DecryptionAlgorithm.Aes256Gcm),
                    new(Convert.FromBase64String("p2PA7MGy5tx56cnyJaFZMr96BCFwZeHjZV2EqMvTq54="),
                        Sealed.DecryptionAlgorithm.Aes256Gcm)
                }));

        var lastError = ex!.UnsealExceptions.Last();
        Assert.That(lastError.InnerException, Is.InstanceOf(typeof(InvalidCipherTextException)));
    }
}
