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
    /// IdentificationSeenAt
    /// </summary>
    [DataContract]
    public class IdentificationSeenAt : IEquatable<IdentificationSeenAt>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="IdentificationSeenAt" /> class.
        /// </summary>
        /// <param name="global">global (required).</param>
        /// <param name="subscription">subscription (required).</param>
        public IdentificationSeenAt(DateTime? global = default(DateTime?), DateTime? subscription = default(DateTime?))
        {
            this.Global = global;
            this.Subscription = subscription;
        }

        /// <summary>
        /// Gets or Sets Global
        /// </summary>
        [DataMember(Name = "global", EmitDefaultValue = false)]
        [JsonPropertyName("global")]
        public DateTime? Global { get; set; }

        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name = "subscription", EmitDefaultValue = false)]
        [JsonPropertyName("subscription")]
        public DateTime? Subscription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentificationSeenAt {\n");
            sb.Append("  Global: ").Append(Global).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
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
        /// Returns true if IdentificationSeenAt instances are equal
        /// </summary>
        /// <param name="input">Instance of IdentificationSeenAt to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentificationSeenAt? input)
        {
            if (input == null)
                return false;

            return
                (
                this.Global == input.Global ||
                (this.Global != null &&
                this.Global.Equals(input.Global))
                ) &&
                (
                this.Subscription == input.Subscription ||
                (this.Subscription != null &&
                this.Subscription.Equals(input.Subscription))
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
                if (this.Global != null)
                    hashCode = hashCode * 59 + this.Global.GetHashCode();
                if (this.Subscription != null)
                    hashCode = hashCode * 59 + this.Subscription.GetHashCode();
                return hashCode;
            }
        }

    }
}
