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
    /// WebhookDeveloperTools
    /// </summary>
    [DataContract]
    public class WebhookDeveloperTools : IEquatable<WebhookDeveloperTools>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeveloperTools" /> class.
        /// </summary>
        /// <param name="result">`true` if the browser is Chrome with DevTools open or Firefox with Developer Tools open, `false` otherwise. .</param>
        public WebhookDeveloperTools(bool? result = default(bool?))
        {
            this.Result = result;
        }

        /// <summary>
        /// `true` if the browser is Chrome with DevTools open or Firefox with Developer Tools open, `false` otherwise. 
        /// </summary>
        /// <value>`true` if the browser is Chrome with DevTools open or Firefox with Developer Tools open, `false` otherwise. </value>
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
            sb.Append("class WebhookDeveloperTools {\n");
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
        /// Returns true if WebhookDeveloperTools instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookDeveloperTools to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookDeveloperTools? input)
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
