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
    /// This component returns references to all of the Vendors in the response, grouped by categorizations that Bungie has deemed to be interesting, in the order in which both the groups and the vendors within that group should be rendered.
    /// </summary>
    [DataContract]
    public partial class DestinyComponentsVendorsDestinyVendorGroupComponent :  IEquatable<DestinyComponentsVendorsDestinyVendorGroupComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyComponentsVendorsDestinyVendorGroupComponent" /> class.
        /// </summary>
        /// <param name="groups">The ordered list of groups being returned..</param>
        public DestinyComponentsVendorsDestinyVendorGroupComponent(List<DestinyComponentsVendorsDestinyVendorGroup> groups = default(List<DestinyComponentsVendorsDestinyVendorGroup>))
        {
            this.Groups = groups;
        }
        
        /// <summary>
        /// The ordered list of groups being returned.
        /// </summary>
        /// <value>The ordered list of groups being returned.</value>
        [DataMember(Name="groups", EmitDefaultValue=false)]
        public List<DestinyComponentsVendorsDestinyVendorGroup> Groups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyComponentsVendorsDestinyVendorGroupComponent {\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
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
            return this.Equals(input as DestinyComponentsVendorsDestinyVendorGroupComponent);
        }

        /// <summary>
        /// Returns true if DestinyComponentsVendorsDestinyVendorGroupComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyComponentsVendorsDestinyVendorGroupComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyComponentsVendorsDestinyVendorGroupComponent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Groups == input.Groups ||
                    this.Groups != null &&
                    input.Groups != null &&
                    this.Groups.SequenceEqual(input.Groups)
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
                if (this.Groups != null)
                    hashCode = hashCode * 59 + this.Groups.GetHashCode();
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
