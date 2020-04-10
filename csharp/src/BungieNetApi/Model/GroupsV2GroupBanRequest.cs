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
    /// GroupsV2GroupBanRequest
    /// </summary>
    [DataContract]
    public partial class GroupsV2GroupBanRequest :  IEquatable<GroupsV2GroupBanRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsV2GroupBanRequest" /> class.
        /// </summary>
        /// <param name="comment">comment.</param>
        /// <param name="length">length.</param>
        public GroupsV2GroupBanRequest(string comment = default(string), int length = default(int))
        {
            this.Comment = comment;
            this.Length = length;
        }
        
        /// <summary>
        /// Gets or Sets Comment
        /// </summary>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Gets or Sets Length
        /// </summary>
        [DataMember(Name="length", EmitDefaultValue=false)]
        public int Length { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupsV2GroupBanRequest {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
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
            return this.Equals(input as GroupsV2GroupBanRequest);
        }

        /// <summary>
        /// Returns true if GroupsV2GroupBanRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupsV2GroupBanRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupsV2GroupBanRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                ) && 
                (
                    this.Length == input.Length ||
                    (this.Length != null &&
                    this.Length.Equals(input.Length))
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
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                if (this.Length != null)
                    hashCode = hashCode * 59 + this.Length.GetHashCode();
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
