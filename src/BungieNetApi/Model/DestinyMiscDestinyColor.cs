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
    /// Represents a color whose RGBA values are all represented as values between 0 and 255.
    /// </summary>
    [DataContract]
    public partial class DestinyMiscDestinyColor :  IEquatable<DestinyMiscDestinyColor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DestinyMiscDestinyColor" /> class.
        /// </summary>
        /// <param name="red">red.</param>
        /// <param name="green">green.</param>
        /// <param name="blue">blue.</param>
        /// <param name="alpha">alpha.</param>
        public DestinyMiscDestinyColor(byte[] red = default(byte[]), byte[] green = default(byte[]), byte[] blue = default(byte[]), byte[] alpha = default(byte[]))
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Alpha = alpha;
        }
        
        /// <summary>
        /// Gets or Sets Red
        /// </summary>
        [DataMember(Name="red", EmitDefaultValue=false)]
        public byte[] Red { get; set; }

        /// <summary>
        /// Gets or Sets Green
        /// </summary>
        [DataMember(Name="green", EmitDefaultValue=false)]
        public byte[] Green { get; set; }

        /// <summary>
        /// Gets or Sets Blue
        /// </summary>
        [DataMember(Name="blue", EmitDefaultValue=false)]
        public byte[] Blue { get; set; }

        /// <summary>
        /// Gets or Sets Alpha
        /// </summary>
        [DataMember(Name="alpha", EmitDefaultValue=false)]
        public byte[] Alpha { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DestinyMiscDestinyColor {\n");
            sb.Append("  Red: ").Append(Red).Append("\n");
            sb.Append("  Green: ").Append(Green).Append("\n");
            sb.Append("  Blue: ").Append(Blue).Append("\n");
            sb.Append("  Alpha: ").Append(Alpha).Append("\n");
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
            return this.Equals(input as DestinyMiscDestinyColor);
        }

        /// <summary>
        /// Returns true if DestinyMiscDestinyColor instances are equal
        /// </summary>
        /// <param name="input">Instance of DestinyMiscDestinyColor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DestinyMiscDestinyColor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Red == input.Red ||
                    (this.Red != null &&
                    this.Red.Equals(input.Red))
                ) && 
                (
                    this.Green == input.Green ||
                    (this.Green != null &&
                    this.Green.Equals(input.Green))
                ) && 
                (
                    this.Blue == input.Blue ||
                    (this.Blue != null &&
                    this.Blue.Equals(input.Blue))
                ) && 
                (
                    this.Alpha == input.Alpha ||
                    (this.Alpha != null &&
                    this.Alpha.Equals(input.Alpha))
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
                if (this.Red != null)
                    hashCode = hashCode * 59 + this.Red.GetHashCode();
                if (this.Green != null)
                    hashCode = hashCode * 59 + this.Green.GetHashCode();
                if (this.Blue != null)
                    hashCode = hashCode * 59 + this.Blue.GetHashCode();
                if (this.Alpha != null)
                    hashCode = hashCode * 59 + this.Alpha.GetHashCode();
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
