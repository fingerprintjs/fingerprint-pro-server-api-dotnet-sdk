/* 
 * Fingerprint Server API
 *
 * Fingerprint Server API allows you to search, update, and delete identification events in a server environment. It can be used for data exports, decision-making, and data analysis scenarios. Server API is intended for server-side usage, it's not intended to be used from the client side, whether it's a browser or a mobile device. 
 *
 * OpenAPI spec version: 3
 * Contact: support@fingerprint.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System.Text;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Text.Json;
using FingerprintPro.ServerSdk.Json;

namespace FingerprintPro.ServerSdk.Model
{
    /// <summary>
    /// Webhook
    /// </summary>
    [DataContract]
    public class Webhook : IEquatable<Webhook>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="Webhook" /> class.
        /// </summary>
        /// <param name="requestId">Unique identifier of the user's request. (required).</param>
        /// <param name="url">Page URL from which the request was sent. (required).</param>
        /// <param name="ip">IP address of the requesting browser or bot. (required).</param>
        /// <param name="environmentId">Environment ID of the event..</param>
        /// <param name="tag">tag.</param>
        /// <param name="time">Time expressed according to ISO 8601 in UTC format, when the request from the JS agent was made. We recommend to treat requests that are older than 2 minutes as malicious. Otherwise, request replay attacks are possible. (required).</param>
        /// <param name="timestamp">Timestamp of the event with millisecond precision in Unix time. (required).</param>
        /// <param name="ipLocation">ipLocation.</param>
        /// <param name="linkedId">A customer-provided id that was sent with the request..</param>
        /// <param name="visitorId">String of 20 characters that uniquely identifies the visitor's browser..</param>
        /// <param name="visitorFound">Attribute represents if a visitor had been identified before..</param>
        /// <param name="confidence">confidence.</param>
        /// <param name="firstSeenAt">firstSeenAt.</param>
        /// <param name="lastSeenAt">lastSeenAt.</param>
        /// <param name="browserDetails">browserDetails.</param>
        /// <param name="incognito">Flag if user used incognito session..</param>
        /// <param name="clientReferrer">clientReferrer.</param>
        /// <param name="components">components.</param>
        /// <param name="bot">bot.</param>
        /// <param name="userAgent">userAgent.</param>
        /// <param name="rootApps">rootApps.</param>
        /// <param name="emulator">emulator.</param>
        /// <param name="ipInfo">ipInfo.</param>
        /// <param name="ipBlocklist">ipBlocklist.</param>
        /// <param name="tor">tor.</param>
        /// <param name="vpn">vpn.</param>
        /// <param name="proxy">proxy.</param>
        /// <param name="tampering">tampering.</param>
        /// <param name="clonedApp">clonedApp.</param>
        /// <param name="factoryReset">factoryReset.</param>
        /// <param name="jailbroken">jailbroken.</param>
        /// <param name="frida">frida.</param>
        /// <param name="privacySettings">privacySettings.</param>
        /// <param name="virtualMachine">virtualMachine.</param>
        /// <param name="rawDeviceAttributes">rawDeviceAttributes.</param>
        /// <param name="highActivity">highActivity.</param>
        /// <param name="locationSpoofing">locationSpoofing.</param>
        /// <param name="suspectScore">suspectScore.</param>
        /// <param name="remoteControl">remoteControl.</param>
        /// <param name="velocity">velocity.</param>
        /// <param name="developerTools">developerTools.</param>
        /// <param name="mitmAttack">mitmAttack.</param>
        /// <param name="replayed">`true` if we determined that this payload was replayed, `false` otherwise. .</param>
        public Webhook(string requestId = default(string), string url = default(string), string ip = default(string), string environmentId = default(string), Tag tag = default(Tag), DateTime? time = default(DateTime?), long? timestamp = default(long?), DeprecatedGeolocation ipLocation = default(DeprecatedGeolocation), string linkedId = default(string), string visitorId = default(string), bool? visitorFound = default(bool?), IdentificationConfidence confidence = default(IdentificationConfidence), IdentificationSeenAt firstSeenAt = default(IdentificationSeenAt), IdentificationSeenAt lastSeenAt = default(IdentificationSeenAt), BrowserDetails browserDetails = default(BrowserDetails), bool? incognito = default(bool?), string clientReferrer = default(string), RawDeviceAttributes components = default(RawDeviceAttributes), BotdBot bot = default(BotdBot), string userAgent = default(string), WebhookRootApps rootApps = default(WebhookRootApps), WebhookEmulator emulator = default(WebhookEmulator), WebhookIPInfo ipInfo = default(WebhookIPInfo), WebhookIPBlocklist ipBlocklist = default(WebhookIPBlocklist), WebhookTor tor = default(WebhookTor), WebhookVPN vpn = default(WebhookVPN), WebhookProxy proxy = default(WebhookProxy), WebhookTampering tampering = default(WebhookTampering), WebhookClonedApp clonedApp = default(WebhookClonedApp), WebhookFactoryReset factoryReset = default(WebhookFactoryReset), WebhookJailbroken jailbroken = default(WebhookJailbroken), WebhookFrida frida = default(WebhookFrida), WebhookPrivacySettings privacySettings = default(WebhookPrivacySettings), WebhookVirtualMachine virtualMachine = default(WebhookVirtualMachine), WebhookRawDeviceAttributes rawDeviceAttributes = default(WebhookRawDeviceAttributes), WebhookHighActivity highActivity = default(WebhookHighActivity), WebhookLocationSpoofing locationSpoofing = default(WebhookLocationSpoofing), WebhookSuspectScore suspectScore = default(WebhookSuspectScore), WebhookRemoteControl remoteControl = default(WebhookRemoteControl), WebhookVelocity velocity = default(WebhookVelocity), WebhookDeveloperTools developerTools = default(WebhookDeveloperTools), WebhookMitMAttack mitmAttack = default(WebhookMitMAttack), bool? replayed = default(bool?))
        {
            // to ensure "requestId" is required (not null)
            // swagger debug: Webhook RequestId

            if (requestId == null)
            {
                throw new InvalidDataException("requestId is a required property for Webhook and cannot be null");
            }
            else
            {
                this.RequestId = requestId;
            }
            // to ensure "url" is required (not null)
            // swagger debug: Webhook Url

            if (url == null)
            {
                throw new InvalidDataException("url is a required property for Webhook and cannot be null");
            }
            else
            {
                this.Url = url;
            }
            // to ensure "ip" is required (not null)
            // swagger debug: Webhook Ip

            if (ip == null)
            {
                throw new InvalidDataException("ip is a required property for Webhook and cannot be null");
            }
            else
            {
                this.Ip = ip;
            }
            // to ensure "time" is required (not null)
            // swagger debug: Webhook Time

            if (time == null)
            {
                throw new InvalidDataException("time is a required property for Webhook and cannot be null");
            }
            else
            {
                this.Time = time;
            }
            // to ensure "timestamp" is required (not null)
            // swagger debug: Webhook Timestamp

            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for Webhook and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            this.EnvironmentId = environmentId;
            this.Tag = tag;
            this.IpLocation = ipLocation;
            this.LinkedId = linkedId;
            this.VisitorId = visitorId;
            this.VisitorFound = visitorFound;
            this.Confidence = confidence;
            this.FirstSeenAt = firstSeenAt;
            this.LastSeenAt = lastSeenAt;
            this.BrowserDetails = browserDetails;
            this.Incognito = incognito;
            this.ClientReferrer = clientReferrer;
            this.Components = components;
            this.Bot = bot;
            this.UserAgent = userAgent;
            this.RootApps = rootApps;
            this.Emulator = emulator;
            this.IpInfo = ipInfo;
            this.IpBlocklist = ipBlocklist;
            this.Tor = tor;
            this.Vpn = vpn;
            this.Proxy = proxy;
            this.Tampering = tampering;
            this.ClonedApp = clonedApp;
            this.FactoryReset = factoryReset;
            this.Jailbroken = jailbroken;
            this.Frida = frida;
            this.PrivacySettings = privacySettings;
            this.VirtualMachine = virtualMachine;
            this.RawDeviceAttributes = rawDeviceAttributes;
            this.HighActivity = highActivity;
            this.LocationSpoofing = locationSpoofing;
            this.SuspectScore = suspectScore;
            this.RemoteControl = remoteControl;
            this.Velocity = velocity;
            this.DeveloperTools = developerTools;
            this.MitmAttack = mitmAttack;
            this.Replayed = replayed;
        }

        /// <summary>
        /// Unique identifier of the user's request.
        /// </summary>
        /// <value>Unique identifier of the user's request.</value>
        [DataMember(Name = "requestId", EmitDefaultValue = false)]
        [JsonPropertyName("requestId")]
        public string RequestId { get; set; }

        /// <summary>
        /// Page URL from which the request was sent.
        /// </summary>
        /// <value>Page URL from which the request was sent.</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        [JsonPropertyName("url")]
        public string Url { get; set; }

        /// <summary>
        /// IP address of the requesting browser or bot.
        /// </summary>
        /// <value>IP address of the requesting browser or bot.</value>
        [DataMember(Name = "ip", EmitDefaultValue = false)]
        [JsonPropertyName("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// Environment ID of the event.
        /// </summary>
        /// <value>Environment ID of the event.</value>
        [DataMember(Name = "environmentId", EmitDefaultValue = false)]
        [JsonPropertyName("environmentId")]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Gets or Sets Tag
        /// </summary>
        [DataMember(Name = "tag", EmitDefaultValue = false)]
        [JsonPropertyName("tag")]
        public Tag Tag { get; set; }

        /// <summary>
        /// Time expressed according to ISO 8601 in UTC format, when the request from the JS agent was made. We recommend to treat requests that are older than 2 minutes as malicious. Otherwise, request replay attacks are possible.
        /// </summary>
        /// <value>Time expressed according to ISO 8601 in UTC format, when the request from the JS agent was made. We recommend to treat requests that are older than 2 minutes as malicious. Otherwise, request replay attacks are possible.</value>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        [JsonPropertyName("time")]
        public DateTime? Time { get; set; }

        /// <summary>
        /// Timestamp of the event with millisecond precision in Unix time.
        /// </summary>
        /// <value>Timestamp of the event with millisecond precision in Unix time.</value>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        [JsonPropertyName("timestamp")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets IpLocation
        /// </summary>
        [DataMember(Name = "ipLocation", EmitDefaultValue = false)]
        [JsonPropertyName("ipLocation")]
        public DeprecatedGeolocation IpLocation { get; set; }

        /// <summary>
        /// A customer-provided id that was sent with the request.
        /// </summary>
        /// <value>A customer-provided id that was sent with the request.</value>
        [DataMember(Name = "linkedId", EmitDefaultValue = false)]
        [JsonPropertyName("linkedId")]
        public string LinkedId { get; set; }

        /// <summary>
        /// String of 20 characters that uniquely identifies the visitor's browser.
        /// </summary>
        /// <value>String of 20 characters that uniquely identifies the visitor's browser.</value>
        [DataMember(Name = "visitorId", EmitDefaultValue = false)]
        [JsonPropertyName("visitorId")]
        public string VisitorId { get; set; }

        /// <summary>
        /// Attribute represents if a visitor had been identified before.
        /// </summary>
        /// <value>Attribute represents if a visitor had been identified before.</value>
        [DataMember(Name = "visitorFound", EmitDefaultValue = false)]
        [JsonPropertyName("visitorFound")]
        public bool? VisitorFound { get; set; }

        /// <summary>
        /// Gets or Sets Confidence
        /// </summary>
        [DataMember(Name = "confidence", EmitDefaultValue = false)]
        [JsonPropertyName("confidence")]
        public IdentificationConfidence Confidence { get; set; }

        /// <summary>
        /// Gets or Sets FirstSeenAt
        /// </summary>
        [DataMember(Name = "firstSeenAt", EmitDefaultValue = false)]
        [JsonPropertyName("firstSeenAt")]
        public IdentificationSeenAt FirstSeenAt { get; set; }

        /// <summary>
        /// Gets or Sets LastSeenAt
        /// </summary>
        [DataMember(Name = "lastSeenAt", EmitDefaultValue = false)]
        [JsonPropertyName("lastSeenAt")]
        public IdentificationSeenAt LastSeenAt { get; set; }

        /// <summary>
        /// Gets or Sets BrowserDetails
        /// </summary>
        [DataMember(Name = "browserDetails", EmitDefaultValue = false)]
        [JsonPropertyName("browserDetails")]
        public BrowserDetails BrowserDetails { get; set; }

        /// <summary>
        /// Flag if user used incognito session.
        /// </summary>
        /// <value>Flag if user used incognito session.</value>
        [DataMember(Name = "incognito", EmitDefaultValue = false)]
        [JsonPropertyName("incognito")]
        public bool? Incognito { get; set; }

        /// <summary>
        /// Gets or Sets ClientReferrer
        /// </summary>
        [DataMember(Name = "clientReferrer", EmitDefaultValue = false)]
        [JsonPropertyName("clientReferrer")]
        public string ClientReferrer { get; set; }

        /// <summary>
        /// Gets or Sets Components
        /// </summary>
        [DataMember(Name = "components", EmitDefaultValue = false)]
        [JsonPropertyName("components")]
        public RawDeviceAttributes Components { get; set; }

        /// <summary>
        /// Gets or Sets Bot
        /// </summary>
        [DataMember(Name = "bot", EmitDefaultValue = false)]
        [JsonPropertyName("bot")]
        public BotdBot Bot { get; set; }

        /// <summary>
        /// Gets or Sets UserAgent
        /// </summary>
        [DataMember(Name = "userAgent", EmitDefaultValue = false)]
        [JsonPropertyName("userAgent")]
        public string UserAgent { get; set; }

        /// <summary>
        /// Gets or Sets RootApps
        /// </summary>
        [DataMember(Name = "rootApps", EmitDefaultValue = false)]
        [JsonPropertyName("rootApps")]
        public WebhookRootApps RootApps { get; set; }

        /// <summary>
        /// Gets or Sets Emulator
        /// </summary>
        [DataMember(Name = "emulator", EmitDefaultValue = false)]
        [JsonPropertyName("emulator")]
        public WebhookEmulator Emulator { get; set; }

        /// <summary>
        /// Gets or Sets IpInfo
        /// </summary>
        [DataMember(Name = "ipInfo", EmitDefaultValue = false)]
        [JsonPropertyName("ipInfo")]
        public WebhookIPInfo IpInfo { get; set; }

        /// <summary>
        /// Gets or Sets IpBlocklist
        /// </summary>
        [DataMember(Name = "ipBlocklist", EmitDefaultValue = false)]
        [JsonPropertyName("ipBlocklist")]
        public WebhookIPBlocklist IpBlocklist { get; set; }

        /// <summary>
        /// Gets or Sets Tor
        /// </summary>
        [DataMember(Name = "tor", EmitDefaultValue = false)]
        [JsonPropertyName("tor")]
        public WebhookTor Tor { get; set; }

        /// <summary>
        /// Gets or Sets Vpn
        /// </summary>
        [DataMember(Name = "vpn", EmitDefaultValue = false)]
        [JsonPropertyName("vpn")]
        public WebhookVPN Vpn { get; set; }

        /// <summary>
        /// Gets or Sets Proxy
        /// </summary>
        [DataMember(Name = "proxy", EmitDefaultValue = false)]
        [JsonPropertyName("proxy")]
        public WebhookProxy Proxy { get; set; }

        /// <summary>
        /// Gets or Sets Tampering
        /// </summary>
        [DataMember(Name = "tampering", EmitDefaultValue = false)]
        [JsonPropertyName("tampering")]
        public WebhookTampering Tampering { get; set; }

        /// <summary>
        /// Gets or Sets ClonedApp
        /// </summary>
        [DataMember(Name = "clonedApp", EmitDefaultValue = false)]
        [JsonPropertyName("clonedApp")]
        public WebhookClonedApp ClonedApp { get; set; }

        /// <summary>
        /// Gets or Sets FactoryReset
        /// </summary>
        [DataMember(Name = "factoryReset", EmitDefaultValue = false)]
        [JsonPropertyName("factoryReset")]
        public WebhookFactoryReset FactoryReset { get; set; }

        /// <summary>
        /// Gets or Sets Jailbroken
        /// </summary>
        [DataMember(Name = "jailbroken", EmitDefaultValue = false)]
        [JsonPropertyName("jailbroken")]
        public WebhookJailbroken Jailbroken { get; set; }

        /// <summary>
        /// Gets or Sets Frida
        /// </summary>
        [DataMember(Name = "frida", EmitDefaultValue = false)]
        [JsonPropertyName("frida")]
        public WebhookFrida Frida { get; set; }

        /// <summary>
        /// Gets or Sets PrivacySettings
        /// </summary>
        [DataMember(Name = "privacySettings", EmitDefaultValue = false)]
        [JsonPropertyName("privacySettings")]
        public WebhookPrivacySettings PrivacySettings { get; set; }

        /// <summary>
        /// Gets or Sets VirtualMachine
        /// </summary>
        [DataMember(Name = "virtualMachine", EmitDefaultValue = false)]
        [JsonPropertyName("virtualMachine")]
        public WebhookVirtualMachine VirtualMachine { get; set; }

        /// <summary>
        /// Gets or Sets RawDeviceAttributes
        /// </summary>
        [DataMember(Name = "rawDeviceAttributes", EmitDefaultValue = false)]
        [JsonPropertyName("rawDeviceAttributes")]
        public WebhookRawDeviceAttributes RawDeviceAttributes { get; set; }

        /// <summary>
        /// Gets or Sets HighActivity
        /// </summary>
        [DataMember(Name = "highActivity", EmitDefaultValue = false)]
        [JsonPropertyName("highActivity")]
        public WebhookHighActivity HighActivity { get; set; }

        /// <summary>
        /// Gets or Sets LocationSpoofing
        /// </summary>
        [DataMember(Name = "locationSpoofing", EmitDefaultValue = false)]
        [JsonPropertyName("locationSpoofing")]
        public WebhookLocationSpoofing LocationSpoofing { get; set; }

        /// <summary>
        /// Gets or Sets SuspectScore
        /// </summary>
        [DataMember(Name = "suspectScore", EmitDefaultValue = false)]
        [JsonPropertyName("suspectScore")]
        public WebhookSuspectScore SuspectScore { get; set; }

        /// <summary>
        /// Gets or Sets RemoteControl
        /// </summary>
        [DataMember(Name = "remoteControl", EmitDefaultValue = false)]
        [JsonPropertyName("remoteControl")]
        public WebhookRemoteControl RemoteControl { get; set; }

        /// <summary>
        /// Gets or Sets Velocity
        /// </summary>
        [DataMember(Name = "velocity", EmitDefaultValue = false)]
        [JsonPropertyName("velocity")]
        public WebhookVelocity Velocity { get; set; }

        /// <summary>
        /// Gets or Sets DeveloperTools
        /// </summary>
        [DataMember(Name = "developerTools", EmitDefaultValue = false)]
        [JsonPropertyName("developerTools")]
        public WebhookDeveloperTools DeveloperTools { get; set; }

        /// <summary>
        /// Gets or Sets MitmAttack
        /// </summary>
        [DataMember(Name = "mitmAttack", EmitDefaultValue = false)]
        [JsonPropertyName("mitmAttack")]
        public WebhookMitMAttack MitmAttack { get; set; }

        /// <summary>
        /// `true` if we determined that this payload was replayed, `false` otherwise. 
        /// </summary>
        /// <value>`true` if we determined that this payload was replayed, `false` otherwise. </value>
        [DataMember(Name = "replayed", EmitDefaultValue = false)]
        [JsonPropertyName("replayed")]
        public bool? Replayed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Webhook {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  EnvironmentId: ").Append(EnvironmentId).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  IpLocation: ").Append(IpLocation).Append("\n");
            sb.Append("  LinkedId: ").Append(LinkedId).Append("\n");
            sb.Append("  VisitorId: ").Append(VisitorId).Append("\n");
            sb.Append("  VisitorFound: ").Append(VisitorFound).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  FirstSeenAt: ").Append(FirstSeenAt).Append("\n");
            sb.Append("  LastSeenAt: ").Append(LastSeenAt).Append("\n");
            sb.Append("  BrowserDetails: ").Append(BrowserDetails).Append("\n");
            sb.Append("  Incognito: ").Append(Incognito).Append("\n");
            sb.Append("  ClientReferrer: ").Append(ClientReferrer).Append("\n");
            sb.Append("  Components: ").Append(Components).Append("\n");
            sb.Append("  Bot: ").Append(Bot).Append("\n");
            sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
            sb.Append("  RootApps: ").Append(RootApps).Append("\n");
            sb.Append("  Emulator: ").Append(Emulator).Append("\n");
            sb.Append("  IpInfo: ").Append(IpInfo).Append("\n");
            sb.Append("  IpBlocklist: ").Append(IpBlocklist).Append("\n");
            sb.Append("  Tor: ").Append(Tor).Append("\n");
            sb.Append("  Vpn: ").Append(Vpn).Append("\n");
            sb.Append("  Proxy: ").Append(Proxy).Append("\n");
            sb.Append("  Tampering: ").Append(Tampering).Append("\n");
            sb.Append("  ClonedApp: ").Append(ClonedApp).Append("\n");
            sb.Append("  FactoryReset: ").Append(FactoryReset).Append("\n");
            sb.Append("  Jailbroken: ").Append(Jailbroken).Append("\n");
            sb.Append("  Frida: ").Append(Frida).Append("\n");
            sb.Append("  PrivacySettings: ").Append(PrivacySettings).Append("\n");
            sb.Append("  VirtualMachine: ").Append(VirtualMachine).Append("\n");
            sb.Append("  RawDeviceAttributes: ").Append(RawDeviceAttributes).Append("\n");
            sb.Append("  HighActivity: ").Append(HighActivity).Append("\n");
            sb.Append("  LocationSpoofing: ").Append(LocationSpoofing).Append("\n");
            sb.Append("  SuspectScore: ").Append(SuspectScore).Append("\n");
            sb.Append("  RemoteControl: ").Append(RemoteControl).Append("\n");
            sb.Append("  Velocity: ").Append(Velocity).Append("\n");
            sb.Append("  DeveloperTools: ").Append(DeveloperTools).Append("\n");
            sb.Append("  MitmAttack: ").Append(MitmAttack).Append("\n");
            sb.Append("  Replayed: ").Append(Replayed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonUtils.Serialize(this);
        }

        /// <summary>
        /// Returns true if Webhook instances are equal
        /// </summary>
        /// <param name="input">Instance of Webhook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Webhook? input)
        {
            if (input == null)
                return false;

            return
                (
                this.RequestId == input.RequestId ||
                (this.RequestId != null &&
                this.RequestId.Equals(input.RequestId))
                ) &&
                (
                this.Url == input.Url ||
                (this.Url != null &&
                this.Url.Equals(input.Url))
                ) &&
                (
                this.Ip == input.Ip ||
                (this.Ip != null &&
                this.Ip.Equals(input.Ip))
                ) &&
                (
                this.EnvironmentId == input.EnvironmentId ||
                (this.EnvironmentId != null &&
                this.EnvironmentId.Equals(input.EnvironmentId))
                ) &&
                (
                this.Tag == input.Tag ||
                (this.Tag != null &&
                this.Tag.Equals(input.Tag))
                ) &&
                (
                this.Time == input.Time ||
                (this.Time != null &&
                this.Time.Equals(input.Time))
                ) &&
                (
                this.Timestamp == input.Timestamp ||
                (this.Timestamp != null &&
                this.Timestamp.Equals(input.Timestamp))
                ) &&
                (
                this.IpLocation == input.IpLocation ||
                (this.IpLocation != null &&
                this.IpLocation.Equals(input.IpLocation))
                ) &&
                (
                this.LinkedId == input.LinkedId ||
                (this.LinkedId != null &&
                this.LinkedId.Equals(input.LinkedId))
                ) &&
                (
                this.VisitorId == input.VisitorId ||
                (this.VisitorId != null &&
                this.VisitorId.Equals(input.VisitorId))
                ) &&
                (
                this.VisitorFound == input.VisitorFound ||
                (this.VisitorFound != null &&
                this.VisitorFound.Equals(input.VisitorFound))
                ) &&
                (
                this.Confidence == input.Confidence ||
                (this.Confidence != null &&
                this.Confidence.Equals(input.Confidence))
                ) &&
                (
                this.FirstSeenAt == input.FirstSeenAt ||
                (this.FirstSeenAt != null &&
                this.FirstSeenAt.Equals(input.FirstSeenAt))
                ) &&
                (
                this.LastSeenAt == input.LastSeenAt ||
                (this.LastSeenAt != null &&
                this.LastSeenAt.Equals(input.LastSeenAt))
                ) &&
                (
                this.BrowserDetails == input.BrowserDetails ||
                (this.BrowserDetails != null &&
                this.BrowserDetails.Equals(input.BrowserDetails))
                ) &&
                (
                this.Incognito == input.Incognito ||
                (this.Incognito != null &&
                this.Incognito.Equals(input.Incognito))
                ) &&
                (
                this.ClientReferrer == input.ClientReferrer ||
                (this.ClientReferrer != null &&
                this.ClientReferrer.Equals(input.ClientReferrer))
                ) &&
                (
                this.Components == input.Components ||
                (this.Components != null &&
                this.Components.Equals(input.Components))
                ) &&
                (
                this.Bot == input.Bot ||
                (this.Bot != null &&
                this.Bot.Equals(input.Bot))
                ) &&
                (
                this.UserAgent == input.UserAgent ||
                (this.UserAgent != null &&
                this.UserAgent.Equals(input.UserAgent))
                ) &&
                (
                this.RootApps == input.RootApps ||
                (this.RootApps != null &&
                this.RootApps.Equals(input.RootApps))
                ) &&
                (
                this.Emulator == input.Emulator ||
                (this.Emulator != null &&
                this.Emulator.Equals(input.Emulator))
                ) &&
                (
                this.IpInfo == input.IpInfo ||
                (this.IpInfo != null &&
                this.IpInfo.Equals(input.IpInfo))
                ) &&
                (
                this.IpBlocklist == input.IpBlocklist ||
                (this.IpBlocklist != null &&
                this.IpBlocklist.Equals(input.IpBlocklist))
                ) &&
                (
                this.Tor == input.Tor ||
                (this.Tor != null &&
                this.Tor.Equals(input.Tor))
                ) &&
                (
                this.Vpn == input.Vpn ||
                (this.Vpn != null &&
                this.Vpn.Equals(input.Vpn))
                ) &&
                (
                this.Proxy == input.Proxy ||
                (this.Proxy != null &&
                this.Proxy.Equals(input.Proxy))
                ) &&
                (
                this.Tampering == input.Tampering ||
                (this.Tampering != null &&
                this.Tampering.Equals(input.Tampering))
                ) &&
                (
                this.ClonedApp == input.ClonedApp ||
                (this.ClonedApp != null &&
                this.ClonedApp.Equals(input.ClonedApp))
                ) &&
                (
                this.FactoryReset == input.FactoryReset ||
                (this.FactoryReset != null &&
                this.FactoryReset.Equals(input.FactoryReset))
                ) &&
                (
                this.Jailbroken == input.Jailbroken ||
                (this.Jailbroken != null &&
                this.Jailbroken.Equals(input.Jailbroken))
                ) &&
                (
                this.Frida == input.Frida ||
                (this.Frida != null &&
                this.Frida.Equals(input.Frida))
                ) &&
                (
                this.PrivacySettings == input.PrivacySettings ||
                (this.PrivacySettings != null &&
                this.PrivacySettings.Equals(input.PrivacySettings))
                ) &&
                (
                this.VirtualMachine == input.VirtualMachine ||
                (this.VirtualMachine != null &&
                this.VirtualMachine.Equals(input.VirtualMachine))
                ) &&
                (
                this.RawDeviceAttributes == input.RawDeviceAttributes ||
                (this.RawDeviceAttributes != null &&
                this.RawDeviceAttributes.Equals(input.RawDeviceAttributes))
                ) &&
                (
                this.HighActivity == input.HighActivity ||
                (this.HighActivity != null &&
                this.HighActivity.Equals(input.HighActivity))
                ) &&
                (
                this.LocationSpoofing == input.LocationSpoofing ||
                (this.LocationSpoofing != null &&
                this.LocationSpoofing.Equals(input.LocationSpoofing))
                ) &&
                (
                this.SuspectScore == input.SuspectScore ||
                (this.SuspectScore != null &&
                this.SuspectScore.Equals(input.SuspectScore))
                ) &&
                (
                this.RemoteControl == input.RemoteControl ||
                (this.RemoteControl != null &&
                this.RemoteControl.Equals(input.RemoteControl))
                ) &&
                (
                this.Velocity == input.Velocity ||
                (this.Velocity != null &&
                this.Velocity.Equals(input.Velocity))
                ) &&
                (
                this.DeveloperTools == input.DeveloperTools ||
                (this.DeveloperTools != null &&
                this.DeveloperTools.Equals(input.DeveloperTools))
                ) &&
                (
                this.MitmAttack == input.MitmAttack ||
                (this.MitmAttack != null &&
                this.MitmAttack.Equals(input.MitmAttack))
                ) &&
                (
                this.Replayed == input.Replayed ||
                (this.Replayed != null &&
                this.Replayed.Equals(input.Replayed))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Ip != null)
                    hashCode = hashCode * 59 + this.Ip.GetHashCode();
                if (this.EnvironmentId != null)
                    hashCode = hashCode * 59 + this.EnvironmentId.GetHashCode();
                if (this.Tag != null)
                    hashCode = hashCode * 59 + this.Tag.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.IpLocation != null)
                    hashCode = hashCode * 59 + this.IpLocation.GetHashCode();
                if (this.LinkedId != null)
                    hashCode = hashCode * 59 + this.LinkedId.GetHashCode();
                if (this.VisitorId != null)
                    hashCode = hashCode * 59 + this.VisitorId.GetHashCode();
                if (this.VisitorFound != null)
                    hashCode = hashCode * 59 + this.VisitorFound.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.FirstSeenAt != null)
                    hashCode = hashCode * 59 + this.FirstSeenAt.GetHashCode();
                if (this.LastSeenAt != null)
                    hashCode = hashCode * 59 + this.LastSeenAt.GetHashCode();
                if (this.BrowserDetails != null)
                    hashCode = hashCode * 59 + this.BrowserDetails.GetHashCode();
                if (this.Incognito != null)
                    hashCode = hashCode * 59 + this.Incognito.GetHashCode();
                if (this.ClientReferrer != null)
                    hashCode = hashCode * 59 + this.ClientReferrer.GetHashCode();
                if (this.Components != null)
                    hashCode = hashCode * 59 + this.Components.GetHashCode();
                if (this.Bot != null)
                    hashCode = hashCode * 59 + this.Bot.GetHashCode();
                if (this.UserAgent != null)
                    hashCode = hashCode * 59 + this.UserAgent.GetHashCode();
                if (this.RootApps != null)
                    hashCode = hashCode * 59 + this.RootApps.GetHashCode();
                if (this.Emulator != null)
                    hashCode = hashCode * 59 + this.Emulator.GetHashCode();
                if (this.IpInfo != null)
                    hashCode = hashCode * 59 + this.IpInfo.GetHashCode();
                if (this.IpBlocklist != null)
                    hashCode = hashCode * 59 + this.IpBlocklist.GetHashCode();
                if (this.Tor != null)
                    hashCode = hashCode * 59 + this.Tor.GetHashCode();
                if (this.Vpn != null)
                    hashCode = hashCode * 59 + this.Vpn.GetHashCode();
                if (this.Proxy != null)
                    hashCode = hashCode * 59 + this.Proxy.GetHashCode();
                if (this.Tampering != null)
                    hashCode = hashCode * 59 + this.Tampering.GetHashCode();
                if (this.ClonedApp != null)
                    hashCode = hashCode * 59 + this.ClonedApp.GetHashCode();
                if (this.FactoryReset != null)
                    hashCode = hashCode * 59 + this.FactoryReset.GetHashCode();
                if (this.Jailbroken != null)
                    hashCode = hashCode * 59 + this.Jailbroken.GetHashCode();
                if (this.Frida != null)
                    hashCode = hashCode * 59 + this.Frida.GetHashCode();
                if (this.PrivacySettings != null)
                    hashCode = hashCode * 59 + this.PrivacySettings.GetHashCode();
                if (this.VirtualMachine != null)
                    hashCode = hashCode * 59 + this.VirtualMachine.GetHashCode();
                if (this.RawDeviceAttributes != null)
                    hashCode = hashCode * 59 + this.RawDeviceAttributes.GetHashCode();
                if (this.HighActivity != null)
                    hashCode = hashCode * 59 + this.HighActivity.GetHashCode();
                if (this.LocationSpoofing != null)
                    hashCode = hashCode * 59 + this.LocationSpoofing.GetHashCode();
                if (this.SuspectScore != null)
                    hashCode = hashCode * 59 + this.SuspectScore.GetHashCode();
                if (this.RemoteControl != null)
                    hashCode = hashCode * 59 + this.RemoteControl.GetHashCode();
                if (this.Velocity != null)
                    hashCode = hashCode * 59 + this.Velocity.GetHashCode();
                if (this.DeveloperTools != null)
                    hashCode = hashCode * 59 + this.DeveloperTools.GetHashCode();
                if (this.MitmAttack != null)
                    hashCode = hashCode * 59 + this.MitmAttack.GetHashCode();
                if (this.Replayed != null)
                    hashCode = hashCode * 59 + this.Replayed.GetHashCode();
                return hashCode;
            }
        }

    }
}
