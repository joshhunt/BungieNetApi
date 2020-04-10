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
    /// UserHardLinkedUserMembership
    /// </summary>
    [DataContract]
    public partial class UserHardLinkedUserMembership :  IEquatable<UserHardLinkedUserMembership>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserHardLinkedUserMembership" /> class.
        /// </summary>
        /// <param name="membershipType">membershipType.</param>
        /// <param name="membershipId">membershipId.</param>
        /// <param name="crossSaveOverriddenType">crossSaveOverriddenType.</param>
        /// <param name="crossSaveOverriddenMembershipId">crossSaveOverriddenMembershipId.</param>
        public UserHardLinkedUserMembership(int membershipType = default(int), long membershipId = default(long), int crossSaveOverriddenType = default(int), long crossSaveOverriddenMembershipId = default(long))
        {
            this.MembershipType = membershipType;
            this.MembershipId = membershipId;
            this.CrossSaveOverriddenType = crossSaveOverriddenType;
            this.CrossSaveOverriddenMembershipId = crossSaveOverriddenMembershipId;
        }
        
        /// <summary>
        /// Gets or Sets MembershipType
        /// </summary>
        [DataMember(Name="membershipType", EmitDefaultValue=false)]
        public int MembershipType { get; set; }

        /// <summary>
        /// Gets or Sets MembershipId
        /// </summary>
        [DataMember(Name="membershipId", EmitDefaultValue=false)]
        public long MembershipId { get; set; }

        /// <summary>
        /// Gets or Sets CrossSaveOverriddenType
        /// </summary>
        [DataMember(Name="CrossSaveOverriddenType", EmitDefaultValue=false)]
        public int CrossSaveOverriddenType { get; set; }

        /// <summary>
        /// Gets or Sets CrossSaveOverriddenMembershipId
        /// </summary>
        [DataMember(Name="CrossSaveOverriddenMembershipId", EmitDefaultValue=false)]
        public long CrossSaveOverriddenMembershipId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserHardLinkedUserMembership {\n");
            sb.Append("  MembershipType: ").Append(MembershipType).Append("\n");
            sb.Append("  MembershipId: ").Append(MembershipId).Append("\n");
            sb.Append("  CrossSaveOverriddenType: ").Append(CrossSaveOverriddenType).Append("\n");
            sb.Append("  CrossSaveOverriddenMembershipId: ").Append(CrossSaveOverriddenMembershipId).Append("\n");
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
            return this.Equals(input as UserHardLinkedUserMembership);
        }

        /// <summary>
        /// Returns true if UserHardLinkedUserMembership instances are equal
        /// </summary>
        /// <param name="input">Instance of UserHardLinkedUserMembership to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserHardLinkedUserMembership input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MembershipType == input.MembershipType ||
                    this.MembershipType.Equals(input.MembershipType)
                ) && 
                (
                    this.MembershipId == input.MembershipId ||
                    this.MembershipId.Equals(input.MembershipId)
                ) && 
                (
                    this.CrossSaveOverriddenType == input.CrossSaveOverriddenType ||
                    this.CrossSaveOverriddenType.Equals(input.CrossSaveOverriddenType)
                ) && 
                (
                    this.CrossSaveOverriddenMembershipId == input.CrossSaveOverriddenMembershipId ||
                    this.CrossSaveOverriddenMembershipId.Equals(input.CrossSaveOverriddenMembershipId)
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
                hashCode = hashCode * 59 + this.MembershipType.GetHashCode();
                hashCode = hashCode * 59 + this.MembershipId.GetHashCode();
                hashCode = hashCode * 59 + this.CrossSaveOverriddenType.GetHashCode();
                hashCode = hashCode * 59 + this.CrossSaveOverriddenMembershipId.GetHashCode();
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
