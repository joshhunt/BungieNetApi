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
    /// All damage types that are possible in the game are defined here, along with localized info and icons as needed.
    /// </summary>
    [DataContract]
    public partial class DestinyDefinitionsDestinyDamageTypeDefinition :  IEquatable<DestinyDefinitionsDestinyDamageTypeDefinition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyDefinitionsDestinyDamageTypeDefinition" /> class.
        /// </summary>
        /// <param name="displayProperties">The description of the damage type, icon etc....</param>
        /// <param name="transparentIconPath">A variant of the icon that is transparent and colorless..</param>
        /// <param name="showIcon">If TRUE, the game shows this damage type&#39;s icon. Otherwise, it doesn&#39;t. Whether you show it or not is up to you..</param>
        /// <param name="enumValue">We have an enumeration for damage types for quick reference. This is the current definition&#39;s damage type enum value..</param>
        /// <param name="hash">The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to..</param>
        /// <param name="index">The index of the entity as it was found in the investment tables..</param>
        /// <param name="redacted">If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!.</param>
        public DestinyDefinitionsDestinyDamageTypeDefinition(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition displayProperties = default(DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition), string transparentIconPath = default(string), bool showIcon = default(bool), int enumValue = default(int), int hash = default(int), int index = default(int), bool redacted = default(bool))
        {
            this.DisplayProperties = displayProperties;
            this.TransparentIconPath = transparentIconPath;
            this.ShowIcon = showIcon;
            this.EnumValue = enumValue;
            this.Hash = hash;
            this.Index = index;
            this.Redacted = redacted;
        }
        
        /// <summary>
        /// The description of the damage type, icon etc...
        /// </summary>
        /// <value>The description of the damage type, icon etc...</value>
        [DataMember(Name="displayProperties", EmitDefaultValue=false)]
        public DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        /// <summary>
        /// A variant of the icon that is transparent and colorless.
        /// </summary>
        /// <value>A variant of the icon that is transparent and colorless.</value>
        [DataMember(Name="transparentIconPath", EmitDefaultValue=false)]
        public string TransparentIconPath { get; set; }

        /// <summary>
        /// If TRUE, the game shows this damage type&#39;s icon. Otherwise, it doesn&#39;t. Whether you show it or not is up to you.
        /// </summary>
        /// <value>If TRUE, the game shows this damage type&#39;s icon. Otherwise, it doesn&#39;t. Whether you show it or not is up to you.</value>
        [DataMember(Name="showIcon", EmitDefaultValue=false)]
        public bool ShowIcon { get; set; }

        /// <summary>
        /// We have an enumeration for damage types for quick reference. This is the current definition&#39;s damage type enum value.
        /// </summary>
        /// <value>We have an enumeration for damage types for quick reference. This is the current definition&#39;s damage type enum value.</value>
        [DataMember(Name="enumValue", EmitDefaultValue=false)]
        public int EnumValue { get; set; }

        /// <summary>
        /// The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.
        /// </summary>
        /// <value>The unique identifier for this entity. Guaranteed to be unique for the type of entity, but not globally.  When entities refer to each other in Destiny content, it is this hash that they are referring to.</value>
        [DataMember(Name="hash", EmitDefaultValue=false)]
        public int Hash { get; set; }

        /// <summary>
        /// The index of the entity as it was found in the investment tables.
        /// </summary>
        /// <value>The index of the entity as it was found in the investment tables.</value>
        [DataMember(Name="index", EmitDefaultValue=false)]
        public int Index { get; set; }

        /// <summary>
        /// If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!
        /// </summary>
        /// <value>If this is true, then there is an entity with this identifier/type combination, but BNet is not yet allowed to show it. Sorry!</value>
        [DataMember(Name="redacted", EmitDefaultValue=false)]
        public bool Redacted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyDefinitionsDestinyDamageTypeDefinition {\n");
            sb.Append("  DisplayProperties: ").Append(DisplayProperties).Append("\n");
            sb.Append("  TransparentIconPath: ").Append(TransparentIconPath).Append("\n");
            sb.Append("  ShowIcon: ").Append(ShowIcon).Append("\n");
            sb.Append("  EnumValue: ").Append(EnumValue).Append("\n");
            sb.Append("  Hash: ").Append(Hash).Append("\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Redacted: ").Append(Redacted).Append("\n");
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
            return this.Equals(input as DestinyDefinitionsDestinyDamageTypeDefinition);
        }

        /// <summary>
        /// Returns true if DestinyDefinitionsDestinyDamageTypeDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyDefinitionsDestinyDamageTypeDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyDefinitionsDestinyDamageTypeDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DisplayProperties == input.DisplayProperties ||
                    (this.DisplayProperties != null &&
                    this.DisplayProperties.Equals(input.DisplayProperties))
                ) && 
                (
                    this.TransparentIconPath == input.TransparentIconPath ||
                    (this.TransparentIconPath != null &&
                    this.TransparentIconPath.Equals(input.TransparentIconPath))
                ) && 
                (
                    this.ShowIcon == input.ShowIcon ||
                    this.ShowIcon.Equals(input.ShowIcon)
                ) && 
                (
                    this.EnumValue == input.EnumValue ||
                    this.EnumValue.Equals(input.EnumValue)
                ) && 
                (
                    this.Hash == input.Hash ||
                    this.Hash.Equals(input.Hash)
                ) && 
                (
                    this.Index == input.Index ||
                    this.Index.Equals(input.Index)
                ) && 
                (
                    this.Redacted == input.Redacted ||
                    this.Redacted.Equals(input.Redacted)
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
                if (this.DisplayProperties != null)
                    hashCode = hashCode * 59 + this.DisplayProperties.GetHashCode();
                if (this.TransparentIconPath != null)
                    hashCode = hashCode * 59 + this.TransparentIconPath.GetHashCode();
                hashCode = hashCode * 59 + this.ShowIcon.GetHashCode();
                hashCode = hashCode * 59 + this.EnumValue.GetHashCode();
                hashCode = hashCode * 59 + this.Hash.GetHashCode();
                hashCode = hashCode * 59 + this.Index.GetHashCode();
                hashCode = hashCode * 59 + this.Redacted.GetHashCode();
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
