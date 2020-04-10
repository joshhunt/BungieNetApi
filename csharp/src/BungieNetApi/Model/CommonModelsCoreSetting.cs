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
    /// CommonModelsCoreSetting
    /// </summary>
    [DataContract]
    public partial class CommonModelsCoreSetting :  IEquatable<CommonModelsCoreSetting>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonModelsCoreSetting" /> class.
        /// </summary>
        /// <param name="identifier">identifier.</param>
        /// <param name="isDefault">isDefault.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="summary">summary.</param>
        /// <param name="imagePath">imagePath.</param>
        /// <param name="childSettings">childSettings.</param>
        public CommonModelsCoreSetting(string identifier = default(string), bool isDefault = default(bool), string displayName = default(string), string summary = default(string), string imagePath = default(string), List<CommonModelsCoreSetting> childSettings = default(List<CommonModelsCoreSetting>))
        {
            this.Identifier = identifier;
            this.IsDefault = isDefault;
            this.DisplayName = displayName;
            this.Summary = summary;
            this.ImagePath = imagePath;
            this.ChildSettings = childSettings;
        }
        
        /// <summary>
        /// Gets or Sets Identifier
        /// </summary>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public string Identifier { get; set; }

        /// <summary>
        /// Gets or Sets IsDefault
        /// </summary>
        [DataMember(Name="isDefault", EmitDefaultValue=false)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name="summary", EmitDefaultValue=false)]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or Sets ImagePath
        /// </summary>
        [DataMember(Name="imagePath", EmitDefaultValue=false)]
        public string ImagePath { get; set; }

        /// <summary>
        /// Gets or Sets ChildSettings
        /// </summary>
        [DataMember(Name="childSettings", EmitDefaultValue=false)]
        public List<CommonModelsCoreSetting> ChildSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommonModelsCoreSetting {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
            sb.Append("  ImagePath: ").Append(ImagePath).Append("\n");
            sb.Append("  ChildSettings: ").Append(ChildSettings).Append("\n");
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
            return this.Equals(input as CommonModelsCoreSetting);
        }

        /// <summary>
        /// Returns true if CommonModelsCoreSetting instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonModelsCoreSetting to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonModelsCoreSetting input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.IsDefault == input.IsDefault ||
                    (this.IsDefault != null &&
                    this.IsDefault.Equals(input.IsDefault))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Summary == input.Summary ||
                    (this.Summary != null &&
                    this.Summary.Equals(input.Summary))
                ) && 
                (
                    this.ImagePath == input.ImagePath ||
                    (this.ImagePath != null &&
                    this.ImagePath.Equals(input.ImagePath))
                ) && 
                (
                    this.ChildSettings == input.ChildSettings ||
                    this.ChildSettings != null &&
                    input.ChildSettings != null &&
                    this.ChildSettings.SequenceEqual(input.ChildSettings)
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
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.IsDefault != null)
                    hashCode = hashCode * 59 + this.IsDefault.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Summary != null)
                    hashCode = hashCode * 59 + this.Summary.GetHashCode();
                if (this.ImagePath != null)
                    hashCode = hashCode * 59 + this.ImagePath.GetHashCode();
                if (this.ChildSettings != null)
                    hashCode = hashCode * 59 + this.ChildSettings.GetHashCode();
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
