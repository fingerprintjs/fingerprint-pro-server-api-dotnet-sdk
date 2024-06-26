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
    /// ErrorVisitsDelete404Response
    /// </summary>
    [DataContract]
    public class ErrorVisitsDelete404Response : IEquatable<ErrorVisitsDelete404Response>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorVisitsDelete404Response" /> class.
        /// </summary>
        /// <param name="error">error.</param>
        public ErrorVisitsDelete404Response(ErrorVisitsDelete404ResponseError error = default(ErrorVisitsDelete404ResponseError))
        {
            this.Error = error;
        }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        [JsonPropertyName("error")]
        public ErrorVisitsDelete404ResponseError Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorVisitsDelete404Response {\n");
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
        /// Returns true if ErrorVisitsDelete404Response instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorVisitsDelete404Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorVisitsDelete404Response input)
        {
            if (input == null)
                return false;

            return
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
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                return hashCode;
            }
        }

    }
}
