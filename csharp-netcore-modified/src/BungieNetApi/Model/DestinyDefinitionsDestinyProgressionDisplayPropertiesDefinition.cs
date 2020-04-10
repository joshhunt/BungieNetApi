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
    /// DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition :  IEquatable<DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition" /> class.
        /// </summary>
        /// <param name="displayUnitsName">When progressions show your \&quot;experience\&quot; gained, that bar has units (i.e. \&quot;Experience\&quot;, \&quot;Bad Dudes Snuffed Out\&quot;, whatever). This is the localized string for that unit of measurement..</param>
        /// <param name="description">description.</param>
        /// <param name="name">name.</param>
        /// <param name="icon">Note that \&quot;icon\&quot; is sometimes misleading, and should be interpreted in the context of the entity. For instance, in Destiny 1 the DestinyRecordBookDefinition&#39;s icon was a big picture of a book.  But usually, it will be a small square image that you can use as... well, an icon.  They are currently represented as 96px x 96px images..</param>
        /// <param name="iconSequences">iconSequences.</param>
        /// <param name="highResIcon">If this item has a high-res icon (at least for now, many things won&#39;t), then the path to that icon will be here..</param>
        /// <param name="hasIcon">hasIcon.</param>
        public DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition(string displayUnitsName = default(string), string description = default(string), string name = default(string), string icon = default(string), List<DestinyDefinitionsCommonDestinyIconSequenceDefinition> iconSequences = default(List<DestinyDefinitionsCommonDestinyIconSequenceDefinition>), string highResIcon = default(string), bool hasIcon = default(bool))
        {
            this.DisplayUnitsName = displayUnitsName;
            this.Description = description;
            this.Name = name;
            this.Icon = icon;
            this.IconSequences = iconSequences;
            this.HighResIcon = highResIcon;
            this.HasIcon = hasIcon;
        }
        
        /// <summary>
        /// When progressions show your \&quot;experience\&quot; gained, that bar has units (i.e. \&quot;Experience\&quot;, \&quot;Bad Dudes Snuffed Out\&quot;, whatever). This is the localized string for that unit of measurement.
        /// </summary>
        /// <value>When progressions show your \&quot;experience\&quot; gained, that bar has units (i.e. \&quot;Experience\&quot;, \&quot;Bad Dudes Snuffed Out\&quot;, whatever). This is the localized string for that unit of measurement.</value>
        [DataMember(Name="displayUnitsName", EmitDefaultValue=false)]
        public string DisplayUnitsName { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Note that \&quot;icon\&quot; is sometimes misleading, and should be interpreted in the context of the entity. For instance, in Destiny 1 the DestinyRecordBookDefinition&#39;s icon was a big picture of a book.  But usually, it will be a small square image that you can use as... well, an icon.  They are currently represented as 96px x 96px images.
        /// </summary>
        /// <value>Note that \&quot;icon\&quot; is sometimes misleading, and should be interpreted in the context of the entity. For instance, in Destiny 1 the DestinyRecordBookDefinition&#39;s icon was a big picture of a book.  But usually, it will be a small square image that you can use as... well, an icon.  They are currently represented as 96px x 96px images.</value>
        [DataMember(Name="icon", EmitDefaultValue=false)]
        public string Icon { get; set; }

        /// <summary>
        /// Gets or Sets IconSequences
        /// </summary>
        [DataMember(Name="iconSequences", EmitDefaultValue=false)]
        public List<DestinyDefinitionsCommonDestinyIconSequenceDefinition> IconSequences { get; set; }

        /// <summary>
        /// If this item has a high-res icon (at least for now, many things won&#39;t), then the path to that icon will be here.
        /// </summary>
        /// <value>If this item has a high-res icon (at least for now, many things won&#39;t), then the path to that icon will be here.</value>
        [DataMember(Name="highResIcon", EmitDefaultValue=false)]
        public string HighResIcon { get; set; }

        /// <summary>
        /// Gets or Sets HasIcon
        /// </summary>
        [DataMember(Name="hasIcon", EmitDefaultValue=false)]
        public bool HasIcon { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition {\n");
            sb.Append("  DisplayUnitsName: ").Append(DisplayUnitsName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  IconSequences: ").Append(IconSequences).Append("\n");
            sb.Append("  HighResIcon: ").Append(HighResIcon).Append("\n");
            sb.Append("  HasIcon: ").Append(HasIcon).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayUnitsName == input.DisplayUnitsName ||
                    (this.DisplayUnitsName != null &&
                    this.DisplayUnitsName.Equals(input.DisplayUnitsName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.IconSequences == input.IconSequences ||
                    this.IconSequences != null &&
                    input.IconSequences != null &&
                    this.IconSequences.SequenceEqual(input.IconSequences)
                ) && 
                (
                    this.HighResIcon == input.HighResIcon ||
                    (this.HighResIcon != null &&
                    this.HighResIcon.Equals(input.HighResIcon))
                ) && 
                (
                    this.HasIcon == input.HasIcon ||
                    this.HasIcon.Equals(input.HasIcon)
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
                if (this.DisplayUnitsName != null)
                    hashCode = hashCode * 59 + this.DisplayUnitsName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Icon != null)
                    hashCode = hashCode * 59 + this.Icon.GetHashCode();
                if (this.IconSequences != null)
                    hashCode = hashCode * 59 + this.IconSequences.GetHashCode();
                if (this.HighResIcon != null)
                    hashCode = hashCode * 59 + this.HighResIcon.GetHashCode();
                hashCode = hashCode * 59 + this.HasIcon.GetHashCode();
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
