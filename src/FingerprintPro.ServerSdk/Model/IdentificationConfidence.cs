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
    /// IdentificationConfidence
    /// </summary>
    [DataContract]
    public class IdentificationConfidence : IEquatable<IdentificationConfidence>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="IdentificationConfidence" /> class.
        /// </summary>
        /// <param name="score">The confidence score is a floating-point number between 0 and 1 that represents the probability of accurate identification. (required).</param>
        /// <param name="revision">The revision name of the method used to calculate the Confidence score. This field is only present for customers who opted in to an alternative calculation method..</param>
        /// <param name="comment">comment.</param>
        public IdentificationConfidence(double? score = default(double?), string revision = default(string), string comment = default(string))
        {
            // to ensure "score" is required (not null)
            // swagger debug: IdentificationConfidence Score

            if (score == null)
            {
                throw new InvalidDataException("score is a required property for IdentificationConfidence and cannot be null");
            }
            else
            {
                this.Score = score;
            }
            this.Revision = revision;
            this.Comment = comment;
        }

        /// <summary>
        /// The confidence score is a floating-point number between 0 and 1 that represents the probability of accurate identification.
        /// </summary>
        /// <value>The confidence score is a floating-point number between 0 and 1 that represents the probability of accurate identification.</value>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        [JsonPropertyName("score")]
        public double? Score { get; set; }

        /// <summary>
        /// The revision name of the method used to calculate the Confidence score. This field is only present for customers who opted in to an alternative calculation method.
        /// </summary>
        /// <value>The revision name of the method used to calculate the Confidence score. This field is only present for customers who opted in to an alternative calculation method.</value>
        [DataMember(Name = "revision", EmitDefaultValue = false)]
        [JsonPropertyName("revision")]
        public string Revision { get; set; }

        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        [JsonPropertyName("comment")]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentificationConfidence {\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
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
        /// Returns true if IdentificationConfidence instances are equal
        /// </summary>
        /// <param name="input">Instance of IdentificationConfidence to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentificationConfidence? input)
        {
            if (input == null)
                return false;

            return
                (
                this.Score == input.Score ||
                (this.Score != null &&
                this.Score.Equals(input.Score))
                ) &&
                (
                this.Revision == input.Revision ||
                (this.Revision != null &&
                this.Revision.Equals(input.Revision))
                ) &&
                (
                this.Comment == input.Comment ||
                (this.Comment != null &&
                this.Comment.Equals(input.Comment))
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
                if (this.Score != null)
                    hashCode = hashCode * 59 + this.Score.GetHashCode();
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                return hashCode;
            }
        }

    }
}