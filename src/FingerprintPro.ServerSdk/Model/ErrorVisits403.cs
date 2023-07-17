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
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FingerprintPro.ServerSdk.Model
{
    /// <summary>
    /// ErrorVisits403
    /// </summary>
    [DataContract]
    public partial class ErrorVisits403 : IEquatable<ErrorVisits403>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorVisits403" /> class.
        /// </summary>
        /// <param name="error">Error text. (required).</param>
        public ErrorVisits403(string error = default(string))
        {
            // to ensure "error" is required (not null)

            if (error == null)
            {
                throw new InvalidDataException("error is a required property for ErrorVisits403 and cannot be null");
            }
            else
            {
                this.Error = error;
            }
        }

        /// <summary>
        /// Error text.
        /// </summary>
        /// <value>Error text.</value>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public string Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorVisits403 {\n");
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
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if ErrorVisits403 instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorVisits403 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorVisits403 input)
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