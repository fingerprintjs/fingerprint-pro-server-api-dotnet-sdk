/* 
 * Fingerprint Pro Server API
 *
 * Fingerprint Pro Server API allows you to get information about visitors and about individual events in a server environment. It can be used for data exports, decision-making, and data analysis scenarios. Server API is intended for server-side usage, it's not intended to be used from the client side, whether it's a browser or a mobile device. 
 *
 * OpenAPI spec version: 3
 * Contact: support@fingerprint.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System.Text;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using FingerprintPro.ServerSdk.Json;

namespace FingerprintPro.ServerSdk.Model
{
    /// <summary>
    /// Bot detection result:  * `notDetected` - the visitor is not a bot  * `good` - good bot detected, such as Google bot, Baidu Spider, AlexaBot and so on  * `bad` - bad bot detected, such as Selenium, Puppeteer, Playwright, headless browsers, and so on 
    /// </summary>
    /// <value>Bot detection result:  * `notDetected` - the visitor is not a bot  * `good` - good bot detected, such as Google bot, Baidu Spider, AlexaBot and so on  * `bad` - bad bot detected, such as Selenium, Puppeteer, Playwright, headless browsers, and so on </value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BotdBotResult
    {
        /// <summary>
        /// Enum NotDetected for value: notDetected
        /// </summary>
        [EnumMember(Value = "notDetected")]
        NotDetected = 1,
        /// <summary>
        /// Enum Good for value: good
        /// </summary>
        [EnumMember(Value = "good")]
        Good = 2,
        /// <summary>
        /// Enum Bad for value: bad
        /// </summary>
        [EnumMember(Value = "bad")]
        Bad = 3
    }
}