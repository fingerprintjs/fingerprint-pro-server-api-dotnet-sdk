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
    /// ClonedApp
    /// </summary>
    [DataContract]
    public class ClonedApp : IEquatable<ClonedApp>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="ClonedApp" /> class.
        /// </summary>
        /// <param name="result">Android specific cloned application detection. There are 2 values:    * `true` - Presence of app cloners work detected (e.g. fully cloned application found or launch of it inside of a not main working profile detected).   * `false` - No signs of cloned application detected or the client is not Android.  (required).</param>
        public ClonedApp(bool? result = default(bool?))
        {
            // to ensure "result" is required (not null)
            // swagger debug: ClonedApp Result

            if (result == null)
            {
                throw new InvalidDataException("result is a required property for ClonedApp and cannot be null");
            }
            else
            {
                this.Result = result;
            }
        }

        /// <summary>
        /// Android specific cloned application detection. There are 2 values:    * `true` - Presence of app cloners work detected (e.g. fully cloned application found or launch of it inside of a not main working profile detected).   * `false` - No signs of cloned application detected or the client is not Android. 
        /// </summary>
        /// <value>Android specific cloned application detection. There are 2 values:    * `true` - Presence of app cloners work detected (e.g. fully cloned application found or launch of it inside of a not main working profile detected).   * `false` - No signs of cloned application detected or the client is not Android. </value>
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
            sb.Append("class ClonedApp {\n");
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
        /// Returns true if ClonedApp instances are equal
        /// </summary>
        /// <param name="input">Instance of ClonedApp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClonedApp? input)
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