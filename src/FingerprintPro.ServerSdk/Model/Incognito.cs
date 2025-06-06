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
    /// Incognito
    /// </summary>
    [DataContract]
    public class Incognito : IEquatable<Incognito>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="Incognito" /> class.
        /// </summary>
        /// <param name="result">`true` if we detected incognito mode used in the browser, `false` otherwise.  (required).</param>
        public Incognito(bool? result = default(bool?))
        {
            // to ensure "result" is required (not null)
            // swagger debug: Incognito Result

            if (result == null)
            {
                throw new InvalidDataException("result is a required property for Incognito and cannot be null");
            }
            else
            {
                this.Result = result;
            }
        }

        /// <summary>
        /// `true` if we detected incognito mode used in the browser, `false` otherwise. 
        /// </summary>
        /// <value>`true` if we detected incognito mode used in the browser, `false` otherwise. </value>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        [JsonPropertyName("result")]
        public bool? Result { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Incognito {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
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
        /// Returns true if Incognito instances are equal
        /// </summary>
        /// <param name="input">Instance of Incognito to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Incognito? input)
        {
            if (input == null)
                return false;

            return
                (
                this.Result == input.Result ||
                (this.Result != null &&
                this.Result.Equals(input.Result))
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
                if (this.Result != null)
                    hashCode = hashCode * 59 + this.Result.GetHashCode();
                return hashCode;
            }
        }

    }
}
