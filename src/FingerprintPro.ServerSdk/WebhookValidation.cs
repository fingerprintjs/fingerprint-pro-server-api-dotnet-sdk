using System.Security.Cryptography;
using System.Text;

namespace FingerprintPro.ServerSdk;

public static class WebhookValidation
{
    private static bool IsValidHmacSignature(string signature, byte[] data, string secret)
    {
        using var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(secret));

        var computedHash = hmac.ComputeHash(data);
        var computedHashHex = BitConverter.ToString(computedHash).Replace("-", "").ToLower();
        return signature == computedHashHex;
    }

    /// <summary>
    /// Verifies the HMAC signature extracted from the "fpjs-event-signature" header of the incoming request. This is a part of the webhook signing process, which is available only for enterprise customers.
    /// If you wish to enable it, please contact our support: https://fingerprint.com/support
    /// </summary>
    ///
    /// <param name="header">The value of the "fpjs-event-signature" header.</param>
    /// <param name="data">The raw data of the incoming request.</param>
    /// <param name="secret">The secret key used to sign the request</param>
    public static bool IsValidSignature(string header, byte[] data, string secret)
    {
        var signatures = header.Split(',');

        foreach (var signature in signatures)
        {
            var parts = signature.Split('=');
            if (parts.Length == 2)
            {
                var version = parts[0];
                var hash = parts[1];
                if (version == "v1" && IsValidHmacSignature(hash, data, secret))
                {
                    return true;
                }
            }
        }
        return false;
    }
}
