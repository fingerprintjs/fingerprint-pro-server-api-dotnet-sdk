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
    /// Pagination-related fields `lastTimestamp` and `paginationKey` are included if you use a pagination parameter like `limit` or `before` and there is more data available on the next page.
    /// </summary>
    [DataContract]
    public class VisitorsGetResponse : IEquatable<VisitorsGetResponse>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="VisitorsGetResponse" /> class.
        /// </summary>
        /// <param name="visitorId">visitorId (required).</param>
        /// <param name="visits">visits (required).</param>
        /// <param name="lastTimestamp">⚠️ Deprecated paging attribute, please use `paginationKey` instead. Timestamp of the last visit in the current page of results. .</param>
        /// <param name="paginationKey">Request ID of the last visit in the current page of results. Use this value in the following request as the `paginationKey` parameter to get the next page of results..</param>
        public VisitorsGetResponse(string visitorId = default(string), List<Visit> visits = default(List<Visit>), long? lastTimestamp = default(long?), string paginationKey = default(string))
        {
            // to ensure "visitorId" is required (not null)
            // swagger debug: VisitorsGetResponse VisitorId

            if (visitorId == null)
            {
                throw new InvalidDataException("visitorId is a required property for VisitorsGetResponse and cannot be null");
            }
            else
            {
                this.VisitorId = visitorId;
            }
            // to ensure "visits" is required (not null)
            // swagger debug: VisitorsGetResponse Visits

            if (visits == null)
            {
                throw new InvalidDataException("visits is a required property for VisitorsGetResponse and cannot be null");
            }
            else
            {
                this.Visits = visits;
            }
            this.LastTimestamp = lastTimestamp;
            this.PaginationKey = paginationKey;
        }

        /// <summary>
        /// Gets or Sets VisitorId
        /// </summary>
        [DataMember(Name = "visitorId", EmitDefaultValue = false)]
        [JsonPropertyName("visitorId")]
        public string VisitorId { get; set; }

        /// <summary>
        /// Gets or Sets Visits
        /// </summary>
        [DataMember(Name = "visits", EmitDefaultValue = false)]
        [JsonPropertyName("visits")]
        public List<Visit> Visits { get; set; }

        /// <summary>
        /// ⚠️ Deprecated paging attribute, please use `paginationKey` instead. Timestamp of the last visit in the current page of results. 
        /// </summary>
        /// <value>⚠️ Deprecated paging attribute, please use `paginationKey` instead. Timestamp of the last visit in the current page of results. </value>
        [DataMember(Name = "lastTimestamp", EmitDefaultValue = false)]
        [JsonPropertyName("lastTimestamp")]
        public long? LastTimestamp { get; set; }

        /// <summary>
        /// Request ID of the last visit in the current page of results. Use this value in the following request as the `paginationKey` parameter to get the next page of results.
        /// </summary>
        /// <value>Request ID of the last visit in the current page of results. Use this value in the following request as the `paginationKey` parameter to get the next page of results.</value>
        [DataMember(Name = "paginationKey", EmitDefaultValue = false)]
        [JsonPropertyName("paginationKey")]
        public string PaginationKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VisitorsGetResponse {\n");
            sb.Append("  VisitorId: ").Append(VisitorId).Append("\n");
            sb.Append("  Visits: ").Append(Visits).Append("\n");
            sb.Append("  LastTimestamp: ").Append(LastTimestamp).Append("\n");
            sb.Append("  PaginationKey: ").Append(PaginationKey).Append("\n");
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
        /// Returns true if VisitorsGetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of VisitorsGetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VisitorsGetResponse? input)
        {
            if (input == null)
                return false;

            return
                (
                this.VisitorId == input.VisitorId ||
                (this.VisitorId != null &&
                this.VisitorId.Equals(input.VisitorId))
                ) &&
                (
                this.Visits == input.Visits ||
                this.Visits != null &&
                input.Visits != null &&
                this.Visits.SequenceEqual(input.Visits)
                ) &&
                (
                this.LastTimestamp == input.LastTimestamp ||
                (this.LastTimestamp != null &&
                this.LastTimestamp.Equals(input.LastTimestamp))
                ) &&
                (
                this.PaginationKey == input.PaginationKey ||
                (this.PaginationKey != null &&
                this.PaginationKey.Equals(input.PaginationKey))
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
                if (this.VisitorId != null)
                    hashCode = hashCode * 59 + this.VisitorId.GetHashCode();
                if (this.Visits != null)
                    hashCode = hashCode * 59 + this.Visits.GetHashCode();
                if (this.LastTimestamp != null)
                    hashCode = hashCode * 59 + this.LastTimestamp.GetHashCode();
                if (this.PaginationKey != null)
                    hashCode = hashCode * 59 + this.PaginationKey.GetHashCode();
                return hashCode;
            }
        }

    }
}
