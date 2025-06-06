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
    /// VelocityData
    /// </summary>
    [DataContract]
    public class VelocityData : IEquatable<VelocityData>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="VelocityData" /> class.
        /// </summary>
        /// <param name="intervals">intervals.</param>
        public VelocityData(VelocityIntervals intervals = default(VelocityIntervals))
        {
            this.Intervals = intervals;
        }

        /// <summary>
        /// Gets or Sets Intervals
        /// </summary>
        [DataMember(Name = "intervals", EmitDefaultValue = false)]
        [JsonPropertyName("intervals")]
        public VelocityIntervals Intervals { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VelocityData {\n");
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
        /// Returns true if VelocityData instances are equal
        /// </summary>
        /// <param name="input">Instance of VelocityData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VelocityData? input)
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
