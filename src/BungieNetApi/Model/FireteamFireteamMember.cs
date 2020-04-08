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
    /// FireteamFireteamMember
    /// </summary>
    [DataContract]
    public partial class FireteamFireteamMember :  IEquatable<FireteamFireteamMember>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FireteamFireteamMember" /> class.
        /// </summary>
        /// <param name="destinyUserInfo">destinyUserInfo.</param>
        /// <param name="bungieNetUserInfo">bungieNetUserInfo.</param>
        /// <param name="characterId">characterId.</param>
        /// <param name="dateJoined">dateJoined.</param>
        /// <param name="hasMicrophone">hasMicrophone.</param>
        /// <param name="lastPlatformInviteAttemptDate">lastPlatformInviteAttemptDate.</param>
        /// <param name="lastPlatformInviteAttemptResult">lastPlatformInviteAttemptResult.</param>
        public FireteamFireteamMember(FireteamFireteamUserInfoCard destinyUserInfo = default(FireteamFireteamUserInfoCard), UserUserInfoCard bungieNetUserInfo = default(UserUserInfoCard), long characterId = default(long), DateTime dateJoined = default(DateTime), bool hasMicrophone = default(bool), DateTime lastPlatformInviteAttemptDate = default(DateTime), int lastPlatformInviteAttemptResult = default(int))
        {
            this.DestinyUserInfo = destinyUserInfo;
            this.BungieNetUserInfo = bungieNetUserInfo;
            this.CharacterId = characterId;
            this.DateJoined = dateJoined;
            this.HasMicrophone = hasMicrophone;
            this.LastPlatformInviteAttemptDate = lastPlatformInviteAttemptDate;
            this.LastPlatformInviteAttemptResult = lastPlatformInviteAttemptResult;
        }
        
        /// <summary>
        /// Gets or Sets DestinyUserInfo
        /// </summary>
        [DataMember(Name="destinyUserInfo", EmitDefaultValue=false)]
        public FireteamFireteamUserInfoCard DestinyUserInfo { get; set; }

        /// <summary>
        /// Gets or Sets BungieNetUserInfo
        /// </summary>
        [DataMember(Name="bungieNetUserInfo", EmitDefaultValue=false)]
        public UserUserInfoCard BungieNetUserInfo { get; set; }

        /// <summary>
        /// Gets or Sets CharacterId
        /// </summary>
        [DataMember(Name="characterId", EmitDefaultValue=false)]
        public long CharacterId { get; set; }

        /// <summary>
        /// Gets or Sets DateJoined
        /// </summary>
        [DataMember(Name="dateJoined", EmitDefaultValue=false)]
        public DateTime DateJoined { get; set; }

        /// <summary>
        /// Gets or Sets HasMicrophone
        /// </summary>
        [DataMember(Name="hasMicrophone", EmitDefaultValue=false)]
        public bool HasMicrophone { get; set; }

        /// <summary>
        /// Gets or Sets LastPlatformInviteAttemptDate
        /// </summary>
        [DataMember(Name="lastPlatformInviteAttemptDate", EmitDefaultValue=false)]
        public DateTime LastPlatformInviteAttemptDate { get; set; }

        /// <summary>
        /// Gets or Sets LastPlatformInviteAttemptResult
        /// </summary>
        [DataMember(Name="lastPlatformInviteAttemptResult", EmitDefaultValue=false)]
        public int LastPlatformInviteAttemptResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FireteamFireteamMember {\n");
            sb.Append("  DestinyUserInfo: ").Append(DestinyUserInfo).Append("\n");
            sb.Append("  BungieNetUserInfo: ").Append(BungieNetUserInfo).Append("\n");
            sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
            sb.Append("  DateJoined: ").Append(DateJoined).Append("\n");
            sb.Append("  HasMicrophone: ").Append(HasMicrophone).Append("\n");
            sb.Append("  LastPlatformInviteAttemptDate: ").Append(LastPlatformInviteAttemptDate).Append("\n");
            sb.Append("  LastPlatformInviteAttemptResult: ").Append(LastPlatformInviteAttemptResult).Append("\n");
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
            return this.Equals(input as FireteamFireteamMember);
        }

        /// <summary>
        /// Returns true if FireteamFireteamMember instances are equal
        /// </summary>
        /// <param name="input">Instance of FireteamFireteamMember to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FireteamFireteamMember input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DestinyUserInfo == input.DestinyUserInfo ||
                    (this.DestinyUserInfo != null &&
                    this.DestinyUserInfo.Equals(input.DestinyUserInfo))
                ) && 
                (
                    this.BungieNetUserInfo == input.BungieNetUserInfo ||
                    (this.BungieNetUserInfo != null &&
                    this.BungieNetUserInfo.Equals(input.BungieNetUserInfo))
                ) && 
                (
                    this.CharacterId == input.CharacterId ||
                    (this.CharacterId != null &&
                    this.CharacterId.Equals(input.CharacterId))
                ) && 
                (
                    this.DateJoined == input.DateJoined ||
                    (this.DateJoined != null &&
                    this.DateJoined.Equals(input.DateJoined))
                ) && 
                (
                    this.HasMicrophone == input.HasMicrophone ||
                    (this.HasMicrophone != null &&
                    this.HasMicrophone.Equals(input.HasMicrophone))
                ) && 
                (
                    this.LastPlatformInviteAttemptDate == input.LastPlatformInviteAttemptDate ||
                    (this.LastPlatformInviteAttemptDate != null &&
                    this.LastPlatformInviteAttemptDate.Equals(input.LastPlatformInviteAttemptDate))
                ) && 
                (
                    this.LastPlatformInviteAttemptResult == input.LastPlatformInviteAttemptResult ||
                    (this.LastPlatformInviteAttemptResult != null &&
                    this.LastPlatformInviteAttemptResult.Equals(input.LastPlatformInviteAttemptResult))
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
                if (this.DestinyUserInfo != null)
                    hashCode = hashCode * 59 + this.DestinyUserInfo.GetHashCode();
                if (this.BungieNetUserInfo != null)
                    hashCode = hashCode * 59 + this.BungieNetUserInfo.GetHashCode();
                if (this.CharacterId != null)
                    hashCode = hashCode * 59 + this.CharacterId.GetHashCode();
                if (this.DateJoined != null)
                    hashCode = hashCode * 59 + this.DateJoined.GetHashCode();
                if (this.HasMicrophone != null)
                    hashCode = hashCode * 59 + this.HasMicrophone.GetHashCode();
                if (this.LastPlatformInviteAttemptDate != null)
                    hashCode = hashCode * 59 + this.LastPlatformInviteAttemptDate.GetHashCode();
                if (this.LastPlatformInviteAttemptResult != null)
                    hashCode = hashCode * 59 + this.LastPlatformInviteAttemptResult.GetHashCode();
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
