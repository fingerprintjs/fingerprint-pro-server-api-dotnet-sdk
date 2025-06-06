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
    /// RawDeviceAttribute
    /// </summary>
    [DataContract]
    public class RawDeviceAttribute : IEquatable<RawDeviceAttribute>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="RawDeviceAttribute" /> class.
        /// </summary>
        /// <param name="value">value.</param>
        /// <param name="error">error.</param>
        public RawDeviceAttribute(JsonElement? value = null, RawDeviceAttributeError error = default(RawDeviceAttributeError))
        {
            this.Value = value;
            this.Error = error;
        }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        [JsonPropertyName("value")]
        public JsonElement? Value { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        [JsonPropertyName("error")]
        public RawDeviceAttributeError Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RawDeviceAttribute {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
        /// Returns true if RawDeviceAttribute instances are equal
        /// </summary>
        /// <param name="input">Instance of RawDeviceAttribute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RawDeviceAttribute? input)
        {
            if (input == null)
                return false;

            return
                (
                this.Value.HasValue == input.Value.HasValue &&
                (!this.Value.HasValue ||
                this.Value.Value.Equals(input.Value.Value))
                ) &&
                (
                this.Error == input.Error ||
                (this.Error != null &&
                this.Error.Equals(input.Error))
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
                if (this.Value.HasValue)
                    hashCode = hashCode * 59 + this.Value.Value.GetHashCode();
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                return hashCode;
            }
        }

    }
}
