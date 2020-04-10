/* 
 * Bungie.Net API
 *
 * These endpoints constitute the functionality exposed by Bungie.net, both for more traditional website functionality and for connectivity to Bungie video games and their related functionality.
 *
 * The version of the OpenAPI document: 2.8.0
 * Contact: support@bungie.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = BungieNetApi.Client.OpenAPIDateConverter;

namespace BungieNetApi.Model
{
    /// <summary>
    /// This component contains essential/summary information about the vendor from the perspective of a character-agnostic view.
    /// </summary>
    [DataContract]
    public partial class DestinyComponentsVendorsDestinyPublicVendorComponent :  IEquatable<DestinyComponentsVendorsDestinyPublicVendorComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyComponentsVendorsDestinyPublicVendorComponent" /> class.
        /// </summary>
        /// <param name="vendorHash">The unique identifier for the vendor. Use it to look up their DestinyVendorDefinition..</param>
        /// <param name="nextRefreshDate">The date when this vendor&#39;s inventory will next rotate/refresh.  Note that this is distinct from the date ranges that the vendor is visible/available in-game: this field indicates the specific time when the vendor&#39;s available items refresh and rotate, regardless of whether the vendor is actually available at that time. Unfortunately, these two values may be (and are, for the case of important vendors like Xur) different.  Issue https://github.com/Bungie-net/api/issues/353 is tracking a fix to start providing visibility date ranges where possible in addition to this refresh date, so that all important dates for vendors are available for use..</param>
        /// <param name="enabled">If True, the Vendor is currently accessible.   If False, they may not actually be visible in the world at the moment..</param>
        public DestinyComponentsVendorsDestinyPublicVendorComponent(int vendorHash = default(int), DateTime nextRefreshDate = default(DateTime), bool enabled = default(bool))
        {
            this.VendorHash = vendorHash;
            this.NextRefreshDate = nextRefreshDate;
            this.Enabled = enabled;
        }
        
        /// <summary>
        /// The unique identifier for the vendor. Use it to look up their DestinyVendorDefinition.
        /// </summary>
        /// <value>The unique identifier for the vendor. Use it to look up their DestinyVendorDefinition.</value>
        [DataMember(Name="vendorHash", EmitDefaultValue=false)]
        public int VendorHash { get; set; }

        /// <summary>
        /// The date when this vendor&#39;s inventory will next rotate/refresh.  Note that this is distinct from the date ranges that the vendor is visible/available in-game: this field indicates the specific time when the vendor&#39;s available items refresh and rotate, regardless of whether the vendor is actually available at that time. Unfortunately, these two values may be (and are, for the case of important vendors like Xur) different.  Issue https://github.com/Bungie-net/api/issues/353 is tracking a fix to start providing visibility date ranges where possible in addition to this refresh date, so that all important dates for vendors are available for use.
        /// </summary>
        /// <value>The date when this vendor&#39;s inventory will next rotate/refresh.  Note that this is distinct from the date ranges that the vendor is visible/available in-game: this field indicates the specific time when the vendor&#39;s available items refresh and rotate, regardless of whether the vendor is actually available at that time. Unfortunately, these two values may be (and are, for the case of important vendors like Xur) different.  Issue https://github.com/Bungie-net/api/issues/353 is tracking a fix to start providing visibility date ranges where possible in addition to this refresh date, so that all important dates for vendors are available for use.</value>
        [DataMember(Name="nextRefreshDate", EmitDefaultValue=false)]
        public DateTime NextRefreshDate { get; set; }

        /// <summary>
        /// If True, the Vendor is currently accessible.   If False, they may not actually be visible in the world at the moment.
        /// </summary>
        /// <value>If True, the Vendor is currently accessible.   If False, they may not actually be visible in the world at the moment.</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyComponentsVendorsDestinyPublicVendorComponent {\n");
            sb.Append("  VendorHash: ").Append(VendorHash).Append("\n");
            sb.Append("  NextRefreshDate: ").Append(NextRefreshDate).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DestinyComponentsVendorsDestinyPublicVendorComponent);
        }

        /// <summary>
        /// Returns true if DestinyComponentsVendorsDestinyPublicVendorComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyComponentsVendorsDestinyPublicVendorComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyComponentsVendorsDestinyPublicVendorComponent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VendorHash == input.VendorHash ||
                    (this.VendorHash != null &&
                    this.VendorHash.Equals(input.VendorHash))
                ) && 
                (
                    this.NextRefreshDate == input.NextRefreshDate ||
                    (this.NextRefreshDate != null &&
                    this.NextRefreshDate.Equals(input.NextRefreshDate))
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
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
                if (this.VendorHash != null)
                    hashCode = hashCode * 59 + this.VendorHash.GetHashCode();
                if (this.NextRefreshDate != null)
                    hashCode = hashCode * 59 + this.NextRefreshDate.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
