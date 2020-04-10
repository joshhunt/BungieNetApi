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
    /// DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition :  IEquatable<DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition" /> class.
        /// </summary>
        /// <param name="largeIcon">I regret calling this a \&quot;large icon\&quot;. It&#39;s more like a medium-sized image with a picture of the vendor&#39;s mug on it, trying their best to look cool. Not what one would call an icon..</param>
        /// <param name="subtitle">subtitle.</param>
        /// <param name="originalIcon">If we replaced the icon with something more glitzy, this is the original icon that the vendor had according to the game&#39;s content. It may be more lame and/or have less razzle-dazzle. But who am I to tell you which icon to use..</param>
        /// <param name="requirementsDisplay">Vendors, in addition to expected display property data, may also show some \&quot;common requirements\&quot; as statically defined definition data. This might be when a vendor accepts a single type of currency, or when the currency is unique to the vendor and the designers wanted to show that currency when you interact with the vendor..</param>
        /// <param name="smallTransparentIcon">This is the icon used in parts of the game UI such as the vendor&#39;s waypoint..</param>
        /// <param name="mapIcon">This is the icon used in the map overview, when the vendor is located on the map..</param>
        /// <param name="largeTransparentIcon">This is apparently the \&quot;Watermark\&quot;. I am not certain offhand where this is actually used in the Game UI, but some people may find it useful..</param>
        /// <param name="description">description.</param>
        /// <param name="name">name.</param>
        /// <param name="icon">Note that \&quot;icon\&quot; is sometimes misleading, and should be interpreted in the context of the entity. For instance, in Destiny 1 the DestinyRecordBookDefinition&#39;s icon was a big picture of a book.  But usually, it will be a small square image that you can use as... well, an icon.  They are currently represented as 96px x 96px images..</param>
        /// <param name="iconSequences">iconSequences.</param>
        /// <param name="highResIcon">If this item has a high-res icon (at least for now, many things won&#39;t), then the path to that icon will be here..</param>
        /// <param name="hasIcon">hasIcon.</param>
        public DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition(string largeIcon = default(string), string subtitle = default(string), string originalIcon = default(string), List<DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition> requirementsDisplay = default(List<DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition>), string smallTransparentIcon = default(string), string mapIcon = default(string), string largeTransparentIcon = default(string), string description = default(string), string name = default(string), string icon = default(string), List<DestinyDefinitionsCommonDestinyIconSequenceDefinition> iconSequences = default(List<DestinyDefinitionsCommonDestinyIconSequenceDefinition>), string highResIcon = default(string), bool hasIcon = default(bool))
        {
            this.LargeIcon = largeIcon;
            this.Subtitle = subtitle;
            this.OriginalIcon = originalIcon;
            this.RequirementsDisplay = requirementsDisplay;
            this.SmallTransparentIcon = smallTransparentIcon;
            this.MapIcon = mapIcon;
            this.LargeTransparentIcon = largeTransparentIcon;
            this.Description = description;
            this.Name = name;
            this.Icon = icon;
            this.IconSequences = iconSequences;
            this.HighResIcon = highResIcon;
            this.HasIcon = hasIcon;
        }
        
        /// <summary>
        /// I regret calling this a \&quot;large icon\&quot;. It&#39;s more like a medium-sized image with a picture of the vendor&#39;s mug on it, trying their best to look cool. Not what one would call an icon.
        /// </summary>
        /// <value>I regret calling this a \&quot;large icon\&quot;. It&#39;s more like a medium-sized image with a picture of the vendor&#39;s mug on it, trying their best to look cool. Not what one would call an icon.</value>
        [DataMember(Name="largeIcon", EmitDefaultValue=false)]
        public string LargeIcon { get; set; }

        /// <summary>
        /// Gets or Sets Subtitle
        /// </summary>
        [DataMember(Name="subtitle", EmitDefaultValue=false)]
        public string Subtitle { get; set; }

        /// <summary>
        /// If we replaced the icon with something more glitzy, this is the original icon that the vendor had according to the game&#39;s content. It may be more lame and/or have less razzle-dazzle. But who am I to tell you which icon to use.
        /// </summary>
        /// <value>If we replaced the icon with something more glitzy, this is the original icon that the vendor had according to the game&#39;s content. It may be more lame and/or have less razzle-dazzle. But who am I to tell you which icon to use.</value>
        [DataMember(Name="originalIcon", EmitDefaultValue=false)]
        public string OriginalIcon { get; set; }

        /// <summary>
        /// Vendors, in addition to expected display property data, may also show some \&quot;common requirements\&quot; as statically defined definition data. This might be when a vendor accepts a single type of currency, or when the currency is unique to the vendor and the designers wanted to show that currency when you interact with the vendor.
        /// </summary>
        /// <value>Vendors, in addition to expected display property data, may also show some \&quot;common requirements\&quot; as statically defined definition data. This might be when a vendor accepts a single type of currency, or when the currency is unique to the vendor and the designers wanted to show that currency when you interact with the vendor.</value>
        [DataMember(Name="requirementsDisplay", EmitDefaultValue=false)]
        public List<DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition> RequirementsDisplay { get; set; }

        /// <summary>
        /// This is the icon used in parts of the game UI such as the vendor&#39;s waypoint.
        /// </summary>
        /// <value>This is the icon used in parts of the game UI such as the vendor&#39;s waypoint.</value>
        [DataMember(Name="smallTransparentIcon", EmitDefaultValue=false)]
        public string SmallTransparentIcon { get; set; }

        /// <summary>
        /// This is the icon used in the map overview, when the vendor is located on the map.
        /// </summary>
        /// <value>This is the icon used in the map overview, when the vendor is located on the map.</value>
        [DataMember(Name="mapIcon", EmitDefaultValue=false)]
        public string MapIcon { get; set; }

        /// <summary>
        /// This is apparently the \&quot;Watermark\&quot;. I am not certain offhand where this is actually used in the Game UI, but some people may find it useful.
        /// </summary>
        /// <value>This is apparently the \&quot;Watermark\&quot;. I am not certain offhand where this is actually used in the Game UI, but some people may find it useful.</value>
        [DataMember(Name="largeTransparentIcon", EmitDefaultValue=false)]
        public string LargeTransparentIcon { get; set; }

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
            sb.Append("class DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition {\n");
            sb.Append("  LargeIcon: ").Append(LargeIcon).Append("\n");
            sb.Append("  Subtitle: ").Append(Subtitle).Append("\n");
            sb.Append("  OriginalIcon: ").Append(OriginalIcon).Append("\n");
            sb.Append("  RequirementsDisplay: ").Append(RequirementsDisplay).Append("\n");
            sb.Append("  SmallTransparentIcon: ").Append(SmallTransparentIcon).Append("\n");
            sb.Append("  MapIcon: ").Append(MapIcon).Append("\n");
            sb.Append("  LargeTransparentIcon: ").Append(LargeTransparentIcon).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LargeIcon == input.LargeIcon ||
                    (this.LargeIcon != null &&
                    this.LargeIcon.Equals(input.LargeIcon))
                ) && 
                (
                    this.Subtitle == input.Subtitle ||
                    (this.Subtitle != null &&
                    this.Subtitle.Equals(input.Subtitle))
                ) && 
                (
                    this.OriginalIcon == input.OriginalIcon ||
                    (this.OriginalIcon != null &&
                    this.OriginalIcon.Equals(input.OriginalIcon))
                ) && 
                (
                    this.RequirementsDisplay == input.RequirementsDisplay ||
                    this.RequirementsDisplay != null &&
                    input.RequirementsDisplay != null &&
                    this.RequirementsDisplay.SequenceEqual(input.RequirementsDisplay)
                ) && 
                (
                    this.SmallTransparentIcon == input.SmallTransparentIcon ||
                    (this.SmallTransparentIcon != null &&
                    this.SmallTransparentIcon.Equals(input.SmallTransparentIcon))
                ) && 
                (
                    this.MapIcon == input.MapIcon ||
                    (this.MapIcon != null &&
                    this.MapIcon.Equals(input.MapIcon))
                ) && 
                (
                    this.LargeTransparentIcon == input.LargeTransparentIcon ||
                    (this.LargeTransparentIcon != null &&
                    this.LargeTransparentIcon.Equals(input.LargeTransparentIcon))
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
                if (this.LargeIcon != null)
                    hashCode = hashCode * 59 + this.LargeIcon.GetHashCode();
                if (this.Subtitle != null)
                    hashCode = hashCode * 59 + this.Subtitle.GetHashCode();
                if (this.OriginalIcon != null)
                    hashCode = hashCode * 59 + this.OriginalIcon.GetHashCode();
                if (this.RequirementsDisplay != null)
                    hashCode = hashCode * 59 + this.RequirementsDisplay.GetHashCode();
                if (this.SmallTransparentIcon != null)
                    hashCode = hashCode * 59 + this.SmallTransparentIcon.GetHashCode();
                if (this.MapIcon != null)
                    hashCode = hashCode * 59 + this.MapIcon.GetHashCode();
                if (this.LargeTransparentIcon != null)
                    hashCode = hashCode * 59 + this.LargeTransparentIcon.GetHashCode();
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
