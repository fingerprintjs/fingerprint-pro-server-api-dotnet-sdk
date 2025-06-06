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
    /// VPNMethods
    /// </summary>
    [DataContract]
    public class VPNMethods : IEquatable<VPNMethods>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="VPNMethods" /> class.
        /// </summary>
        /// <param name="timezoneMismatch">The browser timezone doesn't match the timezone inferred from the request IP address. (required).</param>
        /// <param name="publicVPN">Request IP address is owned and used by a public VPN service provider. (required).</param>
        /// <param name="auxiliaryMobile">This method applies to mobile devices only. Indicates the result of additional methods used to detect a VPN in mobile devices. (required).</param>
        /// <param name="osMismatch">The browser runs on a different operating system than the operating system inferred from the request network signature. (required).</param>
        /// <param name="relay">Request IP address belongs to a relay service provider, indicating the use of relay services like [Apple Private relay](https://support.apple.com/en-us/102602) or [Cloudflare Warp](https://developers.cloudflare.com/warp-client/).   * Like VPNs, relay services anonymize the visitor's true IP address. * Unlike traditional VPNs, relay services don't let visitors spoof their location by choosing an exit node in a different country.  This field allows you to differentiate VPN users and relay service users in your fraud prevention logic.  (required).</param>
        public VPNMethods(bool? timezoneMismatch = default(bool?), bool? publicVPN = default(bool?), bool? auxiliaryMobile = default(bool?), bool? osMismatch = default(bool?), bool? relay = default(bool?))
        {
            // to ensure "timezoneMismatch" is required (not null)
            // swagger debug: VPNMethods TimezoneMismatch

            if (timezoneMismatch == null)
            {
                throw new InvalidDataException("timezoneMismatch is a required property for VPNMethods and cannot be null");
            }
            else
            {
                this.TimezoneMismatch = timezoneMismatch;
            }
            // to ensure "publicVPN" is required (not null)
            // swagger debug: VPNMethods PublicVPN

            if (publicVPN == null)
            {
                throw new InvalidDataException("publicVPN is a required property for VPNMethods and cannot be null");
            }
            else
            {
                this.PublicVPN = publicVPN;
            }
            // to ensure "auxiliaryMobile" is required (not null)
            // swagger debug: VPNMethods AuxiliaryMobile

            if (auxiliaryMobile == null)
            {
                throw new InvalidDataException("auxiliaryMobile is a required property for VPNMethods and cannot be null");
            }
            else
            {
                this.AuxiliaryMobile = auxiliaryMobile;
            }
            // to ensure "osMismatch" is required (not null)
            // swagger debug: VPNMethods OsMismatch

            if (osMismatch == null)
            {
                throw new InvalidDataException("osMismatch is a required property for VPNMethods and cannot be null");
            }
            else
            {
                this.OsMismatch = osMismatch;
            }
            // to ensure "relay" is required (not null)
            // swagger debug: VPNMethods Relay

            if (relay == null)
            {
                throw new InvalidDataException("relay is a required property for VPNMethods and cannot be null");
            }
            else
            {
                this.Relay = relay;
            }
        }

        /// <summary>
        /// The browser timezone doesn't match the timezone inferred from the request IP address.
        /// </summary>
        /// <value>The browser timezone doesn't match the timezone inferred from the request IP address.</value>
        [DataMember(Name = "timezoneMismatch", EmitDefaultValue = false)]
        [JsonPropertyName("timezoneMismatch")]
        public bool? TimezoneMismatch { get; set; }

        /// <summary>
        /// Request IP address is owned and used by a public VPN service provider.
        /// </summary>
        /// <value>Request IP address is owned and used by a public VPN service provider.</value>
        [DataMember(Name = "publicVPN", EmitDefaultValue = false)]
        [JsonPropertyName("publicVPN")]
        public bool? PublicVPN { get; set; }

        /// <summary>
        /// This method applies to mobile devices only. Indicates the result of additional methods used to detect a VPN in mobile devices.
        /// </summary>
        /// <value>This method applies to mobile devices only. Indicates the result of additional methods used to detect a VPN in mobile devices.</value>
        [DataMember(Name = "auxiliaryMobile", EmitDefaultValue = false)]
        [JsonPropertyName("auxiliaryMobile")]
        public bool? AuxiliaryMobile { get; set; }

        /// <summary>
        /// The browser runs on a different operating system than the operating system inferred from the request network signature.
        /// </summary>
        /// <value>The browser runs on a different operating system than the operating system inferred from the request network signature.</value>
        [DataMember(Name = "osMismatch", EmitDefaultValue = false)]
        [JsonPropertyName("osMismatch")]
        public bool? OsMismatch { get; set; }

        /// <summary>
        /// Request IP address belongs to a relay service provider, indicating the use of relay services like [Apple Private relay](https://support.apple.com/en-us/102602) or [Cloudflare Warp](https://developers.cloudflare.com/warp-client/).   * Like VPNs, relay services anonymize the visitor's true IP address. * Unlike traditional VPNs, relay services don't let visitors spoof their location by choosing an exit node in a different country.  This field allows you to differentiate VPN users and relay service users in your fraud prevention logic. 
        /// </summary>
        /// <value>Request IP address belongs to a relay service provider, indicating the use of relay services like [Apple Private relay](https://support.apple.com/en-us/102602) or [Cloudflare Warp](https://developers.cloudflare.com/warp-client/).   * Like VPNs, relay services anonymize the visitor's true IP address. * Unlike traditional VPNs, relay services don't let visitors spoof their location by choosing an exit node in a different country.  This field allows you to differentiate VPN users and relay service users in your fraud prevention logic. </value>
        [DataMember(Name = "relay", EmitDefaultValue = false)]
        [JsonPropertyName("relay")]
        public bool? Relay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VPNMethods {\n");
            sb.Append("  TimezoneMismatch: ").Append(TimezoneMismatch).Append("\n");
            sb.Append("  PublicVPN: ").Append(PublicVPN).Append("\n");
            sb.Append("  AuxiliaryMobile: ").Append(AuxiliaryMobile).Append("\n");
            sb.Append("  OsMismatch: ").Append(OsMismatch).Append("\n");
            sb.Append("  Relay: ").Append(Relay).Append("\n");
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
        /// Returns true if VPNMethods instances are equal
        /// </summary>
        /// <param name="input">Instance of VPNMethods to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VPNMethods? input)
        {
            if (input == null)
                return false;

            return
                (
                this.TimezoneMismatch == input.TimezoneMismatch ||
                (this.TimezoneMismatch != null &&
                this.TimezoneMismatch.Equals(input.TimezoneMismatch))
                ) &&
                (
                this.PublicVPN == input.PublicVPN ||
                (this.PublicVPN != null &&
                this.PublicVPN.Equals(input.PublicVPN))
                ) &&
                (
                this.AuxiliaryMobile == input.AuxiliaryMobile ||
                (this.AuxiliaryMobile != null &&
                this.AuxiliaryMobile.Equals(input.AuxiliaryMobile))
                ) &&
                (
                this.OsMismatch == input.OsMismatch ||
                (this.OsMismatch != null &&
                this.OsMismatch.Equals(input.OsMismatch))
                ) &&
                (
                this.Relay == input.Relay ||
                (this.Relay != null &&
                this.Relay.Equals(input.Relay))
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
                if (this.TimezoneMismatch != null)
                    hashCode = hashCode * 59 + this.TimezoneMismatch.GetHashCode();
                if (this.PublicVPN != null)
                    hashCode = hashCode * 59 + this.PublicVPN.GetHashCode();
                if (this.AuxiliaryMobile != null)
                    hashCode = hashCode * 59 + this.AuxiliaryMobile.GetHashCode();
                if (this.OsMismatch != null)
                    hashCode = hashCode * 59 + this.OsMismatch.GetHashCode();
                if (this.Relay != null)
                    hashCode = hashCode * 59 + this.Relay.GetHashCode();
                return hashCode;
            }
        }

    }
}
