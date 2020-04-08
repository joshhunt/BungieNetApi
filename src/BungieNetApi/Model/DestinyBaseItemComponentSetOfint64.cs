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
    /// DestinyBaseItemComponentSetOfint64
    /// </summary>
    [DataContract]
    public partial class DestinyBaseItemComponentSetOfint64 :  IEquatable<DestinyBaseItemComponentSetOfint64>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyBaseItemComponentSetOfint64" /> class.
        /// </summary>
        /// <param name="objectives">objectives.</param>
        public DestinyBaseItemComponentSetOfint64(DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent objectives = default(DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent))
        {
            this.Objectives = objectives;
        }
        
        /// <summary>
        /// Gets or Sets Objectives
        /// </summary>
        [DataMember(Name="objectives", EmitDefaultValue=false)]
        public DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent Objectives { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyBaseItemComponentSetOfint64 {\n");
            sb.Append("  Objectives: ").Append(Objectives).Append("\n");
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
            return this.Equals(input as DestinyBaseItemComponentSetOfint64);
        }

        /// <summary>
        /// Returns true if DestinyBaseItemComponentSetOfint64 instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyBaseItemComponentSetOfint64 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyBaseItemComponentSetOfint64 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Objectives == input.Objectives ||
                    (this.Objectives != null &&
                    this.Objectives.Equals(input.Objectives))
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
                if (this.Objectives != null)
                    hashCode = hashCode * 59 + this.Objectives.GetHashCode();
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
