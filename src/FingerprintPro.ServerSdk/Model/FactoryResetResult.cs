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
    /// FactoryResetResult
    /// </summary>
    [DataContract]
    public class FactoryResetResult : IEquatable<FactoryResetResult>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="FactoryResetResult" /> class.
        /// </summary>
        /// <param name="time">Time in UTC when the most recent factory reset of the Android or iOS device was done.  If there is no sign of factory reset or the client is not a mobile device, the field will contain the epoch time (1 January 1970) in UTC.  (required).</param>
        /// <param name="timestamp">Same value as it's in the `time` field but represented in timestamp format. (required).</param>
        public FactoryResetResult(DateTime? time = default(DateTime?), long? timestamp = default(long?))
        {
            // to ensure "time" is required (not null)
            // swagger debug: FactoryResetResult Time

            if (time == null)
            {
                throw new InvalidDataException("time is a required property for FactoryResetResult and cannot be null");
            }
            else
            {
                this.Time = time;
            }
            // to ensure "timestamp" is required (not null)
            // swagger debug: FactoryResetResult Timestamp

            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for FactoryResetResult and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
        }

        /// <summary>
        /// Time in UTC when the most recent factory reset of the Android or iOS device was done.  If there is no sign of factory reset or the client is not a mobile device, the field will contain the epoch time (1 January 1970) in UTC. 
        /// </summary>
        /// <value>Time in UTC when the most recent factory reset of the Android or iOS device was done.  If there is no sign of factory reset or the client is not a mobile device, the field will contain the epoch time (1 January 1970) in UTC. </value>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        [JsonPropertyName("time")]
        public DateTime? Time { get; set; }

        /// <summary>
        /// Same value as it's in the `time` field but represented in timestamp format.
        /// </summary>
        /// <value>Same value as it's in the `time` field but represented in timestamp format.</value>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        [JsonPropertyName("timestamp")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FactoryResetResult {\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
        /// Returns true if FactoryResetResult instances are equal
        /// </summary>
        /// <param name="input">Instance of FactoryResetResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FactoryResetResult input)
        {
            if (input == null)
                return false;

            return
                (
                this.Time == input.Time ||
                (this.Time != null &&
                this.Time.Equals(input.Time))
                ) &&
                (
                this.Timestamp == input.Timestamp ||
                (this.Timestamp != null &&
                this.Timestamp.Equals(input.Timestamp))
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
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                return hashCode;
            }
        }

    }
}
