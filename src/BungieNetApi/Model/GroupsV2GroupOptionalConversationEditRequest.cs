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
    /// GroupsV2GroupOptionalConversationEditRequest
    /// </summary>
    [DataContract]
    public partial class GroupsV2GroupOptionalConversationEditRequest :  IEquatable<GroupsV2GroupOptionalConversationEditRequest>, IValidatableObject
    {
        /// <summary>
        /// Defines ChatSecurity
        /// </summary>
        public enum ChatSecurityEnum
        {
            /// <summary>
            /// Enum NUMBER_0 for value: 0
            /// </summary>
            NUMBER_0 = 0,

            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            NUMBER_1 = 1

        }

        /// <summary>
        /// Gets or Sets ChatSecurity
        /// </summary>
        [DataMember(Name="chatSecurity", EmitDefaultValue=false)]
        public ChatSecurityEnum? ChatSecurity { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupsV2GroupOptionalConversationEditRequest" /> class.
        /// </summary>
        /// <param name="chatEnabled">chatEnabled.</param>
        /// <param name="chatName">chatName.</param>
        /// <param name="chatSecurity">chatSecurity.</param>
        public GroupsV2GroupOptionalConversationEditRequest(bool chatEnabled = default(bool), string chatName = default(string), ChatSecurityEnum? chatSecurity = default(ChatSecurityEnum?))
        {
            this.ChatEnabled = chatEnabled;
            this.ChatName = chatName;
            this.ChatSecurity = chatSecurity;
        }
        
        /// <summary>
        /// Gets or Sets ChatEnabled
        /// </summary>
        [DataMember(Name="chatEnabled", EmitDefaultValue=false)]
        public bool ChatEnabled { get; set; }

        /// <summary>
        /// Gets or Sets ChatName
        /// </summary>
        [DataMember(Name="chatName", EmitDefaultValue=false)]
        public string ChatName { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupsV2GroupOptionalConversationEditRequest {\n");
            sb.Append("  ChatEnabled: ").Append(ChatEnabled).Append("\n");
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
            return this.Equals(input as GroupsV2GroupOptionalConversationEditRequest);
        }

        /// <summary>
        /// Returns true if GroupsV2GroupOptionalConversationEditRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupsV2GroupOptionalConversationEditRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupsV2GroupOptionalConversationEditRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ChatEnabled == input.ChatEnabled ||
                    (this.ChatEnabled != null &&
                    this.ChatEnabled.Equals(input.ChatEnabled))
                ) && 
                (
                    this.ChatName == input.ChatName ||
                    (this.ChatName != null &&
                    this.ChatName.Equals(input.ChatName))
                ) && 
                (
                    this.ChatSecurity == input.ChatSecurity ||
                    (this.ChatSecurity != null &&
                    this.ChatSecurity.Equals(input.ChatSecurity))
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
                if (this.ChatEnabled != null)
                    hashCode = hashCode * 59 + this.ChatEnabled.GetHashCode();
                if (this.ChatName != null)
                    hashCode = hashCode * 59 + this.ChatName.GetHashCode();
                if (this.ChatSecurity != null)
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
