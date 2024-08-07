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
    /// VelocityIntervals
    /// </summary>
    [DataContract]
    public class VelocityIntervals : IEquatable<VelocityIntervals>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="VelocityIntervals" /> class.
        /// </summary>
        /// <param name="intervals">intervals.</param>
        public VelocityIntervals(VelocityIntervalResult intervals = default(VelocityIntervalResult))
        {
            this.Intervals = intervals;
        }

        /// <summary>
        /// Gets or Sets Intervals
        /// </summary>
        [DataMember(Name = "intervals", EmitDefaultValue = false)]
        [JsonPropertyName("intervals")]
        public VelocityIntervalResult Intervals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VelocityIntervals {\n");
            sb.Append("  Intervals: ").Append(Intervals).Append("\n");
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
        /// Returns true if VelocityIntervals instances are equal
        /// </summary>
        /// <param name="input">Instance of VelocityIntervals to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VelocityIntervals input)
        {
            if (input == null)
                return false;

            return
                (
                this.Intervals == input.Intervals ||
                (this.Intervals != null &&
                this.Intervals.Equals(input.Intervals))
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
                if (this.Intervals != null)
                    hashCode = hashCode * 59 + this.Intervals.GetHashCode();
                return hashCode;
            }
        }

    }
}
