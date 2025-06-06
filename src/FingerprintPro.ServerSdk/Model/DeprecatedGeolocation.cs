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
    /// This field is **deprecated** and will not return a result for **applications created after January 23rd, 2024**.  Please use the [IP Geolocation Smart signal](https://dev.fingerprint.com/docs/smart-signals-overview#ip-geolocation) for geolocation information.
    /// </summary>
    [DataContract]
    public class DeprecatedGeolocation : IEquatable<DeprecatedGeolocation>
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="DeprecatedGeolocation" /> class.
        /// </summary>
        /// <param name="accuracyRadius">The IP address is likely to be within this radius (in km) of the specified location..</param>
        /// <param name="latitude">latitude.</param>
        /// <param name="longitude">longitude.</param>
        /// <param name="postalCode">postalCode.</param>
        /// <param name="timezone">timezone.</param>
        /// <param name="city">city.</param>
        /// <param name="country">country.</param>
        /// <param name="continent">continent.</param>
        /// <param name="subdivisions">subdivisions.</param>
        public DeprecatedGeolocation(int? accuracyRadius = default(int?), double? latitude = default(double?), double? longitude = default(double?), string postalCode = default(string), string timezone = default(string), GeolocationCity city = default(GeolocationCity), GeolocationCountry country = default(GeolocationCountry), GeolocationContinent continent = default(GeolocationContinent), GeolocationSubdivisions subdivisions = default(GeolocationSubdivisions))
        {
            this.AccuracyRadius = accuracyRadius;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.PostalCode = postalCode;
            this.Timezone = timezone;
            this.City = city;
            this.Country = country;
            this.Continent = continent;
            this.Subdivisions = subdivisions;
        }

        /// <summary>
        /// The IP address is likely to be within this radius (in km) of the specified location.
        /// </summary>
        /// <value>The IP address is likely to be within this radius (in km) of the specified location.</value>
        [DataMember(Name = "accuracyRadius", EmitDefaultValue = false)]
        [JsonPropertyName("accuracyRadius")]
        public int? AccuracyRadius { get; set; }

        /// <summary>
        /// Gets or Sets Latitude
        /// </summary>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        [JsonPropertyName("latitude")]
        public double? Latitude { get; set; }

        /// <summary>
        /// Gets or Sets Longitude
        /// </summary>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        [JsonPropertyName("longitude")]
        public double? Longitude { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets Timezone
        /// </summary>
        [DataMember(Name = "timezone", EmitDefaultValue = false)]
        [JsonPropertyName("timezone")]
        public string Timezone { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        [JsonPropertyName("city")]
        public GeolocationCity City { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name = "country", EmitDefaultValue = false)]
        [JsonPropertyName("country")]
        public GeolocationCountry Country { get; set; }

        /// <summary>
        /// Gets or Sets Continent
        /// </summary>
        [DataMember(Name = "continent", EmitDefaultValue = false)]
        [JsonPropertyName("continent")]
        public GeolocationContinent Continent { get; set; }

        /// <summary>
        /// Gets or Sets Subdivisions
        /// </summary>
        [DataMember(Name = "subdivisions", EmitDefaultValue = false)]
        [JsonPropertyName("subdivisions")]
        public GeolocationSubdivisions Subdivisions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeprecatedGeolocation {\n");
            sb.Append("  AccuracyRadius: ").Append(AccuracyRadius).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Continent: ").Append(Continent).Append("\n");
            sb.Append("  Subdivisions: ").Append(Subdivisions).Append("\n");
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
        /// Returns true if DeprecatedGeolocation instances are equal
        /// </summary>
        /// <param name="input">Instance of DeprecatedGeolocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeprecatedGeolocation? input)
        {
            if (input == null)
                return false;

            return
                (
                this.AccuracyRadius == input.AccuracyRadius ||
                (this.AccuracyRadius != null &&
                this.AccuracyRadius.Equals(input.AccuracyRadius))
                ) &&
                (
                this.Latitude == input.Latitude ||
                (this.Latitude != null &&
                this.Latitude.Equals(input.Latitude))
                ) &&
                (
                this.Longitude == input.Longitude ||
                (this.Longitude != null &&
                this.Longitude.Equals(input.Longitude))
                ) &&
                (
                this.PostalCode == input.PostalCode ||
                (this.PostalCode != null &&
                this.PostalCode.Equals(input.PostalCode))
                ) &&
                (
                this.Timezone == input.Timezone ||
                (this.Timezone != null &&
                this.Timezone.Equals(input.Timezone))
                ) &&
                (
                this.City == input.City ||
                (this.City != null &&
                this.City.Equals(input.City))
                ) &&
                (
                this.Country == input.Country ||
                (this.Country != null &&
                this.Country.Equals(input.Country))
                ) &&
                (
                this.Continent == input.Continent ||
                (this.Continent != null &&
                this.Continent.Equals(input.Continent))
                ) &&
                (
                this.Subdivisions == input.Subdivisions ||
                (this.Subdivisions != null &&
                this.Subdivisions.Equals(input.Subdivisions))
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
                if (this.AccuracyRadius != null)
                    hashCode = hashCode * 59 + this.AccuracyRadius.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Continent != null)
                    hashCode = hashCode * 59 + this.Continent.GetHashCode();
                if (this.Subdivisions != null)
                    hashCode = hashCode * 59 + this.Subdivisions.GetHashCode();
                return hashCode;
            }
        }

    }
}
