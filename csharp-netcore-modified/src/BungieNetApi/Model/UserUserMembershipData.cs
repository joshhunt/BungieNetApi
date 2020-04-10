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
    /// UserUserMembershipData
    /// </summary>
    [DataContract]
    public partial class UserUserMembershipData :  IEquatable<UserUserMembershipData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserUserMembershipData" /> class.
        /// </summary>
        /// <param name="destinyMemberships">this allows you to see destiny memberships that are visible and linked to this account (regardless of whether or not they have characters on the world server).</param>
        /// <param name="primaryMembershipId">If this property is populated, it will have the membership ID of the account considered to be \&quot;primary\&quot; in this user&#39;s cross save relationship.   If null, this user has no cross save relationship, nor primary account..</param>
        /// <param name="bungieNetUser">bungieNetUser.</param>
        public UserUserMembershipData(List<GroupsV2GroupUserInfoCard> destinyMemberships = default(List<GroupsV2GroupUserInfoCard>), long primaryMembershipId = default(long), UserGeneralUser bungieNetUser = default(UserGeneralUser))
        {
            this.DestinyMemberships = destinyMemberships;
            this.PrimaryMembershipId = primaryMembershipId;
            this.BungieNetUser = bungieNetUser;
        }
        
        /// <summary>
        /// this allows you to see destiny memberships that are visible and linked to this account (regardless of whether or not they have characters on the world server)
        /// </summary>
        /// <value>this allows you to see destiny memberships that are visible and linked to this account (regardless of whether or not they have characters on the world server)</value>
        [DataMember(Name="destinyMemberships", EmitDefaultValue=false)]
        public List<GroupsV2GroupUserInfoCard> DestinyMemberships { get; set; }

        /// <summary>
        /// If this property is populated, it will have the membership ID of the account considered to be \&quot;primary\&quot; in this user&#39;s cross save relationship.   If null, this user has no cross save relationship, nor primary account.
        /// </summary>
        /// <value>If this property is populated, it will have the membership ID of the account considered to be \&quot;primary\&quot; in this user&#39;s cross save relationship.   If null, this user has no cross save relationship, nor primary account.</value>
        [DataMember(Name="primaryMembershipId", EmitDefaultValue=false)]
        public long PrimaryMembershipId { get; set; }

        /// <summary>
        /// Gets or Sets BungieNetUser
        /// </summary>
        [DataMember(Name="bungieNetUser", EmitDefaultValue=false)]
        public UserGeneralUser BungieNetUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserUserMembershipData {\n");
            sb.Append("  DestinyMemberships: ").Append(DestinyMemberships).Append("\n");
            sb.Append("  PrimaryMembershipId: ").Append(PrimaryMembershipId).Append("\n");
            sb.Append("  BungieNetUser: ").Append(BungieNetUser).Append("\n");
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
            return this.Equals(input as UserUserMembershipData);
        }

        /// <summary>
        /// Returns true if UserUserMembershipData instances are equal
        /// </summary>
        /// <param name="input">Instance of UserUserMembershipData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserUserMembershipData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DestinyMemberships == input.DestinyMemberships ||
                    this.DestinyMemberships != null &&
                    input.DestinyMemberships != null &&
                    this.DestinyMemberships.SequenceEqual(input.DestinyMemberships)
                ) && 
                (
                    this.PrimaryMembershipId == input.PrimaryMembershipId ||
                    this.PrimaryMembershipId.Equals(input.PrimaryMembershipId)
                ) && 
                (
                    this.BungieNetUser == input.BungieNetUser ||
                    (this.BungieNetUser != null &&
                    this.BungieNetUser.Equals(input.BungieNetUser))
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
                if (this.DestinyMemberships != null)
                    hashCode = hashCode * 59 + this.DestinyMemberships.GetHashCode();
                hashCode = hashCode * 59 + this.PrimaryMembershipId.GetHashCode();
                if (this.BungieNetUser != null)
                    hashCode = hashCode * 59 + this.BungieNetUser.GetHashCode();
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
