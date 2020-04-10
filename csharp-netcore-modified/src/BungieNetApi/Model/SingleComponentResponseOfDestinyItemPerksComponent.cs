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
    /// SingleComponentResponseOfDestinyItemPerksComponent
    /// </summary>
    [DataContract]
    public partial class SingleComponentResponseOfDestinyItemPerksComponent :  IEquatable<SingleComponentResponseOfDestinyItemPerksComponent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleComponentResponseOfDestinyItemPerksComponent" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="privacy">privacy.</param>
        /// <param name="disabled">If true, this component is disabled..</param>
        public SingleComponentResponseOfDestinyItemPerksComponent(DestinyEntitiesItemsDestinyItemPerksComponent data = default(DestinyEntitiesItemsDestinyItemPerksComponent), int privacy = default(int), bool disabled = default(bool))
        {
            this.Data = data;
            this.Privacy = privacy;
            this.Disabled = disabled;
        }
        
        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public DestinyEntitiesItemsDestinyItemPerksComponent Data { get; set; }

        /// <summary>
        /// Gets or Sets Privacy
        /// </summary>
        [DataMember(Name="privacy", EmitDefaultValue=false)]
        public int Privacy { get; set; }

        /// <summary>
        /// If true, this component is disabled.
        /// </summary>
        /// <value>If true, this component is disabled.</value>
        [DataMember(Name="disabled", EmitDefaultValue=false)]
        public bool Disabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SingleComponentResponseOfDestinyItemPerksComponent {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
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
            return this.Equals(input as SingleComponentResponseOfDestinyItemPerksComponent);
        }

        /// <summary>
        /// Returns true if SingleComponentResponseOfDestinyItemPerksComponent instances are equal
        /// </summary>
        /// <param name="input">Instance of SingleComponentResponseOfDestinyItemPerksComponent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SingleComponentResponseOfDestinyItemPerksComponent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Privacy == input.Privacy ||
                    this.Privacy.Equals(input.Privacy)
                ) && 
                (
                    this.Disabled == input.Disabled ||
                    this.Disabled.Equals(input.Disabled)
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
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                hashCode = hashCode * 59 + this.Privacy.GetHashCode();
                hashCode = hashCode * 59 + this.Disabled.GetHashCode();
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
