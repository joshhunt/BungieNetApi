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
    /// GroupsV2GroupOptionalConversationAddRequest
    /// </summary>
    [DataContract]
    public partial class GroupsV2GroupOptionalConversationAddRequest :  IEquatable<GroupsV2GroupOptionalConversationAddRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsV2GroupOptionalConversationAddRequest" /> class.
        /// </summary>
        /// <param name="chatName">chatName.</param>
        /// <param name="chatSecurity">chatSecurity.</param>
        public GroupsV2GroupOptionalConversationAddRequest(string chatName = default(string), int chatSecurity = default(int))
        {
            this.ChatName = chatName;
            this.ChatSecurity = chatSecurity;
        }
        
        /// <summary>
        /// Gets or Sets ChatName
        /// </summary>
        [DataMember(Name="chatName", EmitDefaultValue=false)]
        public string ChatName { get; set; }

        /// <summary>
        /// Gets or Sets ChatSecurity
        /// </summary>
        [DataMember(Name="chatSecurity", EmitDefaultValue=false)]
        public int ChatSecurity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupsV2GroupOptionalConversationAddRequest {\n");
            sb.Append("  ChatName: ").Append(ChatName).Append("\n");
            sb.Append("  ChatSecurity: ").Append(ChatSecurity).Append("\n");
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
            return this.Equals(input as GroupsV2GroupOptionalConversationAddRequest);
        }

        /// <summary>
        /// Returns true if GroupsV2GroupOptionalConversationAddRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupsV2GroupOptionalConversationAddRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupsV2GroupOptionalConversationAddRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChatName == input.ChatName ||
                    (this.ChatName != null &&
                    this.ChatName.Equals(input.ChatName))
                ) && 
                (
                    this.ChatSecurity == input.ChatSecurity ||
                    this.ChatSecurity.Equals(input.ChatSecurity)
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
                if (this.ChatName != null)
                    hashCode = hashCode * 59 + this.ChatName.GetHashCode();
                hashCode = hashCode * 59 + this.ChatSecurity.GetHashCode();
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
