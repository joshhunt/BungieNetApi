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
    /// DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry :  IEquatable<DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry" /> class.
        /// </summary>
        /// <param name="presentationNodeHash">presentationNodeHash.</param>
        public DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry(int presentationNodeHash = default(int))
        {
            this.PresentationNodeHash = presentationNodeHash;
        }
        
        /// <summary>
        /// Gets or Sets PresentationNodeHash
        /// </summary>
        [DataMember(Name="presentationNodeHash", EmitDefaultValue=false)]
        public int PresentationNodeHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry {\n");
            sb.Append("  PresentationNodeHash: ").Append(PresentationNodeHash).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsPresentationDestinyPresentationNodeChildEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PresentationNodeHash == input.PresentationNodeHash ||
                    this.PresentationNodeHash.Equals(input.PresentationNodeHash)
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
                hashCode = hashCode * 59 + this.PresentationNodeHash.GetHashCode();
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
