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
    /// ErrorVisitor404ResponseError
    /// </summary>
    [DataContract]
    public class ErrorVisitor404ResponseError : IEquatable<ErrorVisitor404ResponseError>
    {
        /// <summary>
        /// Error code: * `VisitorNotFound` - The specified visitor ID was not found. It never existed or it may have already been deleted. 
        /// </summary>
        /// <value>Error code: * `VisitorNotFound` - The specified visitor ID was not found. It never existed or it may have already been deleted. </value>
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum VisitorNotFound for value: VisitorNotFound
            /// </summary>
            [EnumMember(Value = "VisitorNotFound")]
            VisitorNotFound = 1
        }
        /// <summary>
        /// Error code: * `VisitorNotFound` - The specified visitor ID was not found. It never existed or it may have already been deleted. 
        /// </summary>
        /// <value>Error code: * `VisitorNotFound` - The specified visitor ID was not found. It never existed or it may have already been deleted. </value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        [JsonPropertyName("code")]
        public CodeEnum Code { get; set; }


        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorVisitor404ResponseError" /> class.
        /// </summary>
        /// <param name="code">Error code: * `VisitorNotFound` - The specified visitor ID was not found. It never existed or it may have already been deleted.  (required).</param>
        /// <param name="message">message (required).</param>
        public ErrorVisitor404ResponseError(CodeEnum code = default(CodeEnum), string message = default(string))
        {
            // to ensure "code" is required (not null)
            // swagger debug: ErrorVisitor404ResponseError Code

            if (code == null)
            {
                throw new InvalidDataException("code is a required property for ErrorVisitor404ResponseError and cannot be null");
            }
            else
            {
                this.Code = code;
            }
            // to ensure "message" is required (not null)
            // swagger debug: ErrorVisitor404ResponseError Message

            if (message == null)
            {
                throw new InvalidDataException("message is a required property for ErrorVisitor404ResponseError and cannot be null");
            }
            else
            {
                this.Message = message;
            }
        }


        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorVisitor404ResponseError {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
        /// Returns true if ErrorVisitor404ResponseError instances are equal
        /// </summary>
        /// <param name="input">Instance of ErrorVisitor404ResponseError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorVisitor404ResponseError input)
        {
            if (input == null)
                return false;

            return
                (
                this.Code == input.Code ||
                (this.Code != null &&
                this.Code.Equals(input.Code))
                ) &&
                (
                this.Message == input.Message ||
                (this.Message != null &&
                this.Message.Equals(input.Message))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }

    }
}