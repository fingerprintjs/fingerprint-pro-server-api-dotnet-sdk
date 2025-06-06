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
    /// IPInfoDataCenter
    /// </summary>
    [DataContract]
    public class IPInfoDataCenter : IEquatable<IPInfoDataCenter>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="IPInfoDataCenter" /> class.
        /// </summary>
        /// <param name="result">result (required).</param>
        /// <param name="name">name (required).</param>
        public IPInfoDataCenter(bool? result = default(bool?), string name = default(string))
        {
            // to ensure "result" is required (not null)
            // swagger debug: IPInfoDataCenter Result

            if (result == null)
            {
                throw new InvalidDataException("result is a required property for IPInfoDataCenter and cannot be null");
            }
            else
            {
                this.Result = result;
            }
            // to ensure "name" is required (not null)
            // swagger debug: IPInfoDataCenter Name

            if (name == null)
            {
                throw new InvalidDataException("name is a required property for IPInfoDataCenter and cannot be null");
            }
            else
            {
                this.Name = name;
            }
        }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        [JsonPropertyName("result")]
        public bool? Result { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IPInfoDataCenter {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
        /// Returns true if IPInfoDataCenter instances are equal
        /// </summary>
        /// <param name="input">Instance of IPInfoDataCenter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IPInfoDataCenter? input)
        {
            if (input == null)
                return false;

            return
                (
                this.Result == input.Result ||
                (this.Result != null &&
                this.Result.Equals(input.Result))
                ) &&
                (
                this.Name == input.Name ||
                (this.Name != null &&
                this.Name.Equals(input.Name))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                return hashCode;
            }
        }

    }
}
