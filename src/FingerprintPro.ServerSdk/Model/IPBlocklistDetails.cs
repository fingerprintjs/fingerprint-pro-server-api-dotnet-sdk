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
    /// IPBlocklistDetails
    /// </summary>
    [DataContract]
    public class IPBlocklistDetails : IEquatable<IPBlocklistDetails>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="IPBlocklistDetails" /> class.
        /// </summary>
        /// <param name="emailSpam">IP address was part of a known email spam attack (SMTP). (required).</param>
        /// <param name="attackSource">IP address was part of a known network attack (SSH/HTTPS). (required).</param>
        public IPBlocklistDetails(bool? emailSpam = default(bool?), bool? attackSource = default(bool?))
        {
            // to ensure "emailSpam" is required (not null)
            // swagger debug: IPBlocklistDetails EmailSpam

            if (emailSpam == null)
            {
                throw new InvalidDataException("emailSpam is a required property for IPBlocklistDetails and cannot be null");
            }
            else
            {
                this.EmailSpam = emailSpam;
            }
            // to ensure "attackSource" is required (not null)
            // swagger debug: IPBlocklistDetails AttackSource

            if (attackSource == null)
            {
                throw new InvalidDataException("attackSource is a required property for IPBlocklistDetails and cannot be null");
            }
            else
            {
                this.AttackSource = attackSource;
            }
        }

        /// <summary>
        /// IP address was part of a known email spam attack (SMTP).
        /// </summary>
        /// <value>IP address was part of a known email spam attack (SMTP).</value>
        [DataMember(Name = "emailSpam", EmitDefaultValue = false)]
        [JsonPropertyName("emailSpam")]
        public bool? EmailSpam { get; set; }

        /// <summary>
        /// IP address was part of a known network attack (SSH/HTTPS).
        /// </summary>
        /// <value>IP address was part of a known network attack (SSH/HTTPS).</value>
        [DataMember(Name = "attackSource", EmitDefaultValue = false)]
        [JsonPropertyName("attackSource")]
        public bool? AttackSource { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IPBlocklistDetails {\n");
            sb.Append("  EmailSpam: ").Append(EmailSpam).Append("\n");
            sb.Append("  AttackSource: ").Append(AttackSource).Append("\n");
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
        /// Returns true if IPBlocklistDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of IPBlocklistDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IPBlocklistDetails? input)
        {
            if (input == null)
                return false;

            return
                (
                this.EmailSpam == input.EmailSpam ||
                (this.EmailSpam != null &&
                this.EmailSpam.Equals(input.EmailSpam))
                ) &&
                (
                this.AttackSource == input.AttackSource ||
                (this.AttackSource != null &&
                this.AttackSource.Equals(input.AttackSource))
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
                if (this.EmailSpam != null)
                    hashCode = hashCode * 59 + this.EmailSpam.GetHashCode();
                if (this.AttackSource != null)
                    hashCode = hashCode * 59 + this.AttackSource.GetHashCode();
                return hashCode;
            }
        }

    }
}
