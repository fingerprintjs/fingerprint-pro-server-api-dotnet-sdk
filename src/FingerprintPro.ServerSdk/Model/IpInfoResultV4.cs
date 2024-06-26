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
    /// IpInfoResultV4
    /// </summary>
    [DataContract]
    public class IpInfoResultV4 : IEquatable<IpInfoResultV4>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="IpInfoResultV4" /> class.
        /// </summary>
        /// <param name="address">address (required).</param>
        /// <param name="geolocation">geolocation (required).</param>
        /// <param name="asn">asn.</param>
        /// <param name="datacenter">datacenter.</param>
        public IpInfoResultV4(string address = default(string), IPLocation geolocation = default(IPLocation), ASN asn = default(ASN), DataCenter datacenter = default(DataCenter))
        {
            // to ensure "address" is required (not null)
            // swagger debug: IpInfoResultV4 Address

            if (address == null)
            {
                throw new InvalidDataException("address is a required property for IpInfoResultV4 and cannot be null");
            }
            else
            {
                this.Address = address;
            }
            // to ensure "geolocation" is required (not null)
            // swagger debug: IpInfoResultV4 Geolocation

            if (geolocation == null)
            {
                throw new InvalidDataException("geolocation is a required property for IpInfoResultV4 and cannot be null");
            }
            else
            {
                this.Geolocation = geolocation;
            }
            this.Asn = asn;
            this.Datacenter = datacenter;
        }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Geolocation
        /// </summary>
        [DataMember(Name = "geolocation", EmitDefaultValue = false)]
        [JsonPropertyName("geolocation")]
        public IPLocation Geolocation { get; set; }

        /// <summary>
        /// Gets or Sets Asn
        /// </summary>
        [DataMember(Name = "asn", EmitDefaultValue = false)]
        [JsonPropertyName("asn")]
        public ASN Asn { get; set; }

        /// <summary>
        /// Gets or Sets Datacenter
        /// </summary>
        [DataMember(Name = "datacenter", EmitDefaultValue = false)]
        [JsonPropertyName("datacenter")]
        public DataCenter Datacenter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IpInfoResultV4 {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Geolocation: ").Append(Geolocation).Append("\n");
            sb.Append("  Asn: ").Append(Asn).Append("\n");
            sb.Append("  Datacenter: ").Append(Datacenter).Append("\n");
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
        /// Returns true if IpInfoResultV4 instances are equal
        /// </summary>
        /// <param name="input">Instance of IpInfoResultV4 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IpInfoResultV4 input)
        {
            if (input == null)
                return false;

            return
                (
                this.Address == input.Address ||
                (this.Address != null &&
                this.Address.Equals(input.Address))
                ) &&
                (
                this.Geolocation == input.Geolocation ||
                (this.Geolocation != null &&
                this.Geolocation.Equals(input.Geolocation))
                ) &&
                (
                this.Asn == input.Asn ||
                (this.Asn != null &&
                this.Asn.Equals(input.Asn))
                ) &&
                (
                this.Datacenter == input.Datacenter ||
                (this.Datacenter != null &&
                this.Datacenter.Equals(input.Datacenter))
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
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Geolocation != null)
                    hashCode = hashCode * 59 + this.Geolocation.GetHashCode();
                if (this.Asn != null)
                    hashCode = hashCode * 59 + this.Asn.GetHashCode();
                if (this.Datacenter != null)
                    hashCode = hashCode * 59 + this.Datacenter.GetHashCode();
                return hashCode;
            }
        }

    }
}
